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
    public partial class FrmLogin : Form
    {
        // Calling the class named fileuser 
       private FileUser fu = new FileUser();

        public FrmLogin()
        {
             
            InitializeComponent();
            //modifying the combobox
            cbUser.SelectedIndex=0;
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //using if else statements to give nstrutions on what the user has selected and requests password and name to login 
            if (cbUser.SelectedIndex ==0 && tbName.Text.Equals("Login") && tbPassword.Text.Equals("12345678"))
            {
                //opening another form 
                FrmTestSetup fts = new FrmTestSetup();
                this.Hide();
                fts.Show();
            }
            else
            {
                //else statement and boolean for incorrect statements entered 
                bool found = false;
                int x= 0;
                string[,] array = fu.getStudentList();
                //using a while loop for statements that found true the loop can execue 
                while (x < 5 && found == false)
                { 
                    //using an array that has 3 columns 
                    if(array[x,1].Equals(tbName.Text) && array[x, 3].Equals(tbPassword.Text))
                    {
                        // taking information from the class and the file 

                        found = true;
                        //opening another form 
                        frmTakeTest ftt = new frmTakeTest(x,array);
                        this.Hide();
                        ftt.Show();
                    }
                   
                       
                    
                    x++;
                }
                //ef else statements to display message if anythhing found false 
                if (found==false)
                {
                    MessageBox.Show("was not able to match name and password  ");
                }
            }
            
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
