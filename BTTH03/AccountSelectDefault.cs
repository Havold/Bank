using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH03
{
    public partial class AccountSelectDefault : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string usernameGet;
        string accountGet;
        public AccountSelectDefault()
        {
            InitializeComponent();
        }

        public void loadAccount(string account, int money,bool isDefault)
        {
            if (isDefault)
            {
                txtDefault.Visible = true;
                defaultPanel.Visible = true;
                txtAccount.Checked = true;
            }
            accountGet= account;
            txtAccount.Text = account;
            txtMoney.Text = money.ToString() + " VND";
        }

        public string getAccount() {
            return accountGet;
        }

        public void updateDefault(bool isDefault)
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

            //LẤY THÔNG TIN TÀI KHOẢN
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                usernameGet = reader.GetString(0);
            }
            reader.Close();

           if (isDefault)
            {

                // UPDATE LẠI THUỘC TÍNH MẶC ĐỊNH
                sqlCmd.CommandText = "UPDATE KHACHHANG SET STKdefault = 'T' WHERE STK = '" + accountGet + "'";
                sqlCmd.Connection = sqlCon;
                sqlCmd.ExecuteNonQuery();

                //UPDATE LẠI STK ĐANG XÀI TRONG TABLE ONLINE
                sqlCmd.CommandText = "UPDATE ONLINE SET STK = '"+accountGet+"' WHERE STK = ( SELECT TOP 1 STK FROM ONLINE ORDER BY TIMEIN DESC)";
                sqlCmd.Connection = sqlCon;
                sqlCmd.ExecuteNonQuery();
            }

           else
            {
                sqlCmd.CommandText = "UPDATE KHACHHANG SET STKdefault = 'F' WHERE STK = '"+accountGet+"'";
                sqlCmd.Connection = sqlCon;
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
