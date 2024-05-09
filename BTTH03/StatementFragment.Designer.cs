namespace BTTH03
{
    partial class StatementFragment
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
            titleStatement = new Label();
            txtStart = new DateTimePicker();
            txtEnd = new DateTimePicker();
            completedBtn = new Button();
            allBtn = new Button();
            incomeBtn = new Button();
            outcomeBtn = new Button();
            statementList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // titleStatement
            // 
            titleStatement.AutoSize = true;
            titleStatement.BackColor = Color.Transparent;
            titleStatement.Cursor = Cursors.Hand;
            titleStatement.Font = new Font("Roboto", 14F, FontStyle.Bold);
            titleStatement.Location = new Point(135, 31);
            titleStatement.Name = "titleStatement";
            titleStatement.Size = new Size(206, 29);
            titleStatement.TabIndex = 5;
            titleStatement.Text = "History statement";
            // 
            // txtStart
            // 
            txtStart.AccessibleRole = AccessibleRole.None;
            txtStart.CalendarTitleBackColor = SystemColors.ControlText;
            txtStart.CalendarTitleForeColor = SystemColors.GrayText;
            txtStart.Font = new Font("Roboto", 12F);
            txtStart.Format = DateTimePickerFormat.Short;
            txtStart.Location = new Point(27, 87);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(186, 32);
            txtStart.TabIndex = 15;
            // 
            // txtEnd
            // 
            txtEnd.AccessibleRole = AccessibleRole.None;
            txtEnd.CalendarTitleBackColor = SystemColors.ControlText;
            txtEnd.CalendarTitleForeColor = SystemColors.GrayText;
            txtEnd.Font = new Font("Roboto", 12F);
            txtEnd.Format = DateTimePickerFormat.Short;
            txtEnd.Location = new Point(257, 87);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(186, 32);
            txtEnd.TabIndex = 15;
            // 
            // completedBtn
            // 
            completedBtn.BackColor = Color.SeaGreen;
            completedBtn.Cursor = Cursors.Hand;
            completedBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            completedBtn.ForeColor = Color.White;
            completedBtn.Location = new Point(40, 151);
            completedBtn.Name = "completedBtn";
            completedBtn.Size = new Size(392, 72);
            completedBtn.TabIndex = 16;
            completedBtn.Text = "Completed";
            completedBtn.UseVisualStyleBackColor = false;
            completedBtn.Click += completedBtn_Click;
            // 
            // allBtn
            // 
            allBtn.BackColor = Color.SeaGreen;
            allBtn.Cursor = Cursors.Hand;
            allBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            allBtn.ForeColor = Color.White;
            allBtn.Location = new Point(27, 239);
            allBtn.Name = "allBtn";
            allBtn.Size = new Size(91, 34);
            allBtn.TabIndex = 16;
            allBtn.Text = "All";
            allBtn.UseVisualStyleBackColor = false;
            allBtn.Click += allBtn_Click;
            // 
            // incomeBtn
            // 
            incomeBtn.BackColor = Color.Gainsboro;
            incomeBtn.Cursor = Cursors.Hand;
            incomeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            incomeBtn.ForeColor = Color.Gray;
            incomeBtn.Location = new Point(113, 239);
            incomeBtn.Name = "incomeBtn";
            incomeBtn.Size = new Size(91, 34);
            incomeBtn.TabIndex = 16;
            incomeBtn.Text = "Income";
            incomeBtn.UseVisualStyleBackColor = false;
            incomeBtn.Click += incomeBtn_Click;
            // 
            // outcomeBtn
            // 
            outcomeBtn.BackColor = Color.Gainsboro;
            outcomeBtn.Cursor = Cursors.Hand;
            outcomeBtn.Font = new Font("Roboto", 10F, FontStyle.Bold);
            outcomeBtn.ForeColor = Color.Gray;
            outcomeBtn.Location = new Point(201, 239);
            outcomeBtn.Name = "outcomeBtn";
            outcomeBtn.Size = new Size(103, 34);
            outcomeBtn.TabIndex = 16;
            outcomeBtn.Text = "Outcome";
            outcomeBtn.UseVisualStyleBackColor = false;
            outcomeBtn.Click += outcomeBtn_Click;
            // 
            // statementList
            // 
            statementList.AllowDrop = true;
            statementList.AutoScroll = true;
            statementList.Location = new Point(27, 292);
            statementList.Name = "statementList";
            statementList.Size = new Size(416, 392);
            statementList.TabIndex = 17;
            // 
            // StatementFragment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(statementList);
            Controls.Add(outcomeBtn);
            Controls.Add(incomeBtn);
            Controls.Add(allBtn);
            Controls.Add(completedBtn);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(titleStatement);
            Name = "StatementFragment";
            Size = new Size(459, 719);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleStatement;
        private DateTimePicker txtStart;
        private DateTimePicker txtEnd;
        private Button completedBtn;
        private Button allBtn;
        private Button incomeBtn;
        private Button outcomeBtn;
        private FlowLayoutPanel statementList;
    }
}
