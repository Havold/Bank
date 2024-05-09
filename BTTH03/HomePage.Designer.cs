namespace BTTH03
{
    partial class HomePage
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
            panel1 = new Panel();
            scanIcon = new PictureBox();
            settingIcon = new PictureBox();
            statementIcon = new PictureBox();
            messageIcon = new PictureBox();
            homeIcon = new PictureBox();
            panel4 = new Panel();
            settingFragment = new SettingFragment();
            statementFragment = new StatementFragment();
            messageFragment = new MessageFragment_tmp();
            homeFragment = new homeFragment_tmp();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scanIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statementIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messageIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(scanIcon);
            panel1.Controls.Add(settingIcon);
            panel1.Controls.Add(statementIcon);
            panel1.Controls.Add(messageIcon);
            panel1.Controls.Add(homeIcon);
            panel1.Location = new Point(0, 717);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 82);
            panel1.TabIndex = 0;
            // 
            // scanIcon
            // 
            scanIcon.Cursor = Cursors.Hand;
            scanIcon.Image = Properties.Resources.QRscan;
            scanIcon.Location = new Point(184, -1);
            scanIcon.Name = "scanIcon";
            scanIcon.Size = new Size(80, 80);
            scanIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            scanIcon.TabIndex = 4;
            scanIcon.TabStop = false;
            scanIcon.Click += scanIcon_Click;
            // 
            // settingIcon
            // 
            settingIcon.Cursor = Cursors.Hand;
            settingIcon.Image = Properties.Resources.settingOff1;
            settingIcon.Location = new Point(385, 8);
            settingIcon.Name = "settingIcon";
            settingIcon.Size = new Size(60, 60);
            settingIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            settingIcon.TabIndex = 0;
            settingIcon.TabStop = false;
            settingIcon.Click += settingIcon_Click;
            // 
            // statementIcon
            // 
            statementIcon.Cursor = Cursors.Hand;
            statementIcon.Image = Properties.Resources.graphOff;
            statementIcon.Location = new Point(294, 8);
            statementIcon.Name = "statementIcon";
            statementIcon.Size = new Size(60, 60);
            statementIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            statementIcon.TabIndex = 0;
            statementIcon.TabStop = false;
            statementIcon.Click += statementIcon_Click;
            // 
            // messageIcon
            // 
            messageIcon.Cursor = Cursors.Hand;
            messageIcon.Image = Properties.Resources.messageOff;
            messageIcon.Location = new Point(99, 8);
            messageIcon.Name = "messageIcon";
            messageIcon.Size = new Size(60, 60);
            messageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            messageIcon.TabIndex = 0;
            messageIcon.TabStop = false;
            messageIcon.Click += messageIcon_Click;
            // 
            // homeIcon
            // 
            homeIcon.Cursor = Cursors.Hand;
            homeIcon.Image = Properties.Resources.home_on;
            homeIcon.Location = new Point(13, 8);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(60, 60);
            homeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            homeIcon.TabIndex = 0;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(settingFragment);
            panel4.Controls.Add(statementFragment);
            panel4.Controls.Add(messageFragment);
            panel4.Controls.Add(homeFragment);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 719);
            panel4.TabIndex = 0;
            // 
            // settingFragment
            // 
            settingFragment.BackColor = Color.White;
            settingFragment.Location = new Point(0, 1);
            settingFragment.Name = "settingFragment";
            settingFragment.Size = new Size(460, 994);
            settingFragment.TabIndex = 1;
            settingFragment.Visible = false;
            // 
            // statementFragment
            // 
            statementFragment.BackColor = Color.White;
            statementFragment.Location = new Point(-3, 0);
            statementFragment.Name = "statementFragment";
            statementFragment.Size = new Size(463, 899);
            statementFragment.TabIndex = 5;
            statementFragment.Visible = false;
            // 
            // messageFragment
            // 
            messageFragment.BackColor = Color.White;
            messageFragment.Location = new Point(0, 0);
            messageFragment.Name = "messageFragment";
            messageFragment.Size = new Size(571, 994);
            messageFragment.TabIndex = 1;
            messageFragment.Visible = false;
            // 
            // homeFragment
            // 
            homeFragment.Location = new Point(0, 0);
            homeFragment.Name = "homeFragment";
            homeFragment.Size = new Size(574, 899);
            homeFragment.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(457, 795);
            Controls.Add(panel1);
            Controls.Add(panel4);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Text = "HomePage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scanIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)statementIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)messageIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox homeIcon;
        private Panel panel4;
        private PictureBox scanIcon;
        private PictureBox statementIcon;
        private PictureBox messageIcon;
        private PictureBox settingIcon;
        private homeFragment_tmp homeFragment;
        private MessageFragment_tmp messageFragment;
        private StatementFragment statementFragment;
        private SettingFragment settingFragment;
    }
}