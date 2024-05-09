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
    public partial class ChangeDefault : UserControl
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string usernameGet, stkGet, bankGet;

        // Định nghĩa một sự kiện để thông báo khi đóng UserControl2
        public event EventHandler CloseButtonClicked;


        public ChangeDefault()
        {
            InitializeComponent();
            loadAccount();
        }

        public void loadAccount()
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
                usernameGet = reader.GetString(0);
                stkGet = reader.GetString(1);
                bankGet = reader.GetString(2);
            }
            reader.Close();


            string stk;
            int money;
            bool isDefault = false;

            sqlCmd.CommandText = "SELECT STK,TIEN,STKDefault FROM KHACHHANG WHERE KHACHHANG.USERNAME = '" + usernameGet + "' AND SAVING='F' ORDER BY TIMECREATE DESC";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            accList.Controls.Clear();
            while (reader.Read())
            {
                stk = reader.GetString(0);
                money = reader.GetInt32(1);
                if (reader.GetString(2) == "T")
                {
                    isDefault = true;
                }
                else
                {
                    isDefault = false;
                }


                //CLEAR FLOWLAYOUTPANEL
                // TẠO ITEM ACCOUNT
                AccountSelectDefault accountItem = new AccountSelectDefault();
                accountItem.loadAccount(stk, money, isDefault);
                accList.Controls.Add(accountItem);

                // Gán sự kiện CheckedChanged cho RadioButton trong UserControl
                RadioButton radioButton = accountItem.Controls.OfType<RadioButton>().FirstOrDefault();
                if (radioButton != null)
                {
                    radioButton.CheckedChanged += RadioButton_CheckedChanged;
                }


            }
            reader.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            foreach (Control control in accList.Controls)
            {
                if (control is AccountSelectDefault account)
                {
                    // Tìm RadioButton trong UserControl
                    RadioButton radioButton = account.Controls.OfType<RadioButton>().FirstOrDefault();
                    // Kiểm tra xem RadioButton có được chọn không
                    if (radioButton != null && radioButton.Checked)
                    {
                        account.updateDefault(true);
                    }
                    else
                    {
                        account.updateDefault(false);
                    }
                }
            }

            // Khi nút Close được bấm, kích hoạt sự kiện CloseButtonClicked
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            
        }



        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Lấy RadioButton được chọn
            RadioButton selectedRadioButton = sender as RadioButton;

            // Nếu RadioButton không phải là null
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                // Lấy UserControl chứa RadioButton được chọn
                UserControl selectedUserControl = selectedRadioButton.Parent as UserControl;

                // Lấy FlowLayoutPanel chứa UserControl
                FlowLayoutPanel flowLayoutPanel = selectedUserControl.Parent as FlowLayoutPanel;

                // Duyệt qua tất cả các UserControl trong FlowLayoutPanel và đặt Checked=false cho RadioButton
                foreach (Control control in flowLayoutPanel.Controls)
                {
                    if (control is UserControl userControl && userControl != selectedUserControl)
                    {
                        // Tìm RadioButton trong UserControl và đặt Checked=false
                        RadioButton radioButtonInOtherControl = userControl.Controls.OfType<RadioButton>().FirstOrDefault();
                        if (radioButtonInOtherControl != null)
                        {
                            radioButtonInOtherControl.Checked = false;
                        }
                    }
                }
            }
        }

    }
}
