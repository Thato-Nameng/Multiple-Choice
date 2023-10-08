using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Quiz_Management
{
    public partial class MainMenu : Form
    {
        function fn = new function();
        String query;
        private string studentName;
        private string studentSurname;


        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            pnlStud.Visible = false;
            pnlLect.Visible = false;
            lblLectWrong.Visible = false;
            lblStudWrong.Visible = false;
        }

        private void btnLectLog_Click(object sender, EventArgs e)
        {
            if (txtLectName.Text == "Name" && txtLectPass.Text == "Password")
            {
                lblLectWrong.Visible = false;
                LecturerMenu lecture = new LecturerMenu();
                lecture.Show();
                this.Hide();
            }
            else
            {
                lblLectWrong.Visible = true;
            }
        }

        private void cbxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectUser.SelectedIndex == 0)
            {
                pnlStud.Visible = false;
                pnlLect.Visible = true;
            }
            else if (cbxSelectUser.SelectedIndex == 1)
            {
                pnlLect.Visible = false;
                pnlStud.Visible = true;
            }
        }       

        private void cbLectShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLectShowPass.Checked == true)
            {
                txtLectPass.PasswordChar = '\0';
                cbLectShowPass.Text = "Hide Password";
            }
            else if (cbxStudShowPass.Checked == false)
            {
                txtLectPass.PasswordChar = '*';
                cbLectShowPass.Text = "Show Password";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentRegistration st = new StudentRegistration();
            st.Show();
            this.Hide();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string studentNumber = txtSNumber.Text;
            string password = txtPassword.Text;

            query = $"SELECT Password, Name, Surname FROM Registration WHERE StudentNumber = '{studentNumber}'";

            using (SqlConnection conn = fn.GetsConn())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hashedPasswordFromDB = reader["Password"].ToString();
                    studentName = reader["Name"].ToString();
                    studentSurname = reader["Surname"].ToString();

                    if (VerifyPassword(password, hashedPasswordFromDB))
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        StudentMenu st = new StudentMenu();
                        st.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Tuple<string, string> GetStudentNameAndSurname()
        {
            return Tuple.Create(studentName, studentSurname);
        }

        private bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                string hashedInputPassword = builder.ToString();

                return string.Equals(hashedInputPassword, hashedPassword, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void cbxStudShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxStudShowPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                cbxStudShowPass.Text = "Hide Password";
            }
            else if (cbxStudShowPass.Checked == false)
            {
                txtPassword.PasswordChar = '*';
                cbxStudShowPass.Text = "Show Password";
            }
        }

        private void pnlStud_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
