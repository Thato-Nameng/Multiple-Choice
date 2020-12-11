namespace MultipleChoiceAppTask1
{
    partial class frmTakeTest
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cblA = new System.Windows.Forms.CheckedListBox();
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.btnMemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(28, 289);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cblA
            // 
            this.cblA.CheckOnClick = true;
            this.cblA.FormattingEnabled = true;
            this.cblA.Items.AddRange(new object[] {
            "first choice ",
            "Second choice ",
            "third choice"});
            this.cblA.Location = new System.Drawing.Point(28, 171);
            this.cblA.Name = "cblA";
            this.cblA.Size = new System.Drawing.Size(558, 79);
            this.cblA.TabIndex = 1;
            this.cblA.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.Location = new System.Drawing.Point(12, 34);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(565, 82);
            this.lbQuestion.TabIndex = 2;
            this.lbQuestion.SelectedIndexChanged += new System.EventHandler(this.lbQuestion_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(502, 289);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Location = new System.Drawing.Point(72, 9);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(87, 13);
            this.lblQuestionCount.TabIndex = 4;
            this.lblQuestionCount.Text = "lblQuestionCount";
            // 
            // btnMemo
            // 
            this.btnMemo.Enabled = false;
            this.btnMemo.Location = new System.Drawing.Point(178, 289);
            this.btnMemo.Name = "btnMemo";
            this.btnMemo.Size = new System.Drawing.Size(173, 23);
            this.btnMemo.TabIndex = 5;
            this.btnMemo.Text = "View Memo memorandum";
            this.btnMemo.UseVisualStyleBackColor = true;
            this.btnMemo.Click += new System.EventHandler(this.btnMemo_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(646, 396);
            this.Controls.Add(this.btnMemo);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.cblA);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmTakeTest";
            this.Text = "Test ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckedListBox cblA;
        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.Button btnMemo;
    }
}