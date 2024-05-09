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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTTH03
{
    public partial class SettingFragment : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname;
        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;

        public SettingFragment()
        {
            InitializeComponent();
            loadAcc();
        }

        private void loadAcc()
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

            // LẤY THÔNG TIN NGƯỜI VỪA ĐĂNG NHẬP VÀO
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 * FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                fullname = reader.GetString(1);
            }
            reader.Close();

            name.Text = fullname;

            sqlCmd.CommandText = "SELECT TOP 1 SODT,NGSINH, EMAIL,GIOTINH FROM KHACHHANG WHERE KHACHHANG.USERNAME='" + username + "' AND KHACHHANG.HOTEN='" + fullname + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                string phone = reader.GetString(0);
                string dateOfBirth = reader.GetDateTime(1).ToString();
                string email = reader.GetString(2);
                string sex;
                if (reader.GetString(3) == "M")
                {
                    sex = "Male";
                }
                else { sex = "Female"; }

                txtUsername.Text = username;
                txtPhone.Text = phone;
                txtEmail.Text = email;
                txtDate.Text = dateOfBirth;
                txtSex.Text = sex;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            ChangePassLogin changePassLogin = new ChangePassLogin();
            changePassLogin.Show();
        }
    }
}
