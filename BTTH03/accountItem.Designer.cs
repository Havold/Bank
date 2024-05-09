namespace BTTH03
{
    partial class accountItem
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
            txtAccount = new Label();
            txtMoney = new Label();
            label3 = new Label();
            QRicon = new PictureBox();
            txtDate = new Label();
            rateTitle = new Label();
            txtRate = new Label();
            interestTitle = new Label();
            txtInterestMoney = new Label();
            ((System.ComponentModel.ISupportInitialize)QRicon).BeginInit();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.BackColor = Color.Transparent;
            txtAccount.Font = new Font("Roboto", 14F, FontStyle.Bold);
            txtAccount.ForeColor = Color.Black;
            txtAccount.Location = new Point(8, 18);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(153, 29);
            txtAccount.TabIndex = 20;
            txtAccount.Text = "1234567890";
            txtAccount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMoney
            // 
            txtMoney.BackColor = Color.Transparent;
            txtMoney.Font = new Font("Roboto", 14F, FontStyle.Bold);
            txtMoney.ForeColor = SystemColors.Highlight;
            txtMoney.Location = new Point(7, 129);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(152, 29);
            txtMoney.TabIndex = 20;
            txtMoney.Text = "160000 VND";
            txtMoney.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(8, 98);
            label3.Name = "label3";
            label3.Size = new Size(139, 22);
            label3.TabIndex = 20;
            label3.Text = "Available money";
            // 
            // QRicon
            // 
            QRicon.Cursor = Cursors.Hand;
            QRicon.Image = Properties.Resources.QR_icon;
            QRicon.Location = new Point(325, 11);
            QRicon.Name = "QRicon";
            QRicon.Size = new Size(50, 50);
            QRicon.SizeMode = PictureBoxSizeMode.StretchImage;
            QRicon.TabIndex = 21;
            QRicon.TabStop = false;
            QRicon.Click += QRicon_Click;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Transparent;
            txtDate.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtDate.ForeColor = Color.Gray;
            txtDate.Location = new Point(273, 136);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(102, 22);
            txtDate.TabIndex = 20;
            txtDate.Text = "21/12/2023";
            txtDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rateTitle
            // 
            rateTitle.AutoSize = true;
            rateTitle.BackColor = Color.Transparent;
            rateTitle.Font = new Font("Roboto", 10F, FontStyle.Bold);
            rateTitle.ForeColor = Color.Gray;
            rateTitle.Location = new Point(276, 114);
            rateTitle.Name = "rateTitle";
            rateTitle.Size = new Size(50, 22);
            rateTitle.TabIndex = 20;
            rateTitle.Text = "Rate:";
            rateTitle.Visible = false;
            // 
            // txtRate
            // 
            txtRate.BackColor = Color.Transparent;
            txtRate.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtRate.ForeColor = Color.Green;
            txtRate.Location = new Point(329, 114);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(45, 22);
            txtRate.TabIndex = 20;
            txtRate.Text = "0.32";
            txtRate.TextAlign = ContentAlignment.MiddleRight;
            txtRate.Visible = false;
            // 
            // interestTitle
            // 
            interestTitle.AutoSize = true;
            interestTitle.BackColor = Color.Transparent;
            interestTitle.Font = new Font("Roboto", 10F, FontStyle.Bold);
            interestTitle.ForeColor = Color.Gray;
            interestTitle.Location = new Point(7, 66);
            interestTitle.Name = "interestTitle";
            interestTitle.Size = new Size(132, 22);
            interestTitle.TabIndex = 20;
            interestTitle.Text = "Interest money:";
            interestTitle.Visible = false;
            // 
            // txtInterestMoney
            // 
            txtInterestMoney.BackColor = Color.Transparent;
            txtInterestMoney.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtInterestMoney.ForeColor = Color.Green;
            txtInterestMoney.Location = new Point(140, 68);
            txtInterestMoney.Name = "txtInterestMoney";
            txtInterestMoney.Size = new Size(88, 22);
            txtInterestMoney.TabIndex = 20;
            txtInterestMoney.Text = "1000 VND";
            txtInterestMoney.TextAlign = ContentAlignment.MiddleLeft;
            txtInterestMoney.Visible = false;
            // 
            // accountItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(QRicon);
            Controls.Add(txtDate);
            Controls.Add(txtRate);
            Controls.Add(rateTitle);
            Controls.Add(interestTitle);
            Controls.Add(label3);
            Controls.Add(txtInterestMoney);
            Controls.Add(txtMoney);
            Controls.Add(txtAccount);
            Name = "accountItem";
            Size = new Size(390, 168);
            ((System.ComponentModel.ISupportInitialize)QRicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtAccount;
        private Label txtMoney;
        private Label label3;
        private PictureBox QRicon;
        private Label txtDate;
        private Label rateTitle;
        private Label txtRate;
        private Label interestTitle;
        private Label txtInterestMoney;
    }
}
