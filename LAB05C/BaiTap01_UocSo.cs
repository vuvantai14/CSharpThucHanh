
using System;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiTap01_UocSo : Form
    {
        public BaiTap01_UocSo()
        {
            InitializeComponent();
        }

        // Cập nhật số vào ComboBox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapSo.Text.Trim(), out int n)
                || n <= 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số nguyên dương hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhapSo.Focus();
                return;
            }

            // Kiểm tra số đã tồn tại
            if (cboDanhSach.Items.Contains(n))
            {
                MessageBox.Show(
                    "Số này đã tồn tại trong danh sách!");
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            cboDanhSach.Items.Add(n);

            txtNhapSo.Clear();
            txtNhapSo.Focus();

            cboDanhSach.SelectedItem = n;
        }

        // Khi chọn số trong ComboBox
        private void cboDanhSach_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            lstUocSo.Items.Clear();

            if (cboDanhSach.SelectedItem == null)
                return;

            int n = (int)cboDanhSach.SelectedItem;

            for (int i = 1; i <= n / i; i++)
            {
                if (n % i == 0)
                {
                    lstUocSo.Items.Add(i);
                }
            }

            // Thêm các ước lớn theo thứ tự tăng dần
            int can = (int)Math.Sqrt(n);

            for (int i = can; i >= 1; i--)
            {
                if (n % i == 0)
                {
                    int uoc = n / i;

                    if (uoc != i)
                        lstUocSo.Items.Add(uoc);
                }
            }
        }

        // Tính tổng các ước số
        private void btnTongUoc_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach())
                return;

            long tong = 0;

            foreach (int uoc in lstUocSo.Items)
            {
                tong += uoc;
            }

            MessageBox.Show(
                "Tổng các ước số là: " + tong,
                "Kết quả");
        }

        // Đếm các ước số chẵn
        private void btnUocChan_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach())
                return;

            int dem = 0;

            foreach (int uoc in lstUocSo.Items)
            {
                if (uoc % 2 == 0)
                    dem++;
            }

            MessageBox.Show(
                "Số lượng ước số chẵn: " + dem,
                "Kết quả");
        }

        // Kiểm tra số nguyên tố
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Đếm ước số nguyên tố
        private void btnUocNguyenTo_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach())
                return;

            int dem = 0;

            foreach (int uoc in lstUocSo.Items)
            {
                if (LaSoNguyenTo(uoc))
                    dem++;
            }

            MessageBox.Show(
                "Số lượng ước số nguyên tố: " + dem,
                "Kết quả");
        }

        // Kiểm tra danh sách ước số
        private bool KiemTraDanhSach()
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn số để tính!",
                    "Thông báo");
                return false;
            }

            return true;
        }

        // Nút thoát
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }

        // Xác nhận thoát
        private void BaiTap01_UocSo_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
