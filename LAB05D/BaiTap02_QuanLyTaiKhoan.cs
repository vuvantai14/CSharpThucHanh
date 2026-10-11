
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiTap02_QuanLyTaiKhoan : Form
    {
        private bool dangThem = false;

        public BaiTap02_QuanLyTaiKhoan()
        {
            InitializeComponent();
            ThietLapBanDau();
        }

        // Trạng thái ban đầu theo yêu cầu
        private void ThietLapBanDau()
        {
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            dangThem = false;

            XoaNhapLieu();
            KhoaNhapLieu(true);
            CapNhatDanhSach();
        }

        private void KhoaNhapLieu(bool khoa)
        {
            txtSoTaiKhoan.ReadOnly = khoa;
            txtTenKhachHang.ReadOnly = khoa;
            txtDiaChi.ReadOnly = khoa;
            txtSoTien.ReadOnly = khoa;
        }

        private void XoaNhapLieu()
        {
            txtSoTaiKhoan.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Nút Thêm chuyển thành Hủy
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!dangThem)
            {
                dangThem = true;
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

                lvTaiKhoan.SelectedItems.Clear();
                XoaNhapLieu();
                KhoaNhapLieu(false);
                txtSoTaiKhoan.Focus();
            }
            else
            {
                ThietLapBanDau();
            }
        }

        // Kiểm tra thông tin nhập
        private bool KiemTraDuLieu(out decimal soTien)
        {
            soTien = 0;

            if (string.IsNullOrWhiteSpace(txtSoTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhachHang.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(
                    txtSoTien.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out soTien) || soTien < 0)
            {
                MessageBox.Show(
                    "Số tiền phải là số không âm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoTien.Focus();
                return false;
            }

            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text.Equals(
                    txtSoTaiKhoan.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Số tài khoản đã tồn tại!");
                    txtSoTaiKhoan.Focus();
                    return false;
                }
            }

            return true;
        }

        // Lưu tài khoản vào ListView
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!dangThem)
                return;

            if (!KiemTraDuLieu(out decimal soTien))
                return;

            ListViewItem item = new ListViewItem(
                (lvTaiKhoan.Items.Count + 1).ToString());

            // Số tài khoản được lưu dạng chuỗi
            // để không mất số 0 ở đầu
            item.SubItems.Add(txtSoTaiKhoan.Text.Trim());
            item.SubItems.Add(txtTenKhachHang.Text.Trim());
            item.SubItems.Add(txtDiaChi.Text.Trim());
            item.SubItems.Add(soTien.ToString("N0"));

            // Lưu giá trị số tiền để tính tổng chính xác
            item.Tag = soTien;

            lvTaiKhoan.Items.Add(item);

            CapNhatDanhSach();
            ThietLapBanDau();

            MessageBox.Show(
                "Thêm tài khoản thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Chọn tài khoản để xem thông tin
        private void lvTaiKhoan_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (dangThem)
                return;

            bool coChon = lvTaiKhoan.SelectedItems.Count > 0;
            btnXoa.Enabled = coChon;

            if (!coChon)
                return;

            ListViewItem item = lvTaiKhoan.SelectedItems[0];

            txtSoTaiKhoan.Text = item.SubItems[1].Text;
            txtTenKhachHang.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = item.SubItems[4].Text;
        }

        // Xóa tài khoản đang chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
                return;

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa tài khoản này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
                return;

            ListViewItem item = lvTaiKhoan.SelectedItems[0];
            lvTaiKhoan.Items.Remove(item);

            ThietLapBanDau();

            MessageBox.Show("Xóa tài khoản thành công!");
        }

        // Đánh lại STT và tính tổng tiền
        private void CapNhatDanhSach()
        {
            decimal tongTien = 0;

            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                ListViewItem item = lvTaiKhoan.Items[i];

                // Đánh lại STT bắt đầu từ 1
                item.Text = (i + 1).ToString();

                if (item.Tag is decimal soTien)
                    tongTien += soTien;
            }

            txtTongTien.Text = tongTien.ToString("N0");
        }

        // Thoát Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
