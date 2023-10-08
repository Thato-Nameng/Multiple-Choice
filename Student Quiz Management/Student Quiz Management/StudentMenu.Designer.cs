namespace Student_Quiz_Management
{
    partial class StudentMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.studentMarks1 = new Student_Quiz_Management.Student_UserControl.StudentMarks();
            this.studentTest1 = new Student_Quiz_Management.Student_UserControl.StudentTest();
            this.studentExam1 = new Student_Quiz_Management.Student_UserControl.StudentExam();
            this.studentPractice1 = new Student_Quiz_Management.Student_UserControl.StudentPractice();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome:";
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSurname.Location = new System.Drawing.Point(496, 9);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(68, 30);
            this.lblStudentSurname.TabIndex = 4;
            this.lblStudentSurname.Text = "label2";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(348, 9);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(68, 30);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "label1";
            // 
            // Elipse1
            // 
            this.Elipse1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentMarks1);
            this.panel1.Controls.Add(this.studentTest1);
            this.panel1.Controls.Add(this.studentExam1);
            this.panel1.Controls.Add(this.studentPractice1);
            this.panel1.Location = new System.Drawing.Point(177, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 514);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.btnExam);
            this.panel2.Controls.Add(this.btnTest);
            this.panel2.Controls.Add(this.btnPractice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 573);
            this.panel2.TabIndex = 7;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLog.Location = new System.Drawing.Point(0, 473);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(168, 81);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "LOGOUT";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnResult.ForeColor = System.Drawing.SystemColors.Info;
            this.btnResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResult.Location = new System.Drawing.Point(0, 378);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(168, 81);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "STUDENT RESULT";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnExam.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExam.Location = new System.Drawing.Point(0, 282);
            this.btnExam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(168, 81);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "EXAM";
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnTest.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTest.Location = new System.Drawing.Point(0, 186);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(168, 81);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPractice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPractice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPractice.Location = new System.Drawing.Point(0, 89);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(168, 81);
            this.btnPractice.TabIndex = 0;
            this.btnPractice.Text = "PRACTICE";
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(17, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student";
            // 
            // Elipse2
            // 
            this.Elipse2.TargetControl = this.panel1;
            // 
            // Elipse3
            // 
            this.Elipse3.TargetControl = this.panel1;
            // 
            // Elipse4
            // 
            this.Elipse4.TargetControl = this.panel1;
            // 
            // studentMarks1
            // 
            this.studentMarks1.Location = new System.Drawing.Point(2, -4);
            this.studentMarks1.Name = "studentMarks1";
            this.studentMarks1.Size = new System.Drawing.Size(848, 520);
            this.studentMarks1.TabIndex = 4;
            // 
            // studentTest1
            // 
            this.studentTest1.BackColor = System.Drawing.Color.LightGray;
            this.studentTest1.Location = new System.Drawing.Point(3, 3);
            this.studentTest1.Name = "studentTest1";
            this.studentTest1.Size = new System.Drawing.Size(848, 520);
            this.studentTest1.TabIndex = 3;
            // 
            // studentExam1
            // 
            this.studentExam1.BackColor = System.Drawing.Color.LightGray;
            this.studentExam1.Location = new System.Drawing.Point(3, 3);
            this.studentExam1.Name = "studentExam1";
            this.studentExam1.Size = new System.Drawing.Size(848, 520);
            this.studentExam1.TabIndex = 2;
            // 
            // studentPractice1
            // 
            this.studentPractice1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentPractice1.Location = new System.Drawing.Point(3, 3);
            this.studentPractice1.Name = "studentPractice1";
            this.studentPractice1.Size = new System.Drawing.Size(845, 511);
            this.studentPractice1.TabIndex = 1;
            this.studentPractice1.Load += new System.EventHandler(this.studentPractice1_Load_1);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentSurname);
            this.Controls.Add(this.lblStudentName);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Student_UserControl.StudentPractice studentPractice1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
        private Student_UserControl.StudentExam studentExam1;
        private Student_UserControl.StudentTest studentTest1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse3;
        private Student_UserControl.StudentMarks studentMarks1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse4;
    }
}