
using System;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiTap01_QuanLySinhVien : Form
    {
        public BaiTap01_QuanLySinhVien()
        {
            InitializeComponent();
        }

        // Tự động nạp danh sách dân tộc khi mở Form
        private void BaiTap01_QuanLySinhVien_Load(
            object sender, EventArgs e)
        {
            cboDanToc.Items.AddRange(new object[]
            {
                "Kinh", "Hoa", "Khmer", "Chăm",
                "Tày", "Thái", "Mường", "Nùng",
                "Dao", "H'Mông", "Ê Đê", "Gia Rai"
            });

            cboDanToc.SelectedIndex = 0;
            CapNhatSoLuong();
        }

        // Kiểm tra mã sinh viên đã tồn tại
        private bool KiemTraTrungMa(string maSV)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (string.Equals(item.Text, maSV,
                    StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                cboDanToc.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string maSV = txtMaSV.Text.Trim();

            if (KiemTraTrungMa(maSV))
            {
                MessageBox.Show(
                    "Mã sinh viên đã tồn tại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ListViewItem sv = new ListViewItem(maSV);

            sv.SubItems.Add(txtHoTen.Text.Trim());
            sv.SubItems.Add(cboDanToc.Text);

            lvSinhVien.Items.Add(sv);

            MessageBox.Show("Thêm sinh viên thành công!");

            LamMoi();
            CapNhatSoLuong();
        }

        // Hiển thị thông tin khi chọn sinh viên
        private void lvSinhVien_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            txtMaSV.Text = sv.SubItems[0].Text;
            txtHoTen.Text = sv.SubItems[1].Text;
            cboDanToc.Text = sv.SubItems[2].Text;

            // Không cho phép sửa mã sinh viên
            txtMaSV.ReadOnly = true;
        }

        // Sửa thông tin sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            // Chỉ sửa họ tên và dân tộc
            sv.SubItems[1].Text = txtHoTen.Text.Trim();
            sv.SubItems[2].Text = cboDanToc.Text;

            MessageBox.Show(
                "Cập nhật thông tin thành công!");

            LamMoi();
            lvSinhVien.SelectedItems.Clear();
        }

        // Xóa sinh viên được chọn
        private void XoaSinhVien()
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(
                    lvSinhVien.SelectedItems[0]);

                LamMoi();
                CapNhatSoLuong();

                MessageBox.Show(
                    "Xóa sinh viên thành công!");
            }
        }

        // Xóa bằng Button
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        // Xóa bằng menu chuột phải
        private void mnuXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        // Chọn đúng dòng khi nhấn chuột phải
        private void lvSinhVien_MouseDown(
            object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem? item =
                    lvSinhVien.GetItemAt(e.X, e.Y);

                lvSinhVien.SelectedItems.Clear();

                if (item != null)
                {
                    item.Selected = true;
                    item.Focused = true;
                }
            }
        }

        // Làm mới dữ liệu nhập
        private void LamMoi()
        {
            txtMaSV.ReadOnly = false;
            txtMaSV.Clear();
            txtHoTen.Clear();

            if (cboDanToc.Items.Count > 0)
                cboDanToc.SelectedIndex = 0;

            txtMaSV.Focus();
        }

        private void btnLamMoi_Click(
            object sender, EventArgs e)
        {
            lvSinhVien.SelectedItems.Clear();
            LamMoi();
        }

        // Cập nhật số lượng sinh viên
        private void CapNhatSoLuong()
        {
            lblSoLuong.Text =
                "Tổng số sinh viên: " + lvSinhVien.Items.Count;
        }

        // Hỏi xác nhận trước khi đóng Form
        private void BaiTap01_QuanLySinhVien_FormClosing(
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
