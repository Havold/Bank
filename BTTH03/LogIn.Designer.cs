namespace BTTH03
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            signupBtn = new PictureBox();
            loginBtn = new PictureBox();
            METAN = new Label();
            txtChange = new Label();
            welcome = new Label();
            iconImg = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signupBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconImg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.background1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(signupBtn);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(METAN);
            panel1.Controls.Add(txtChange);
            panel1.Controls.Add(welcome);
            panel1.Controls.Add(iconImg);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 842);
            panel1.TabIndex = 0;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.Transparent;
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.Image = Properties.Resources.BtnSignup;
            signupBtn.Location = new Point(97, 655);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(284, 62);
            signupBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            signupBtn.TabIndex = 1;
            signupBtn.TabStop = false;
            signupBtn.Click += signupBtn_Click_1;
            signupBtn.MouseEnter += signupBtn_MouseEnter;
            signupBtn.MouseLeave += signupBtn_MouseLeave;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.Image = Properties.Resources.BtnLogin;
            loginBtn.Location = new Point(97, 547);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(284, 62);
            loginBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            loginBtn.TabIndex = 1;
            loginBtn.TabStop = false;
            loginBtn.Click += signupBtn_Click;
            loginBtn.MouseEnter += loginBtn_MouseEnter;
            loginBtn.MouseLeave += loginBtn_MouseLeave;
            // 
            // METAN
            // 
            METAN.AutoSize = true;
            METAN.BackColor = Color.Transparent;
            METAN.Font = new Font("VALORANT", 40F);
            METAN.ForeColor = Color.Navy;
            METAN.Location = new Point(88, 433);
            METAN.Name = "METAN";
            METAN.Size = new Size(295, 68);
            METAN.TabIndex = 0;
            METAN.Text = "METAN";
            // 
            // txtChange
            // 
            txtChange.AutoSize = true;
            txtChange.BackColor = Color.Transparent;
            txtChange.Cursor = Cursors.Hand;
            txtChange.Font = new Font("Roboto", 14F);
            txtChange.ForeColor = Color.Gray;
            txtChange.Location = new Point(141, 750);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(204, 29);
            txtChange.TabIndex = 0;
            txtChange.Text = "Change password";
            txtChange.Click += txtChange_Click;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Roboto", 16F, FontStyle.Bold);
            welcome.ForeColor = Color.Navy;
            welcome.Location = new Point(163, 383);
            welcome.Name = "welcome";
            welcome.Size = new Size(159, 33);
            welcome.TabIndex = 0;
            welcome.Text = "Welcome to";
            // 
            // iconImg
            // 
            iconImg.BackColor = Color.Transparent;
            iconImg.Image = Properties.Resources.money1;
            iconImg.Location = new Point(52, 21);
            iconImg.Name = "iconImg";
            iconImg.Size = new Size(394, 388);
            iconImg.SizeMode = PictureBoxSizeMode.StretchImage;
            iconImg.TabIndex = 2;
            iconImg.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 842);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signupBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label welcome;
        private Label METAN;
        private PictureBox loginBtn;
        private PictureBox iconImg;
        private PictureBox signupBtn;
        private Label txtChange;
    }
}
