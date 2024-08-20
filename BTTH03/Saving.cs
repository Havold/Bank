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
    public partial class Saving : Form
    {

        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string username, number, bank, name, bankDefault;
        int totalMoneyFrom, totalMoneyTo;

        public Saving()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            depositSelect.Items.Add("Corroborate - 0.10%");
            depositSelect.Items.Add("7 days - 0.20%");
            depositSelect.Items.Add("14 days - 0.20%");
            depositSelect.Items.Add("1 month - 3.10%");
            depositSelect.Items.Add("2 months - 3.10%");
            depositSelect.Items.Add("3 months - 3.40%");
            depositSelect.Items.Add("6 months - 4%");
            depositSelect.Items.Add("9 months - 4%");
            depositSelect.Items.Add("12 months - 5.50%");
            depositSelect.Items.Add("24 months - 5.30%");
            depositSelect.Items.Add("36 months - 5.30%");
            depositSelect.Items.Add("48 months - 5.30%");
            depositSelect.Items.Add("60 months - 5.30%");

            intersetSelect.Items.Add("Interest paid to source");

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
            sqlCmd.CommandText = "SELECT TOP 1 USERNAME, BANK, NAME FROM ONLINE ORDER BY TIMEIN DESC";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                username = reader.GetString(0);
                bankDefault = reader.GetString(1);
                name = reader.GetString(2);
            }
            reader.Close();

            /*SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT USERNAME,BANK,NAME FROM ONLINE";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                this.username = reader.GetString(0);
                bankDefault = reader.GetString(1);
                name = reader.GetString(2);
            }
            reader.Close();*/


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

        private void completedBtn_Click(object sender, EventArgs e)
        {
            // Số nguyên từ 0 đến 100
            int MaGD = GetRandomInteger(0, 10000);
            string tkNguon = sourceSelect.Text;
            string money = txtMoney.Text;
            //string depositTerm = depositSelect.Text;

            // Lấy mục được chọn trong ComboBox
            string depositTerm = depositSelect.SelectedItem.ToString();

            // Phân tích và trích xuất con số từ chuỗi
            string interestRateString = depositTerm.Substring(depositTerm.LastIndexOf(" ") + 1, depositTerm.LastIndexOf("%") - depositTerm.LastIndexOf(" ") - 1);

            double interesRate = ConvertStringToDouble(interestRateString);

            if (!isValid(tkNguon, depositTerm, money, intersetSelect.Text))
            {
                return;
            }

            string content = "Open saving with " + depositTerm + " and " + intersetSelect.Text;


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

            //TẠO HÓA ĐƠN
            // Tạo đối tượng Random
            Random random = new Random();

            // Tạo một dãy số ngẫu nhiên với 10 chữ số
            number = GenerateRandomNumber(random, 10);

            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO HOADON VALUES(" + MaGD + ",'" + tkNguon + "'," + result + ",'N','" + number + "','" + bankDefault + "','" + content + "','" + currentTime + "','" + username + "'," + totalMoneyFrom + "," + result + ",'N')";
            sqlCmd.Connection = sqlCon;

            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                //MessageBox.Show("Open savings successfully", "Succeed");
                txtMoney.Text = "0";

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

            // THÊM VÀO KHACHHANG 1 STK TIẾT KIỆM
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO KHACHHANG VALUES('" + username + "','" + name + "','N','"+currentTime+"','N','N','N','" + number + "','" + bankDefault + "'," + result + ",'N','" + currentTime + "','T','"+interesRate+"')";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();

            Receipt receipt = new Receipt();
            receipt.Show();
        }

        private int GetRandomInteger(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue + 1);
        }

        private bool isValid(string tkNguon, string depositTerm, string money, string payment)
        {
            if (tkNguon == "")
            {
                MessageBox.Show("Please select source account!", "Error");
                return false;
            }

            if (money == "")
            {
                MessageBox.Show("Please fill out the money!", "Error");
                return false;
            }

            if (depositTerm == "")
            {
                MessageBox.Show("Please select the deposit term!", "Error");
                return false;
            }

            if (payment == "")
            {
                MessageBox.Show("Please select the interest payment!", "Error");
                return false;
            }
            return true;

        }

        private static string GenerateRandomNumber(Random random, int length)
        {
            char[] digits = new char[length];

            // Đảm bảo chữ số đầu tiên khác 0 để tránh số bắt đầu bằng 0
            digits[0] = (char)('1' + random.Next(9));

            // Tạo các chữ số ngẫu nhiên cho các vị trí còn lại
            for (int i = 1; i < length; i++)
            {
                digits[i] = (char)('0' + random.Next(10));
            }

            // Chuyển mảng ký tự thành chuỗi
            return new string(digits);
        }

        private double ConvertStringToDouble(string stringValue)
        {
            double result;

            // Sử dụng double.TryParse để chuyển đổi kiểu string sang double
            if (double.TryParse(stringValue, out result))
            {
                return result;
            }
            else
            {
                // Nếu không thành công, có thể xử lý hoặc trả về một giá trị mặc định
                Console.WriteLine("Failed to convert string to double. Returning 0.0 as default.");
                return 0.0;
            }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
