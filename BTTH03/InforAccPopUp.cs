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
    public partial class InforAccPopUp : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, stk, bank;
        int money;
        string bankGet;

        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;

        public InforAccPopUp()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,STK,BANK FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                this.username = reader.GetString(0);
                stk = reader.GetString(1);
                bank = reader.GetString(2);
               
            }
            reader.Close();

            // LẤY SỐ TIỀN TỪ KHÁCH HÀNG
            sqlCmd.CommandText = "SELECT TIEN,BANK FROM KHACHHANG WHERE KHACHHANG.STK='" + stk + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                money = reader.GetInt32(0);
                bankGet = reader.GetString(1);
            }
            reader.Close();
            txtAcc.Text = stk;
            txtMoney.Text = money.ToString() + " VND";

        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            TransMoney transMoney = new TransMoney();
            transMoney.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            changeDefault.Visible = true;
            changeDefault.loadAccount();
            // Đăng ký sự kiện từ changeDefault
            changeDefault.CloseButtonClicked += changeDefault_CloseButtonClicked;
        }

        private void changeDefault_CloseButtonClicked(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nút Close trong UserControl2 được bấm
            // Thực hiện các thao tác cập nhật bạn muốn ở đây
            loadData();

            // Đóng UserControl2 sau khi thực hiện xong các thao tác
            changeDefault.Visible = false;
        }

        private void QRicon_Click(object sender, EventArgs e)
        {
            QRCode_Form qrCode = new QRCode_Form();
            string qr = stk + " " + bankGet;
            qrCode.Show();
            qrCode.createQRcode(qr);
        }
    }
}
