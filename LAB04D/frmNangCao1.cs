namespace LAB04D
{
    public partial class frmNangCao1 : Form
    {
        private int tongSoKhach = 0;
        private decimal tongTienTatCa = 0;
        private decimal tienHienTai = 0;

        public frmNangCao1()
        {
            InitializeComponent();
        }

        private void frmNangCao1_Load(object sender, EventArgs e)
        {
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            txtTongKhach.Text = "0";
            txtTongTien.Text = "0 VNĐ";

            txtTenKhach.Focus();
        }

        private void DuLieu_Changed(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void KiemTraDuLieu()
        {
            bool coTen =
                !string.IsNullOrWhiteSpace(txtTenKhach.Text);

            bool soKhachHopLe =
                int.TryParse(txtSoKhach.Text, out int soKhach)
                && soKhach > 0;

            bool daChonNuoc =
                rdoCafeDen.Checked ||
                rdoCafeDa.Checked ||
                rdoCafeSua.Checked ||
                rdoCafeSuaDa.Checked ||
                rdoCafeKem.Checked;

            btnTinhTien.Enabled =
                coTen &&
                soKhachHopLe &&
                daChonNuoc;
        }

        private void txtSoKhach_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private decimal LayGiaNuoc()
        {
            if (rdoCafeDen.Checked)
                return 20000;

            if (rdoCafeDa.Checked)
                return 25000;

            if (rdoCafeSua.Checked)
                return 25000;

            if (rdoCafeSuaDa.Checked)
                return 30000;

            if (rdoCafeKem.Checked)
                return 35000;

            return 0;
        }

        private decimal LayGiaThucAn()
        {
            decimal tien = 0;

            if (chkBanhMiTrung.Checked)
                tien += 15000;

            if (chkBanhMiCa.Checked)
                tien += 15000;

            if (chkMiTomTrung.Checked)
                tien += 20000;

            if (chkMiXaoBo.Checked)
                tien += 30000;

            if (chkMiCay.Checked)
                tien += 50000;

            return tien;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                errorProvider1.SetError(
                    txtTenKhach,
                    "Tên khách hàng không được để trống.");

                return;
            }

            if (!int.TryParse(
                txtSoKhach.Text,
                out int soKhach) || soKhach <= 0)
            {
                errorProvider1.SetError(
                    txtSoKhach,
                    "Số khách phải lớn hơn 0.");

                return;
            }

            decimal tienMotNguoi =
                LayGiaNuoc() + LayGiaThucAn();

            tienHienTai =
                tienMotNguoi * soKhach;

            // Sinh viên giảm 20%
            if (chkSinhVien.Checked)
            {
                tienHienTai *= 0.8m;
            }

            MessageBox.Show(
                "Khách hàng: " + txtTenKhach.Text +
                "\nSố khách: " + soKhach +
                "\nThành tiền: " +
                tienHienTai.ToString("N0") +
                " VNĐ",
                "Thông tin tính tiền",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnNhapLai.Enabled = true;
            btnThanhToan.Enabled = true;
            btnTinhTien.Enabled = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soKhach =
                int.Parse(txtSoKhach.Text);

            tongSoKhach += soKhach;
            tongTienTatCa += tienHienTai;

            txtTongKhach.Text =
                tongSoKhach.ToString();

            txtTongTien.Text =
                tongTienTatCa.ToString("N0")
                + " VNĐ";

            MessageBox.Show(
                "Thanh toán thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnThanhToan.Enabled = false;

            XoaThongTinKhach();

            txtTenKhach.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            XoaThongTinKhach();

            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;
            btnTinhTien.Enabled = false;

            txtTenKhach.Focus();
        }

        private void XoaThongTinKhach()
        {
            txtTenKhach.Clear();
            txtSoKhach.Clear();

            chkSinhVien.Checked = false;

            rdoCafeDen.Checked = false;
            rdoCafeDa.Checked = false;
            rdoCafeSua.Checked = false;
            rdoCafeSuaDa.Checked = false;
            rdoCafeKem.Checked = false;

            chkBanhMiTrung.Checked = false;
            chkBanhMiCa.Checked = false;
            chkMiTomTrung.Checked = false;
            chkMiXaoBo.Checked = false;
            chkMiCay.Checked = false;

            tienHienTai = 0;

            errorProvider1.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNangCao1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}