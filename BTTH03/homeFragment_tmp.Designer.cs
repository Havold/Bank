namespace BTTH03
{
    partial class homeFragment_tmp
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
            savingIcon = new PictureBox();
            txtSaving = new Label();
            transIcon = new PictureBox();
            txtTrans = new Label();
            transPanel = new Panel();
            arrowDown = new PictureBox();
            rightArrow = new PictureBox();
            txtList = new Label();
            panel2 = new Panel();
            txtPayment = new Label();
            txtAcc = new Label();
            savingPanel = new Panel();
            pictureBox3 = new PictureBox();
            name = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            inforAccPopUp = new InforAccPopUp();
            ((System.ComponentModel.ISupportInitialize)savingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transIcon).BeginInit();
            transPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)arrowDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).BeginInit();
            panel2.SuspendLayout();
            savingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // savingIcon
            // 
            savingIcon.BackColor = Color.Transparent;
            savingIcon.Image = Properties.Resources.saveMoney;
            savingIcon.Location = new Point(89, 29);
            savingIcon.Name = "savingIcon";
            savingIcon.Size = new Size(40, 40);
            savingIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            savingIcon.TabIndex = 3;
            savingIcon.TabStop = false;
            savingIcon.Click += Savings_Click;
            // 
            // txtSaving
            // 
            txtSaving.AutoSize = true;
            txtSaving.BackColor = Color.Transparent;
            txtSaving.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtSaving.ForeColor = Color.White;
            txtSaving.Location = new Point(44, 83);
            txtSaving.Name = "txtSaving";
            txtSaving.Size = new Size(132, 25);
            txtSaving.TabIndex = 2;
            txtSaving.Text = "Open savings";
            txtSaving.Click += Savings_Click;
            // 
            // transIcon
            // 
            transIcon.BackColor = Color.Transparent;
            transIcon.Image = Properties.Resources.transMoney;
            transIcon.Location = new Point(87, 29);
            transIcon.Name = "transIcon";
            transIcon.Size = new Size(40, 40);
            transIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            transIcon.TabIndex = 3;
            transIcon.TabStop = false;
            transIcon.Click += transPanel_Click;
            // 
            // txtTrans
            // 
            txtTrans.AutoSize = true;
            txtTrans.BackColor = Color.Transparent;
            txtTrans.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtTrans.ForeColor = Color.White;
            txtTrans.Location = new Point(32, 83);
            txtTrans.Name = "txtTrans";
            txtTrans.Size = new Size(153, 25);
            txtTrans.TabIndex = 2;
            txtTrans.Text = "Transfer money";
            txtTrans.Click += transPanel_Click;
            // 
            // transPanel
            // 
            transPanel.BackColor = Color.SteelBlue;
            transPanel.Controls.Add(transIcon);
            transPanel.Controls.Add(txtTrans);
            transPanel.Cursor = Cursors.Hand;
            transPanel.Location = new Point(15, 552);
            transPanel.Name = "transPanel";
            transPanel.Size = new Size(210, 142);
            transPanel.TabIndex = 12;
            transPanel.Click += transPanel_Click;
            // 
            // arrowDown
            // 
            arrowDown.Cursor = Cursors.Hand;
            arrowDown.Image = Properties.Resources.arrowDown;
            arrowDown.Location = new Point(150, 51);
            arrowDown.Name = "arrowDown";
            arrowDown.Size = new Size(20, 10);
            arrowDown.SizeMode = PictureBoxSizeMode.StretchImage;
            arrowDown.TabIndex = 5;
            arrowDown.TabStop = false;
            arrowDown.Click += txtAcc_Click;
            // 
            // rightArrow
            // 
            rightArrow.Cursor = Cursors.Hand;
            rightArrow.Image = Properties.Resources.arrowRight;
            rightArrow.Location = new Point(393, 34);
            rightArrow.Name = "rightArrow";
            rightArrow.Size = new Size(10, 20);
            rightArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            rightArrow.TabIndex = 5;
            rightArrow.TabStop = false;
            rightArrow.Click += txtList_Click;
            // 
            // txtList
            // 
            txtList.AutoSize = true;
            txtList.BackColor = Color.Transparent;
            txtList.Cursor = Cursors.Hand;
            txtList.Font = new Font("Roboto", 9F);
            txtList.ForeColor = Color.Black;
            txtList.Location = new Point(354, 34);
            txtList.Name = "txtList";
            txtList.Size = new Size(34, 19);
            txtList.TabIndex = 2;
            txtList.Text = "List";
            txtList.Click += txtList_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(arrowDown);
            panel2.Controls.Add(rightArrow);
            panel2.Controls.Add(txtList);
            panel2.Controls.Add(txtPayment);
            panel2.Controls.Add(txtAcc);
            panel2.Location = new Point(15, 442);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 89);
            panel2.TabIndex = 18;
            // 
            // txtPayment
            // 
            txtPayment.AutoSize = true;
            txtPayment.BackColor = Color.Transparent;
            txtPayment.Font = new Font("Roboto", 9F);
            txtPayment.ForeColor = Color.Gray;
            txtPayment.Location = new Point(24, 15);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(125, 19);
            txtPayment.TabIndex = 2;
            txtPayment.Text = "Payment account";
            // 
            // txtAcc
            // 
            txtAcc.AutoSize = true;
            txtAcc.BackColor = Color.Transparent;
            txtAcc.Cursor = Cursors.Hand;
            txtAcc.Font = new Font("Roboto", 12F, FontStyle.Bold);
            txtAcc.Location = new Point(24, 43);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(122, 25);
            txtAcc.TabIndex = 2;
            txtAcc.Text = "1234567890";
            txtAcc.Click += txtAcc_Click;
            // 
            // savingPanel
            // 
            savingPanel.BackColor = Color.SteelBlue;
            savingPanel.Controls.Add(savingIcon);
            savingPanel.Controls.Add(txtSaving);
            savingPanel.Cursor = Cursors.Hand;
            savingPanel.Location = new Point(238, 552);
            savingPanel.Name = "savingPanel";
            savingPanel.Size = new Size(210, 142);
            savingPanel.TabIndex = 14;
            savingPanel.Click += Savings_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(15, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Font = new Font("Roboto", 12F, FontStyle.Bold);
            name.Location = new Point(84, 86);
            name.Name = "name";
            name.Size = new Size(182, 25);
            name.TabIndex = 15;
            name.Text = "TRUONG HUU THO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 9F);
            label2.Location = new Point(84, 61);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 16;
            label2.Text = "Good morning!";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.background_home3;
            pictureBox4.Location = new Point(-1, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(460, 501);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("VALORANT", 20F);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 11;
            label1.Text = "METAN";
            // 
            // inforAccPopUp
            // 
            inforAccPopUp.BackColor = Color.White;
            inforAccPopUp.BorderStyle = BorderStyle.FixedSingle;
            inforAccPopUp.Location = new Point(18, 239);
            inforAccPopUp.Name = "inforAccPopUp";
            inforAccPopUp.Size = new Size(430, 288);
            inforAccPopUp.TabIndex = 0;
            inforAccPopUp.Visible = false;
            // 
            // homeFragment_tmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inforAccPopUp);
            Controls.Add(transPanel);
            Controls.Add(panel2);
            Controls.Add(savingPanel);
            Controls.Add(pictureBox3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Name = "homeFragment_tmp";
            Size = new Size(459, 719);
            ((System.ComponentModel.ISupportInitialize)savingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)transIcon).EndInit();
            transPanel.ResumeLayout(false);
            transPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)arrowDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            savingPanel.ResumeLayout(false);
            savingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox savingIcon;
        private Label txtSaving;
        private PictureBox transIcon;
        private Label txtTrans;
        private Panel transPanel;
        private PictureBox arrowDown;
        private PictureBox rightArrow;
        private Label txtList;
        private Panel panel2;
        private Label txtPayment;
        private Label txtAcc;
        private Panel savingPanel;
        private PictureBox pictureBox3;
        private Label name;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label1;
        private InforAccPopUp inforAccPopUp;
    }
}
