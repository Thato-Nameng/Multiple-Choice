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
using System.Xml.Linq;

namespace Student_Quiz_Management.Student_UserControl
{
    public partial class StudentMarks : UserControl
    {
        private string StudentName;
        private string StudentSurname;
        private string Subject;
        private function fn = new function();
        public StudentMarks()
        {
            InitializeComponent();
        }

        private void StudentMarks_Load(object sender, EventArgs e)
        {

        }

        public void InitializePracticeQuestions(string studentName, string studentSurname, string Subject)
        {
            StudentName = studentName;
            StudentSurname = studentSurname;
            DataSet dataSet = fn.GetData($"SELECT DISTINCT Subject FROM UserResponse WHERE Name = '{StudentName}' AND " +
                $"Surname = '{StudentSurname}'");

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                this.Subject = dataSet.Tables[0].Rows[0][0].ToString(); 
            }
            CalculateAndDisplayPercentages();
        }


        public void CalculateAndDisplayPercentages()
        {
            int practiceTotal = 0, testTotal = 0, examTotal = 0;
            int practiceCorrect = 0, testCorrect = 0, examCorrect = 0;

            DataSet dataSet = fn.GetData($"SELECT * FROM UserResponse WHERE Name = '{StudentName}' AND Surname = " +
                $"'{StudentSurname}' AND Subject = '{Subject}'");

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string testType = row["Test_Type"].ToString();
                string userAnswer = row["User_Answer"].ToString().ToLower(); 
                string correctAnswer = row["Ans"].ToString().ToLower(); 

                if (userAnswer == correctAnswer)
                {
                    switch (testType)
                    {
                        case "Practice":
                            practiceCorrect++;
                            break;
                        case "Test":
                            testCorrect++;
                            break;
                        case "Exam":
                            examCorrect++;
                            break;
                    }
                }

                switch (testType)
                {
                    case "Practice":
                        practiceTotal++;
                        break;
                    case "Test":
                        testTotal++;
                        break;
                    case "Exam":
                        examTotal++;
                        break;
                }
            }

            double practicePercentage = practiceTotal > 0 ? (double)practiceCorrect / practiceTotal * 100 : 0;
            double testPercentage = testTotal > 0 ? (double)testCorrect / testTotal * 100 : 0;
            double examPercentage = examTotal > 0 ? (double)examCorrect / examTotal * 100 : 0;

            label1.Text = Subject;

            label2.Text = "Practice";
            label3.Text = practicePercentage.ToString("0.00") + "%";

            label4.Text = "Test";
            label5.Text = testPercentage.ToString("0.00") + "%";

            label6.Text = "Exam";
            label7.Text = examPercentage.ToString("0.00") + "%";
        }
    }
}