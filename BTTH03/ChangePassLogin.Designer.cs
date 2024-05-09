namespace BTTH03
{
    partial class ChangePassLogin
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
            eyeBtn_2 = new PictureBox();
            txtNewPwd = new TextBox();
            pictureBox1 = new PictureBox();
            changeBtn = new PictureBox();
            backBtn = new PictureBox();
            txtChangePass = new Label();
            eyeBtn = new PictureBox();
            txtOldPwd = new TextBox();
            pwdInputbg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eyeBtn_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pwdInputbg).BeginInit();
            SuspendLayout();
            // 
            // eyeBtn_2
            // 
            eyeBtn_2.BackColor = Color.White;
            eyeBtn_2.Cursor = Cursors.Hand;
            eyeBtn_2.Image = Properties.Resources.eye_closed;
            eyeBtn_2.Location = new Point(374, 342);
            eyeBtn_2.Name = "eyeBtn_2";
            eyeBtn_2.Size = new Size(40, 40);
            eyeBtn_2.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeBtn_2.TabIndex = 40;
            eyeBtn_2.TabStop = false;
            eyeBtn_2.Click += eyeBtn_2_Click;
            // 
            // txtNewPwd
            // 
            txtNewPwd.BorderStyle = BorderStyle.None;
            txtNewPwd.Font = new Font("Roboto", 14F);
            txtNewPwd.ForeColor = Color.Gray;
            txtNewPwd.Location = new Point(89, 347);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(284, 29);
            txtNewPwd.TabIndex = 36;
            txtNewPwd.Text = "New password";
            txtNewPwd.Click += txtNewPwd_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.InputUsername;
            pictureBox1.Location = new Point(50, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // changeBtn
            // 
            changeBtn.BackColor = Color.Transparent;
            changeBtn.Cursor = Cursors.Hand;
            changeBtn.Image = Properties.Resources.ChangeBtn;
            changeBtn.Location = new Point(50, 469);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(375, 67);
            changeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            changeBtn.TabIndex = 33;
            changeBtn.TabStop = false;
            changeBtn.Click += changeBtn_Click;
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
            backBtn.TabIndex = 32;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtChangePass
            // 
            txtChangePass.AutoSize = true;
            txtChangePass.BackColor = Color.Transparent;
            txtChangePass.Font = new Font("Roboto", 20F, FontStyle.Bold);
            txtChangePass.ForeColor = Color.Black;
            txtChangePass.Location = new Point(93, 119);
            txtChangePass.Name = "txtChangePass";
            txtChangePass.Size = new Size(287, 42);
            txtChangePass.TabIndex = 31;
            txtChangePass.Text = "Change password";
            // 
            // eyeBtn
            // 
            eyeBtn.BackColor = Color.White;
            eyeBtn.Cursor = Cursors.Hand;
            eyeBtn.Image = Properties.Resources.eye_closed;
            eyeBtn.Location = new Point(374, 244);
            eyeBtn.Name = "eyeBtn";
            eyeBtn.Size = new Size(40, 40);
            eyeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            eyeBtn.TabIndex = 41;
            eyeBtn.TabStop = false;
            eyeBtn.Click += eyeBtn_Click;
            // 
            // txtOldPwd
            // 
            txtOldPwd.BorderStyle = BorderStyle.None;
            txtOldPwd.Font = new Font("Roboto", 14F);
            txtOldPwd.ForeColor = Color.Gray;
            txtOldPwd.Location = new Point(89, 249);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(284, 29);
            txtOldPwd.TabIndex = 37;
            txtOldPwd.Text = "Old password";
            txtOldPwd.Click += txtOldPwd_Click;
            // 
            // pwdInputbg
            // 
            pwdInputbg.BackColor = Color.Transparent;
            pwdInputbg.Image = Properties.Resources.InputUsername;
            pwdInputbg.Location = new Point(50, 231);
            pwdInputbg.Name = "pwdInputbg";
            pwdInputbg.Size = new Size(375, 67);
            pwdInputbg.SizeMode = PictureBoxSizeMode.StretchImage;
            pwdInputbg.TabIndex = 39;
            pwdInputbg.TabStop = false;
            // 
            // ChangePassLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 795);
            Controls.Add(eyeBtn_2);
            Controls.Add(eyeBtn);
            Controls.Add(txtNewPwd);
            Controls.Add(txtOldPwd);
            Controls.Add(pictureBox1);
            Controls.Add(pwdInputbg);
            Controls.Add(changeBtn);
            Controls.Add(backBtn);
            Controls.Add(txtChangePass);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassLogin";
            Text = "ChangePassLogin";
            ((System.ComponentModel.ISupportInitialize)eyeBtn_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)changeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pwdInputbg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox eyeBtn_2;
        private TextBox txtNewPwd;
        private PictureBox pictureBox1;
        private PictureBox changeBtn;
        private PictureBox backBtn;
        private Label txtChangePass;
        private PictureBox eyeBtn;
        private TextBox txtOldPwd;
        private PictureBox pwdInputbg;
    }
}