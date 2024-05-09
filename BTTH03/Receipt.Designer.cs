namespace BTTH03
{
    partial class Receipt
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
            titleMessage = new Label();
            txtMoney = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new Label();
            txtSTK = new Label();
            txtBank = new Label();
            txtMaGD = new Label();
            txtContent = new TextBox();
            transferBtn = new Button();
            txtDate = new Label();
            ((System.ComponentModel.ISupportInitialize)iconImg).BeginInit();
            SuspendLayout();
            // 
            // iconImg
            // 
            iconImg.BackColor = Color.Transparent;
            iconImg.Image = Properties.Resources.money1;
            iconImg.Location = new Point(129, -1);
            iconImg.Name = "iconImg";
            iconImg.Size = new Size(199, 170);
            iconImg.SizeMode = PictureBoxSizeMode.StretchImage;
            iconImg.TabIndex = 4;
            iconImg.TabStop = false;
            // 
            // titleMessage
            // 
            titleMessage.AutoSize = true;
            titleMessage.BackColor = Color.Transparent;
            titleMessage.Cursor = Cursors.Hand;
            titleMessage.Font = new Font("Roboto", 14F, FontStyle.Bold);
            titleMessage.Location = new Point(116, 152);
            titleMessage.Name = "titleMessage";
            titleMessage.Size = new Size(228, 29);
            titleMessage.TabIndex = 5;
            titleMessage.Text = "Transfer successful";
            // 
            // txtMoney
            // 
            txtMoney.BackColor = Color.Transparent;
            txtMoney.Cursor = Cursors.Hand;
            txtMoney.Font = new Font("Roboto", 18F, FontStyle.Bold);
            txtMoney.ForeColor = Color.Green;
            txtMoney.Location = new Point(116, 181);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(237, 37);
            txtMoney.TabIndex = 5;
            txtMoney.Text = "120000 VND";
            txtMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 257);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 5;
            label1.Text = "Beneficiary name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 330);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 5;
            label2.Text = "Beneficiary account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 402);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 5;
            label3.Text = "Beneficiary bank";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label4.Location = new Point(11, 472);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 5;
            label4.Text = "Transfering code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Roboto", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 540);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 5;
            label5.Text = "Content";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Transparent;
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtName.Location = new Point(257, 257);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.Yes;
            txtName.Size = new Size(182, 25);
            txtName.TabIndex = 5;
            txtName.Text = "TRUONG HUU THO";
            txtName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSTK
            // 
            txtSTK.BackColor = Color.Transparent;
            txtSTK.Cursor = Cursors.Hand;
            txtSTK.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtSTK.Location = new Point(315, 330);
            txtSTK.Name = "txtSTK";
            txtSTK.RightToLeft = RightToLeft.Yes;
            txtSTK.Size = new Size(122, 25);
            txtSTK.TabIndex = 5;
            txtSTK.Text = "1234567890";
            txtSTK.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBank
            // 
            txtBank.BackColor = Color.Transparent;
            txtBank.Cursor = Cursors.Hand;
            txtBank.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtBank.Location = new Point(357, 402);
            txtBank.Name = "txtBank";
            txtBank.RightToLeft = RightToLeft.Yes;
            txtBank.Size = new Size(80, 25);
            txtBank.TabIndex = 5;
            txtBank.Text = "METAN";
            txtBank.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaGD
            // 
            txtMaGD.BackColor = Color.Transparent;
            txtMaGD.Cursor = Cursors.Hand;
            txtMaGD.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtMaGD.Location = new Point(392, 472);
            txtMaGD.Name = "txtMaGD";
            txtMaGD.RightToLeft = RightToLeft.Yes;
            txtMaGD.Size = new Size(45, 25);
            txtMaGD.TabIndex = 5;
            txtMaGD.Text = "123";
            txtMaGD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtContent
            // 
            txtContent.AllowDrop = true;
            txtContent.BackColor = Color.LightBlue;
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtContent.Location = new Point(221, 538);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(216, 118);
            txtContent.TabIndex = 6;
            txtContent.Text = "Thank you so much for everything you have done for me";
            txtContent.TextAlign = HorizontalAlignment.Right;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = Color.Green;
            transferBtn.Cursor = Cursors.Hand;
            transferBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            transferBtn.ForeColor = Color.White;
            transferBtn.Location = new Point(12, 708);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(425, 53);
            transferBtn.TabIndex = 24;
            transferBtn.Text = "Close";
            transferBtn.UseVisualStyleBackColor = false;
            transferBtn.Click += transferBtn_Click;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Transparent;
            txtDate.Cursor = Cursors.Hand;
            txtDate.Font = new Font("Roboto", 8F, FontStyle.Bold);
            txtDate.Location = new Point(144, 220);
            txtDate.Name = "txtDate";
            txtDate.RightToLeft = RightToLeft.Yes;
            txtDate.Size = new Size(169, 18);
            txtDate.TabIndex = 5;
            txtDate.Text = "2023-12-23 22:49:20.000";
            txtDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 795);
            Controls.Add(transferBtn);
            Controls.Add(txtContent);
            Controls.Add(txtMoney);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMaGD);
            Controls.Add(txtBank);
            Controls.Add(txtSTK);
            Controls.Add(txtDate);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(titleMessage);
            Controls.Add(iconImg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)iconImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox iconImg;
        private Label titleMessage;
        private Label txtMoney;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtName;
        private Label txtSTK;
        private Label txtBank;
        private Label txtMaGD;
        private TextBox txtContent;
        private Button transferBtn;
        private Label txtDate;
    }
}