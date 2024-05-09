using System.Data.SqlClient;
using System.Data;

namespace BTTH03
{
    public partial class LogIn : Form
    {


        public LogIn()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            txtChange.ForeColor = ColorTranslator.FromHtml("#2DBCAA");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\icon\\BtnLoginEnter.png");
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\icon\\BtnLogin.png");
        }

        private void signupBtn_MouseEnter(object sender, EventArgs e)
        {
            signupBtn.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\icon\\SignupBtnEnter.png");
        }

        private void signupBtn_MouseLeave(object sender, EventArgs e)
        {
            signupBtn.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\icon\\BtnSignup.png");
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            LogInPage logInPage = new LogInPage();
            logInPage.Show();
            this.Hide();
        }

        private void signupBtn_Click_1(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            register.Show();
            this.Hide();
        }

        private void txtChange_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.Show();
            this.Close();
        }
    }
}
