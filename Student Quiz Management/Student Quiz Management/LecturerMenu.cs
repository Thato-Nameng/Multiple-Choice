using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Quiz_Management
{
    public partial class LecturerMenu : Form
    {
        public LecturerMenu()
        {
            InitializeComponent();
        }

        private void LecturerMenu_Load(object sender, EventArgs e)
        {
            add_Question1.Visible = false;
            updateQuestions1.Visible = false;
            viewDeleteQuestion1.Visible = false;
            studentResults1.Visible = false;
        }
        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            add_Question1.Visible = true;
            add_Question1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateQuestions1.Visible = true;
            updateQuestions1.BringToFront();
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

        private void btnResult_Click(object sender, EventArgs e)
        {
            studentResults1.Visible = true;
            studentResults1.BringToFront();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            viewDeleteQuestion1.Visible = true;
            viewDeleteQuestion1.BringToFront();
        }

        private void add_Question1_Load(object sender, EventArgs e)
        {

        }

        private void updateQuestions1_Load(object sender, EventArgs e)
        {

        }
    }
}
