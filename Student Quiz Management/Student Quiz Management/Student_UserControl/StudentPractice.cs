using System;
using System.Collections;
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
    public partial class StudentPractice : UserControl
    {
        function fn = new function();
        String query;

        private string StudentName;
        private string StudentSurname;


        private int currentQuestionIndex = 0;
        private DataTable practiceQuestionsTable;
        public StudentPractice()
        {
            InitializeComponent();
        }

        private void StudentPractice_Load(object sender, EventArgs e)
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

            string query = $"SELECT * FROM UserQuestion WHERE Name = '" +
                $"{userName}' AND Surname = '{userSurname}' AND Test_Type = 'Practice'";
            practiceQuestionsTable = fn.GetData(query).Tables[0];

            LoadQuestion(currentQuestionIndex);
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
                    MessageBox.Show("You have completed the practice test!");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string selectedOption = GetSelectedOption();
            SaveUserResponse(selectedOption);

            currentQuestionIndex++;
            LoadQuestion(currentQuestionIndex);
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
                string questionNo = practiceQuestionsTable.Rows[currentQuestionIndex]["Question_No"].ToString();

                query = $"SELECT COUNT(*) FROM UserResponse WHERE Name = '{userName}' " +
                        $"AND Surname = '{userSurname}' " +
                        $"AND QuestionID = {questionID} " +
                        $"AND Question_No = '{questionNo}'";

                SqlDataReader reader = fn.getCombo(query);
                int responseCount = 0;

                if (reader.Read())
                {
                    responseCount = Convert.ToInt32(reader[0]);
                }

                reader.Close();

                if (responseCount > 0)
                {
                    string updateQuery = $"UPDATE UserResponse SET User_Answer = '{selectedOption}' " +
                                         $"WHERE Name = '{userName}' " +
                                         $"AND Surname = '{userSurname}' " +
                                         $"AND QuestionID = {questionID} " +
                                         $"AND Question_No = '{questionNo}'";

                    fn.setData(updateQuery, "Response updated successfully.");
                }
                else
                {
                    string subject = practiceQuestionsTable.Rows[currentQuestionIndex]["Subject"].ToString();
                    string testType = "Practice";
                    string ans = practiceQuestionsTable.Rows[currentQuestionIndex]["Ans"].ToString();

                    string insertQuery = $"INSERT INTO UserResponse (Name, Surname, QuestionID, Subject, Test_Type, " +
                                        $"Question_No, User_Answer, Ans) " +
                                        $"VALUES ('{userName}', '{userSurname}', {questionID}, " +
                                        $"'{subject}', '{testType}', '{questionNo}', '{selectedOption}', '{ans}')";

                    fn.setData(insertQuery, "Response saved successfully.");
                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }       
    }
}
