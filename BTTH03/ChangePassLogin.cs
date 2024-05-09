using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH03
{
    public partial class ChangePassLogin : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        bool eyeOpen = false;
        bool eyeOpen_2 = false;
        string username;

        public ChangePassLogin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPwd.Text;
            string newPwd = txtNewPwd.Text;
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                username = reader.GetString(0);
            }
            reader.Close();

            sqlCmd.CommandText = "SELECT COUNT(*) FROM KHACHHANG WHERE USERNAME = @Username AND PASSWORD = @OldPassword";
            sqlCmd.Connection = sqlCon;

            // Sử dụng Parameters để tránh tấn công SQL Injection
            sqlCmd.Parameters.AddWithValue("@Username", username);
            sqlCmd.Parameters.AddWithValue("@OldPassword", oldPwd);

            // Thực hiện truy vấn và kiểm tra số lượng bản ghi trả về
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

            if (count > 0)
            {
                // Có kết quả trả về, thực hiện thay đổi mật khẩu
                // Thêm mã lệnh ChangePassword ở đây
                changePass(username, newPwd);
                MessageBox.Show("Password changed successfully!", "Success");
                txtNewPwd.Text = "New password";
                txtOldPwd.Text = "Old password";
            }
            else
            {
                // Không có kết quả trả về, hiện thông báo lỗi
                MessageBox.Show("Invalid username or password.", "Error");
            }

            sqlCon.Close();
        }

        private void changePass(string username, string newPwd)
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
            sqlCmd.CommandText = "UPDATE KHACHHANG SET PASSWORD = '" + newPwd + "' WHERE USERNAME = '" + username + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        } 

        private void txtOldPwd_Click(object sender, EventArgs e)
        {

            if (txtNewPwd.Text == "")
            {
                txtNewPwd.PasswordChar = '\0';
                txtNewPwd.Text = "New password";
            }

            if (txtOldPwd.Text == "Old password")
            {
                txtOldPwd.Text = "";
                txtOldPwd.PasswordChar = '*';

            }
        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {

            if (txtNewPwd.Text == "New password")
            {
                txtNewPwd.PasswordChar = '*';
                txtNewPwd.Text = "";
            }

            if (txtOldPwd.Text == "")
            {
                txtOldPwd.PasswordChar = '\0';
                txtOldPwd.Text = "Old password";
            }
        }
        private void eyeBtn_Click(object sender, EventArgs e)
        {
            if (!eyeOpen)
            {
                eyeOpen = true;
                eyeBtn.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\eye_open.png");
                txtOldPwd.PasswordChar = '\0';
            }
            else
            {
                eyeOpen = false;
                eyeBtn.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\eye_closed.png");
                txtOldPwd.PasswordChar = '*';
            }
        }

        private void eyeBtn_2_Click(object sender, EventArgs e)
        {
            if (!eyeOpen_2)
            {
                eyeOpen_2 = true;
                eyeBtn_2.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\eye_open.png");
                txtNewPwd.PasswordChar = '\0';
            }
            else
            {
                eyeOpen_2 = false;
                eyeBtn_2.Image = Image.FromFile("D:\\C#\\BTTH03\\img\\eye_closed.png");
                txtNewPwd.PasswordChar = '*';
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
