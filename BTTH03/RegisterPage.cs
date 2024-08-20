using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;


namespace BTTH03
{
    public partial class RegisterPage : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;

        public RegisterPage()
        {   
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            registerTxt.ForeColor = ColorTranslator.FromHtml("#2DBCAA");
        }

        private bool CheckValid(string username, string email, string phone)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection();
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string usernameGet = reader.GetString(0);
                string nameGet = reader.GetString(1);
                string phoneGet = reader.GetString(2);
                DateTime birthGet = reader.GetDateTime(3);
                string emailGet = reader.GetString(4);
                string passwordGet = reader.GetString(5);
                string sexGet = reader.GetString(6);
                string STKGet = reader.GetString(7);
                string bankGet = reader.GetString(8);
                decimal moneyGet = reader.GetInt32(9);
                if (username == usernameGet)
                {
                    MessageBox.Show("Username already exists. Please choose another username", "Failed");
                    reader.Close();
                    return false;
                }
                else if (email == emailGet)
                {
                    MessageBox.Show("This email has been registered. Please choose another username", "Failed");
                    reader.Close();
                    return false;
                }
                else if (phone == phoneGet)
                {
                    MessageBox.Show("This phone number has been registered. Please choose another username", "Failed");
                    reader.Close();
                    return false;

                }
            }
            reader.Close();
            return true;
          
        }

        private void resetClick()
        {
            if (txtPwd.Text == string.Empty)
            {
                txtPwd.PasswordChar = '\0';
                txtPwd.Text = "Password";
            }
            if (txtName.Text == string.Empty)
            {
                txtName.Text = "Name";
            }
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
            if (txtPhone.Text == string.Empty)
            {
                txtPhone.Text = "Phone";
            }
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Email";
            }
        }
        private void nameInput_click(object sender, EventArgs e)
        {
            resetClick();
            if (txtName.Text == "Name")
            {
                txtName.Text = string.Empty;
            }
        }

        private void userInput_click(object sender, EventArgs e)
        {
            resetClick();
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = string.Empty;
            }
        }

        private void phoneInput_click(object sender, EventArgs e)
        {
            resetClick();
            if (txtPhone.Text == "Phone")
            {
                txtPhone.Text = string.Empty;
            }
        }

        private void emailInput_click(object sender, EventArgs e)
        {
            resetClick();
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = string.Empty;
            }
        }

        private void pwdInput_click(object sender, EventArgs e)
        {
            resetClick();
            if (txtPwd.Text == "Password")
            {
                txtPwd.PasswordChar = '*';
                txtPwd.Text = string.Empty;
            }
        }

        private void maleSelect_CheckedChanged(object sender, EventArgs e)
        {
            resetClick();
        }

        private void femaleSelect_CheckedChanged(object sender, EventArgs e)
        {
            resetClick();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            resetClick();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            resetClick();

        }

        private void signupBtn_MouseEnter(object sender, EventArgs e)
        {
            signupBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\icon\\SignupBtnEnter.png");
        }

        private void signupBtn_MouseLeave(object sender, EventArgs e)
        {
            signupBtn.Image = Image.FromFile("C:\\C#\\METAN-Banking\\img\\icon\\BtnSignup.png");
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

        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            
            // Lay du lieu
            string name = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string phone = txtPhone.Text.Trim();
            DateTime birth = txtDate.Value;
            string sex = "F";
            // Tạo đối tượng Random
            Random random = new Random();

            // Tạo một dãy số ngẫu nhiên với 10 chữ số
            string randomString = GenerateRandomNumber(random, 10);



            if (maleSelect.Checked)
            {
                sex = "M";
            }

            // Kiem tra xem email co hop le khong?
            if (!IsValidEmail(email)) 
            {
                MessageBox.Show("Invalid email.", "Error");
                return;
            }

            if (!IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number", "Error");
                return;
            }

            if (!CheckValid(username,email,phone))
            {
                return;
            }

            DateTime dateTime = DateTime.Now;

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO KHACHHANG VALUES(@USERNAME,@HOTEN,@SODT,@NGSINH,@EMAIL,@PASSWORD,@GIOITINH,@STK,'METAN',500000,'T','"+ dateTime + "','F',0)";
        
            SqlParameter parName = new SqlParameter("@HOTEN",SqlDbType.VarChar);
            SqlParameter parUsername = new SqlParameter("@USERNAME",SqlDbType.VarChar);
            SqlParameter parPhone = new SqlParameter("@SODT", SqlDbType.VarChar);
            SqlParameter parEmail = new SqlParameter("@EMAIL",SqlDbType.VarChar);
            SqlParameter parDate = new SqlParameter("@NGSINH",SqlDbType.SmallDateTime);
            SqlParameter parPwd = new SqlParameter("@PASSWORD",SqlDbType.VarChar);
            SqlParameter parSex = new SqlParameter("@GIOITINH",SqlDbType.Char);
            SqlParameter parSTK = new SqlParameter("@STK",SqlDbType.VarChar);

            parDate.Value = birth;
            parName.Value = name;
            parUsername.Value = username;
            parPhone.Value = phone;
            parEmail.Value = email;
            parPwd.Value = pwd;
            parSex.Value = sex;
            parSTK.Value = randomString;

            sqlCmd.Parameters.Add(parName);
            sqlCmd.Parameters.Add(parUsername);
            sqlCmd.Parameters.Add(parEmail);
            sqlCmd.Parameters.Add(parDate);
            sqlCmd.Parameters.Add(parPwd);
            sqlCmd.Parameters.Add(parSex);
            sqlCmd.Parameters.Add(parPhone);
            sqlCmd.Parameters.Add(parSTK);

            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Account registration successful","Succeed");
                txtEmail.Text = "";
                txtName.Text = "";
                txtUsername.Text = "";
                txtPwd.Text = "";
                txtPhone.Text = "";
            }
            else
            {
                MessageBox.Show("Account registration failed","Error");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy để kiểm tra định dạng số điện thoại
            string pattern = @"^\d{10}$";

            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(phoneNumber, pattern);
        }

        // Hàm tạo một dãy số ngẫu nhiên với độ dài cho trước
        private static string GenerateRandomNumber(Random random, int length)
        {
            char[] digits = new char[length];

            // Đảm bảo chữ số đầu tiên khác 0 để tránh số bắt đầu bằng 0
            digits[0] = (char)('1' + random.Next(9));

            // Tạo các chữ số ngẫu nhiên cho các vị trí còn lại
            for (int i = 1; i < length; i++)
            {
                digits[i] = (char)('0' + random.Next(10));
            }

            // Chuyển mảng ký tự thành chuỗi
            return new string(digits);
        }
    }
}
