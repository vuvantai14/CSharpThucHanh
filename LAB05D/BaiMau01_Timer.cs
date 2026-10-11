
using System;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiMau01_Timer : Form
    {
        public BaiMau01_Timer()
        {
            InitializeComponent();

            // Hiển thị thời gian ngay khi mở Form
            HienThiThoiGian();

            // Timer cập nhật sau mỗi 1 giây
            timer1.Interval = 1000;
            timer1.Start();
        }

        // Hàm hiển thị thời gian hiện tại
        private void HienThiThoiGian()
        {
            DateTime now = DateTime.Now;

            lblDongHo.Text =
                now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Sự kiện Tick của Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            HienThiThoiGian();
        }
    }
}
