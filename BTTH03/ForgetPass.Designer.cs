namespace BTTH03
{
    partial class ForgetPass
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
            backBtn = new PictureBox();
            txtForget = new Label();
            txtEmail = new TextBox();
            pictureBox4 = new PictureBox();
            instruction = new TextBox();
            sendBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sendBtn).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.backBtn2;
            backBtn.Location = new Point(20, 17);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(60, 60);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 17;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // txtForget
            // 
            txtForget.AutoSize = true;
            txtForget.BackColor = Color.Transparent;
            txtForget.Font = new Font("Roboto", 20F, FontStyle.Bold);
            txtForget.ForeColor = Color.Black;
            txtForget.Location = new Point(107, 185);
            txtForget.Name = "txtForget";
            txtForget.Size = new Size(270, 42);
            txtForget.TabIndex = 16;
            txtForget.Text = "Forget password";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Roboto", 14F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(83, 343);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 29);
            txtEmail.TabIndex = 18;
            txtEmail.Text = "Email";
            txtEmail.Click += txtEmail_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.InputUsername;
            pictureBox4.Location = new Point(51, 325);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(375, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // instruction
            // 
            instruction.AllowDrop = true;
            instruction.BackColor = Color.White;
            instruction.BorderStyle = BorderStyle.None;
            instruction.Font = new Font("Roboto", 10F);
            instruction.ForeColor = Color.Gray;
            instruction.Location = new Point(83, 238);
            instruction.Multiline = true;
            instruction.Name = "instruction";
            instruction.ReadOnly = true;
            instruction.Size = new Size(318, 50);
            instruction.TabIndex = 18;
            instruction.Text = "Please fill in the box below and we will send you a new password.";
            instruction.TextAlign = HorizontalAlignment.Center;
            // 
            // sendBtn
            // 
            sendBtn.BackColor = Color.Transparent;
            sendBtn.Cursor = Cursors.Hand;
            sendBtn.Image = Properties.Resources.sendBtn1;
            sendBtn.Location = new Point(51, 479);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(375, 67);
            sendBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            sendBtn.TabIndex = 19;
            sendBtn.TabStop = false;
            sendBtn.Click += sendBtn_Click;
            // 
            // ForgetPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 795);
            Controls.Add(instruction);
            Controls.Add(txtEmail);
            Controls.Add(sendBtn);
            Controls.Add(pictureBox4);
            Controls.Add(backBtn);
            Controls.Add(txtForget);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPass";
            Text = "ForgetPass";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)sendBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backBtn;
        private Label txtForget;
        private TextBox txtEmail;
        private PictureBox pictureBox4;
        private TextBox instruction;
        private PictureBox sendBtn;
    }
}