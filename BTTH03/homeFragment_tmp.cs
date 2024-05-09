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
    public partial class homeFragment_tmp : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, fullname, stk, bank;
        // Định nghĩa một sự kiện để thông báo về việc cần cập nhật dữ liệu
        //public event EventHandler DataUpdateRequested;

        public homeFragment_tmp()
        {
            InitializeComponent();
            loadAcc();
        }


        private void transPanel_Click(object sender, EventArgs e)
        {
            TransMoney transMoney = new TransMoney();
            transMoney.Show();
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
                stk = reader.GetString(2);
                bank = reader.GetString(3);
            }
            reader.Close();

            name.Text = fullname;
            txtAcc.Text = stk;
        }

        private void txtList_Click(object sender, EventArgs e)
        {
            AccountList accountList = new AccountList();
            accountList.Show();

        }

        private void txtAcc_Click(object sender, EventArgs e)
        {
            //popupPanel.Visible = true;
            inforAccPopUp.Visible = true;
            // Đăng ký sự kiện từ changeDefault
            inforAccPopUp.CloseButtonClicked += changeDefault_CloseButtonClicked;
        }

        private void changeDefault_CloseButtonClicked(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nút Close trong UserControl2 được bấm
            // Thực hiện các thao tác cập nhật bạn muốn ở đây
            loadAcc();

            // Đóng UserControl2 sau khi thực hiện xong các thao tác
            inforAccPopUp.Visible = false;
        }

        private void Savings_Click(object sender, EventArgs e)
        {
            Saving saving = new Saving();
            saving.Show();
        }
    }
}
