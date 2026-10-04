namespace LAB04C
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();

            // Gắn sự kiện
            btnTinh.Click += btnTinh_Click;
            btnXoa.Click += btnXoa_Click;

            txtA.KeyPress += txtSo_KeyPress;
            txtB.KeyPress += txtSo_KeyPress;

            FormClosing += frmBai3_FormClosing;

            // Nhấn Enter tương đương nút Tính
            AcceptButton = btnTinh;
        }

        // =========================================
        // KIỂM TRA DỮ LIỆU
        // =========================================
        private bool KiemTraDuLieu(out int a, out int b)
        {
            errorProvider1.Clear();

            bool hopLeA = int.TryParse(txtA.Text.Trim(), out a);
            bool hopLeB = int.TryParse(txtB.Text.Trim(), out b);

            bool hopLe = true;

            if (!hopLeA)
            {
                errorProvider1.SetError(
                    txtA,
                    "Vui lòng nhập số nguyên a!");

                hopLe = false;
            }

            if (!hopLeB)
            {
                errorProvider1.SetError(
                    txtB,
                    "Vui lòng nhập số nguyên b!");

                hopLe = false;
            }

            if (!hopLe)
            {
                txtUCLN.Clear();
                txtBCNN.Clear();

                MessageBox.Show(
                    "Vui lòng nhập hai số nguyên hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // =========================================
        // HÀM TÍNH UCLN
        // Thuật toán Euclid
        // =========================================
        private int TinhUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        // =========================================
        // HÀM TÍNH BCNN
        // =========================================
        private long TinhBCNN(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            int ucln = TinhUCLN(a, b);

            return Math.Abs((long)a / ucln * b);
        }

        // =========================================
        // NÚT TÍNH
        // =========================================
        private void btnTinh_Click(object? sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out int a, out int b))
            {
                return;
            }

            int ucln = TinhUCLN(a, b);
            long bcnn = TinhBCNN(a, b);

            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        // =========================================
        // NÚT XÓA
        // =========================================
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();

            errorProvider1.Clear();

            txtA.Focus();
        }

        // =========================================
        // CHỈ CHO NHẬP SỐ NGUYÊN
        // =========================================
        private void txtSo_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender!;

            // Cho phép Backspace...
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Cho phép chữ số
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Cho phép dấu âm ở đầu
            if (e.KeyChar == '-' &&
                txt.SelectionStart == 0 &&
                !txt.Text.Contains('-'))
            {
                return;
            }

            // Chặn ký tự khác
            e.Handled = true;
        }

        // =========================================
        // XÁC NHẬN KHI ĐÓNG FORM
        // =========================================
        private void frmBai3_FormClosing(
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