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
    public partial class StudentResults : UserControl
    {
        function fn = new function();
        string query;
        public StudentResults()
        {
            InitializeComponent();
            guna2Subject.SelectedIndexChanged += guna2Subject_SelectedIndexChanged;
            guna2TestType.SelectedIndexChanged += guna2TestType_SelectedIndexChanged;
        }

        private void StudentResults_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadTestTypes();
            UpdateDataGridView();
        }

        private void LoadSubjects()
        {
            query = "SELECT DISTINCT Subject FROM UserResponse";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string databaseValue = ds.Tables[0].Rows[i][0].ToString();
                guna2Subject.Items.Add(databaseValue);
            }
        }

        private void LoadTestTypes()
        {
            query = "SELECT DISTINCT Test_Type FROM UserResponse";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string databaseValue = ds.Tables[0].Rows[i][0].ToString();
                guna2TestType.Items.Add(databaseValue);
            }
        }

        private void UpdateDataGridView()
        {
            try
            {
                string selectedSubject = guna2Subject.SelectedItem?.ToString();
                string selectedTestType = guna2TestType.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedSubject) && string.IsNullOrEmpty(selectedTestType))
                {
                    // If neither subject nor test type is selected, show all data
                    dataGridView1.DataSource = fn.GetData("SELECT * FROM UserResponse").Tables[0];
                }
                else
                {
                    string query = "SELECT * FROM UserResponse WHERE 1=1";

                    if (!string.IsNullOrEmpty(selectedSubject))
                    {
                        query += $" AND Subject = '{selectedSubject}'";
                    }

                    if (!string.IsNullOrEmpty(selectedTestType))
                    {
                        query += $" AND Test_Type = '{selectedTestType}'";
                    }

                    query += " ORDER BY Subject, Test_Type, Question_No";

                    DataSet ds = fn.GetData(query);

                    if (ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2TestType.SelectedIndex = -1;
            UpdateDataGridView();
        }

        private void guna2TestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();

        }
    }
}
