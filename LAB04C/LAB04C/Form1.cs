namespace LAB04C
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();

            // Gắn sự kiện cho 4 nút phép tính
            btnCong.Click += btnCong_Click;
            btnTru.Click += btnTru_Click;
            btnNhan.Click += btnNhan_Click;
            btnChia.Click += btnChia_Click;

            // Chặn nhập ký tự không hợp lệ
            txtA.KeyPress += txtSo_KeyPress;
            txtB.KeyPress += txtSo_KeyPress;

            // Xác nhận trước khi đóng Form
            FormClosing += frmBai1_FormClosing;
        }

        // =====================================================
        // KIỂM TRA DỮ LIỆU NHẬP
        // =====================================================
        private bool KiemTraDuLieu(out double a, out double b)
        {
            errorProvider1.Clear();

            bool hopLeA = double.TryParse(txtA.Text.Trim(), out a);
            bool hopLeB = double.TryParse(txtB.Text.Trim(), out b);

            // Kiểm tra số a
            if (!hopLeA)
            {
                errorProvider1.SetError(
                    txtA,
                    "Vui lòng nhập số a hợp lệ!");
            }

            // Kiểm tra số b
            if (!hopLeB)
            {
                errorProvider1.SetError(
                    txtB,
                    "Vui lòng nhập số b hợp lệ!");
            }

            // Nếu a hoặc b không hợp lệ
            if (!hopLeA || !hopLeB)
            {
                txtKetQua.Clear();

                MessageBox.Show(
                    "Dữ liệu nhập không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // =====================================================
        // PHÉP CỘNG
        // =====================================================
        private void btnCong_Click(object? sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a + b).ToString();
            }
        }

        // =====================================================
        // PHÉP TRỪ
        // =====================================================
        private void btnTru_Click(object? sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a - b).ToString();
            }
        }

        // =====================================================
        // PHÉP NHÂN
        // =====================================================
        private void btnNhan_Click(object? sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a * b).ToString();
            }
        }

        // =====================================================
        // PHÉP CHIA
        // =====================================================
        private void btnChia_Click(object? sender, EventArgs e)
        {
            if (KiemTraDuLieu(out double a, out double b))
            {
                // Không cho phép chia cho 0
                if (b == 0)
                {
                    // Xóa kết quả cũ
                    txtKetQua.Clear();

                    // Hiển thị ErrorProvider tại ô b
                    errorProvider1.SetError(
                        txtB,
                        "Không được chia cho 0!");

                    // Hiển thị MessageBox báo lỗi
                    MessageBox.Show(
                        "Không thể chia cho 0!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                txtKetQua.Text = (a / b).ToString();
            }
        }

        // =====================================================
        // CHẶN NHẬP KÝ TỰ KHÔNG PHẢI SỐ
        // =====================================================
        private void txtSo_KeyPress(object? sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender!;

            // Cho phép Backspace, Delete...
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Cho phép chữ số 0 - 9
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

            // Cho phép một dấu thập phân
            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                !txt.Text.Contains(',') &&
                !txt.Text.Contains('.'))
            {
                return;
            }

            // Chặn tất cả ký tự còn lại
            e.Handled = true;
        }

        // =====================================================
        // XÁC NHẬN TRƯỚC KHI ĐÓNG FORM
        // =====================================================
        private void frmBai1_FormClosing(
            object? sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            // Chọn No thì không đóng chương trình
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // =====================================================
        // CÁC EVENT CŨ DESIGNER ĐANG THAM CHIẾU
        // KHÔNG XÓA ĐỂ TRÁNH LỖI CS0103
        // =====================================================

        private void lblA_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khi Form mở, đặt con trỏ vào ô a
            txtA.Focus();
        }
    }
}