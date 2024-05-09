namespace BTTH03
{
    partial class Message
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
            sms = new TextBox();
            SuspendLayout();
            // 
            // sms
            // 
            sms.AllowDrop = true;
            sms.BackColor = Color.LightCyan;
            sms.BorderStyle = BorderStyle.None;
            sms.Font = new Font("Roboto", 12F);
            sms.Location = new Point(0, 0);
            sms.Multiline = true;
            sms.Name = "sms";
            sms.ReadOnly = true;
            sms.Size = new Size(406, 118);
            sms.TabIndex = 1;
            sms.Text = "Account 1234567890 in METAN +1390,000VND on 19:00 21/12/2023. account balance: 200,000VND. Message: Thank you";
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(sms);
            Font = new Font("Roboto", 9F);
            Name = "Message";
            Size = new Size(406, 118);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sms;
    }
}
