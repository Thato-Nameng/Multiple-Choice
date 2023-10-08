using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Quiz_Management.Lecturer_UserControl
{
    public partial class ViewDeleteQuestion : UserControl
    {
        function fn = new function();
        string query;
        public ViewDeleteQuestion()
        {
            InitializeComponent();
            guna2Subject.SelectedIndexChanged += guna2Subject_SelectedIndexChanged;
            guna2TestType.SelectedIndexChanged += guna2TestType_SelectedIndexChanged;
        }

        private void ViewDeleteQuestion_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadTestTypes();
            UpdateDataGridView();
        }

        private void LoadSubjects()
        {
            query = "SELECT DISTINCT Subjects FROM Questions";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string databaseValue = ds.Tables[0].Rows[i][0].ToString();
                guna2Subject.Items.Add(databaseValue);
            }
        }

        private void LoadTestTypes()
        {
            query = "SELECT DISTINCT Test_Type FROM Questions";
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

                string query = "SELECT * FROM Questions WHERE 1=1";

                if (!string.IsNullOrEmpty(selectedSubject))
                {
                    query += $" AND Subjects = '{selectedSubject}'";
                }

                if (!string.IsNullOrEmpty(selectedTestType))
                {
                    query += $" AND Test_Type = '{selectedTestType}'";
                }

                query += " ORDER BY Subjects, Test_Type, Question_No"; 

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["Id"].Value); 
                string questionNo = dataGridView1.Rows[selectedRow].Cells["Question_No"].Value.ToString(); 

                if (MessageBox.Show("Are you sure you want to delete this question?", "Delete Confirmation", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "DELETE FROM Questions WHERE ID = '" + id + "' AND Question_No = '" + questionNo + "'";
                    fn.setData(query, "Question deleted");
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
