using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTTH03
{
    public partial class LogInPage : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        bool eyeOpen = false;
        string stk, bank, name;

        public LogInPage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadInput();
            forgetTxt.ForeColor = ColorTranslator.FromHtml("#2DBCAA");
            signupTxt.ForeColor = ColorTranslator.FromHtml("#2DBCAA");
        }

        private void loadInput()
        {
            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            string username = "";
            string password = "";
            bool isRemember = false;
            // LẤY THÔNG TIN NGƯỜI ĐĂNG NHẬP GẦN NHẤT
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,PASSWORD,REMEMBER FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                password = reader.GetString(1);
                if (reader.GetString(2) == "T")
                {
                    isRemember = true;
                }
            }

            if (isRemember)
            {
                txtUsername.Text = username;
                txtPwd.Text = password;
                txtPwd.PasswordChar = '*';
            }
            reader.Close();
        }

        private void resetClick(object sender, EventArgs e)
        {
            if (txtPwd.Text == string.Empty)
            {
                txtPwd.PasswordChar = '\0';
                txtPwd.Text = "Password";
            }
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
        }

        private void userInput_click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = string.Empty;
            }
            if (txtPwd.Text == string.Empty)
            {
                txtPwd.Text = "Password";
            }
        }

        private void pwdInput_click(object sender, EventArgs e)
        {
            if (txtPwd.Text == "Password")
            {

                txtPwd.PasswordChar = '*';
                txtPwd.Text = string.Empty;
            }
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
        }

        private void forgetTxt_MouseEnter(object sender, EventArgs e)
        {
            forgetTxt.Font = new Font(forgetTxt.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void forgetTxt_MouseLeave(object sender, EventArgs e)
        {
            forgetTxt.Font = new Font(forgetTxt.Font, FontStyle.Regular);
        }
        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\icon\\BtnLoginEnter.png");
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\icon\\BtnLogin.png");
        }

        private void signupTxt_MouseEnter(Object sender, EventArgs e)
        {
            signupTxt.ForeColor = Color.White;
        }

        private void signupTxt_MouseLeave(Object sender, EventArgs e)
        {
            signupTxt.ForeColor = ColorTranslator.FromHtml("#2DBCAA");
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

        private void signupTxt_Click(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            register.Show();
            this.Hide();
        }

        private void backBtn_MouseEnter(Object sender, EventArgs e)
        {
            backBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\backBtn_onMouse.png");
        }

        private void backBtn_MouseLeave(Object sender, EventArgs e)
        {
            backBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\backBtn.png");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPwd.Text;
            if (CheckValid(username, password))
            {
                MessageBox.Show("Logged in successfully", "Succeed");

                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strcCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                // LẤY THÔNG TIN STK VÀ NGÂN HÀNG MẶC ĐỊNH
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT HOTEN,STK, BANK FROM KHACHHANG WHERE USERNAME = '" + username + "' AND STKdefault='T'";
                sqlCmd.Connection = sqlCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    name = reader.GetString(0);
                    stk = reader.GetString(1);
                    bank = reader.GetString(2);
                }
                reader.Close();

                string remember = "F";
                DateTime dateTime = DateTime.Now;
                if (remeberBox.Checked)
                {
                    remember = "T";
                }

                //THÊM NGƯỜI DÙNG VÀO TABLE ĐANG ONLINE
                sqlCmd.CommandText = "INSERT INTO ONLINE VALUES('" + username + "','" + name + "','" + stk + "','" + bank + "','" + dateTime + "','" + remember + "','" + password + "')";
                sqlCmd.Connection = sqlCon;
                int sql = sqlCmd.ExecuteNonQuery();

                HomePage homePage = new HomePage();
                homePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect", "Error");
            }
        }

        private bool CheckValid(string username, string password)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT COUNT(*) FROM KHACHHANG WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD";


            using (SqlCommand command = new SqlCommand(sqlCmd.CommandText, sqlCon))
            {
                command.Parameters.AddWithValue("@USERNAME", username);
                command.Parameters.AddWithValue("@PASSWORD", password);

                int count = (int)command.ExecuteScalar();

                // Nếu có ít nhất một kết quả trả về, đăng nhập thành công
                return count > 0;
            }

        }

        private void eyeBtn_Click(object sender, EventArgs e)
        {
            if (!eyeOpen)
            {
                eyeOpen = true;
                eyeBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\eye_open.png");
                txtPwd.PasswordChar = '\0';
            }
            else
            {
                eyeOpen = false;
                eyeBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\eye_closed.png");
                txtPwd.PasswordChar = '*';
            }
        }

        private void forgetTxt_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.Show();        }
    }
}
