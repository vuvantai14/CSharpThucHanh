
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiVeNha01_TuDien : Form
    {
        // Lưu danh sách từ điển trong bộ nhớ
        private readonly List<KeyValuePair<string, string>> tuDien =
            new List<KeyValuePair<string, string>>();

        public BaiVeNha01_TuDien()
        {
            InitializeComponent();
            TaoDuLieu();
            TaiDanhSachTu();
        }

        // Tạo dữ liệu từ điển mẫu
        private void TaoDuLieu()
        {
            ThemTu("Apple", "Quả táo");
            ThemTu("Banana", "Quả chuối");
            ThemTu("Book", "Quyển sách");
            ThemTu("Cat", "Con mèo");
            ThemTu("Computer", "Máy tính");
            ThemTu("Dog", "Con chó");
            ThemTu("Family", "Gia đình");
            ThemTu("Flower", "Bông hoa");
            ThemTu("Friend", "Bạn bè");
            ThemTu("Good", "Tốt");
            ThemTu("Hello", "Xin chào");
            ThemTu("House", "Ngôi nhà");
            ThemTu("Love", "Tình yêu");
            ThemTu("Mother", "Mẹ");
            ThemTu("Father", "Cha");
            ThemTu("School", "Trường học");
            ThemTu("Student", "Sinh viên");
            ThemTu("Teacher", "Giáo viên");
            ThemTu("Water", "Nước");
            ThemTu("Window", "Cửa sổ");
            ThemTu("Work", "Công việc");
            ThemTu("Table", "Cái bàn");
            ThemTu("Chair", "Cái ghế");
            ThemTu("Phone", "Điện thoại");
            ThemTu("Music", "Âm nhạc");
            ThemTu("Food", "Thức ăn");
            ThemTu("Happy", "Vui vẻ");
            ThemTu("Beautiful", "Đẹp");
            ThemTu("City", "Thành phố");
            ThemTu("Country", "Đất nước");
        }

        private void ThemTu(string tiengAnh, string tiengViet)
        {
            tuDien.Add(
                new KeyValuePair<string, string>(
                    tiengAnh, tiengViet));
        }

        // Kiểm tra chế độ từ điển
        private bool LaAnhViet()
        {
            return radAnhViet.Checked;
        }

        // Lấy từ khóa theo chế độ
        private string LayTu(
            KeyValuePair<string, string> item)
        {
            return LaAnhViet() ? item.Key : item.Value;
        }

        // Lấy nghĩa theo chế độ
        private string LayNghia(
            KeyValuePair<string, string> item)
        {
            return LaAnhViet() ? item.Value : item.Key;
        }

        // Tải danh sách từ vào ComboBox
        private void TaiDanhSachTu()
        {
            string tuDangNhap = cboTuCanTra.Text;

            cboTuCanTra.Items.Clear();

            var danhSach = tuDien
                .Select(item => LayTu(item))
                .OrderBy(s => s, StringComparer.CurrentCultureIgnoreCase);

            foreach (string tu in danhSach)
            {
                cboTuCanTra.Items.Add(tu);
            }

            cboTuCanTra.Text = "";
            txtNghia.Text = "";
            lblTrangThai.Text =
                "Tổng số từ: " + cboTuCanTra.Items.Count;
        }

        // Đổi chế độ Anh - Việt / Việt - Anh
        private void radTuDien_CheckedChanged(
            object sender, EventArgs e)
        {
            if (!radAnhViet.Checked && !radVietAnh.Checked)
                return;

            TaiDanhSachTu();
            cboTuCanTra.Focus();
        }

        // Tìm từ khớp chính xác
        private KeyValuePair<string, string>? TimTu(
            string tuCanTim)
        {
            foreach (var item in tuDien)
            {
                if (string.Equals(
                    LayTu(item),
                    tuCanTim,
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }

        // Tra từ
        private void TraTu()
        {
            string tu = cboTuCanTra.Text.Trim();

            if (tu == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập từ cần tra!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cboTuCanTra.Focus();
                return;
            }

            var ketQua = TimTu(tu);

            if (ketQua.HasValue)
            {
                txtNghia.Text = LayNghia(ketQua.Value);
                lblTrangThai.Text = "Tra cứu thành công!";
            }
            else
            {
                txtNghia.Text = "";
                lblTrangThai.Text = "Không tìm thấy từ!";

                MessageBox.Show(
                    "Không tìm thấy từ trong từ điển!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Nút Enter
        private void btnEnter_Click(
            object sender, EventArgs e)
        {
            TraTu();
        }

        // Nhấn Enter trên ComboBox
        private void cboTuCanTra_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TraTu();
                e.SuppressKeyPress = true;
            }
        }

        // Nhấp đúp để tra từ
        private void cboTuCanTra_DoubleClick(
            object sender, EventArgs e)
        {
            TraTu();
        }

        // Khi thay đổi từ đang nhập
        private void cboTuCanTra_TextUpdate(
            object sender, EventArgs e)
        {
            txtNghia.Clear();
            lblTrangThai.Text = "Đang nhập từ cần tra...";
        }

        // Xóa dữ liệu tra cứu
        private void btnLamMoi_Click(
            object sender, EventArgs e)
        {
            cboTuCanTra.Text = "";
            txtNghia.Clear();
            cboTuCanTra.Focus();

            lblTrangThai.Text = "Sẵn sàng tra cứu";
        }

        // Thoát chương trình
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
