using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTTH03
{
    public partial class TransMoney : Form
    {

        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, number, bank, name, bankDefault;
        int totalMoneyFrom, totalMoneyTo;

        public TransMoney()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            bankSelect.Items.Add("METAN");
            bankSelect.Items.Add("BIDV");
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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME,BANK FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                this.username = reader.GetString(0);
                bankDefault = reader.GetString(1);
            }
            reader.Close();


            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG WHERE USERNAME = '" + username + "' AND SAVING='F'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(7);
                sourceSelect.Items.Add(tmp);

            }
            reader.Close();

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            number = txtReceiveNum.Text;
            bank = bankSelect.Text;
            if (bankSelect.Text == "")
            {
                bank = bankDefault;
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT COUNT(*) FROM KHACHHANG WHERE STK = '" + number + "' AND BANK = '" + bank + "'";
            sqlCmd.Connection = sqlCon;
            // Thực hiện truy vấn và kiểm tra số lượng bản ghi trả về
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count==0)
            {
                receiveName.Visible = true;
                receiveName.Text = "CAN'T FOUND";
                receiveName.ForeColor = Color.DarkRed;
                return;
            }

            sqlCmd.CommandText = "SELECT * FROM KHACHHANG WHERE STK = '" + number + "' AND BANK = '" + bank + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString(1);
                receiveName.Text = name;
                receiveName.ForeColor = Color.Green;
                receiveName.Visible = true;
            }
            reader.Close();
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            // Số nguyên từ 0 đến 100
            int MaGD = GetRandomInteger(0, 10000);
            string tkNguon = sourceSelect.Text;
            bank = bankSelect.Text;
            if (bankSelect.Text == "")
            {
                bank = bankDefault;
            }
            number = txtReceiveNum.Text;
            string money = txtMoney.Text;
            string content = txtContent.Text;

            if (!isValid(tkNguon, bank, number, money, content))
            {
                return;
            }

            int result = int.Parse(money);

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strcCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }



            DateTime currentTime = DateTime.Now;

            SqlCommand sqlCmd = new SqlCommand();


            //LẤY THONG TIN TÀI KHOẢN NGUỒN
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG WHERE STK = '" + tkNguon + "'";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                totalMoneyFrom = reader.GetInt32(9);
            }
            reader.Close();
            totalMoneyFrom = totalMoneyFrom - result;
            if (totalMoneyFrom < 0)
            {
                MessageBox.Show("You are transfering an amount of money that exceeds the amount you currently have in your account!!", "Error");
                return;
            }

            //LẤY THONG TIN TÀI KHOẢN NHẬN
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG WHERE STK = '" + number + "'";
            sqlCmd.Connection = sqlCon;
            reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                totalMoneyTo = reader.GetInt32(9);
            }
            reader.Close();
            totalMoneyTo = totalMoneyTo + result;

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO HOADON VALUES(" + MaGD + ",'" + tkNguon + "'," + result + ",'" + name + "','" + number + "','" + bank + "','" + content + "','" + currentTime + "','" + username + "'," + totalMoneyFrom + "," + totalMoneyTo + ",'N')";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                //MessageBox.Show("Transmited money successfully", "Succeed");
                txtMoney.Text = "0";
                txtContent.Text = "";

            }
            else
            {
                MessageBox.Show("Somthing went wrong", "Error");
                return;
            }


            //Trừ tiền tài khoản nguồn
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE KHACHHANG SET TIEN = TIEN-" + result + " WHERE STK = '" + tkNguon + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            //Công tiền tài khoản thụ hưởng
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE KHACHHANG SET TIEN = TIEN+" + result + " WHERE STK = '" + number + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            Receipt receipt = new Receipt();
            receipt.Show();
        }

        private bool isValid(string tkNguon, string bank, string number, string money, string content)
        {
            if (tkNguon == "")
            {
                MessageBox.Show("Please fill out source account!", "Error");
                return false;
            }
            if (bank == "" && bankSelect.Enabled == true)
            {
                MessageBox.Show("Please fill out name of bank!", "Error");
                return false;
            }
            if (number == "")
            {
                MessageBox.Show("Please fill out the number of account!", "Error");
                return false;
            }
            if (money == "")
            {
                MessageBox.Show("Please fill out the money!", "Error");
                return false;
            }
            if (content == "")
            {
                MessageBox.Show("Please fill out the content!", "Error");
                return false;
            }
            return true;

        }

        private int GetRandomInteger(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue + 1);
        }



        private void internalPanel_Click(object sender, EventArgs e)
        {
            externalPanel.BackColor = Color.LightSeaGreen;
            internalPanel.BackColor = Color.SeaGreen;
            bankSelect.Text = "";
            bankSelect.DropDownStyle = ComboBoxStyle.DropDownList; // Chỉ đọc
            bankSelect.Enabled = false;
        }

        private void externalPanel_Click(object sender, EventArgs e)
        {
            internalPanel.BackColor = Color.LightSeaGreen;
            externalPanel.BackColor = Color.SeaGreen;
            bankSelect.Text = "";
            bankSelect.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox có mục được chọn không
            if (sourceSelect.SelectedItem != null)
            {
                // Lấy giá trị của mục được chọn
                string selectedValue = sourceSelect.SelectedItem.ToString();

                // Kiểm tra giá trị và thay đổi thuộc tính Visible của Label
                txtAvailable.Visible = true;
                txtMoneyAvai.Visible = true;

                // MỞ KẾT NỐI
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
                sqlCmd.CommandText = "SELECT TIEN FROM KHACHHANG WHERE STK='" + selectedValue + "'";
                sqlCmd.Connection = sqlCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMoneyAvai.Text = reader.GetInt32(0).ToString() + "VND";
                }
                reader.Close();
            }
            else
            {
                txtAvailable.Visible = false;
                txtMoneyAvai.Visible = false;
            }
        }

        public void GetData(string data)
        {
            // Tách chuỗi thành mảng các phần tử dựa trên khoảng trắng
            string[] parts = data.Split(' ');
            txtReceiveNum.Text = parts[0];
            bankSelect.Text = parts[1];
        }

        private void QRicon_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.Show();
            this.Close();
        }
    }
}
