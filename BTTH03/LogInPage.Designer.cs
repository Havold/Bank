namespace BTTH03
{
    partial class LogInPage
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
            iconImg = new PictureBox();
            txtUsername = new TextBox();
            txtPwd = new TextBox();
            userInputbg = new PictureBox();
            pwdInputbg = new PictureBox();
            remeberBox = new CheckBox();
            forgetTxt = new Label();
            loginBtn = new PictureBox();
            label2 = new Label();
            signupTxt = new Label();
            backBtn = new PictureBox();
            eyeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userInputbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pwdInputbg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeBtn).BeginInit();
            SuspendLayout();
            // 
            // iconImg
            // 
            iconImg.BackColor = Color.Transparent;
            iconImg.Image = Properties.Resources.money1;
            iconImg.Location = new Point(85, 1);
            iconImg.Name = "iconImg";
            iconImg.Size = new Size(304, 298);
            iconImg.SizeMode = PictureBoxSizeMode.StretchImage;
            iconImg.TabIndex = 3;
            iconImg.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Roboto", 14F);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(78, 321);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 29);
            txtUsername.TabIndex = 4;
            txtUsername.Text = "Username";
            txtUsername.Click += userInput_click;
            // 
            // txtPwd
            // 
            txtPwd.BorderStyle = BorderStyle.None;
            txtPwd.Font = new Font("Roboto", 14F);
            txtPwd.ForeColor = Color.Gray;
            txtPwd.Location = new Point(85, 411);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(284, 29);
            txtPwd.TabIndex = 4;
            txtPwd.Text = "Password";
            txtPwd.Click += pwdInput_click;
            // 
            // userInputbg
            // 
            userInputbg.BackColor = Color.Transparent;
            userInputbg.Image = Properties.Resources.InputUsername;
            userInputbg.Location = new Point(46, 303);
            userInputbg.Name = "userInputbg";
            userInputbg.Size = new Size(375, 67);
            userInputbg.SizeMode = PictureBoxSizeMode.StretchImage;
            userInputbg.TabIndex = 5;
            userInputbg.TabStop = false;
            // 
            // pwdInputbg
            // 
            pwdInputbg.BackColor = Color.Transparent;
            pwdInputbg.Image = Properties.Resources.InputUsername;
            pwdInputbg.Location = new Point(46, 393);
            pwdInputbg.Name = "pwdInputbg";
            pwdInputbg.Size = new Size(375, 67);
            pwdInputbg.SizeMode = PictureBoxSizeMode.StretchImage;
            pwdInputbg.TabIndex = 5;
            pwdInputbg.TabStop = false;
            // 
            // remeberBox
            // 
            remeberBox.AutoSize = true;
            remeberBox.BackColor = Color.Transparent;
            remeberBox.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            remeberBox.Location = new Point(48, 477);
            remeberBox.Name = "remeberBox";
            remeberBox.Size = new Size(143, 26);
            remeberBox.TabIndex = 6;
            remeberBox.Text = "Remember me";
            remeberBox.UseVisualStyleBackColor = false;
            remeberBox.Click += resetClick;
            // 
            // forgetTxt
            // 
            forgetTxt.AutoSize = true;
            forgetTxt.BackColor = Color.Transparent;
            forgetTxt.Cursor = Cursors.Hand;
            forgetTxt.Font = new Font("Roboto", 10F);
            forgetTxt.ForeColor = Color.Black;
            forgetTxt.Location = new Point(272, 478);
            forgetTxt.Name = "forgetTxt";
            forgetTxt.Size = new Size(149, 22);
            forgetTxt.TabIndex = 7;
            forgetTxt.Text = "Forget Password?";
            forgetTxt.Click += forgetTxt_Click;
            forgetTxt.MouseEnter += forgetTxt_MouseEnter;
            forgetTxt.MouseLeave += forgetTxt_MouseLeave;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Image = Properties.Resources.BtnLogin1;
            loginBtn.Location = new Point(85, 532);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(284, 62);
            loginBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            loginBtn.TabIndex = 8;
            loginBtn.TabStop = false;
            loginBtn.Click += loginBtn_Click;
            loginBtn.MouseEnter += loginBtn_MouseEnter;
            loginBtn.MouseLeave += loginBtn_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(46, 703);
            label2.Name = "label2";
            label2.Size = new Size(161, 22);
            label2.TabIndex = 7;
            label2.Text = "Don't have account?";
            // 
            // signupTxt
            // 
            signupTxt.AutoSize = true;
            signupTxt.BackColor = Color.Transparent;
            signupTxt.Cursor = Cursors.Hand;
            signupTxt.Font = new Font("Roboto", 14F, FontStyle.Bold);
            signupTxt.ForeColor = Color.Black;
            signupTxt.Location = new Point(216, 697);
            signupTxt.Name = "signupTxt";
            signupTxt.Size = new Size(97, 29);
            signupTxt.TabIndex = 7;
            signupTxt.Text = "Sign Up";
            signupTxt.Click += signupTxt_Click;
            signupTxt.MouseEnter += signupTxt_MouseEnter;
            signupTxt.MouseLeave += signupTxt_MouseLeave;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn2;
            backBtn.Location = new Point(12, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 16;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            backBtn.MouseEnter += backBtn_MouseEnter;
            backBtn.MouseLeave += backBtn_MouseLeave;
            // 
            // eyeBtn
            // 
            eyeBtn.BackColor = Color.White;
            eyeBtn.Cursor = Cursors.Hand;
            eyeBtn.Image = Properties.Resources.eye_closed;
            eyeBtn.Location = new Point(370, 406);
            eyeBtn.Name = "eyeBtn";
            eyeBtn.Size = new Size(40, 40);
            eyeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeBtn.TabIndex = 16;
            eyeBtn.TabStop = false;
            eyeBtn.Click += eyeBtn_Click;
            eyeBtn.MouseEnter += backBtn_MouseEnter;
            eyeBtn.MouseLeave += backBtn_MouseLeave;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 795);
            Controls.Add(eyeBtn);
            Controls.Add(backBtn);
            Controls.Add(loginBtn);
            Controls.Add(signupTxt);
            Controls.Add(label2);
            Controls.Add(forgetTxt);
            Controls.Add(remeberBox);
            Controls.Add(txtPwd);
            Controls.Add(txtUsername);
            Controls.Add(iconImg);
            Controls.Add(pwdInputbg);
            Controls.Add(userInputbg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInPage";
            Text = "LogInPage";
            Load += LogInPage_Load;
            ((System.ComponentModel.ISupportInitialize)iconImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)userInputbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pwdInputbg).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconImg;
        private TextBox txtUsername;
        private TextBox txtPwd;
        private PictureBox userInputbg;
        private PictureBox pwdInputbg;
        private CheckBox remeberBox;
        private Label forgetTxt;
        private PictureBox loginBtn;
        private Label label2;
        private Label signupTxt;
        private PictureBox backBtn;
        private PictureBox eyeBtn;
    }
}