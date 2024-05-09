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
    public partial class Message : UserControl
    {
        public Message()
        {
            InitializeComponent();
        }

        public void loadMessage(string tkNguon, string currBank,int money, int finalMoney, DateTime time, string toBank , string tkCuoi ,string content,bool isOut)
        {
            string sign;
            if (isOut)
            {
                 sign = "-";
            }
            else { sign = "+"; }
            sms.Text = "Account "+tkNguon+" in "+currBank+" "+sign+money+"VND on "+time+". Account balance: "+finalMoney+"VND. From "+ toBank +" "+ tkCuoi+". Message: " + content;
        }
    }
}
