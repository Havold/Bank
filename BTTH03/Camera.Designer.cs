namespace BTTH03
{
    partial class Camera
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
            startBtn = new Button();
            logoutBtn = new Button();
            txtCode = new TextBox();
            cbCamera = new ComboBox();
            pbCam = new PictureBox();
            transferBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCam).BeginInit();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.BackColor = SystemColors.Highlight;
            startBtn.Cursor = Cursors.Hand;
            startBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            startBtn.ForeColor = Color.White;
            startBtn.Location = new Point(32, 629);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(393, 53);
            startBtn.TabIndex = 29;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.DarkRed;
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(32, 706);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(393, 53);
            logoutBtn.TabIndex = 30;
            logoutBtn.Text = "Close";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += Close_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(32, 504);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(393, 27);
            txtCode.TabIndex = 28;
            // 
            // cbCamera
            // 
            cbCamera.FormattingEnabled = true;
            cbCamera.Location = new Point(32, 452);
            cbCamera.Name = "cbCamera";
            cbCamera.Size = new Size(393, 28);
            cbCamera.TabIndex = 27;
            // 
            // pbCam
            // 
            pbCam.BorderStyle = BorderStyle.Fixed3D;
            pbCam.Location = new Point(32, 63);
            pbCam.Name = "pbCam";
            pbCam.Size = new Size(393, 367);
            pbCam.TabIndex = 26;
            pbCam.TabStop = false;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = Color.Green;
            transferBtn.Cursor = Cursors.Hand;
            transferBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            transferBtn.ForeColor = Color.White;
            transferBtn.Location = new Point(32, 553);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(393, 53);
            transferBtn.TabIndex = 29;
            transferBtn.Text = "Transfer money";
            transferBtn.UseVisualStyleBackColor = false;
            transferBtn.Visible = false;
            transferBtn.Click += transferBtn_Click;
            // 
            // Camera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 795);
            Controls.Add(transferBtn);
            Controls.Add(startBtn);
            Controls.Add(logoutBtn);
            Controls.Add(txtCode);
            Controls.Add(cbCamera);
            Controls.Add(pbCam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Camera";
            Text = "Camera";
            Load += Camera_Load;
            ((System.ComponentModel.ISupportInitialize)pbCam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Button logoutBtn;
        private TextBox txtCode;
        private ComboBox cbCamera;
        private PictureBox pbCam;
        private Button transferBtn;
    }
}