namespace BTTH03
{
    partial class MessageFragment_tmp
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
            titleMessage = new Label();
            txtAll = new Label();
            txtNotseen = new Label();
            txtSeen = new Label();
            messageList = new FlowLayoutPanel();
            notseenPanel = new Panel();
            seenPanel = new Panel();
            allPanel = new Panel();
            notseenPanel.SuspendLayout();
            seenPanel.SuspendLayout();
            allPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleMessage
            // 
            titleMessage.AutoSize = true;
            titleMessage.BackColor = Color.Transparent;
            titleMessage.Cursor = Cursors.Hand;
            titleMessage.Font = new Font("Roboto", 16F, FontStyle.Bold);
            titleMessage.Location = new Point(170, 16);
            titleMessage.Name = "titleMessage";
            titleMessage.Size = new Size(126, 33);
            titleMessage.TabIndex = 6;
            titleMessage.Text = "Message";
            // 
            // txtAll
            // 
            txtAll.AutoSize = true;
            txtAll.BackColor = Color.Transparent;
            txtAll.Cursor = Cursors.Hand;
            txtAll.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtAll.ForeColor = Color.White;
            txtAll.Location = new Point(28, 10);
            txtAll.Name = "txtAll";
            txtAll.Size = new Size(31, 22);
            txtAll.TabIndex = 3;
            txtAll.Text = "All";
            txtAll.Click += allPanel_Click;
            // 
            // txtNotseen
            // 
            txtNotseen.AutoSize = true;
            txtNotseen.BackColor = Color.Transparent;
            txtNotseen.Cursor = Cursors.Hand;
            txtNotseen.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtNotseen.ForeColor = Color.Gray;
            txtNotseen.Location = new Point(14, 9);
            txtNotseen.Name = "txtNotseen";
            txtNotseen.Size = new Size(79, 22);
            txtNotseen.TabIndex = 3;
            txtNotseen.Text = "Not seen";
            txtNotseen.Click += notseenPanel_Click;
            // 
            // txtSeen
            // 
            txtSeen.AutoSize = true;
            txtSeen.BackColor = Color.Transparent;
            txtSeen.Cursor = Cursors.Hand;
            txtSeen.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtSeen.ForeColor = Color.Gray;
            txtSeen.Location = new Point(22, 10);
            txtSeen.Name = "txtSeen";
            txtSeen.Size = new Size(48, 22);
            txtSeen.TabIndex = 3;
            txtSeen.Text = "Seen";
            txtSeen.Click += seenPanel_Click;
            // 
            // messageList
            // 
            messageList.AllowDrop = true;
            messageList.AutoScroll = true;
            messageList.Location = new Point(22, 130);
            messageList.Name = "messageList";
            messageList.Size = new Size(417, 588);
            messageList.TabIndex = 10;
            // 
            // notseenPanel
            // 
            notseenPanel.BackColor = Color.Gainsboro;
            notseenPanel.Controls.Add(txtNotseen);
            notseenPanel.Location = new Point(179, 66);
            notseenPanel.Name = "notseenPanel";
            notseenPanel.Size = new Size(105, 41);
            notseenPanel.TabIndex = 7;
            notseenPanel.Click += notseenPanel_Click;
            // 
            // seenPanel
            // 
            seenPanel.BackColor = Color.FromArgb(224, 224, 224);
            seenPanel.Controls.Add(txtSeen);
            seenPanel.Location = new Point(284, 66);
            seenPanel.Name = "seenPanel";
            seenPanel.Size = new Size(89, 41);
            seenPanel.TabIndex = 8;
            seenPanel.Click += seenPanel_Click;
            // 
            // allPanel
            // 
            allPanel.BackColor = Color.SeaGreen;
            allPanel.Controls.Add(txtAll);
            allPanel.Location = new Point(91, 66);
            allPanel.Name = "allPanel";
            allPanel.Size = new Size(89, 41);
            allPanel.TabIndex = 9;
            allPanel.Click += allPanel_Click;
            // 
            // MessageFragment_tmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(titleMessage);
            Controls.Add(messageList);
            Controls.Add(notseenPanel);
            Controls.Add(seenPanel);
            Controls.Add(allPanel);
            Name = "MessageFragment_tmp";
            Size = new Size(457, 795);
            notseenPanel.ResumeLayout(false);
            notseenPanel.PerformLayout();
            seenPanel.ResumeLayout(false);
            seenPanel.PerformLayout();
            allPanel.ResumeLayout(false);
            allPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleMessage;
        private Label txtAll;
        private Label txtNotseen;
        private Label txtSeen;
        private FlowLayoutPanel messageList;
        private Panel notseenPanel;
        private Panel seenPanel;
        private Panel allPanel;
    }
}
