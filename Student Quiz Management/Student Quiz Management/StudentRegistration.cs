using System;
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
    public partial class StudentRegistration : Form
    {
        function fn = new function();
        String query;
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            lblNameError.Visible = false;
            lblSurnameError.Visible = false;
            lblSubjectError.Visible = false;
            lblEmailError.Visible = false;
            lblDOBError.Visible = false;
            lblEmailError.Visible = false;
            lblCPasswordError.Visible = false;
            lblPasswordError.Visible = false;

            
            List<string> subjects = new List<string>
            {
                 "Information Technology",
                "Accounting",
                "Project Management",
                "Mathematics",
            };
            cbxSubject.DataSource = subjects;
            cbxSubject.SelectedIndex = -1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fName = txtName.Text;
            string Surname = txtSurname.Text;
            string date = dateTimePicker.Value.ToString();
            string Email = txtEmail.Text;
            string pass = txtPassword.Text;
            string cpass = txtCPass.Text;

            string checkEmailQuery = $"SELECT COUNT(*) FROM Registration WHERE Email = '{Email}'";

            using (SqlConnection conn = fn.GetsConn())
            using (SqlCommand cmd = new SqlCommand(checkEmailQuery, conn))
            {
                conn.Open();
                int emailCount = (int)cmd.ExecuteScalar();

                if (emailCount > 0)
                {
                    lblEmailError.Visible = true;
                    MessageBox.Show("The email address is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(fName) || string.IsNullOrEmpty(Surname) ||
                cbxSubject.SelectedIndex == -1 || !IsValidEmail(Email) ||
                string.IsNullOrEmpty(pass) != string.IsNullOrEmpty(cpass) ||
                DateTime.Now.Subtract(dateTimePicker.Value).TotalDays < (365.25 * 18))
            {
                lblNameError.Visible = string.IsNullOrWhiteSpace(fName);
                lblSurnameError.Visible = string.IsNullOrEmpty(Surname);
                lblDOBError.Visible = DateTime.Now.Subtract(dateTimePicker.Value).TotalDays < (365.25 * 18);
                lblSubjectError.Visible = cbxSubject.SelectedIndex == -1;
                lblEmailError.Visible = !IsValidEmail(txtEmail.Text);
                lblEmailError.Visible = !IsValidEmail(txtEmail.Text);

                lblCPasswordError.Visible = (string.IsNullOrEmpty(pass) && string.IsNullOrEmpty(cpass)) || (pass != cpass);

                return;
            }

            string studentNumber = GenerateUniqueStudentNumber(dateTimePicker.Value, cbxSubject.SelectedIndex);
            string selectedSubject = cbxSubject.SelectedItem.ToString();

            string hashedPassword = HashPassword(txtPassword.Text);

            query = $@"INSERT INTO Registration (Name, Surname, DateOfBirth, Subject, Email, Password, StudentNumber) " +
                           $"VALUES ('{fName}', '{Surname}', '{date}', '{selectedSubject}', '{Email}', '{hashedPassword}', '{studentNumber}')";

            DataSet ds = fn.GetData(query);

            string msg = "Registration successful. Your student number is: " + studentNumber;
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            string[] allowedDomains = { "gmail.com", "yahoo.com", "whatever.com" }; 
            string[] parts = email.Split('@');
            if (parts.Length == 2)
            {
                string domain = parts[1].ToLower();
                foreach (string allowedDomain in allowedDomains)
                {
                    if (domain.EndsWith(allowedDomain))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private string GenerateUniqueStudentNumber(DateTime dateOfBirth, int subjectIndex)
        {
            Random random = new Random();
            int randomDigits = random.Next(10, 99); 

            int year = dateOfBirth.Year % 100;

            string studentNumber = year.ToString("00") + subjectIndex.ToString("00") + randomDigits.ToString("00");

            return studentNumber;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            this.Close();
            m.Show();
        }
    }
}
