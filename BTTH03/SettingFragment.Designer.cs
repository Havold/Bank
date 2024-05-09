namespace BTTH03
{
    partial class SettingFragment
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
            pictureBox3 = new PictureBox();
            name = new Label();
            label2 = new Label();
            logoutBtn = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            changeBtn = new Button();
            txtUsername = new Label();
            txtPhone = new Label();
            txtDate = new Label();
            txtEmail = new Label();
            txtSex = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(181, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Roboto", 12F, FontStyle.Bold);
            name.ForeColor = SystemColors.Highlight;
            name.Location = new Point(139, 184);
            name.Name = "name";
            name.Size = new Size(182, 25);
            name.TabIndex = 18;
            name.Text = "TRUONG HUU THO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 9F);
            label2.Location = new Point(176, 159);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 19;
            label2.Text = "Good morning!";
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.DarkRed;
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(241, 597);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(200, 53);
            logoutBtn.TabIndex = 24;
            logoutBtn.Text = "Log out";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label1.Location = new Point(21, 240);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 18;
            label1.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 293);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 18;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label4.Location = new Point(18, 353);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 18;
            label4.Text = "Date of birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 411);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 18;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label6.Location = new Point(20, 469);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 18;
            label6.Text = "Sex:";
            // 
            // changeBtn
            // 
            changeBtn.BackColor = SystemColors.Highlight;
            changeBtn.Cursor = Cursors.Hand;
            changeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            changeBtn.ForeColor = Color.White;
            changeBtn.Location = new Point(16, 597);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(200, 53);
            changeBtn.TabIndex = 24;
            changeBtn.Text = "Change password";
            changeBtn.UseVisualStyleBackColor = false;
            changeBtn.Click += changeBtn_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtUsername.Location = new Point(136, 242);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(148, 25);
            txtUsername.TabIndex = 18;
            txtUsername.Text = "havold";
            txtUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.Transparent;
            txtPhone.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtPhone.Location = new Point(97, 295);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(188, 25);
            txtPhone.TabIndex = 18;
            txtPhone.Text = "0833873869";
            txtPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Transparent;
            txtDate.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtDate.Location = new Point(153, 354);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(177, 25);
            txtDate.TabIndex = 18;
            txtDate.Text = "03/07/2003";
            txtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(93, 412);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 25);
            txtEmail.TabIndex = 18;
            txtEmail.Text = "huutho030703@gmail.com";
            txtEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSex
            // 
            txtSex.BackColor = Color.Transparent;
            txtSex.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtSex.Location = new Point(77, 470);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(109, 25);
            txtSex.TabIndex = 18;
            txtSex.Text = "Male";
            txtSex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SettingFragment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(changeBtn);
            Controls.Add(logoutBtn);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSex);
            Controls.Add(txtEmail);
            Controls.Add(txtDate);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "SettingFragment";
            Size = new Size(457, 676);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label name;
        private Label label2;
        private Button logoutBtn;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button changeBtn;
        private Label txtUsername;
        private Label txtPhone;
        private Label txtDate;
        private Label txtEmail;
        private Label txtSex;
    }
}
