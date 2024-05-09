namespace BTTH03
{
    partial class statementItem
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
            txtDate = new Label();
            txtMoney = new Label();
            txtContent = new TextBox();
            SuspendLayout();
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Roboto", 10F);
            txtDate.ForeColor = Color.Gray;
            txtDate.Location = new Point(11, 0);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(104, 22);
            txtDate.TabIndex = 0;
            txtDate.Text = "01/12/2023";
            txtDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMoney
            // 
            txtMoney.Anchor = AnchorStyles.Right;
            txtMoney.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtMoney.ForeColor = Color.DarkRed;
            txtMoney.Location = new Point(267, 42);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(112, 25);
            txtMoney.TabIndex = 0;
            txtMoney.Text = "+3.546.000";
            txtMoney.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtContent
            // 
            txtContent.AllowDrop = true;
            txtContent.BackColor = Color.White;
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Roboto", 10F);
            txtContent.Location = new Point(11, 40);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(230, 41);
            txtContent.TabIndex = 1;
            txtContent.Text = "Thưởng chuyên cần";
            // 
            // statementItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtContent);
            Controls.Add(txtMoney);
            Controls.Add(txtDate);
            Name = "statementItem";
            Size = new Size(382, 90);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtDate;
        private Label txtMoney;
        private TextBox txtContent;
    }
}
