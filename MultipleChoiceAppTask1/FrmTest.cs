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
    public partial class frmTakeTest : Form
    {
        FileUser file = new FileUser();  
        int index,question=0;
        string[] answers = new string[5];
        string[,] test, studentList;  
        public frmTakeTest(int i, string[,] a)
        {
            InitializeComponent();
            test = file.getTest();
            studentList=a;
            index = i;
            setQuestions();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMemo_Click(object sender, EventArgs e)
        {
            FrmReport fr = new FrmReport(test, index,answers,studentList);
            fr.Show();
            this.Hide();
        }

        private void lbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void setQuestions()
        {
            lbQuestion.Items.Clear(); 
            lbQuestion.Items.Add(test[question, 0]);
            cblA.Items.Clear();
            cblA.Items.Add(test[question, 1]);
            cblA.Items.Add(test[question, 2]);
            cblA.Items.Add(test[question, 3]);
            cblA.SetItemChecked(0, true);

        } 

        private void btnSubmit_Click(object sender, EventArgs e)
        {

          
            }

        }
    }
}
