namespace BTTH03
{
    partial class AccountList
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
            titleMessage = new Label();
            backBtn = new PictureBox();
            paymentBtn = new Button();
            savingBtn = new Button();
            titleTotal = new Label();
            panel2 = new Panel();
            txtTotal = new Label();
            accList = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(titleMessage);
            panel1.Controls.Add(backBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 65);
            panel1.TabIndex = 0;
            // 
            // titleMessage
            // 
            titleMessage.AutoSize = true;
            titleMessage.BackColor = Color.Transparent;
            titleMessage.Cursor = Cursors.Hand;
            titleMessage.Font = new Font("Roboto", 14F, FontStyle.Bold);
            titleMessage.Location = new Point(166, 17);
            titleMessage.Name = "titleMessage";
            titleMessage.Size = new Size(103, 29);
            titleMessage.TabIndex = 5;
            titleMessage.Text = "Account";
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = Properties.Resources.leftArrow;
            backBtn.Location = new Point(20, 15);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(20, 30);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // paymentBtn
            // 
            paymentBtn.BackColor = Color.White;
            paymentBtn.Cursor = Cursors.Hand;
            paymentBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            paymentBtn.ForeColor = Color.DarkTurquoise;
            paymentBtn.Location = new Point(30, 82);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(189, 34);
            paymentBtn.TabIndex = 17;
            paymentBtn.Text = "Payment";
            paymentBtn.UseVisualStyleBackColor = false;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // savingBtn
            // 
            savingBtn.BackColor = Color.Gainsboro;
            savingBtn.Cursor = Cursors.Hand;
            savingBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            savingBtn.ForeColor = Color.Gray;
            savingBtn.Location = new Point(216, 82);
            savingBtn.Name = "savingBtn";
            savingBtn.Size = new Size(215, 34);
            savingBtn.TabIndex = 17;
            savingBtn.Text = "Saving";
            savingBtn.UseVisualStyleBackColor = false;
            savingBtn.Click += savingBtn_Click;
            // 
            // titleTotal
            // 
            titleTotal.AutoSize = true;
            titleTotal.BackColor = Color.Transparent;
            titleTotal.Font = new Font("Roboto", 8F);
            titleTotal.ForeColor = Color.White;
            titleTotal.Location = new Point(10, 8);
            titleTotal.Name = "titleTotal";
            titleTotal.Size = new Size(126, 18);
            titleTotal.TabIndex = 19;
            titleTotal.Text = "Total money (VND)";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(titleTotal);
            panel2.Location = new Point(30, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 69);
            panel2.TabIndex = 20;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Transparent;
            txtTotal.Font = new Font("Roboto", 10F, FontStyle.Bold);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(10, 36);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(70, 22);
            txtTotal.TabIndex = 19;
            txtTotal.Text = "160000";
            txtTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accList
            // 
            accList.AutoScroll = true;
            accList.Location = new Point(30, 200);
            accList.Name = "accList";
            accList.Size = new Size(401, 566);
            accList.TabIndex = 21;
            // 
            // AccountList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 795);
            Controls.Add(accList);
            Controls.Add(panel2);
            Controls.Add(savingBtn);
            Controls.Add(paymentBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountList";
            Text = "AccountList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox backBtn;
        private Label titleMessage;
        private Button paymentBtn;
        private Button savingBtn;
        private Label titleTotal;
        private Panel panel2;
        private Label txtTotal;
        private FlowLayoutPanel accList;
    }
}