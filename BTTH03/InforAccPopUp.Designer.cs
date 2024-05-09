namespace BTTH03
{
    partial class InforAccPopUp
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
            label1 = new Label();
            closeBtn = new Label();
            label3 = new Label();
            txtAcc = new Label();
            label5 = new Label();
            txtMoney = new Label();
            QRicon = new PictureBox();
            changeBtn = new Button();
            transferBtn = new Button();
            changeDefault = new ChangeDefault();
            ((System.ComponentModel.ISupportInitialize)QRicon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 0;
            label1.Text = "Account information";
            // 
            // closeBtn
            // 
            closeBtn.AutoSize = true;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            closeBtn.ForeColor = SystemColors.Highlight;
            closeBtn.Location = new Point(355, 10);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(54, 22);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Close";
            closeBtn.Click += closeBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(13, 61);
            label3.Name = "label3";
            label3.Size = new Size(147, 19);
            label3.TabIndex = 0;
            label3.Text = "Account information";
            // 
            // txtAcc
            // 
            txtAcc.AutoSize = true;
            txtAcc.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtAcc.ForeColor = Color.Black;
            txtAcc.Location = new Point(10, 85);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(122, 25);
            txtAcc.TabIndex = 0;
            txtAcc.Text = "1234567890";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(13, 129);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 0;
            label5.Text = "Available money";
            // 
            // txtMoney
            // 
            txtMoney.AutoSize = true;
            txtMoney.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtMoney.ForeColor = SystemColors.Highlight;
            txtMoney.Location = new Point(13, 155);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(123, 25);
            txtMoney.TabIndex = 0;
            txtMoney.Text = "100000 VND";
            // 
            // QRicon
            // 
            QRicon.Cursor = Cursors.Hand;
            QRicon.Image = Properties.Resources.QR_icon;
            QRicon.Location = new Point(355, 60);
            QRicon.Name = "QRicon";
            QRicon.Size = new Size(50, 50);
            QRicon.SizeMode = PictureBoxSizeMode.StretchImage;
            QRicon.TabIndex = 22;
            QRicon.TabStop = false;
            QRicon.Click += QRicon_Click;
            // 
            // changeBtn
            // 
            changeBtn.BackColor = Color.LightCyan;
            changeBtn.Cursor = Cursors.Hand;
            changeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            changeBtn.ForeColor = SystemColors.Highlight;
            changeBtn.Location = new Point(13, 199);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(200, 53);
            changeBtn.TabIndex = 23;
            changeBtn.Text = "Change default account";
            changeBtn.UseVisualStyleBackColor = false;
            changeBtn.Click += changeBtn_Click;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = SystemColors.Highlight;
            transferBtn.Cursor = Cursors.Hand;
            transferBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            transferBtn.ForeColor = Color.White;
            transferBtn.Location = new Point(225, 199);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(184, 53);
            transferBtn.TabIndex = 23;
            transferBtn.Text = "Transfer money";
            transferBtn.UseVisualStyleBackColor = false;
            transferBtn.Click += transferBtn_Click;
            // 
            // changeDefault
            // 
            changeDefault.Location = new Point(-1, 0);
            changeDefault.Name = "changeDefault";
            changeDefault.Size = new Size(426, 271);
            changeDefault.TabIndex = 0;
            changeDefault.Visible = false;
            // 
            // InforAccPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(changeDefault);
            Controls.Add(transferBtn);
            Controls.Add(changeBtn);
            Controls.Add(QRicon);
            Controls.Add(closeBtn);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtMoney);
            Controls.Add(txtAcc);
            Controls.Add(label1);
            Name = "InforAccPopUp";
            Size = new Size(425, 270);
            ((System.ComponentModel.ISupportInitialize)QRicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label closeBtn;
        private Label label3;
        private Label txtAcc;
        private Label label5;
        private Label txtMoney;
        private PictureBox QRicon;
        private Button changeBtn;
        private Button transferBtn;
        private ChangeDefault changeDefault;
    }
}
