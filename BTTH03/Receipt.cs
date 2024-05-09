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
    public partial class Receipt : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username,stk,bank,nameDefault;
        public Receipt()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,NAME,STK,BANK FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                this.username = reader.GetString(0);
                nameDefault = reader.GetString(1);
                stk = reader.GetString(2);
                bank = reader.GetString(3);
            }
            reader.Close();

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 1 MAGIAODICH,SOTIENCHUYEN,TAIKHOANTHUHUONG,TENNGUOITHUHUONG,NGANHANGTHUHUONG,NOIDUNGCHUYENTIEN,THOIGIANGD FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.STK = HOADON.SoTaiKhoanChuyen OR KHACHHANG.STK= HOADON.TaiKhoanThuHuong ORDER BY HOADON.ThoiGianGD DESC";

            sqlCmd.Connection = sqlCon;

            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                int maGD = reader.GetInt32(0);
                //string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(1);
                string TKthuhuong = reader.GetString(2);
                string nameThuHuong = reader.GetString(3);
                if (nameThuHuong == "N")
                {
                    nameThuHuong = nameDefault;
                }
                string Bankthuhuong = reader.GetString(4);
                string content = reader.GetString(5);
                DateTime date = reader.GetDateTime(6);
                //int totalMoneyFrom = reader.GetInt32(9);
                //int totalMoneyTo = reader.GetInt32(10);   

                txtMoney.Text = tienChuyen.ToString()+" VND";
                txtName.Text = nameThuHuong;
                txtMaGD.Text = maGD.ToString();
                txtBank.Text = Bankthuhuong;
                txtSTK.Text = TKthuhuong;
                txtContent.Text = content;
                txtDate.Text = date.ToString();
            }
            reader.Close();
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
