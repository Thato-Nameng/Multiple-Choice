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
    public partial class FrmReport : Form
    {
        int back;
        public FrmReport()
        {
            InitializeComponent();
            back = 0;
             
            FileUser file = new FileUser();
            string[,] array = file.getStudentList();
            
            double average=0, highest=0, lowest=100; 
            a.Items.Add("Student number");
            b.Items.Add("Student Name");
            c.Items.Add("Student Marks");
            a.Items.Add("----------------");
            b.Items.Add("----------------");
            c.Items.Add("----------------");
            for (int x = 0; x < 6; ++x)
            {
               
                average += Double.Parse(array[x,2]);
                
                if(highest< Double.Parse(array[x, 2]))
                {
                    highest= Double.Parse(array[x, 2]); ;
                }

                if(lowest> Double.Parse(array[x, 2]))
                {
                    lowest= Double.Parse(array[x, 2]);
                }
                
                
                a.Items.Add(array[x, 0]);
                b.Items.Add(array[x, 1]);
                c.Items.Add(array[x, 2]);
            }
            average = average / 5;
            Report.Items.Add("Aveage: "+average);
            Report.Items.Add("Highest "+highest);
            Report.Items.Add("Lowest "+lowest);
                
        }

        public FrmReport(String[,] t, int i, string[] a, string[,] sl)
        {
            InitializeComponent();
            back = 1;
            int mark=0;
            this.a.Items.Add("Question");
            b.Items.Add(" Answer");
            c.Items.Add("Correct Answer");

            for (int x=0;x<5;x++)

            {
                if(t[x,4].Equals(a[x]))
                {
                    mark++;
                    this.a.Items.Add(t[x, 4]);
                    b.Items.Add(t[x,convert(a[x])]);
                    c.Items.Add(t[x, convert(a[x])]);
                }
                else
                {
                    this.a.Items.Add(t[x, 4]);
                    b.Items.Add(t[x, convert(a[x])]);
                    c.Items.Add(t[x, convert(t[x,4])]);
                }
            }
            double fmark = mark / 5.0 * 100.0;
            Report.Items.Add("Marks: " + fmark + "%");
            sl[i, 2] = fmark + "";
            FileUser fu = new FileUser();
            fu.setStudentList(sl);
        }


        public int convert(String sAns)
        {
            int ans = 0;
            if(sAns.Equals("First Option"))
            {
                ans = 1;
            }
            else if(sAns.Equals("Second Option"))
            {
                ans = 2;
            }
            else if (sAns.Equals("Third option"))
            {
                ans = 3;
            }

            return ans;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {

        }

        private void lbReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (back == 5)
            {
                FrmTestSetup ts = new FrmTestSetup();
                ts.Show();
                this.Hide();
            }
            else if (back == 1)
            {
                FrmLogin lg = new FrmLogin();
                lg.Show();
                this.Hide();
            }
        }

        private void lbc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
