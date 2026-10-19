
using System;
using System.Windows.Forms;

namespace LAB06B
{
    public partial class QLCuaHang : Form
    {
        public QLCuaHang()
        {
            InitializeComponent();
        }

        // =====================================
        // 1. THÊM SẢN PHẨM
        // =====================================
        private void mnuThemSanPham_Click(
            object sender, EventArgs e)
        {
            using (ThemSanPham form = new ThemSanPham())
            {
                form.ShowDialog(this);
            }
        }

        // =====================================
        // 2. TẠO TỒN KHO THEO NGÀY
        // =====================================
        private void mnuTaoTonKho_Click(
            object sender, EventArgs e)
        {
            using (TaoTonKho form = new TaoTonKho())
            {
                form.ShowDialog(this);
            }
        }

        // =====================================
        // 3. QUẢN LÝ BÁN HÀNG
        // =====================================
        private void mnuBanHang_Click(
            object sender, EventArgs e)
        {
            using (BanHang form = new BanHang())
            {
                form.ShowDialog(this);
            }
        }

        // =====================================
        // 4. THOÁT CHƯƠNG TRÌNH
        // =====================================
        private void mnuThoat_Click(
            object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
