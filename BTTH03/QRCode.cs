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
    public partial class QRCode : UserControl
    {
        public QRCode()
        {
            InitializeComponent();
        }

        public void createQRcode(string data)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            var qr1 = qr.CreateQrCode(data, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(qr1);
            pbQR.Image = code.GetGraphic(10);
        }




    }
}
