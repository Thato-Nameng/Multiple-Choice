namespace MultipleChoiceAppTask1
{
    partial class FrmReport
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
            this.Report = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.ListBox();
            this.b = new System.Windows.Forms.ListBox();
            this.c = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.FormattingEnabled = true;
            this.Report.Location = new System.Drawing.Point(12, 12);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(557, 121);
            this.Report.TabIndex = 0;
            this.Report.SelectedIndexChanged += new System.EventHandler(this.lbReport_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(196, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 58);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // a
            // 
            this.a.FormattingEnabled = true;
            this.a.Location = new System.Drawing.Point(7, 153);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(98, 147);
            this.a.TabIndex = 2;
            this.a.SelectedIndexChanged += new System.EventHandler(this.lba_SelectedIndexChanged);
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.SystemColors.Menu;
            this.b.FormattingEnabled = true;
            this.b.Location = new System.Drawing.Point(223, 153);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(98, 147);
            this.b.TabIndex = 3;
            this.b.SelectedIndexChanged += new System.EventHandler(this.lbb_SelectedIndexChanged);
            // 
            // c
            // 
            this.c.FormattingEnabled = true;
            this.c.Location = new System.Drawing.Point(462, 153);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(98, 147);
            this.c.TabIndex = 4;
            this.c.SelectedIndexChanged += new System.EventHandler(this.lbc_SelectedIndexChanged);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 430);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Report);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Report;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox a;
        private System.Windows.Forms.ListBox b;
        private System.Windows.Forms.ListBox c;
    }
}