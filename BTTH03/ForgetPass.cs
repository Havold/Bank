using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH03
{
    public partial class ForgetPass : Form
    {
        string strcCon = @"Data Source=LAPTOP-89QJAUQN\SQLEXPRESS;Initial Catalog=QLNganHang;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";
        SqlConnection sqlCon = null;
        string email;

        public ForgetPass()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;

            if (email.Trim() == "") { MessageBox.Show("Please enter the gmail!"); return; }

            if (!IsValidEmail(email))
            {
                return;
            }
            if (!CheckValid(email))
            {
                return;
            }
            else
            {
                MailMessage mail = new MailMessage();
                string mailFrom = "21521479@gm.uit.edu.vn";
                mail.From = new System.Net.Mail.MailAddress(mailFrom);
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "hyyg djmo ejlt licw");
                smtp.Host = "smtp.gmail.com";
                mail.To.Add(new MailAddress(email));
                mail.IsBodyHtml = true;
                string newPass = GenerateRandomString(8);
                mail.Subject = "Get new banking app password";
                mail.Body = "Your new password: " + newPass;
                //string query = "Update Taikhoan set MK = '" + mknew + "' where TenTK = '" + Properties.Settings.Default.getTenTK + "'";
                //Modify.command(query);
                smtp.Send(mail);
                MessageBox.Show("An email containing your new password has been sent to you!", "Succeed");
                updatePass(newPass, email);
                txtEmail.Text = "";

            }
        }

        private void updatePass(string newPass, string email)
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
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE KHACHHANG SET PASSWORD = '" + newPass + "' WHERE EMAIL = '" + email + "'";
            sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
        }

        static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] randomArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomArray);
        }

        private bool CheckValid(string email)
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
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT EMAIL FROM KHACHHANG";

            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string emailGet = reader.GetString(0);

                if (email == emailGet)
                {

                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            MessageBox.Show("This email has not been registered for use!", "Error");
            return false;

        }


        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(email, pattern);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text=="Email")
            {
                txtEmail.Text = string.Empty;
            }
        }

    }
}
