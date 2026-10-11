
using System;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiVeNha01_DongHoDemNguoc : Form
    {
        // Sử dụng Timer của Windows Forms
        // Tránh lỗi CS0104 do trùng tên Timer
        private readonly System.Windows.Forms.Timer timer =
            new System.Windows.Forms.Timer();

        // Thời gian còn lại tính bằng giây
        private int thoiGianConLai = 0;

        // Kiểm tra đồng hồ đã bắt đầu hay chưa
        private bool daBatDau = false;

        public BaiVeNha01_DongHoDemNguoc()
        {
            InitializeComponent();

            // Timer chạy mỗi 1000ms = 1 giây
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // Mặc định 30 phút 00 giây
            cboPhut.SelectedItem = "30";
            cboGiay.SelectedItem = "00";

            thoiGianConLai = 30 * 60;

            HienThiThoiGian();
            CapNhatTrangThai();
        }

        // =====================================
        // HIỂN THỊ THỜI GIAN
        // =====================================
        private void HienThiThoiGian()
        {
            int phut = thoiGianConLai / 60;
            int giay = thoiGianConLai % 60;

            lblDongHo.Text = $"{phut:00}:{giay:00}";
        }

        // =====================================
        // TIMER ĐẾM NGƯỢC MỖI GIÂY
        // =====================================
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (thoiGianConLai > 0)
            {
                thoiGianConLai--;

                HienThiThoiGian();
            }

            // Khi thời gian về 0
            if (thoiGianConLai <= 0)
            {
                timer.Stop();

                thoiGianConLai = 0;
                daBatDau = false;

                HienThiThoiGian();
                CapNhatTrangThai();

                MessageBox.Show(
                    "Đã hết thời gian!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // =====================================
        // NÚT BẮT ĐẦU / TIẾP TỤC
        // =====================================
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            // Nếu đồng hồ chưa bắt đầu
            if (!daBatDau)
            {
                int phut = int.Parse(cboPhut.Text);
                int giay = int.Parse(cboGiay.Text);

                // Chuyển phút và giây thành tổng số giây
                thoiGianConLai = phut * 60 + giay;

                // Kiểm tra thời gian hợp lệ
                if (thoiGianConLai <= 0)
                {
                    MessageBox.Show(
                        "Vui lòng chọn thời gian lớn hơn 0!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                daBatDau = true;

                HienThiThoiGian();
            }

            // Bắt đầu hoặc tiếp tục đếm
            timer.Start();

            CapNhatTrangThai();
        }

        // =====================================
        // NÚT TẠM DỪNG
        // =====================================
        private void btnTamDung_Click(object sender, EventArgs e)
        {
            timer.Stop();

            CapNhatTrangThai();
        }

        // =====================================
        // NÚT ĐẶT LẠI
        // =====================================
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            // Dừng Timer
            timer.Stop();

            // Đưa về trạng thái ban đầu
            daBatDau = false;

            // Lấy lại thời gian từ ComboBox
            int phut = int.Parse(cboPhut.Text);
            int giay = int.Parse(cboGiay.Text);

            thoiGianConLai = phut * 60 + giay;

            HienThiThoiGian();
            CapNhatTrangThai();
        }

        // =====================================
        // CẬP NHẬT TRẠNG THÁI NÚT
        // =====================================
        private void CapNhatTrangThai()
        {
            // Khi Timer đang chạy
            if (timer.Enabled)
            {
                btnBatDau.Enabled = false;
                btnTamDung.Enabled = true;

                cboPhut.Enabled = false;
                cboGiay.Enabled = false;
            }
            else
            {
                btnBatDau.Enabled = true;
                btnTamDung.Enabled = false;

                // Nếu đã bắt đầu nhưng đang tạm dừng
                if (daBatDau)
                {
                    btnBatDau.Text = "Tiếp tục";

                    cboPhut.Enabled = false;
                    cboGiay.Enabled = false;
                }
                else
                {
                    btnBatDau.Text = "Bắt đầu";

                    cboPhut.Enabled = true;
                    cboGiay.Enabled = true;
                }
            }
        }

        // =====================================
        // NÚT THOÁT
        // =====================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            timer.Stop();

            Close();
        }

        // =====================================
        // GIẢI PHÓNG TIMER KHI ĐÓNG FORM
        // =====================================
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer.Stop();
            timer.Dispose();

            base.OnFormClosed(e);
        }
    }
}
