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
    public partial class StatementFragment : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string stkGet;
        bool isAll=true, isIncome=false, isOutcome=false;
        bool onSubmit = false;
        public StatementFragment()
        {
            InitializeComponent();
            loadData();
        }

        private void resetState()
        {
            isAll = false;
            isIncome = false;
            isOutcome = false;

            allBtn.ForeColor = Color.Gray;
            allBtn.BackColor = Color.Gainsboro;

            incomeBtn.ForeColor = Color.Gray;
            incomeBtn.BackColor = Color.Gainsboro;

            outcomeBtn.ForeColor = Color.Gray;
            outcomeBtn.BackColor = Color.Gainsboro;
        }

        public void loadData()
        {
            statementList.Controls.Clear();
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
            sqlCmd.CommandText = "SELECT TOP 1 STK FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                stkGet = reader.GetString(0);
            }
            reader.Close();
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            onSubmit = true;
            // LẤY THÔNG TIN NGÀY BẮT ĐẦU VÀ NGÀY KẾT THÚC
            string start = txtStart.Value.ToString("yyyy-MM-dd");


            DateTime endTmp = txtEnd.Value.Date;
            // Thêm thời gian là 23:59:59 vào ngày đã chọn
            //DateTime endOfDay = endTmp.AddDays(1).AddSeconds(-1);

            // THÊM 1 NGÀY VÀO THỜI GIAN VỪA CHỌN
            DateTime endOfDay = endTmp.AddDays(1);

            string end = endOfDay.ToString("yyyy-MM-dd");

            // MỞ KẾT NỐI
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            // LỌC THÔNG TIN
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "DELETE FROM HOADON_Filtered";    //XÓA TOÀN BỘ DỮ LIỆU TRƯỚC KHI LỌC
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            // LOC THÔNG TIN TỪ NGÀY START DẾN END
            sqlCmd.CommandText = "INSERT INTO HOADON_Filtered SELECT * FROM HOADON WHERE ThoiGianGD BETWEEN '"+start+"' AND '"+end+"'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();


            if (isAll)
            {
                loadSmsAll();
            }

            else if (isIncome)
            {
                loadSmsIncome();
            }

            else
            {
                loadSmsOutcome();
            }

        }

        private void loadSmsOutcome()
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
            statementList.Controls.Clear();

            sqlCmd.CommandType = CommandType.Text;
            // CHỈ LẤY CÁC THÔNG TIN KHI TÀI KHOẢN NGUỒN Ở MỤC TÀI KHOẢN CHUYỂN TIỀN
            sqlCmd.CommandText = "SELECT HOADON_Filtered.* FROM KHACHHANG INNER JOIN HOADON_Filtered ON KHACHHANG.STK = HOADON_Filtered.SoTaiKhoanChuyen WHERE KHACHHANG.STK = '" + stkGet + "' ORDER BY ThoiGianGD DESC";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                //string TKthuhuong = reader.GetString(4);
                //string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                //int totalMoneyFrom = reader.GetInt32(9);
                //int totalMoneyTo = reader.GetInt32(10);

                //Tạo tin nhắn
                statementItem message = new statementItem();
                message.loadMessage(date, content, tienChuyen, true); //isOutcome=true
                statementList.Controls.Add(message);
            }
            reader.Close();
        }

        private void loadSmsIncome()
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
            statementList.Controls.Clear();

            sqlCmd.CommandType = CommandType.Text;
            // Chỉ lấy các thông tin khi tài khoản nguồn ở mục nhận
            sqlCmd.CommandText = "SELECT HOADON_Filtered.* FROM KHACHHANG INNER JOIN HOADON_Filtered ON KHACHHANG.STK= HOADON_Filtered.TaiKhoanThuHuong WHERE KHACHHANG.STK = '" + stkGet + "' ORDER BY ThoiGianGD DESC";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                //string TKthuhuong = reader.GetString(4);
                //string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                //int totalMoneyFrom = reader.GetInt32(9);
                //int totalMoneyTo = reader.GetInt32(10);

                //Tạo tin nhắn
                statementItem message = new statementItem();
                message.loadMessage(date, content, tienChuyen, false); //isOutcome=false
                statementList.Controls.Add(message);
            }
            reader.Close();
        }

        private void loadSmsAll()
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
            statementList.Controls.Clear();

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT HOADON_Filtered.* FROM KHACHHANG INNER JOIN HOADON_Filtered ON KHACHHANG.STK = HOADON_Filtered.SoTaiKhoanChuyen OR KHACHHANG.STK= HOADON_Filtered.TaiKhoanThuHuong WHERE KHACHHANG.STK = '"+stkGet+ "' ORDER BY ThoiGianGD DESC";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string STKChuyen = reader.GetString(1);
                int tienChuyen = reader.GetInt32(2);
                //string TKthuhuong = reader.GetString(4);
                //string Bankthuhuong = reader.GetString(5);
                string content = reader.GetString(6);
                DateTime date = reader.GetDateTime(7);
                //int totalMoneyFrom = reader.GetInt32(9);
                //int totalMoneyTo = reader.GetInt32(10);

                //Tạo tin nhắn
                statementItem message = new statementItem();
                if (STKChuyen == stkGet)
                {
                    message.loadMessage(date, content, tienChuyen, true);
                }
                else
                {
                    message.loadMessage(date, content, tienChuyen, false);

                }
                statementList.Controls.Add(message);
            }
            reader.Close();
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            resetState();
            isAll = true;
            allBtn.ForeColor = Color.White;
            allBtn.BackColor = Color.Green;
            if (onSubmit)
            {
                loadSmsAll();
            }
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            resetState();
            isIncome = true;
            incomeBtn.ForeColor = Color.White;
            incomeBtn.BackColor = Color.Green;
            if (onSubmit)
            {
                loadSmsIncome();
            }
        }

        private void outcomeBtn_Click(object sender, EventArgs e)
        {
            resetState();
            isOutcome = true;
            outcomeBtn.ForeColor = Color.White;
            outcomeBtn.BackColor = Color.Green;
            if (onSubmit)
            {
                loadSmsOutcome();
            }
        }
        
        public void setSubmit(bool flag)
        {
            onSubmit = flag;
        }
    }
}
