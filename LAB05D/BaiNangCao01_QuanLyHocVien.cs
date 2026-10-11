
using System;
using System.Linq;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiNangCao01_QuanLyHocVien : Form
    {
        public BaiNangCao01_QuanLyHocVien()
        {
            InitializeComponent();
            CapNhatSoLuong();
        }

        // Mở Form nhập học viên
        private void mnuNhapHocVien_Click(object sender, EventArgs e)
        {
            using (var form = new BaiNangCao01_NhapHocVien())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    string hoTen = form.HoTen;
                    string lop = form.Lop;

                    if (lop == "Lớp A")
                        lstLopA.Items.Add(hoTen);
                    else
                        lstLopB.Items.Add(hoTen);

                    CapNhatSoLuong();
                }
            }
        }

        // Chuyển các học viên đang chọn
        private void ChuyenHocVien(ListBox nguon, ListBox dich)
        {
            if (nguon.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên cần chuyển!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Sao chép danh sách được chọn
            var danhSach = nguon.SelectedItems
                .Cast<object>()
                .ToList();

            foreach (object hocVien in danhSach)
            {
                dich.Items.Add(hocVien);
                nguon.Items.Remove(hocVien);
            }

            CapNhatSoLuong();
        }

        // Chuyển từ lớp B sang lớp A
        private void mnuChuyenLopA_Click(object sender, EventArgs e)
        {
            ChuyenHocVien(lstLopB, lstLopA);
        }

        // Chuyển từ lớp A sang lớp B
        private void mnuChuyenLopB_Click(object sender, EventArgs e)
        {
            ChuyenHocVien(lstLopA, lstLopB);
        }

        // Xóa học viên ở cả hai lớp
        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0 &&
                lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn học viên cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa các học viên đã chọn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
                return;

            foreach (var item in lstLopA.SelectedItems
                .Cast<object>().ToList())
            {
                lstLopA.Items.Remove(item);
            }

            foreach (var item in lstLopB.SelectedItems
                .Cast<object>().ToList())
            {
                lstLopB.Items.Remove(item);
            }

            CapNhatSoLuong();
        }

        // Hiển thị tổng số học viên
        private void CapNhatSoLuong()
        {
            lblSoLuongA.Text =
                "Số học viên lớp A: " + lstLopA.Items.Count;

            lblSoLuongB.Text =
                "Số học viên lớp B: " + lstLopB.Items.Count;
        }

        // Menu Kết thúc
        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Xác nhận trước khi đóng Form
        private void BaiNangCao01_QuanLyHocVien_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn kết thúc chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
