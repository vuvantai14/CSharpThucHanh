using System.Text.RegularExpressions;

namespace LAB04C
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();

            // Gắn sự kiện
            btnDangKy.Click += btnDangKy_Click;
            txtEmail.Leave += txtEmail_Leave;
            txtXacNhanMatKhau.KeyDown += txtXacNhanMatKhau_KeyDown;
            FormClosing += frmBai2_FormClosing;

            // Ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;

            // Nhấn Enter để đăng ký
            AcceptButton = btnDangKy;
        }

        // =====================================================
        // KIỂM TRA ĐỊNH DẠNG EMAIL
        // =====================================================
        private bool EmailHopLe(string email)
        {
            string mauEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, mauEmail);
        }

        // =====================================================
        // KIỂM TRA EMAIL KHI RỜI TEXTBOX
        // =====================================================
        private void txtEmail_Leave(object? sender, EventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Địa chỉ email không được để trống!");

                return;
            }

            if (!EmailHopLe(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Địa chỉ email không đúng định dạng!");
            }
        }

        // =====================================================
        // KIỂM TRA TOÀN BỘ DỮ LIỆU
        // =====================================================
        private bool KiemTraDuLieu()
        {
            errorProvider1.Clear();

            bool hopLe = true;

            // Kiểm tra tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                errorProvider1.SetError(
                    txtTenDangNhap,
                    "Tên đăng nhập không được để trống!");

                hopLe = false;
            }

            // Kiểm tra email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Địa chỉ email không được để trống!");

                hopLe = false;
            }
            else if (!EmailHopLe(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Địa chỉ email không đúng định dạng!");

                hopLe = false;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu không được để trống!");

                hopLe = false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                errorProvider1.SetError(
                    txtXacNhanMatKhau,
                    "Vui lòng xác nhận mật khẩu!");

                hopLe = false;
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMatKhau,
                    "Xác nhận mật khẩu không khớp!");

                hopLe = false;
            }

            return hopLe;
        }

        // =====================================================
        // XỬ LÝ ĐĂNG KÝ
        // =====================================================
        private void DangKy()
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Hiển thị thông tin các TextBox theo yêu cầu bài
            string thongTin =
                "Tên đăng nhập: " + txtTenDangNhap.Text.Trim() + "\n" +
                "Địa chỉ email: " + txtEmail.Text.Trim() + "\n" +
                "Mật khẩu: " + txtMatKhau.Text + "\n" +
                "Xác nhận mật khẩu: " + txtXacNhanMatKhau.Text;

            MessageBox.Show(
                thongTin,
                "Thông tin đăng ký",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =====================================================
        // BUTTON ĐĂNG KÝ
        // =====================================================
        private void btnDangKy_Click(object? sender, EventArgs e)
        {
            DangKy();
        }

        // =====================================================
        // NHẤN ENTER Ở Ô XÁC NHẬN MẬT KHẨU
        // =====================================================
        private void txtXacNhanMatKhau_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangKy();

                // Không phát âm thanh khi nhấn Enter
                e.SuppressKeyPress = true;
            }
        }

        // =====================================================
        // XÁC NHẬN TRƯỚC KHI ĐÓNG FORM
        // =====================================================
        private void frmBai2_FormClosing(
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

        // =====================================================
        // EVENT CŨ DESIGNER ĐANG THAM CHIẾU
        // KHÔNG XÓA
        // =====================================================

        private void label1_Click(object sender, EventArgs e)
        {
            // Không cần xử lý
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            // Khi mở Form, đưa con trỏ vào ô tên đăng nhập
            txtTenDangNhap.Focus();
        }
    }
}