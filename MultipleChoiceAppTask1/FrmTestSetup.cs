using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceAppTask1
{
    public partial class FrmTestSetup : Form
    {
        int index=7,x=0;
        string[,] array = new string[5, 5];


        public FrmTestSetup()
        {
            InitializeComponent();
            cbCA.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back to login
            FrmLogin li = new FrmLogin();
            this.Hide();
            li.Show();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            //To frmreport
            FrmReport report = new FrmReport();
            this.Hide();
            report.Show(); 
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            FileUser fu = new FileUser();
            fu.setTest(array);
            MessageBox.Show("Test Saved");
            x = 0;
            index = 5;
            btnSaveTest.Enabled = false;
            btnSaveQuestion.Enabled = true;
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            array[x, 0] = tbQ.Text;
            array[x, 1] = tbOpA.Text;
            array[x, 2] = tbOpB.Text;
            array[x, 3] = tbOpC.Text;
            array[x, 4] = cbCA.Text;

            x++;
            index--;

           

            tbQ.Text="";
            tbOpA.Text = "";
            tbOpB.Text = "";
            tbOpC.Text = "";
            cbCA.SelectedIndex=0;

            if(index==0)
            {
                btnSaveTest.Enabled = true;
                btnSaveQuestion.Enabled = false;
            }
            else
            {
                MessageBox.Show("you must set another " + index + " questions");
            }

        }
    }
}
