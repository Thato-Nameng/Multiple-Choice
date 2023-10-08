using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Quiz_Management
{
    internal class function
    {
        protected SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "data source = ; " +
                "database = QuizApp;" +
                "integrated security = True";
            return Conn;
        }

        public SqlConnection GetsConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "data source = ; " +
                "database = QuizApp;" +
                "integrated security = True";
            return Conn;
        }

        public DataSet GetData(String query)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public DataSet getComboString(String query)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            cmd.CommandText = query;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
        public void setData(String query, String msg)
        {
            try
            {
                using (SqlConnection conn = GetConn())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlDataReader getCombo(String query)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;

        }
    }
}
