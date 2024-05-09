namespace BTTH03
{
    partial class ScanQR
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
            pbCam = new PictureBox();
            cbCamera = new ComboBox();
            txtCode = new TextBox();
            logoutBtn = new Button();
            startBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCam).BeginInit();
            SuspendLayout();
            // 
            // pbCam
            // 
            pbCam.Location = new Point(35, 25);
            pbCam.Name = "pbCam";
            pbCam.Size = new Size(393, 367);
            pbCam.TabIndex = 0;
            pbCam.TabStop = false;
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(35, 414);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(393, 28);
            cbCamera.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(35, 507);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(393, 27);
            txtCode.TabIndex = 2;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.DarkRed;
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(35, 641);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(393, 53);
            logoutBtn.TabIndex = 25;
            logoutBtn.Text = "Close";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.Highlight;
            startBtn.Cursor = Cursors.Hand;
            startBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(35, 564);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(393, 53);
            startBtn.TabIndex = 25;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // ScanQR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(startBtn);
            Controls.Add(logoutBtn);
            Controls.Add(txtCode);
            Controls.Add(cbCamera);
            Controls.Add(pbCam);
            Name = "ScanQR";
            Size = new Size(457, 795);
            Load += ScanQR_Load;
            ((System.ComponentModel.ISupportInitialize)pbCam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCam;
        private ComboBox cbCamera;
        private TextBox txtCode;
        private Button logoutBtn;
        private Button startBtn;
    }
}
