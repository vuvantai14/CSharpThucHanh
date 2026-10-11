
using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LAB05C
{
    public partial class BaiNangCao01_XuLyChuoi : Form
    {
        private readonly Random random = new Random();

        private readonly string[] HO =
        {
            "Lê", "Nguyễn", "Lý", "Trần", "Lâm",
            "Hồ", "Lai", "Huỳnh", "La"
        };

        private readonly string[] TENLOT =
        {
            "Quang", "Thành", "Ngọc", "Anh",
            "Xuân", "Bảo", "Cẩm", "Thị",
            "Kim", "Thái", "Hồng"
        };

        private readonly string[] TEN =
        {
            "Hà", "Danh", "Sơn", "Mai",
            "Thắng", "Kỳ", "Thành", "Lâm",
            "Tâm", "Phụng", "Thắm"
        };

        public BaiNangCao01_XuLyChuoi()
        {
            InitializeComponent();
        }

        // Sinh ngẫu nhiên 50 họ tên
        private void btnNgauNhien_Click(
            object sender, EventArgs e)
        {
            lstHoTen.Items.Clear();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[random.Next(HO.Length)];
                string tenLot = TENLOT[random.Next(TENLOT.Length)];
                string ten = TEN[random.Next(TEN.Length)];

                string hoTen = ho + " " + tenLot + " " + ten;
                lstHoTen.Items.Add(hoTen);
            }

            CapNhatSoLuong();
        }

        // Thêm họ tên nhập từ TextBox
        private void btnThem_Click(
            object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            lstHoTen.Items.Add(hoTen);
            txtHoTen.Clear();
            txtHoTen.Focus();

            CapNhatSoLuong();
        }

        // Xóa các họ tên được chọn
        private void btnXoa_Click(
            object sender, EventArgs e)
        {
            if (lstHoTen.SelectedIndices.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn họ tên cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa các họ tên đã chọn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
                return;

            for (int i = lstHoTen.SelectedIndices.Count - 1;
                 i >= 0; i--)
            {
                int index = lstHoTen.SelectedIndices[i];
                lstHoTen.Items.RemoveAt(index);
            }

            CapNhatSoLuong();
        }

        // Xóa họ tên chứa chuỗi cần tìm
        private void btnXoaTheoTen_Click(
            object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (tuKhoa == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập chuỗi cần xóa!");
                return;
            }

            int dem = 0;

            for (int i = lstHoTen.Items.Count - 1;
                 i >= 0; i--)
            {
                string hoTen = lstHoTen.Items[i].ToString()!;

                if (hoTen.Contains(
                    tuKhoa,
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    lstHoTen.Items.RemoveAt(i);
                    dem++;
                }
            }

            MessageBox.Show(
                "Đã xóa " + dem + " họ tên phù hợp.");

            CapNhatSoLuong();
        }

        // Chuyển tất cả thành chữ IN HOA
        private void btnChuHoa_Click(
            object sender, EventArgs e)
        {
            for (int i = 0; i < lstHoTen.Items.Count; i++)
            {
                string s = lstHoTen.Items[i].ToString()!;
                lstHoTen.Items[i] = s.ToUpper(
                    CultureInfo.GetCultureInfo("vi-VN"));
            }
        }

        // Chuyển tất cả thành chữ thường
        private void btnChuThuong_Click(
            object sender, EventArgs e)
        {
            for (int i = 0; i < lstHoTen.Items.Count; i++)
            {
                string s = lstHoTen.Items[i].ToString()!;
                lstHoTen.Items[i] = s.ToLower(
                    CultureInfo.GetCultureInfo("vi-VN"));
            }
        }

        // Viết hoa chữ cái đầu mỗi từ
        private void btnVietHoaDauTu_Click(
            object sender, EventArgs e)
        {
            CultureInfo vi =
                CultureInfo.GetCultureInfo("vi-VN");

            for (int i = 0; i < lstHoTen.Items.Count; i++)
            {
                string s = lstHoTen.Items[i].ToString()!;
                s = s.Trim().ToLower(vi);

                lstHoTen.Items[i] =
                    vi.TextInfo.ToTitleCase(s);
            }
        }

        // Nhấp đúp để sửa họ tên bằng InputBox
        private void lstHoTen_DoubleClick(
            object sender, EventArgs e)
        {
            int index = lstHoTen.SelectedIndex;

            if (index < 0)
                return;

            string tenCu = lstHoTen.Items[index].ToString()!;

            string tenMoi = Interaction.InputBox(
                "Nhập họ tên mới:",
                "Chỉnh sửa họ tên",
                tenCu);

            if (string.IsNullOrWhiteSpace(tenMoi))
                return;

            lstHoTen.Items[index] = tenMoi.Trim();
        }

        // Cập nhật số lượng phần tử
        private void CapNhatSoLuong()
        {
            lblSoLuong.Text =
                "Tổng số họ tên: " + lstHoTen.Items.Count;
        }

        // Xóa toàn bộ danh sách
        private void btnXoaTatCa_Click(
            object sender, EventArgs e)
        {
            if (lstHoTen.Items.Count == 0)
                return;

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa toàn bộ danh sách?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lstHoTen.Items.Clear();
                CapNhatSoLuong();
            }
        }

        // Thoát
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
