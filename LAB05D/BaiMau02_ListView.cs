
using System;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiMau02_ListView : Form
    {
        public BaiMau02_ListView()
        {
            InitializeComponent();
        }

        // Thêm sinh viên vào ListView
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string lop = txtLop.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (maSV == "" || hoTen == "" || lop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã sinh viên
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (item.Text.Equals(
                    maSV,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã sinh viên đã tồn tại!");
                    txtMaSV.Focus();
                    return;
                }
            }

            // Tạo dòng mới
            ListViewItem sv = new ListViewItem(maSV);
            sv.SubItems.Add(hoTen);
            sv.SubItems.Add(lop);

            // Thêm vào ListView
            lvSinhVien.Items.Add(sv);

            MessageBox.Show(
                "Thêm sinh viên thành công!",
                "Thông báo");

            LamMoi();
            CapNhatSoLuong();
        }

        // Chọn sinh viên để hiển thị lên TextBox
        private void lvSinhVien_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            txtMaSV.Text = sv.Text;
            txtHoTen.Text = sv.SubItems[1].Text;
            txtLop.Text = sv.SubItems[2].Text;
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

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string lop = txtLop.Text.Trim();

            if (maSV == "" || hoTen == "" || lop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            // Kiểm tra mã SV trùng với sinh viên khác
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (item != sv &&
                    item.Text.Equals(
                        maSV,
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã sinh viên đã tồn tại!");
                    return;
                }
            }

            // Cập nhật dữ liệu
            sv.Text = maSV;
            sv.SubItems[1].Text = hoTen;
            sv.SubItems[2].Text = lop;

            MessageBox.Show(
                "Cập nhật sinh viên thành công!");

            LamMoi();
            lvSinhVien.SelectedItems.Clear();
        }

        // Xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận xóa",
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

        // Làm mới dữ liệu nhập
        private void LamMoi()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
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

        // Thoát chương trình
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
