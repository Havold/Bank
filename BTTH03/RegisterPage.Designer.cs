namespace BTTH03
{
    partial class RegisterPage
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
            registerTxt = new Label();
            signupBtn = new PictureBox();
            txtName = new TextBox();
            userInputbg = new PictureBox();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPhone = new TextBox();
            pictureBox4 = new PictureBox();
            txtEmail = new TextBox();
            pictureBox5 = new PictureBox();
            txtPwd = new TextBox();
            femaleSelect = new RadioButton();
            maleSelect = new RadioButton();
            txtDate = new DateTimePicker();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)signupBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInputbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // registerTxt
            // 
            registerTxt.AutoSize = true;
            registerTxt.BackColor = Color.Transparent;
            registerTxt.Font = new Font("Roboto", 20F, FontStyle.Bold);
            registerTxt.ForeColor = Color.Black;
            registerTxt.Location = new Point(156, 31);
            registerTxt.Name = "registerTxt";
            registerTxt.Size = new Size(144, 42);
            registerTxt.TabIndex = 8;
            registerTxt.Text = "Register";
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.Transparent;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.Image = Properties.Resources.BtnSignup1;
            signupBtn.Location = new Point(77, 649);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(284, 62);
            signupBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            signupBtn.TabIndex = 10;
            signupBtn.TabStop = false;
            signupBtn.Click += signupBtn_Click;
            signupBtn.MouseEnter += signupBtn_MouseEnter;
            signupBtn.MouseLeave += signupBtn_MouseLeave;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Roboto", 14F);
            txtName.ForeColor = Color.Gray;
            txtName.Location = new Point(64, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(318, 29);
            txtName.TabIndex = 11;
            txtName.Text = "Name";
            txtName.Click += nameInput_click;
            // 
            // userInputbg
            // 
            userInputbg.BackColor = Color.Transparent;
            userInputbg.Image = Properties.Resources.InputUsername;
            userInputbg.Location = new Point(32, 94);
            userInputbg.Name = "userInputbg";
            userInputbg.Size = new Size(375, 67);
            userInputbg.SizeMode = PictureBoxSizeMode.StretchImage;
            userInputbg.TabIndex = 12;
            userInputbg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.InputUsername;
            pictureBox1.Location = new Point(32, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.AcceptsReturn = true;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Roboto", 14F);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(64, 207);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(318, 29);
            txtUsername.TabIndex = 11;
            txtUsername.Text = "Username";
            txtUsername.Click += userInput_click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.InputUsername;
            pictureBox2.Location = new Point(32, 285);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.InputUsername;
            pictureBox3.Location = new Point(32, 377);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(375, 67);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Roboto", 14F);
            txtPhone.ForeColor = Color.Gray;
            txtPhone.Location = new Point(64, 395);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 29);
            txtPhone.TabIndex = 11;
            txtPhone.Text = "Phone";
            txtPhone.Click += phoneInput_click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.InputUsername;
            pictureBox4.Location = new Point(32, 465);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(375, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Roboto", 14F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(64, 483);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 29);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "Email";
            txtEmail.Click += emailInput_click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.InputUsername;
            pictureBox5.Location = new Point(32, 557);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(375, 67);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // txtPwd
            // 
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Roboto", 14F);
            txtPwd.ForeColor = Color.Gray;
            txtPwd.Location = new Point(64, 575);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(318, 29);
            txtPwd.TabIndex = 11;
            txtPwd.Text = "Password";
            txtPwd.Click += pwdInput_click;
            // 
            // femaleSelect
            // 
            femaleSelect.AutoSize = true;
            femaleSelect.BackColor = Color.Transparent;
            femaleSelect.Cursor = Cursors.Hand;
            femaleSelect.Font = new Font("Roboto", 10F, FontStyle.Bold);
            femaleSelect.Location = new Point(320, 324);
            femaleSelect.Name = "femaleSelect";
            femaleSelect.Size = new Size(87, 26);
            femaleSelect.TabIndex = 13;
            femaleSelect.TabStop = true;
            femaleSelect.Text = "Female";
            femaleSelect.UseVisualStyleBackColor = false;
            femaleSelect.CheckedChanged += femaleSelect_CheckedChanged;
            // 
            // maleSelect
            // 
            maleSelect.AutoSize = true;
            maleSelect.BackColor = Color.Transparent;
            maleSelect.Checked = true;
            maleSelect.Cursor = Cursors.Hand;
            maleSelect.Font = new Font("Roboto", 10F, FontStyle.Bold);
            maleSelect.Location = new Point(320, 285);
            maleSelect.Name = "maleSelect";
            maleSelect.Size = new Size(69, 26);
            maleSelect.TabIndex = 13;
            maleSelect.TabStop = true;
            maleSelect.Text = "Male";
            maleSelect.UseVisualStyleBackColor = false;
            maleSelect.CheckedChanged += maleSelect_CheckedChanged;
            // 
            // txtDate
            // 
            txtDate.AccessibleRole = AccessibleRole.None;
            txtDate.CalendarMonthBackground = SystemColors.Highlight;
            txtDate.CalendarTitleBackColor = SystemColors.ControlText;
            txtDate.CalendarTitleForeColor = SystemColors.GrayText;
            txtDate.Font = new Font("Roboto", 14F);
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.Location = new Point(64, 301);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(219, 36);
            txtDate.TabIndex = 14;
            txtDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn2;
            backBtn.Location = new Point(9, 15);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 15;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            backBtn.MouseEnter += backBtn_MouseEnter;
            backBtn.MouseLeave += backBtn_MouseLeave;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(443, 748);
            Controls.Add(backBtn);
            Controls.Add(txtDate);
            Controls.Add(maleSelect);
            Controls.Add(femaleSelect);
            Controls.Add(txtPwd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(userInputbg);
            Controls.Add(signupBtn);
            Controls.Add(registerTxt);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterPage";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)signupBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInputbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerTxt;
        private PictureBox signupBtn;
        private TextBox txtName;
        private PictureBox userInputbg;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPhone;
        private PictureBox pictureBox4;
        private TextBox txtEmail;
        private PictureBox pictureBox5;
        private TextBox txtPwd;
        private RadioButton femaleSelect;
        private RadioButton maleSelect;
        private DateTimePicker txtDate;
        private PictureBox backBtn;
    }
}