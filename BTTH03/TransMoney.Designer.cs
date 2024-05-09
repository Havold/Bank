namespace BTTH03
{
    partial class TransMoney
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
            titleMessage = new Label();
            label1 = new Label();
            internalPanel = new Panel();
            externalPanel = new Panel();
            External = new Label();
            label3 = new Label();
            txtAvailable = new Label();
            txtMoneyAvai = new Label();
            label6 = new Label();
            receiveNum = new Label();
            txtReceiveNum = new TextBox();
            receiveName = new Label();
            label9 = new Label();
            txtMoney = new TextBox();
            label10 = new Label();
            txtContent = new TextBox();
            completedBtn = new Button();
            checkBtn = new Button();
            sourceSelect = new ComboBox();
            bankSelect = new ComboBox();
            label2 = new Label();
            QRicon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            internalPanel.SuspendLayout();
            externalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QRicon).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.leftArrow;
            backBtn.Location = new Point(34, 20);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(20, 30);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // titleMessage
            // 
            titleMessage.AutoSize = true;
            titleMessage.BackColor = Color.Transparent;
            titleMessage.Cursor = Cursors.Hand;
            titleMessage.Font = new Font("Roboto", 14F, FontStyle.Bold);
            titleMessage.Location = new Point(124, 20);
            titleMessage.Name = "titleMessage";
            titleMessage.Size = new Size(241, 29);
            titleMessage.TabIndex = 4;
            titleMessage.Text = "Choose a beneficiary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Roboto", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 4;
            label1.Text = "Internal";
            label1.Click += internalPanel_Click;
            // 
            // internalPanel
            // 
            internalPanel.BackColor = Color.SeaGreen;
            internalPanel.Controls.Add(label1);
            internalPanel.Cursor = Cursors.Hand;
            internalPanel.Location = new Point(41, 74);
            internalPanel.Name = "internalPanel";
            internalPanel.Size = new Size(182, 61);
            internalPanel.TabIndex = 6;
            internalPanel.Click += internalPanel_Click;
            // 
            // externalPanel
            // 
            externalPanel.BackColor = Color.LightSeaGreen;
            externalPanel.Controls.Add(External);
            externalPanel.Cursor = Cursors.Hand;
            externalPanel.Location = new Point(229, 74);
            externalPanel.Name = "externalPanel";
            externalPanel.Size = new Size(194, 61);
            externalPanel.TabIndex = 6;
            externalPanel.Click += externalPanel_Click;
            // 
            // External
            // 
            External.AutoSize = true;
            External.BackColor = Color.Transparent;
            External.Cursor = Cursors.Hand;
            External.Font = new Font("Roboto", 10F, FontStyle.Bold);
            External.ForeColor = Color.White;
            External.Location = new Point(62, 19);
            External.Name = "External";
            External.Size = new Size(74, 22);
            External.TabIndex = 4;
            External.Text = "External";
            External.Click += externalPanel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(35, 171);
            label3.Name = "label3";
            label3.Size = new Size(107, 18);
            label3.TabIndex = 4;
            label3.Text = "Source account";
            // 
            // txtAvailable
            // 
            txtAvailable.AutoSize = true;
            txtAvailable.BackColor = Color.Transparent;
            txtAvailable.Cursor = Cursors.Hand;
            txtAvailable.Font = new Font("Roboto", 8F);
            txtAvailable.ForeColor = Color.Gray;
            txtAvailable.Location = new Point(179, 206);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(123, 18);
            txtAvailable.TabIndex = 4;
            txtAvailable.Text = "Available balances";
            txtAvailable.Visible = false;
            // 
            // txtMoneyAvai
            // 
            txtMoneyAvai.BackColor = Color.Transparent;
            txtMoneyAvai.Cursor = Cursors.Hand;
            txtMoneyAvai.Font = new Font("Roboto", 8F);
            txtMoneyAvai.ForeColor = Color.Gray;
            txtMoneyAvai.Location = new Point(318, 206);
            txtMoneyAvai.Name = "txtMoneyAvai";
            txtMoneyAvai.Size = new Size(109, 18);
            txtMoneyAvai.TabIndex = 4;
            txtMoneyAvai.Text = "15,000,000 VND";
            txtMoneyAvai.TextAlign = ContentAlignment.MiddleRight;
            txtMoneyAvai.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(31, 322);
            label6.Name = "label6";
            label6.Size = new Size(115, 18);
            label6.TabIndex = 4;
            label6.Text = "Beneficiary bank";
            // 
            // receiveNum
            // 
            receiveNum.AutoSize = true;
            receiveNum.BackColor = Color.Transparent;
            receiveNum.Cursor = Cursors.Hand;
            receiveNum.Font = new Font("Roboto", 8F, FontStyle.Bold);
            receiveNum.ForeColor = Color.Gray;
            receiveNum.Location = new Point(30, 367);
            receiveNum.Name = "receiveNum";
            receiveNum.Size = new Size(126, 18);
            receiveNum.TabIndex = 4;
            receiveNum.Text = "Received Acc Num";
            // 
            // txtReceiveNum
            // 
            txtReceiveNum.Font = new Font("Roboto", 9F);
            txtReceiveNum.Location = new Point(175, 362);
            txtReceiveNum.Name = "txtReceiveNum";
            txtReceiveNum.Size = new Size(248, 26);
            txtReceiveNum.TabIndex = 8;
            // 
            // receiveName
            // 
            receiveName.Font = new Font("Roboto", 10F, FontStyle.Bold);
            receiveName.ForeColor = Color.SeaGreen;
            receiveName.Location = new Point(267, 408);
            receiveName.Name = "receiveName";
            receiveName.Size = new Size(156, 22);
            receiveName.TabIndex = 9;
            receiveName.Text = "TRUONG HUU THO";
            receiveName.TextAlign = ContentAlignment.MiddleCenter;
            receiveName.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(30, 454);
            label9.Name = "label9";
            label9.Size = new Size(137, 18);
            label9.TabIndex = 4;
            label9.Text = "Transaction amount";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(175, 449);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(248, 27);
            txtMoney.TabIndex = 8;
            txtMoney.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(30, 499);
            label10.Name = "label10";
            label10.Size = new Size(137, 18);
            label10.TabIndex = 4;
            label10.Text = "Transaction content";
            // 
            // txtContent
            // 
            txtContent.AllowDrop = true;
            txtContent.Location = new Point(175, 494);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(248, 142);
            txtContent.TabIndex = 8;
            // 
            // completedBtn
            // 
            completedBtn.BackColor = Color.SeaGreen;
            completedBtn.Cursor = Cursors.Hand;
            completedBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            completedBtn.ForeColor = Color.White;
            completedBtn.Location = new Point(35, 680);
            completedBtn.Name = "completedBtn";
            completedBtn.Size = new Size(392, 72);
            completedBtn.TabIndex = 10;
            completedBtn.Text = "Completed";
            completedBtn.UseVisualStyleBackColor = false;
            completedBtn.Click += completedBtn_Click;
            // 
            // checkBtn
            // 
            checkBtn.BackColor = Color.SeaGreen;
            checkBtn.Cursor = Cursors.Hand;
            checkBtn.Font = new Font("Roboto", 8F, FontStyle.Bold);
            checkBtn.ForeColor = Color.White;
            checkBtn.Location = new Point(175, 399);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(75, 40);
            checkBtn.TabIndex = 10;
            checkBtn.Text = "Check";
            checkBtn.UseVisualStyleBackColor = false;
            checkBtn.Click += checkBtn_Click;
            // 
            // sourceSelect
            // 
            sourceSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            sourceSelect.Font = new Font("Roboto", 9F);
            sourceSelect.FormattingEnabled = true;
            sourceSelect.Location = new Point(179, 165);
            sourceSelect.Name = "sourceSelect";
            sourceSelect.Size = new Size(248, 27);
            sourceSelect.TabIndex = 8;
            sourceSelect.SelectedIndexChanged += selectSource_SelectedIndexChanged;
            // 
            // bankSelect
            // 
            bankSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            bankSelect.Enabled = false;
            bankSelect.Font = new Font("Roboto", 9F);
            bankSelect.FormattingEnabled = true;
            bankSelect.Location = new Point(175, 316);
            bankSelect.Name = "bankSelect";
            bankSelect.Size = new Size(248, 27);
            bankSelect.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(35, 254);
            label2.Name = "label2";
            label2.Size = new Size(62, 18);
            label2.TabIndex = 4;
            label2.Text = "Scan QR";
            // 
            // QRicon
            // 
            QRicon.Cursor = Cursors.Hand;
            QRicon.Image = Properties.Resources.QR_icon;
            QRicon.Location = new Point(179, 240);
            QRicon.Name = "QRicon";
            QRicon.Size = new Size(50, 50);
            QRicon.SizeMode = PictureBoxSizeMode.StretchImage;
            QRicon.TabIndex = 22;
            QRicon.TabStop = false;
            QRicon.Click += QRicon_Click;
            // 
            // TransMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 795);
            Controls.Add(QRicon);
            Controls.Add(bankSelect);
            Controls.Add(sourceSelect);
            Controls.Add(checkBtn);
            Controls.Add(completedBtn);
            Controls.Add(receiveName);
            Controls.Add(txtContent);
            Controls.Add(txtMoney);
            Controls.Add(txtReceiveNum);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMoneyAvai);
            Controls.Add(receiveNum);
            Controls.Add(txtAvailable);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(externalPanel);
            Controls.Add(internalPanel);
            Controls.Add(titleMessage);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransMoney";
            Text = "TransMoney";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            internalPanel.ResumeLayout(false);
            internalPanel.PerformLayout();
            externalPanel.ResumeLayout(false);
            externalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QRicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backBtn;
        private Label titleMessage;
        private Label label1;
        private Panel internalPanel;
        private Panel externalPanel;
        private Label External;
        private Label label3;
        private Label txtAvailable;
        private Label txtMoneyAvai;
        private Label label6;
        private Label receiveNum;
        private TextBox txtReceiveNum;
        private Label receiveName;
        private Label label9;
        private TextBox txtMoney;
        private Label label10;
        private TextBox txtContent;
        private Button completedBtn;
        private Button checkBtn;
        private ComboBox sourceSelect;
        private ComboBox bankSelect;
        private Label label2;
        private PictureBox QRicon;
    }
}