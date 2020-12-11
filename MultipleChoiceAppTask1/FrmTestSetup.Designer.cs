namespace MultipleChoiceAppTask1
{
    partial class FrmTestSetup
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
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbOpA = new System.Windows.Forms.TextBox();
            this.tbOpC = new System.Windows.Forms.TextBox();
            this.tbOpB = new System.Windows.Forms.TextBox();
            this.cbCA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(12, 41);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(250, 20);
            this.tbQ.TabIndex = 0;
            // 
            // tbOpA
            // 
            this.tbOpA.Location = new System.Drawing.Point(12, 78);
            this.tbOpA.Name = "tbOpA";
            this.tbOpA.Size = new System.Drawing.Size(250, 20);
            this.tbOpA.TabIndex = 1;
            // 
            // tbOpC
            // 
            this.tbOpC.Location = new System.Drawing.Point(12, 157);
            this.tbOpC.Name = "tbOpC";
            this.tbOpC.Size = new System.Drawing.Size(250, 20);
            this.tbOpC.TabIndex = 2;
            // 
            // tbOpB
            // 
            this.tbOpB.Location = new System.Drawing.Point(12, 117);
            this.tbOpB.Name = "tbOpB";
            this.tbOpB.Size = new System.Drawing.Size(250, 20);
            this.tbOpB.TabIndex = 3;
            // 
            // cbCA
            // 
            this.cbCA.FormattingEnabled = true;
            this.cbCA.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbCA.Location = new System.Drawing.Point(12, 196);
            this.cbCA.Name = "cbCA";
            this.cbCA.Size = new System.Drawing.Size(121, 21);
            this.cbCA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OptionA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OptionB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "OptionC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correct Answer";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(12, 239);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(75, 35);
            this.btnSaveQuestion.TabIndex = 10;
            this.btnSaveQuestion.Text = "Save Question";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Enabled = false;
            this.btnSaveTest.Location = new System.Drawing.Point(93, 239);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(88, 35);
            this.btnSaveTest.TabIndex = 11;
            this.btnSaveTest.Text = "Save Test";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(187, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(93, 281);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(88, 31);
            this.btnViewReport.TabIndex = 13;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // FrmTestSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveTest);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCA);
            this.Controls.Add(this.tbOpB);
            this.Controls.Add(this.tbOpC);
            this.Controls.Add(this.tbOpA);
            this.Controls.Add(this.tbQ);
            this.Name = "FrmTestSetup";
            this.Text = "FrmTestSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbOpA;
        private System.Windows.Forms.TextBox tbOpC;
        private System.Windows.Forms.TextBox tbOpB;
        private System.Windows.Forms.ComboBox cbCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewReport;
    }
}