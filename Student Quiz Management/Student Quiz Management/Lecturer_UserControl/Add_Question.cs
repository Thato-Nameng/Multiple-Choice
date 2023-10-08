using System;
using System.Collections;
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
    public partial class Add_Question : UserControl
    {
        function fn = new function();
        String query;

        Dictionary<Tuple<string, string>, int> questionNumbers = new Dictionary<Tuple<string, string>, int>();

        public Add_Question()
        {
            InitializeComponent();
        }
        

        private void Add_Question_Load(object sender, EventArgs e)
        {
            List<string> subjects = new List<string>
            {
                "Information Technology",
                "Accounting",
                "Project Management",
                "Mathematics",
            };
            guna2Subject.DataSource = subjects;
            guna2Subject.SelectedIndex = -1;


            List<string> testType = new List<string>
            {
                "Exam",
                "Test",
                "Practice"
            };
            guna2TestType.DataSource = testType;
            guna2TestType.SelectedIndex = -1;

            int maxSubjects = GetMaxSubjects();

            if (maxSubjects > 0)
            {
                guna2Subject.SelectedIndex = maxSubjects - 1;
            }

            guna2TestType.SelectedIndex = 0; 
            UpdateCurrentQuestionNumber();
        }

        private void UpdateCurrentQuestionNumber()
        {
            string selectedSubject = guna2Subject.SelectedItem as string;
            string selectedTestType = guna2TestType.SelectedItem as string;

            Tuple<string, string> subjectTestTypeCombo = new Tuple<string, string>(selectedSubject, selectedTestType);

            if (!questionNumbers.ContainsKey(subjectTestTypeCombo))
            {
                questionNumbers[subjectTestTypeCombo] = 1;
            }

            int currentQuestionNo = questionNumbers[subjectTestTypeCombo];
            lblQNum.Text = currentQuestionNo.ToString();
        }

        private int GetMaxSubjects()
        {
            query = "SELECT MAX(Subjects) FROM Questions";
            DataSet dataSet = fn.GetData(query);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                string maxSubjectsString = dataSet.Tables[0].Rows[0][0].ToString();
                if (int.TryParse(maxSubjectsString, out int maxSubjects))
                {
                    return maxSubjects;
                }
            }
            return 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtQA.Text) ||
                string.IsNullOrWhiteSpace(txtQB.Text) ||
                string.IsNullOrWhiteSpace(txtAns.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrWhiteSpace(txtAns.Text))
            {
                MessageBox.Show("Please provide an answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrWhiteSpace(txtQA.Text) && string.IsNullOrWhiteSpace(txtQB.Text))
            {
                MessageBox.Show("Please provide at least two options (A and B).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedSubject = guna2Subject.SelectedItem as string;
            string selectedTestType = guna2TestType.SelectedItem as string;

            Tuple<string, string> subjectTestTypeCombo = new Tuple<string, string>(selectedSubject, selectedTestType);

            if (!questionNumbers.ContainsKey(subjectTestTypeCombo))
            {
                questionNumbers[subjectTestTypeCombo] = 1;
            }

            int currentQuestionNo = questionNumbers[subjectTestTypeCombo];

            string question = txtQuestion.Text;
            string optionA = txtQA.Text;
            string optionB = txtQB.Text;
            string optionC = txtQC.Text;
            string optionD = txtQD.Text;
            string answer = txtAns.Text;

            query = $@"INSERT INTO Questions (Subjects, Test_Type, Question_No, Question, OptionA, OptionB, 
                        OptionC, OptionD, Ans) " +
                    $"VALUES ('{selectedSubject}', '{selectedTestType}', '{currentQuestionNo}', '{question}', " +
                        $"'{optionA}', '{optionB}', '{optionC}', '{optionD}', '{answer}')";

            fn.setData(query, "Data inserted successfully.");

            questionNumbers[subjectTestTypeCombo]++;
            lblQNum.Text = questionNumbers[subjectTestTypeCombo].ToString();

            ClearAll();
        }

        private void ClearAll()
        {
            txtQuestion.Clear();
            txtQA.Clear();
            txtQB.Clear();
            txtQC.Clear();
            txtQD.Clear();
            txtAns.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Unsaved datea will be lost", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAll();

            }
        }
    }
}
