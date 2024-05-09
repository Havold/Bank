namespace BTTH03
{
    partial class ChangeDefault
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
            label1 = new Label();
            accList = new FlowLayoutPanel();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(281, 24);
            label1.TabIndex = 1;
            label1.Text = "Select default payment account";
            // 
            // accList
            // 
            accList.AllowDrop = true;
            accList.AutoScroll = true;
            accList.Location = new Point(20, 54);
            accList.Name = "accList";
            accList.Size = new Size(386, 142);
            accList.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = SystemColors.Highlight;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(20, 208);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(386, 53);
            closeBtn.TabIndex = 24;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // ChangeDefault
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(closeBtn);
            Controls.Add(accList);
            Controls.Add(label1);
            Name = "ChangeDefault";
            Size = new Size(425, 270);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel accList;
        private Button closeBtn;
    }
}
