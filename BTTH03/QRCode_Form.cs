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
    public partial class QRCode_Form : Form
    {
        public QRCode_Form()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void createQRcode(string data)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(data, QRCoder.QRCodeGenerator.ECCLevel.H);
            txtStk.Text = data;
            var code = new QRCoder.QRCode(qr1);
            pbQR.Image = code.GetGraphic(10);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
