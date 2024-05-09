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

namespace BTTH03
{
    public partial class AccountList : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string usernameGet, stkGet, bankGet;
        int total=0;
        int totalInterest = 0;
        public AccountList()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadAccount();
        }

        private void resetBtn()
        {
            paymentBtn.ForeColor = Color.Gray;
            paymentBtn.BackColor = Color.Gainsboro;

            savingBtn.ForeColor = Color.Gray;
            savingBtn.BackColor = Color.Gainsboro;
        }

        private void loadAccount()
        {
            total=0;
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,STK,BANK FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                usernameGet = reader.GetString(0);
                stkGet = reader.GetString(1);
                bankGet = reader.GetString(2);
            }
            reader.Close();


            string stk;
            int money;
            DateTime date;
            sqlCmd.CommandText = "SELECT STK,TIEN,TIMECREATE FROM KHACHHANG WHERE KHACHHANG.USERNAME = '" + usernameGet + "' AND SAVING='F' ORDER BY TIMECREATE DESC";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            accList.Controls.Clear();
            while (reader.Read())
            {
                stk = reader.GetString(0);
                money = reader.GetInt32(1);
                date = reader.GetDateTime(2);

                //Tính tổng tiền
                total = total+money;

                //CLEAR FLOWLAYOUTPANEL
                // TẠO ITEM ACCOUNT
                accountItem accountItem = new accountItem();
                accountItem.loadAccount(stk, money, date,false,0,0,bankGet);
                accList.Controls.Add(accountItem);
            }
            reader.Close ();
            txtTotal.Text = total.ToString();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            resetBtn();
            loadAccount();
            paymentBtn.ForeColor = Color.DarkTurquoise;
            paymentBtn.BackColor = Color.White;
        }

        private void savingBtn_Click(object sender, EventArgs e)
        {
            resetBtn();
            loadSavingAccount();
            savingBtn.ForeColor = Color.DarkTurquoise;
            savingBtn.BackColor = Color.White;
        }

        private void loadSavingAccount()
        {
            total = 0;
            

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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,STK,BANK FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                usernameGet = reader.GetString(0);
                stkGet = reader.GetString(1);
                bankGet = reader.GetString(2);
            }
            reader.Close();


            string stk;
            int money;
            double interestMoney;
            double rate;
            DateTime date;
            sqlCmd.CommandText = "SELECT STK,TIEN,TIMECREATE,INTEREST FROM KHACHHANG WHERE KHACHHANG.USERNAME = '" + usernameGet + "' AND SAVING='T' ORDER BY TIMECREATE DESC";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            accList.Controls.Clear();
            while (reader.Read())
            {
                stk = reader.GetString(0);
                money = reader.GetInt32(1);
                date = reader.GetDateTime(2);
                rate = reader.GetDouble(3);
                //Tính tổng tiền
                total = total + money;

                // Tính tiền lãi
                interestMoney = (money * rate);
                //CLEAR FLOWLAYOUTPANEL
                // TẠO ITEM ACCOUNT
                accountItem accountItem = new accountItem();
                accountItem.loadAccount(stk, money, date,true,rate,interestMoney,bankGet);
                accList.Controls.Add(accountItem);
            }
            reader.Close();
            txtTotal.Text = total.ToString();
        }
    }
}
