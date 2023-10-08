namespace Student_Quiz_Management
{
    partial class LecturerMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewDeleteQuestion1 = new Student_Quiz_Management.Lecturer_UserControl.ViewDeleteQuestion();
            this.updateQuestions1 = new Student_Quiz_Management.Lecturer_UserControl.UpdateQuestions();
            this.add_Question1 = new Student_Quiz_Management.Lecturer_UserControl.Add_Question();
            this.Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.studentResults1 = new Student_Quiz_Management.Lecturer_UserControl.StudentResults();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNewQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 662);
            this.panel1.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnLog.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLog.Location = new System.Drawing.Point(0, 519);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(288, 110);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Log out";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnResult.ForeColor = System.Drawing.SystemColors.Info;
            this.btnResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResult.Location = new System.Drawing.Point(0, 403);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(288, 110);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Students Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(0, 287);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(288, 110);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(0, 171);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(288, 110);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnNewQuestion.ForeColor = System.Drawing.SystemColors.Info;
            this.btnNewQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewQuestion.Location = new System.Drawing.Point(0, 55);
            this.btnNewQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(288, 110);
            this.btnNewQuestion.TabIndex = 0;
            this.btnNewQuestion.Text = "Add New Question";
            this.btnNewQuestion.UseVisualStyleBackColor = false;
            this.btnNewQuestion.Click += new System.EventHandler(this.btnNewQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LECTURE";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.studentResults1);
            this.panel2.Controls.Add(this.viewDeleteQuestion1);
            this.panel2.Controls.Add(this.updateQuestions1);
            this.panel2.Controls.Add(this.add_Question1);
            this.panel2.ForeColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(299, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 662);
            this.panel2.TabIndex = 4;
            // 
            // Elipse1
            // 
            this.Elipse1.TargetControl = this.panel2;
            // 
            // Elipse2
            // 
            this.Elipse2.TargetControl = this.panel2;
            // 
            // Elipse3
            // 
            this.Elipse3.TargetControl = this.panel2;
            // 
            // viewDeleteQuestion1
            // 
            this.viewDeleteQuestion1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDeleteQuestion1.BackColor = System.Drawing.Color.DarkKhaki;
            this.viewDeleteQuestion1.Location = new System.Drawing.Point(3, 0);
            this.viewDeleteQuestion1.Name = "viewDeleteQuestion1";
            this.viewDeleteQuestion1.Size = new System.Drawing.Size(739, 659);
            this.viewDeleteQuestion1.TabIndex = 2;
            // 
            // updateQuestions1
            // 
            this.updateQuestions1.BackColor = System.Drawing.Color.LightSalmon;
            this.updateQuestions1.Location = new System.Drawing.Point(3, 0);
            this.updateQuestions1.Name = "updateQuestions1";
            this.updateQuestions1.Size = new System.Drawing.Size(739, 657);
            this.updateQuestions1.TabIndex = 1;
            // 
            // add_Question1
            // 
            this.add_Question1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Question1.BackColor = System.Drawing.Color.SandyBrown;
            this.add_Question1.Location = new System.Drawing.Point(3, 2);
            this.add_Question1.Name = "add_Question1";
            this.add_Question1.Size = new System.Drawing.Size(739, 657);
            this.add_Question1.TabIndex = 0;
            this.add_Question1.Load += new System.EventHandler(this.add_Question1_Load);
            // 
            // Elipse4
            // 
            this.Elipse4.TargetControl = this.panel2;
            // 
            // studentResults1
            // 
            this.studentResults1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.studentResults1.Location = new System.Drawing.Point(3, 0);
            this.studentResults1.Name = "studentResults1";
            this.studentResults1.Size = new System.Drawing.Size(739, 659);
            this.studentResults1.TabIndex = 3;
            // 
            // LecturerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1052, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LecturerMenu";
            this.Text = "StudentQuiz Management";
            this.Load += new System.EventHandler(this.LecturerMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private Lecturer_UserControl.Add_Question add_Question1;
        private Lecturer_UserControl.UpdateQuestions updateQuestions1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse Elipse3;
        private Lecturer_UserControl.ViewDeleteQuestion viewDeleteQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse Elipse4;
        private Lecturer_UserControl.StudentResults studentResults1;
    }
}