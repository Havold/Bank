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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTTH03
{
    public partial class MessageFragment_tmp : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username,stk,bank;
        
        private void resetAll()
        {
            txtAll.ForeColor = Color.Gray;
            allPanel.BackColor = Color.Gainsboro;

            txtNotseen.ForeColor = Color.Gray;
            notseenPanel.BackColor = Color.Gainsboro;

            txtSeen.ForeColor = Color.Gray;
            seenPanel.BackColor = Color.Gainsboro;
        }
        public MessageFragment_tmp()
        {
            InitializeComponent();
            LoadSms();

        }

        public void LoadSms()
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

            messageList.Controls.Clear();

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT HOADON.* FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.STK = HOADON.SoTaiKhoanChuyen OR KHACHHANG.STK= HOADON.TaiKhoanThuHuong WHERE KHACHHANG.STK = '" + stk + "' ORDER BY HOADON.ThoiGianGD DESC";

            sqlCmd.Connection = sqlCon;

            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                string TKthuhuong = reader.GetString(4);
                string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                int totalMoneyFrom = reader.GetInt32(9);
                int totalMoneyTo = reader.GetInt32(10);

                //Tạo tin nhắn
                Message message = new Message();
                if (STKChuyen==stk)
                {
                    message.loadMessage(STKChuyen, bank, tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, true);
                }
                else
                {
                    message.loadMessage(STKChuyen, bank, tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, false);

                }
                messageList.Controls.Add(message);
            }
            reader.Close();

            /*

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT HOADON.* FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.STK = HOADON.TaiKhoanThuHuong WHERE KHACHHANG.USERNAME = '" + username + "'";

            sqlCmd.Connection = sqlCon;

            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                string TKthuhuong = reader.GetString(4);
                string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                int totalMoneyFrom = reader.GetInt32(9);
                int totalMoneyTo = reader.GetInt32(10);
                Message message = new Message();
                message.loadMessage(STKChuyen, "METAN", tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, false);
                messageList.Controls.Add(message);
            }
            reader.Close();
            */
            //message.loadMessage();
        }
        
        // HÀM TẠO TIN NHẮN CHƯA ĐỌC
        private void LoadSmsNotSeen()
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

            messageList.Controls.Clear();


            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT HOADON.* FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.STK = HOADON.SoTaiKhoanChuyen OR KHACHHANG.STK= HOADON.TaiKhoanThuHuong WHERE KHACHHANG.STK = '" + stk + "' AND HOADON.seen='N' ORDER BY HOADON.ThoiGianGD DESC";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                string TKthuhuong = reader.GetString(4);
                string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                int totalMoneyFrom = reader.GetInt32(9);
                int totalMoneyTo = reader.GetInt32(10);

                //Tạo tin nhắn
                Message message = new Message();
                if (STKChuyen == stk)
                {
                    message.loadMessage(STKChuyen, "METAN", tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, true);
                }
                else
                {
                    message.loadMessage(STKChuyen, "METAN", tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, false);

                }
                messageList.Controls.Add(message);
            }
            reader.Close();

            //CẬP NHẬN LẠI TRANG THÁI ĐÃ ĐỌC
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE HOADON SET seen = 'S' FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.STK = HOADON.SoTaiKhoanChuyen OR KHACHHANG.STK= HOADON.TaiKhoanThuHuong WHERE KHACHHANG.STK = '" + stk + "' AND HOADON.seen='N'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        // HÀM TẠO TIN NHẮN ĐÃ ĐỌC
        private void LoadSmsSeen()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            messageList.Controls.Clear();


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT HOADON.* FROM KHACHHANG INNER JOIN HOADON ON KHACHHANG.STK = HOADON.SoTaiKhoanChuyen OR KHACHHANG.STK= HOADON.TaiKhoanThuHuong WHERE KHACHHANG.STK = '" + stk + "' AND HOADON.seen='S' ORDER BY HOADON.ThoiGianGD DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                string TKthuhuong = reader.GetString(4);
                string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                int totalMoneyFrom = reader.GetInt32(9);
                int totalMoneyTo = reader.GetInt32(10);

                //Tạo tin nhắn
                Message message = new Message();
                if (STKChuyen == stk)
                {
                    message.loadMessage(STKChuyen, "METAN", tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, true);
                }
                else
                {
                    message.loadMessage(STKChuyen, "METAN", tienChuyen, totalMoneyFrom, date, Bankthuhuong, TKthuhuong, content, false);

                }
                messageList.Controls.Add(message);
            }
            reader.Close();

        }


        private void allPanel_Click(object sender, EventArgs e)
        {
            resetAll();
            txtAll.ForeColor = Color.White;
            allPanel.BackColor = Color.SeaGreen;
            LoadSms();
        }

        private void notseenPanel_Click (object sender, EventArgs e)
        {
            resetAll();
            txtNotseen.ForeColor = Color.White;
            notseenPanel.BackColor = Color.SeaGreen;
            LoadSmsNotSeen();
        }

        private void seenPanel_Click(object sender, EventArgs e)
        {
            resetAll();
            txtSeen.ForeColor = Color.White;
            seenPanel.BackColor = Color.SeaGreen;
            LoadSmsSeen();
        }
    }
}
