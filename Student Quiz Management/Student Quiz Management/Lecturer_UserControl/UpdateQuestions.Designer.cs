namespace Student_Quiz_Management.Lecturer_UserControl
{
    partial class UpdateQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateQuestions));
            this.btnSync = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Subject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2TestType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxQuestion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOption1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOption2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOption3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOption4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.BorderColor = System.Drawing.Color.Transparent;
            this.btnSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSync.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSync.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSync.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSync.FillColor = System.Drawing.Color.Transparent;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSync.Location = new System.Drawing.Point(365, 27);
            this.btnSync.Name = "btnSync";
            this.btnSync.PressedColor = System.Drawing.Color.Transparent;
            this.btnSync.Size = new System.Drawing.Size(30, 24);
            this.btnSync.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "Update Student Question";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(32, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "Subject";
            // 
            // guna2Subject
            // 
            this.guna2Subject.BackColor = System.Drawing.Color.IndianRed;
            this.guna2Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2Subject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Subject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Subject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2Subject.ItemHeight = 30;
            this.guna2Subject.Location = new System.Drawing.Point(37, 120);
            this.guna2Subject.Name = "guna2Subject";
            this.guna2Subject.Size = new System.Drawing.Size(221, 36);
            this.guna2Subject.TabIndex = 73;
            this.guna2Subject.SelectedIndexChanged += new System.EventHandler(this.guna2Subject_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(328, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 76;
            this.label11.Text = "Test Type";
            // 
            // guna2TestType
            // 
            this.guna2TestType.BackColor = System.Drawing.Color.IndianRed;
            this.guna2TestType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2TestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2TestType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TestType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TestType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2TestType.ItemHeight = 30;
            this.guna2TestType.Location = new System.Drawing.Point(333, 120);
            this.guna2TestType.Name = "guna2TestType";
            this.guna2TestType.Size = new System.Drawing.Size(155, 36);
            this.guna2TestType.TabIndex = 75;
            this.guna2TestType.SelectedIndexChanged += new System.EventHandler(this.guna2TestType_SelectedIndexChanged);
            // 
            // cbxQuestion
            // 
            this.cbxQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cbxQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQuestion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxQuestion.ForeColor = System.Drawing.Color.Black;
            this.cbxQuestion.ItemHeight = 30;
            this.cbxQuestion.Location = new System.Drawing.Point(551, 120);
            this.cbxQuestion.Name = "cbxQuestion";
            this.cbxQuestion.Size = new System.Drawing.Size(137, 36);
            this.cbxQuestion.TabIndex = 78;
            this.cbxQuestion.SelectedIndexChanged += new System.EventHandler(this.cbxQuestion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(546, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Question No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(320, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.DefaultText = "";
            this.txtQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.Location = new System.Drawing.Point(34, 197);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.PlaceholderText = "";
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.Size = new System.Drawing.Size(682, 36);
            this.txtQuestion.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(32, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 82;
            this.label9.Text = "Option 1:";
            // 
            // txtOption1
            // 
            this.txtOption1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption1.DefaultText = "";
            this.txtOption1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOption1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption1.Location = new System.Drawing.Point(37, 291);
            this.txtOption1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.PasswordChar = '\0';
            this.txtOption1.PlaceholderText = "";
            this.txtOption1.SelectedText = "";
            this.txtOption1.Size = new System.Drawing.Size(317, 36);
            this.txtOption1.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(403, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Option 2:";
            // 
            // txtOption2
            // 
            this.txtOption2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption2.DefaultText = "";
            this.txtOption2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOption2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption2.Location = new System.Drawing.Point(401, 291);
            this.txtOption2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.PasswordChar = '\0';
            this.txtOption2.PlaceholderText = "";
            this.txtOption2.SelectedText = "";
            this.txtOption2.Size = new System.Drawing.Size(317, 36);
            this.txtOption2.TabIndex = 83;
            // 
            // txtOption3
            // 
            this.txtOption3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption3.DefaultText = "";
            this.txtOption3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOption3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption3.Location = new System.Drawing.Point(37, 379);
            this.txtOption3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.PasswordChar = '\0';
            this.txtOption3.PlaceholderText = "";
            this.txtOption3.SelectedText = "";
            this.txtOption3.Size = new System.Drawing.Size(317, 36);
            this.txtOption3.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(32, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 85;
            this.label8.Text = "Option 3:";
            // 
            // txtOption4
            // 
            this.txtOption4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOption4.DefaultText = "";
            this.txtOption4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOption4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOption4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOption4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOption4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOption4.Location = new System.Drawing.Point(401, 379);
            this.txtOption4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.PasswordChar = '\0';
            this.txtOption4.PlaceholderText = "";
            this.txtOption4.SelectedText = "";
            this.txtOption4.Size = new System.Drawing.Size(317, 36);
            this.txtOption4.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(396, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Option 4:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.Location = new System.Drawing.Point(34, 469);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "";
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.Size = new System.Drawing.Size(682, 36);
            this.txtAnswer.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(329, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Answer";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Location = new System.Drawing.Point(389, 529);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 41);
            this.btnReset.TabIndex = 92;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Location = new System.Drawing.Point(252, 529);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 41);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Elipse2
            // 
            this.Elipse2.TargetControl = this;
            // 
            // UpdateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOption4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOption3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOption2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOption1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.cbxQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2TestType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2Subject);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateQuestions";
            this.Size = new System.Drawing.Size(739, 657);
            this.Load += new System.EventHandler(this.UpdateQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox guna2Subject;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox guna2TestType;
        private Guna.UI2.WinForms.Guna2ComboBox cbxQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtOption1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtOption2;
        private Guna.UI2.WinForms.Guna2TextBox txtOption3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtOption4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Elipse Elipse2;
    }
}
