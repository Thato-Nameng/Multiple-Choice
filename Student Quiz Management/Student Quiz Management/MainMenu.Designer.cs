namespace Student_Quiz_Management
{
    partial class MainMenu
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
            this.pnlLect = new System.Windows.Forms.Panel();
            this.txtLectPass = new System.Windows.Forms.TextBox();
            this.txtLectName = new System.Windows.Forms.TextBox();
            this.cbLectShowPass = new System.Windows.Forms.CheckBox();
            this.btnLectLog = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLectWrong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSelectUser = new System.Windows.Forms.ComboBox();
            this.pnlStud = new System.Windows.Forms.Panel();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.cbxStudShowPass = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblStudWrong = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlLect.SuspendLayout();
            this.pnlStud.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLect
            // 
            this.pnlLect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlLect.Controls.Add(this.txtLectPass);
            this.pnlLect.Controls.Add(this.txtLectName);
            this.pnlLect.Controls.Add(this.cbLectShowPass);
            this.pnlLect.Controls.Add(this.btnLectLog);
            this.pnlLect.Controls.Add(this.label6);
            this.pnlLect.Controls.Add(this.lblLectWrong);
            this.pnlLect.Controls.Add(this.label4);
            this.pnlLect.Controls.Add(this.label3);
            this.pnlLect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLect.Location = new System.Drawing.Point(207, 151);
            this.pnlLect.Name = "pnlLect";
            this.pnlLect.Size = new System.Drawing.Size(382, 454);
            this.pnlLect.TabIndex = 21;
            // 
            // txtLectPass
            // 
            this.txtLectPass.AutoCompleteCustomSource.AddRange(new string[] {
            " "});
            this.txtLectPass.BackColor = System.Drawing.Color.GhostWhite;
            this.txtLectPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLectPass.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtLectPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtLectPass.Location = new System.Drawing.Point(24, 162);
            this.txtLectPass.Multiline = true;
            this.txtLectPass.Name = "txtLectPass";
            this.txtLectPass.PasswordChar = '*';
            this.txtLectPass.Size = new System.Drawing.Size(337, 41);
            this.txtLectPass.TabIndex = 27;
            // 
            // txtLectName
            // 
            this.txtLectName.AutoCompleteCustomSource.AddRange(new string[] {
            " "});
            this.txtLectName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtLectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLectName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtLectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtLectName.Location = new System.Drawing.Point(24, 89);
            this.txtLectName.Name = "txtLectName";
            this.txtLectName.Size = new System.Drawing.Size(337, 36);
            this.txtLectName.TabIndex = 26;
            // 
            // cbLectShowPass
            // 
            this.cbLectShowPass.AutoSize = true;
            this.cbLectShowPass.ForeColor = System.Drawing.Color.MistyRose;
            this.cbLectShowPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbLectShowPass.Location = new System.Drawing.Point(137, 219);
            this.cbLectShowPass.Name = "cbLectShowPass";
            this.cbLectShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbLectShowPass.TabIndex = 7;
            this.cbLectShowPass.Text = "Show Password";
            this.cbLectShowPass.UseVisualStyleBackColor = true;
            this.cbLectShowPass.CheckedChanged += new System.EventHandler(this.cbLectShowPass_CheckedChanged);
            // 
            // btnLectLog
            // 
            this.btnLectLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLectLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLectLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLectLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLectLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLectLog.Location = new System.Drawing.Point(87, 245);
            this.btnLectLog.Name = "btnLectLog";
            this.btnLectLog.Size = new System.Drawing.Size(202, 54);
            this.btnLectLog.TabIndex = 6;
            this.btnLectLog.Text = "Login";
            this.btnLectLog.UseVisualStyleBackColor = false;
            this.btnLectLog.Click += new System.EventHandler(this.btnLectLog_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(145, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password";
            // 
            // lblLectWrong
            // 
            this.lblLectWrong.AutoSize = true;
            this.lblLectWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectWrong.ForeColor = System.Drawing.Color.Salmon;
            this.lblLectWrong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLectWrong.Location = new System.Drawing.Point(100, 306);
            this.lblLectWrong.Name = "lblLectWrong";
            this.lblLectWrong.Size = new System.Drawing.Size(185, 15);
            this.lblLectWrong.TabIndex = 2;
            this.lblLectWrong.Text = "Wrong username/ password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(143, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(114, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lecture Login: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(302, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select User Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(263, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "StudentsQuiz";
            // 
            // cbxSelectUser
            // 
            this.cbxSelectUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectUser.FormattingEnabled = true;
            this.cbxSelectUser.Items.AddRange(new object[] {
            "Lecturer",
            "Student"});
            this.cbxSelectUser.Location = new System.Drawing.Point(223, 100);
            this.cbxSelectUser.Name = "cbxSelectUser";
            this.cbxSelectUser.Size = new System.Drawing.Size(347, 26);
            this.cbxSelectUser.TabIndex = 18;
            this.cbxSelectUser.SelectedIndexChanged += new System.EventHandler(this.cbxSelectUser_SelectedIndexChanged);
            // 
            // pnlStud
            // 
            this.pnlStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlStud.Controls.Add(this.btnStudentLogin);
            this.pnlStud.Controls.Add(this.cbxStudShowPass);
            this.pnlStud.Controls.Add(this.btnRegister);
            this.pnlStud.Controls.Add(this.txtPassword);
            this.pnlStud.Controls.Add(this.txtSNumber);
            this.pnlStud.Controls.Add(this.label13);
            this.pnlStud.Controls.Add(this.lblStudWrong);
            this.pnlStud.Controls.Add(this.label15);
            this.pnlStud.Controls.Add(this.label16);
            this.pnlStud.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlStud.Location = new System.Drawing.Point(206, 151);
            this.pnlStud.Name = "pnlStud";
            this.pnlStud.Size = new System.Drawing.Size(382, 453);
            this.pnlStud.TabIndex = 22;
            this.pnlStud.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStud_Paint);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudentLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudentLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStudentLogin.Location = new System.Drawing.Point(24, 279);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(332, 54);
            this.btnStudentLogin.TabIndex = 8;
            this.btnStudentLogin.Text = "Student Login";
            this.btnStudentLogin.UseVisualStyleBackColor = false;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // cbxStudShowPass
            // 
            this.cbxStudShowPass.AutoSize = true;
            this.cbxStudShowPass.ForeColor = System.Drawing.Color.MistyRose;
            this.cbxStudShowPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxStudShowPass.Location = new System.Drawing.Point(137, 250);
            this.cbxStudShowPass.Name = "cbxStudShowPass";
            this.cbxStudShowPass.Size = new System.Drawing.Size(102, 17);
            this.cbxStudShowPass.TabIndex = 7;
            this.cbxStudShowPass.Text = "Show Password";
            this.cbxStudShowPass.UseVisualStyleBackColor = true;
            this.cbxStudShowPass.CheckedChanged += new System.EventHandler(this.cbxStudShowPass_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Teal;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegister.Location = new System.Drawing.Point(24, 343);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(332, 54);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(24, 193);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(332, 50);
            this.txtPassword.TabIndex = 5;
            // 
            // txtSNumber
            // 
            this.txtSNumber.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSNumber.DefaultText = "";
            this.txtSNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSNumber.Location = new System.Drawing.Point(24, 99);
            this.txtSNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSNumber.Name = "txtSNumber";
            this.txtSNumber.PasswordChar = '\0';
            this.txtSNumber.PlaceholderText = "";
            this.txtSNumber.SelectedText = "";
            this.txtSNumber.Size = new System.Drawing.Size(332, 50);
            this.txtSNumber.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.ForeColor = System.Drawing.Color.SeaShell;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(145, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Password";
            // 
            // lblStudWrong
            // 
            this.lblStudWrong.AutoSize = true;
            this.lblStudWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudWrong.ForeColor = System.Drawing.Color.Salmon;
            this.lblStudWrong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStudWrong.Location = new System.Drawing.Point(94, 404);
            this.lblStudWrong.Name = "lblStudWrong";
            this.lblStudWrong.Size = new System.Drawing.Size(185, 15);
            this.lblStudWrong.TabIndex = 2;
            this.lblStudWrong.Text = "Wrong username/ password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label15.ForeColor = System.Drawing.Color.SeaShell;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(125, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Student Number";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.SeaShell;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(120, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Student Login:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.pnlStud);
            this.Controls.Add(this.pnlLect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSelectUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.pnlLect.ResumeLayout(false);
            this.pnlLect.PerformLayout();
            this.pnlStud.ResumeLayout(false);
            this.pnlStud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLect;
        private System.Windows.Forms.TextBox txtLectPass;
        private System.Windows.Forms.TextBox txtLectName;
        private System.Windows.Forms.CheckBox cbLectShowPass;
        private System.Windows.Forms.Button btnLectLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLectWrong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSelectUser;
        private System.Windows.Forms.Panel pnlStud;
        private System.Windows.Forms.Button btnStudentLogin;
        private System.Windows.Forms.CheckBox cbxStudShowPass;
        private System.Windows.Forms.Button btnRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtSNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblStudWrong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}