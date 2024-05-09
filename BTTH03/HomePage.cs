using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH03
{
    public partial class HomePage : Form
    {

        private void resetIcon()
        {
            homeIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\home_off.png");
            homeFragment.Visible = false;
            messageIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\messageOff.png");
            messageFragment.Visible = false;
            statementIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\graphOff.png");
            statementFragment.Visible = false;
            settingIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\settingOff.png");
            settingFragment.Visible = false;
        }
        public HomePage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            //homeFragment.DataUpdateRequested += UserControl_DataUpdateRequested;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void arrowDown_Click(object sender, EventArgs e)
        {

        }

        private void messageIcon_Click(object sender, EventArgs e)
        {
            resetIcon();
            messageFragment.LoadSms();
            messageIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\messageOn.png");
            messageFragment.Visible = true;
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            resetIcon();
            homeIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\home_on.png");
            homeFragment.Visible = true;
        }

        private void statementIcon_Click(object sender, EventArgs e)
        {
            resetIcon();
            statementIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\graphOn.png");
            statementFragment.Visible = true;
            statementFragment.setSubmit(false);
            statementFragment.loadData();
        }

        private void settingIcon_Click(object sender, EventArgs e)
        {
            resetIcon();
            settingIcon.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\settingOn.png");
            settingFragment.Visible = true;
            // Đăng ký sự kiện từ changeDefault
            settingFragment.CloseButtonClicked += Close_CloseButtonClicked;
        }

        private void Close_CloseButtonClicked(object sender, EventArgs e)
        {

            // Đóng UserControl2 sau khi thực hiện xong các thao tác
            settingFragment.Visible = false;
            LogInPage login = new LogInPage();
            login.Show();
            this.Close();
        }

        private void scanIcon_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.Show();
        }
    }
}
