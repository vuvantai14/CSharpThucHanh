namespace LAB04C
{
    public partial class frmBai5 : Form
    {
        private bool choPhepDong = false;

        public frmBai5()
        {
            InitializeComponent();

            btnThucHien.Click += btnThucHien_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;

            txtSo.KeyPress += txtSo_KeyPress;
            FormClosing += frmBai5_FormClosing;

            AcceptButton = btnThucHien;
        }

        // Đọc một chữ số
        private string DocChuSo(int n)
        {
            string[] chuSo =
            {
                "không", "một", "hai", "ba", "bốn",
                "năm", "sáu", "bảy", "tám", "chín"
            };

            return chuSo[n];
        }

        // Đọc số có 2 chữ số
        private string DocHaiChuSo(int n)
        {
            int chuc = n / 10;
            int donVi = n % 10;

            if (chuc == 0)
                return DocChuSo(donVi);

            if (chuc == 1)
            {
                if (donVi == 0)
                    return "mười";

                if (donVi == 5)
                    return "mười lăm";

                return "mười " + DocChuSo(donVi);
            }

            string ketQua = DocChuSo(chuc) + " mươi";

            if (donVi == 0)
                return ketQua;

            if (donVi == 1)
                return ketQua + " mốt";

            if (donVi == 5)
                return ketQua + " lăm";

            return ketQua + " " + DocChuSo(donVi);
        }

        // Đọc số từ 1 đến 999
        private string DocSo(int n)
        {
            if (n < 100)
                return DocHaiChuSo(n);

            int tram = n / 100;
            int phanConLai = n % 100;

            string ketQua = DocChuSo(tram) + " trăm";

            if (phanConLai == 0)
                return ketQua;

            // Ví dụ: 105 -> một trăm lẻ năm
            if (phanConLai < 10)
                return ketQua + " lẻ " + DocChuSo(phanConLai);

            return ketQua + " " + DocHaiChuSo(phanConLai);
        }

        // Nút Thực hiện
        private void btnThucHien_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!int.TryParse(txtSo.Text.Trim(), out int n))
            {
                errorProvider1.SetError(
                    txtSo,
                    "Vui lòng nhập số nguyên!");

                txtKetQua.Clear();

                MessageBox.Show(
                    "Vui lòng nhập số nguyên từ 1 đến 999!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (n < 1 || n > 999)
            {
                errorProvider1.SetError(
                    txtSo,
                    "Số phải nằm trong khoảng 1 đến 999!");

                txtKetQua.Clear();

                MessageBox.Show(
                    "Chỉ được nhập số từ 1 đến 999!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            txtKetQua.Text = DocSo(n);
        }

        // Nút Xóa
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            txtSo.Clear();
            txtKetQua.Clear();
            errorProvider1.Clear();

            txtSo.Focus();
        }

        // Chỉ cho nhập chữ số
        private void txtSo_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }

        // Nút Thoát
        private void btnThoat_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                choPhepDong = true;
                Close();
            }
        }

        // Nhấn X trên Form
        private void frmBai5_FormClosing(
            object? sender,
            FormClosingEventArgs e)
        {
            if (choPhepDong)
                return;

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