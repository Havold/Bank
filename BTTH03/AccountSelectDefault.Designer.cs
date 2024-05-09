namespace BTTH03
{
    partial class AccountSelectDefault
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
            txtAccount = new RadioButton();
            label1 = new Label();
            txtMoney = new Label();
            defaultPanel = new Panel();
            txtDefault = new Label();
            defaultPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.AutoSize = true;
            txtAccount.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtAccount.Location = new Point(22, 17);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(143, 29);
            txtAccount.TabIndex = 3;
            txtAccount.TabStop = true;
            txtAccount.Text = "1234567890";
            txtAccount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(46, 51);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 4;
            label1.Text = "Available money:";
            // 
            // txtMoney
            // 
            txtMoney.AutoSize = true;
            txtMoney.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtMoney.ForeColor = Color.Black;
            txtMoney.Location = new Point(174, 50);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(60, 22);
            txtMoney.TabIndex = 4;
            txtMoney.Text = "70000";
            // 
            // defaultPanel
            // 
            defaultPanel.BackColor = SystemColors.Highlight;
            defaultPanel.Controls.Add(txtDefault);
            defaultPanel.Location = new Point(178, 12);
            defaultPanel.Name = "defaultPanel";
            defaultPanel.Size = new Size(84, 34);
            defaultPanel.TabIndex = 5;
            defaultPanel.Visible = false;
            // 
            // txtDefault
            // 
            txtDefault.AutoSize = true;
            txtDefault.Font = new Font("Roboto", 9F, FontStyle.Bold);
            txtDefault.ForeColor = Color.White;
            txtDefault.Location = new Point(15, 7);
            txtDefault.Name = "txtDefault";
            txtDefault.Size = new Size(57, 19);
            txtDefault.TabIndex = 0;
            txtDefault.Text = "Default";
            txtDefault.Visible = false;
            // 
            // AccountSelectDefault
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(defaultPanel);
            Controls.Add(txtMoney);
            Controls.Add(label1);
            Controls.Add(txtAccount);
            Name = "AccountSelectDefault";
            Size = new Size(381, 87);
            defaultPanel.ResumeLayout(false);
            defaultPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton txtAccount;
        private Label label1;
        private Label txtMoney;
        private Panel defaultPanel;
        private Label txtDefault;
    }
}
