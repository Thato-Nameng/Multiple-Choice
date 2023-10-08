using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Quiz_Management.Student_UserControl
{
    public partial class StudentTest : UserControl
    {
        private function fn = new function();
        private string StudentName;
        private string StudentSurname;
        private int currentQuestionIndex = 0;
        private DataTable practiceQuestionsTable;
        public StudentTest()
        {
            InitializeComponent();
        }

        private void StudentTest_Load(object sender, EventArgs e)
        {

        }

        public void InitializePracticeQuestions(string studentName, string studentSurname)
        {
            StudentName = studentName;
            StudentSurname = studentSurname;
            LoadPracticeQuestions();
        }

        private void LoadPracticeQuestions()
        {
            string userName = StudentName;
            string userSurname = StudentSurname;


            bool userResponseNotEmptyTest = CheckUserResponseNotEmpty(userName, userSurname, "Test");

            if (userResponseNotEmptyTest)
            {
                DisableControls(); 
                MessageBox.Show("Test is completed.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                practiceQuestionsTable = fn.GetData($@"
                    SELECT Q.ID AS QuestionID, Q.Question, Q.OptionA, 
                        Q.OptionB, Q.OptionC, Q.OptionD, Q.Ans, Q.Subjects
                    FROM Questions Q
                        JOIN Registration R ON Q.Subjects = R.Subject
                    WHERE R.Name = '{userName}' 
                        AND R.Surname = '{userSurname}' 
                        AND Q.Test_Type = 'Test'").Tables[0];

                if (practiceQuestionsTable.Rows.Count > 0)
                {
                    LoadQuestion(currentQuestionIndex);
                    EnableControls();
                }
                else
                {
                    DisableControls();
                    MessageBox.Show("There are no questions available for this test.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool CheckUserResponseNotEmpty(string userName, string userSurname, string testType)
        {
            string query = $@"
            SELECT TOP 1 User_Answer
            FROM UserResponse
            WHERE Name = '{userName}' 
                AND Surname = '{userSurname}' 
                AND User_Answer IS NOT NULL 
                AND User_Answer <> '' 
                AND Test_Type = '{testType}'";

            using (SqlConnection conn = fn.GetsConn())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value;
                }
            }
        }

        private void EnableControls()
        {
            rad1.Enabled = true;
            rad2.Enabled = true;
            rad3.Enabled = true;
            rad4.Enabled = true;
            btnNext.Enabled = true;
        }
        private void DisableControls()
        {
            rad1.Enabled = false;
            rad2.Enabled = false;
            rad3.Enabled = false;
            rad4.Enabled = false;
            btnNext.Enabled = false;
        }

        private void LoadQuestion(int index)
        {
            if (index >= 0 && index < practiceQuestionsTable.Rows.Count)
            {
                DataRow questionRow = practiceQuestionsTable.Rows[index];
                label1.Text = questionRow["Question"].ToString();
                rad1.Text = questionRow["OptionA"].ToString();
                rad2.Text = questionRow["OptionB"].ToString();
                rad3.Text = questionRow["OptionC"].ToString();
                rad4.Text = questionRow["OptionD"].ToString();

                rad1.Visible = !string.IsNullOrEmpty(rad1.Text);
                rad2.Visible = !string.IsNullOrEmpty(rad2.Text);
                rad3.Visible = !string.IsNullOrEmpty(rad3.Text);
                rad4.Visible = !string.IsNullOrEmpty(rad4.Text);
            }
            else
            {
                if (index == practiceQuestionsTable.Rows.Count)
                {
                    MessageBox.Show("You have completed the Test!");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedOption = GetSelectedOption();
                SaveUserResponse(selectedOption);

                currentQuestionIndex++;

                if (currentQuestionIndex < practiceQuestionsTable.Rows.Count)
                {
                    LoadQuestion(currentQuestionIndex);
                }
                else
                {
                    MessageBox.Show("You have completed the Test!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedOption()
        {
            if (rad1.Checked) return rad1.Text;
            if (rad2.Checked) return rad2.Text;
            if (rad3.Checked) return rad3.Text;
            if (rad4.Checked) return rad4.Text;
            return "";
        }

        private void SaveUserResponse(string selectedOption)
        {
            if (!string.IsNullOrEmpty(selectedOption))
            {
                string userName = StudentName;
                string userSurname = StudentSurname;

                int questionID = Convert.ToInt32(practiceQuestionsTable.Rows[currentQuestionIndex]["QuestionID"]);
                string questionNo = (currentQuestionIndex + 1).ToString();
                string subject = practiceQuestionsTable.Rows[currentQuestionIndex]["Subjects"].ToString();
                string testType = "Test";
                string ans = practiceQuestionsTable.Rows[currentQuestionIndex]["Ans"].ToString();

                string responseQuery = $@"
                    SELECT COUNT(*) 
                    FROM UserResponse 
                    WHERE Name = '{userName}' 
                        AND Surname = '{userSurname}' 
                        AND QuestionID = {questionID} 
                        AND Question_No = '{questionNo}'
                        AND Subject = '{subject}'
                ";

                SqlDataReader responseReader = fn.getCombo(responseQuery);
                int responseCount = 0;

                if (responseReader.Read())
                {
                    responseCount = Convert.ToInt32(responseReader[0]);
                }

                responseReader.Close();

                if (responseCount > 0)
                {
                    string updateQuery = $@"
                        UPDATE UserResponse 
                        SET User_Answer = '{selectedOption}'
                        WHERE Name = '{userName}' 
                            AND Surname = '{userSurname}' 
                            AND QuestionID = {questionID} 
                            AND Question_No = '{questionNo}'
                            AND Subject = '{subject}'
                    ";

                    fn.setData(updateQuery, "Response updated successfully.");
                }
                else
                {
                    string insertQuery = $@"
                        INSERT INTO UserResponse (RegistrationID, QuestionID, Name, Surname, Subject, Test_Type, 
                            Question_No, User_Answer, Ans) 
                        VALUES (
                            (SELECT ID FROM Registration WHERE Name = '{userName}' AND Surname = '{userSurname}'), 
                            {questionID}, 
                            '{userName}', 
                            '{userSurname}', 
                            '{subject}', 
                            '{testType}', 
                            '{questionNo}', 
                            '{selectedOption}', 
                            '{ans}'
                        )";

                    fn.setData(insertQuery, "Response saved successfully.");
                }

            }
        }              

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
