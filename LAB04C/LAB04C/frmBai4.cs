namespace LAB04C
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();

            btnTinh.Click += btnTinh_Click;
            btnXoa.Click += btnXoa_Click;
            txtN.KeyPress += txtN_KeyPress;

            FormClosing += frmBai4_FormClosing;

            AcceptButton = btnTinh;
        }

        // Kiểm tra một số có phải số nguyên tố hay không
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu(out int n)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtN.Text.Trim(), out n))
            {
                txtTong.Clear();

                errorProvider1.SetError(
                    txtN,
                    "N phải là số nguyên!");

                MessageBox.Show(
                    "Vui lòng nhập số nguyên dương N!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (n <= 0)
            {
                txtTong.Clear();

                errorProvider1.SetError(
                    txtN,
                    "N phải lớn hơn 0!");

                MessageBox.Show(
                    "N phải là số nguyên dương!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // Nút Tính
        private void btnTinh_Click(object? sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int n))
                return;

            long tong = 0;

            // Tính tổng các số nguyên tố nhỏ hơn N
            for (int i = 2; i < n; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    tong += i;
                }
            }

            txtTong.Text = tong.ToString();
        }

        // Nút Xóa
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            txtN.Clear();
            txtTong.Clear();

            errorProvider1.Clear();

            txtN.Focus();
        }

        // Chỉ cho nhập số
        private void txtN_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }

        // Xác nhận trước khi thoát
        private void frmBai4_FormClosing(
            object? sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}