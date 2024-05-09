using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH03
{
    public partial class statementItem : UserControl
    {
        public statementItem()
        {
            InitializeComponent();
            
        }

        public void loadMessage(DateTime date, string content, int money, bool isOut)
        {
            string sign;
            if (isOut)
            {
                sign = "-";
                txtMoney.ForeColor = Color.DarkRed;
            }
            else { 
                sign = "+";
                txtMoney.ForeColor = Color.Green;

            }
            txtDate.Text = date.ToString();
            txtContent.Text = content;
            txtMoney.Text = sign + money.ToString();
            //sms.Text = "Account " + tkNguon + " in " + currBank + " " + sign + money + "VND on " + time + ". Account balance: " + finalMoney + "VND. From " + toBank + " " + tkCuoi + ". Message: " + content;
        }
    }
}
