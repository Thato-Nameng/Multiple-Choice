namespace Student_Quiz_Management.Student_UserControl
{
    partial class StudentExam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(690, 450);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 46);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rad4
            // 
            this.rad4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad4.AutoSize = true;
            this.rad4.BackColor = System.Drawing.Color.Transparent;
            this.rad4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad4.Location = new System.Drawing.Point(53, 369);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(67, 37);
            this.rad4.TabIndex = 16;
            this.rad4.TabStop = true;
            this.rad4.Text = "rad1";
            this.rad4.UseVisualStyleBackColor = false;
            // 
            // rad2
            // 
            this.rad2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad2.AutoSize = true;
            this.rad2.BackColor = System.Drawing.Color.Transparent;
            this.rad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad2.Location = new System.Drawing.Point(53, 177);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(67, 37);
            this.rad2.TabIndex = 15;
            this.rad2.TabStop = true;
            this.rad2.Text = "rad1";
            this.rad2.UseVisualStyleBackColor = false;
            // 
            // rad3
            // 
            this.rad3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad3.AutoSize = true;
            this.rad3.BackColor = System.Drawing.Color.Transparent;
            this.rad3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad3.Location = new System.Drawing.Point(53, 280);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(67, 37);
            this.rad3.TabIndex = 14;
            this.rad3.TabStop = true;
            this.rad3.Text = "rad1";
            this.rad3.UseVisualStyleBackColor = false;
            // 
            // rad1
            // 
            this.rad1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rad1.AutoSize = true;
            this.rad1.BackColor = System.Drawing.Color.Transparent;
            this.rad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rad1.Location = new System.Drawing.Point(53, 85);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(67, 37);
            this.rad1.TabIndex = 13;
            this.rad1.TabStop = true;
            this.rad1.Text = "rad1";
            this.rad1.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(733, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "label2";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad1);
            this.Name = "StudentExam";
            this.Size = new System.Drawing.Size(848, 520);
            this.Load += new System.EventHandler(this.StudentExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
    }
}
