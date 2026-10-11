
using System;
using System.Numerics;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiVeNha02_DanhSachSo : Form
    {
        public BaiVeNha02_DanhSachSo()
        {
            InitializeComponent();
        }

        // Cập nhật số vào ListBox
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(txtNhapSo.Text.Trim(),
                out BigInteger n) || n < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số tự nhiên hợp lệ (>= 0)!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                txtNhapSo.SelectAll();
                return;
            }

            lstDanhSach.Items.Add(n);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
            CapNhatSoLuong();
        }

        // Tính tổng các phần tử
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (!KiemTraDanhSach()) return;

            BigInteger tong = BigInteger.Zero;

            foreach (BigInteger n in lstDanhSach.Items)
            {
                tong += n;
            }

            MessageBox.Show(
                "Tổng các phần tử là: " + tong,
                "Kết quả",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Xóa phần tử đầu và cuối
        private void btnXoaDauCuoi_Click(
            object sender, EventArgs e)
        {
            int count = lstDanhSach.Items.Count;

            if (count == 0)
            {
                MessageBox.Show("Danh sách đang trống!");
                return;
            }

            if (count == 1)
            {
                lstDanhSach.Items.RemoveAt(0);
            }
            else
            {
                lstDanhSach.Items.RemoveAt(count - 1);
                lstDanhSach.Items.RemoveAt(0);
            }

            CapNhatSoLuong();
        }

        // Xóa các phần tử đang chọn
        private void btnXoaDaChon_Click(
            object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phần tử cần xóa!");
                return;
            }

            for (int i = lstDanhSach.SelectedIndices.Count - 1;
                 i >= 0; i--)
            {
                int index = lstDanhSach.SelectedIndices[i];
                lstDanhSach.Items.RemoveAt(index);
            }

            CapNhatSoLuong();
        }

        // Tăng mỗi phần tử lên 2
        private void btnTangHai_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach()) return;

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                BigInteger n =
                    (BigInteger)lstDanhSach.Items[i];

                lstDanhSach.Items[i] = n + 2;
            }
        }

        // Bình phương từng phần tử
        private void btnBinhPhuong_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach()) return;

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                BigInteger n =
                    (BigInteger)lstDanhSach.Items[i];

                lstDanhSach.Items[i] = n * n;
            }
        }

        // Chọn tất cả phần tử chẵn
        private void btnChonChan_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach()) return;

            lstDanhSach.ClearSelected();

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                BigInteger n =
                    (BigInteger)lstDanhSach.Items[i];

                if (n % 2 == 0)
                    lstDanhSach.SetSelected(i, true);
            }
        }

        // Chọn tất cả phần tử lẻ
        private void btnChonLe_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDanhSach()) return;

            lstDanhSach.ClearSelected();

            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                BigInteger n =
                    (BigInteger)lstDanhSach.Items[i];

                if (n % 2 != 0)
                    lstDanhSach.SetSelected(i, true);
            }
        }

        // Kiểm tra danh sách rỗng
        private bool KiemTraDanhSach()
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show(
                    "Danh sách chưa có phần tử!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Hiển thị số lượng phần tử
        private void CapNhatSoLuong()
        {
            lblSoLuong.Text =
                "Số phần tử: " + lstDanhSach.Items.Count;
        }

        // Thoát chương trình
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
