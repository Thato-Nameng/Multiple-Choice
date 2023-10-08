using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Quiz_Management.Lecturer_UserControl
{
    public partial class UpdateQuestions : UserControl
    {
        function fn = new function();
        String query;

        public UpdateQuestions()
        {
            InitializeComponent();
        }

        private void UpdateQuestions_Load(object sender, EventArgs e)
        {
            query = "SELECT DISTINCT Subjects FROM Questions";


            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string databaseValue = ds.Tables[0].Rows[i][0].ToString();
                string displayValue = GetDisplaySubject(databaseValue);
                guna2Subject.Items.Add(displayValue);
            }
        }

        private string GetDisplaySubject(string databaseValue) 
        {
            List<string> subjects = new List<string>
            {
                "Information Technology",
                "Accounting",
                "Project Management",
                "Mathematics",
            };

            if (subjects.Contains(databaseValue))
            {
                return databaseValue;
            }

            return "";
        }

        private void guna2Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TestType.Items.Clear();

            string selectedSubject = guna2Subject.SelectedItem.ToString(); 

            query = $"SELECT DISTINCT Test_Type " +
                $"FROM Questions " +
                $"WHERE Subjects = '{selectedSubject}'";

            query = $"SELECT DISTINCT Test_Type " +
                $"FROM Questions " +
                $"WHERE Subjects = '{selectedSubject}'"; 

            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string databaseValue = ds.Tables[0].Rows[i][0].ToString(); 
                string displayValue = GetTestType(databaseValue);
                guna2TestType.Items.Add(displayValue);
            }
        }

        private string GetTestType(string databaseValue)
        {
            List<string> testType = new List<string>
            {
                "Exam",
                "Test",
                "Practice"
            };

            if (testType.Contains(databaseValue))
            {
                return databaseValue;
            }

            return "";
        }

        private void guna2TestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxQuestion.Items.Clear();

            string selectedSubject = guna2Subject.SelectedItem.ToString(); 
            string selectedTestType = guna2TestType.SelectedItem.ToString();

            query = $"SELECT Question_No " +
                $"FROM Questions " +
                $"WHERE Subjects = '{selectedSubject}' AND Test_Type = '{selectedTestType}'"; 

            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbxQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cbxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = guna2Subject.SelectedItem.ToString();
            string selectedTestType = guna2TestType.SelectedItem.ToString();
            string selectedQuestionNo = cbxQuestion.SelectedItem.ToString();

            query = $"SELECT Question, OptionA, OptionB, OptionC, OptionD, Ans " +
                    $"FROM Questions " +
                    $"WHERE Subjects = '{selectedSubject}' AND Test_Type = '{selectedTestType}' AND Question_No = '{selectedQuestionNo}'";

            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtQuestion.Text = ds.Tables[0].Rows[0]["Question"].ToString();
                txtOption1.Text = ds.Tables[0].Rows[0]["OptionA"].ToString();
                txtOption2.Text = ds.Tables[0].Rows[0]["OptionB"].ToString();
                txtOption3.Text = ds.Tables[0].Rows[0]["OptionC"].ToString();
                txtOption4.Text = ds.Tables[0].Rows[0]["OptionD"].ToString();
                txtAnswer.Text = ds.Tables[0].Rows[0]["Ans"].ToString();
            }
            else
            {
                MessageBox.Show("Question not found.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxQuestion.SelectedIndex != -1)
            {
                string selectedSubject = guna2Subject.SelectedItem.ToString();
                string selectedTestType = guna2TestType.SelectedItem.ToString();
                string selectedQuestionNo = cbxQuestion.SelectedItem.ToString();

                string updatedQuestion = txtQuestion.Text;
                string updatedOption1 = txtOption1.Text;
                string updatedOption2 = txtOption2.Text;
                string updatedOption3 = txtOption3.Text;
                string updatedOption4 = txtOption4.Text;
                string updatedAnswer = txtAnswer.Text;

                query = $@"UPDATE Questions 
                           SET 
                               Question = '{updatedQuestion}',
                               OptionA = '{updatedOption1}',
                               OptionB = '{updatedOption2}',
                               OptionC = '{updatedOption3}',
                               OptionD = '{updatedOption4}',
                               Ans = '{updatedAnswer}'
                           WHERE Subjects = '{selectedSubject}' 
                           AND Test_Type = '{selectedTestType}' 
                           AND Question_No = '{selectedQuestionNo}'";

                fn.setData(query, $"Question No : {selectedQuestionNo}\nSubjects : {selectedSubject}\nTest Type : " +
                    $"{selectedTestType} is updated");

                clearAll();
            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            guna2Subject.SelectedIndex = -1;
            guna2TestType.Items.Clear();
            cbxQuestion.Items.Clear();
            clearAll();
        }
    }
}