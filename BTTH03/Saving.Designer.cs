namespace BTTH03
{
    partial class Saving
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
            titleMessage = new Label();
            backBtn = new PictureBox();
            depositSelect = new ComboBox();
            sourceSelect = new ComboBox();
            txtMoney = new TextBox();
            label9 = new Label();
            txtMoneyAvai = new Label();
            txtAvailable = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            intersetSelect = new ComboBox();
            completedBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // titleMessage
            // 
            titleMessage.AutoSize = true;
            titleMessage.BackColor = Color.Transparent;
            titleMessage.Cursor = Cursors.Hand;
            titleMessage.Font = new Font("Roboto", 14F, FontStyle.Bold);
            titleMessage.Location = new Point(156, 18);
            titleMessage.Name = "titleMessage";
            titleMessage.Size = new Size(158, 29);
            titleMessage.TabIndex = 7;
            titleMessage.Text = "Open savings";
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.leftArrow;
            backBtn.Location = new Point(25, 15);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(20, 30);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 6;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // depositSelect
            // 
            depositSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            depositSelect.Font = new Font("Roboto", 9F);
            depositSelect.FormattingEnabled = true;
            depositSelect.Location = new Point(180, 188);
            depositSelect.Name = "depositSelect";
            depositSelect.Size = new Size(248, 27);
            depositSelect.TabIndex = 14;
            // 
            // sourceSelect
            // 
            sourceSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            sourceSelect.Font = new Font("Roboto", 9F);
            sourceSelect.FormattingEnabled = true;
            sourceSelect.Location = new Point(180, 102);
            sourceSelect.Name = "sourceSelect";
            sourceSelect.Size = new Size(248, 27);
            sourceSelect.TabIndex = 15;
            sourceSelect.SelectedIndexChanged += selectSource_SelectedIndexChanged;
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(180, 241);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(248, 27);
            txtMoney.TabIndex = 16;
            txtMoney.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(35, 246);
            label9.Name = "label9";
            label9.Size = new Size(137, 18);
            label9.TabIndex = 9;
            label9.Text = "Transaction amount";
            // 
            // txtMoneyAvai
            // 
            txtMoneyAvai.AutoSize = true;
            txtMoneyAvai.BackColor = Color.Transparent;
            txtMoneyAvai.Cursor = Cursors.Hand;
            txtMoneyAvai.Font = new Font("Roboto", 8F);
            txtMoneyAvai.ForeColor = Color.Gray;
            txtMoneyAvai.Location = new Point(319, 143);
            txtMoneyAvai.Name = "txtMoneyAvai";
            txtMoneyAvai.Size = new Size(109, 18);
            txtMoneyAvai.TabIndex = 10;
            txtMoneyAvai.Text = "15,000,000 VND";
            txtMoneyAvai.TextAlign = ContentAlignment.MiddleRight;
            txtMoneyAvai.Visible = false;
            // 
            // txtAvailable
            // 
            txtAvailable.AutoSize = true;
            txtAvailable.BackColor = Color.Transparent;
            txtAvailable.Cursor = Cursors.Hand;
            txtAvailable.Font = new Font("Roboto", 8F);
            txtAvailable.ForeColor = Color.Gray;
            txtAvailable.Location = new Point(180, 143);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(123, 18);
            txtAvailable.TabIndex = 11;
            txtAvailable.Text = "Available balances";
            txtAvailable.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(36, 194);
            label6.Name = "label6";
            label6.Size = new Size(90, 18);
            label6.TabIndex = 12;
            label6.Text = "Deposit term";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(36, 107);
            label3.Name = "label3";
            label3.Size = new Size(107, 18);
            label3.TabIndex = 13;
            label3.Text = "Source account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Roboto", 8F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(36, 301);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 12;
            label1.Text = "Interest payment";
            // 
            // intersetSelect
            // 
            intersetSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            intersetSelect.Font = new Font("Roboto", 9F);
            intersetSelect.FormattingEnabled = true;
            intersetSelect.Location = new Point(180, 295);
            intersetSelect.Name = "intersetSelect";
            intersetSelect.Size = new Size(248, 27);
            intersetSelect.TabIndex = 14;
            // 
            // completedBtn
            // 
            completedBtn.BackColor = Color.SeaGreen;
            completedBtn.Cursor = Cursors.Hand;
            completedBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            completedBtn.ForeColor = Color.White;
            completedBtn.Location = new Point(36, 372);
            completedBtn.Name = "completedBtn";
            completedBtn.Size = new Size(392, 72);
            completedBtn.TabIndex = 17;
            completedBtn.Text = "Completed";
            completedBtn.UseVisualStyleBackColor = false;
            completedBtn.Click += completedBtn_Click;
            // 
            // Saving
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 795);
            Controls.Add(completedBtn);
            Controls.Add(intersetSelect);
            Controls.Add(depositSelect);
            Controls.Add(sourceSelect);
            Controls.Add(txtMoney);
            Controls.Add(label9);
            Controls.Add(txtMoneyAvai);
            Controls.Add(label1);
            Controls.Add(txtAvailable);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(titleMessage);
            Controls.Add(backBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Saving";
            Text = "Saving";
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleMessage;
        private PictureBox backBtn;
        private ComboBox depositSelect;
        private ComboBox sourceSelect;
        private TextBox txtMoney;
        private Label label9;
        private Label txtMoneyAvai;
        private Label txtAvailable;
        private Label label6;
        private Label label3;
        private Label label1;
        private ComboBox intersetSelect;
        private Button completedBtn;
    }
}