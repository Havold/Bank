namespace BTTH03
{
    partial class QRCode_Form
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
            closeBtn = new Button();
            pbQR = new PictureBox();
            txtStk = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.DarkRed;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(12, 378);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(302, 53);
            closeBtn.TabIndex = 28;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // pbQR
            // 
            pbQR.Location = new Point(14, 11);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(300, 300);
            pbQR.TabIndex = 27;
            pbQR.TabStop = false;
            // 
            // txtStk
            // 
            txtStk.BackColor = Color.Transparent;
            txtStk.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtStk.ForeColor = SystemColors.Highlight;
            txtStk.Location = new Point(14, 330);
            txtStk.Name = "txtStk";
            txtStk.Size = new Size(300, 29);
            txtStk.TabIndex = 29;
            txtStk.Text = "1234567890_bank";
            txtStk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QRCode_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 443);
            Controls.Add(txtStk);
            Controls.Add(closeBtn);
            Controls.Add(pbQR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QRCode_Form";
            Text = "QRCode_Form";
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button closeBtn;
        private PictureBox pbQR;
        private Label txtStk;
    }
}