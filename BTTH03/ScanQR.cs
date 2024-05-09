using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility; //Thư viện đọc barcode và QRCode

namespace BTTH03
{
    public partial class ScanQR : UserControl
    {
        public ScanQR()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection; //biến lưu thông tin các thiết bị viedo
        VideoCaptureDevice videoCaptureDevice; //Biến tương tác với thiết bí device


        private void startBtn_Click(object sender, EventArgs e)
        {
            //Khởi tạo thiết bị video, dựa trên thiết bị được chọn từ combobox Camera
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);

            // ĐĂNG KÝ NHẬN SỰ KIỆN FRAME MỚI TỪ CAMERA
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //Nhận frame hình ảnh từ camera
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap); // Đọc QRCode/ Barcode từ hình ảnh
            if (result != null)
            {
                txtCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtCode.Text = result.ToString();

                }
                ));
            }
            pbCam.Image = bitmap; // Hiển thị frame hình ảnh lên pictureBox
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    pbCam.Image = null;
                }
            }
        }

        private void ScanQR_Load(object sender, EventArgs e)
        {
            // LẤY DANH SÁCH TẤT CẢ CÁC THIẾT BỊ VIDEO ĐANG ĐƯỢC KẾT NỐI VỚI MÁY TÍNH
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // THÊM TÊ CỦA MỖI THIẾT BỊ VÀO DROPDOWN CỦA COMBO BOX CAMERA
            foreach (FilterInfo device in filterInfoCollection)
                cbCamera.Items.Add(device.Name);
            cbCamera.SelectedIndex = 0; // CHỌN THIẾT BỊ CÓ CHỈ SỐ ĐẦU TIÊN TRONG DANH SÁCH

        }
    }
}
