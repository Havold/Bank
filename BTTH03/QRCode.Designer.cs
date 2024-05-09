namespace BTTH03
{
    partial class QRCode
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
            pbQR = new PictureBox();
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // pbQR
            // 
            pbQR.Location = new Point(15, 19);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(204, 219);
            pbQR.TabIndex = 0;
            pbQR.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.DarkRed;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(15, 253);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(204, 46);
            closeBtn.TabIndex = 26;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            // 
            // QRCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(closeBtn);
            Controls.Add(pbQR);
            Name = "QRCode";
            Size = new Size(236, 314);
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbQR;
        private Button closeBtn;
    }
}
