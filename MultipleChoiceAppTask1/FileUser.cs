using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceAppTask1
{
    
    class FileUser
    {
        //Declaring Variables
        private StreamReader read;
        private StreamWriter write;
        private string test= "Test.txt", studentList = "StudentList.txt", filecontent;
        private string[,] arrTest=new string[5,5], arrSL = new string[5,4];
        private int index;
        public string[,] getTest()
            //try and catch exception
        {
            try
            {
                //using if else statements 
                if (File.Exists(test))
                {
                    //reading from the file 
                    read = new StreamReader(test);
                    filecontent = read.ReadToEnd();
                    //closing the fle 
                    read.Close();
                    //nested for loop 
                    for (int x = 0; x < 5; x++)
                    {
                        for (int y = 0; y < 5; y++)
                        {
                            index = filecontent.IndexOf(";");
                            arrTest[x, y] = filecontent.Substring(0, index);
                            filecontent = filecontent.Substring(index + 1); 
                        }
                         

                    }  
                } 
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return arrTest;
        }

        public string [,] getStudentList()
        {
            //using if else statements 
            if (File.Exists(test))
            {
                //reading from the file 
                read = new StreamReader(studentList);
                filecontent = read.ReadToEnd();
                //closing the fle 
                read.Close();
                //nested for loop 
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        index = filecontent.IndexOf(";");
                        arrSL[x, y] = filecontent.Substring(0, index);
                        filecontent = filecontent.Substring(index + 1);
                    }
                }
            }
            return arrSL;

        }

        public void setTest(string [,] a)
        {
            try {
                write = new StreamWriter(test);
                for(int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 6; ++y)
                    {
                        write.Write(a[x, y] + ";");
                    }
                    write.WriteLine("");
                }
                write.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        } 

        public void setStudentList(string [,] a)
        {

            try
            {
                write = new StreamWriter(studentList);
                for (int x = 0; x < 5; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        write.Write(a[x, y] + ";");
                    }
                    write.WriteLine("");
                }
                write.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }





    }
}
