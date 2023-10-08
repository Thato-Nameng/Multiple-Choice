using Student_Quiz_Management.Lecturer_UserControl;
using Student_Quiz_Management.Student_UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Quiz_Management
{
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }
        private void StudentMenu_Load(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
            if (mainMenu != null)
            {
                Tuple<string, string> nameAndSurname = mainMenu.GetStudentNameAndSurname();
                lblStudentName.Text = nameAndSurname.Item1;
                lblStudentSurname.Text = nameAndSurname.Item2;
            }
            studentPractice1.InitializePracticeQuestions(lblStudentName.Text, lblStudentSurname.Text);
            studentTest1.InitializePracticeQuestions(lblStudentName.Text, lblStudentSurname.Text);
            studentExam1.InitializePracticeQuestions(lblStudentName.Text, lblStudentSurname.Text);


            string selectedSubject = "Selected Subject"; 

            studentMarks1.InitializePracticeQuestions(lblStudentName.Text, lblStudentSurname.Text, selectedSubject);

            studentPractice1.Visible = false;
            studentTest1.Visible = false;
            studentExam1.Visible = false;
            studentMarks1.Visible = false;

        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            studentPractice1.Visible = true;
            studentPractice1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            studentTest1.Visible = true;
            studentTest1.BringToFront();
        }
        private void btnExam_Click(object sender, EventArgs e)
        {
            studentExam1.Visible = true;
            studentExam1.BringToFront();
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            studentMarks1.Visible = true;
            studentMarks1.BringToFront();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close this?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
        }

        private void studentPractice1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void studentPractice1_Load(object sender, EventArgs e)
        {

        }

    }
}
