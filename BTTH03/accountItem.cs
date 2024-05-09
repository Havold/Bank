using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BTTH03
{
    public partial class accountItem : UserControl
    {
        string bankGet, stkGet;

        public accountItem()
        {
            InitializeComponent();
        }

        public void loadAccount(string account, int money, DateTime date, bool isSaving, double rate, double interestMoney,string bank)
        {
            bankGet = bank;
            stkGet = account;
            txtAccount.Text = account;
            txtMoney.Text = money.ToString() + " VND";
            string dateStr = date.ToString();
            txtDate.Text = dateStr;
            if (isSaving)
            {
                interestTitle.Visible = true;
                txtInterestMoney.Visible = true;
                rateTitle.Visible = true;
                txtRate.Visible = true;
                txtRate.Text = rate.ToString();
                txtInterestMoney.Text = interestMoney.ToString() + " VND";
            }
        }

        private void QRicon_Click(object sender, EventArgs e)
        {
                QRCode_Form qrCode = new QRCode_Form();
                string qr = stkGet + " " + bankGet;
                qrCode.Show();
                qrCode.createQRcode(qr);
            
        }
    }
}
