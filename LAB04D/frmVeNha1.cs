namespace LAB04D
{
    public partial class frmVeNha1 : Form
    {
        // Thống kê trong ngày
        private int tongLuotKhach = 0;
        private decimal tongTienTrongNgay = 0;

        public frmVeNha1()
        {
            InitializeComponent();
        }

        private void frmVeNha1_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;

            txtThanhTien.Clear();
            txtTongKhach.Clear();
            txtTongTien.Clear();

            txtHoTen.Focus();
        }

        // =========================
        // KIỂM TRA DỮ LIỆU
        // =========================
        private void DuLieu_Changed(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void KiemTraDuLieu()
        {
            bool coTen =
                !string.IsNullOrWhiteSpace(txtHoTen.Text);

            bool coDiaChi =
                !string.IsNullOrWhiteSpace(txtDiaChi.Text);

            bool soNgayHopLe =
                int.TryParse(txtSoNgay.Text, out int soNgay)
                && soNgay > 0;

            bool daChonPhong =
                rdoPhongDon.Checked ||
                rdoPhongDoi.Checked ||
                rdoPhongBa.Checked;

            btnThanhToan.Enabled =
                coTen &&
                coDiaChi &&
                soNgayHopLe &&
                daChonPhong;
        }

        // Chỉ cho nhập số ở ô số ngày
        private void txtSoNgay_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // =========================
        // GIÁ PHÒNG
        // =========================
        private decimal LayGiaPhong()
        {
            if (rdoPhongDon.Checked)
                return 300000;

            if (rdoPhongDoi.Checked)
                return 350000;

            if (rdoPhongBa.Checked)
                return 400000;

            return 0;
        }

        // =========================
        // TIỆN NGHI
        // Mỗi loại +10.000
        // =========================
        private decimal LayTienTienNghi()
        {
            decimal tien = 0;

            if (chkTivi.Checked)
                tien += 10000;

            if (chkInternet.Checked)
                tien += 10000;

            if (chkMayNuocNong.Checked)
                tien += 10000;

            return tien;
        }

        // =========================
        // THANH TOÁN
        // =========================
        private void btnThanhToan_Click(
            object sender,
            EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống.");

                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider1.SetError(
                    txtDiaChi,
                    "Địa chỉ không được để trống.");

                return;
            }

            if (!int.TryParse(
                txtSoNgay.Text,
                out int soNgay) || soNgay <= 0)
            {
                errorProvider1.SetError(
                    txtSoNgay,
                    "Số ngày ở phải lớn hơn 0.");

                return;
            }

            if (!rdoPhongDon.Checked &&
                !rdoPhongDoi.Checked &&
                !rdoPhongBa.Checked)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Tiền phòng
            decimal tienPhong =
                LayGiaPhong() * soNgay;

            // Tiện nghi:
            // Theo đề: mỗi loại cộng thêm 10.000đ
            decimal tienTienNghi =
                LayTienTienNghi();

            // Dịch vụ
            decimal tienDichVu = 0;

            // Karaoke 50.000đ
            if (chkKaraoke.Checked)
                tienDichVu += 50000;

            // Ăn sáng 15.000đ / ngày
            if (chkAnSang.Checked)
                tienDichVu += 15000 * soNgay;

            decimal thanhTien =
                tienPhong +
                tienTienNghi +
                tienDichVu;

            txtThanhTien.Text =
                thanhTien.ToString("N0") + " VNĐ";

            // Lưu thống kê trong ngày
            tongLuotKhach++;
            tongTienTrongNgay += thanhTien;

            btnNhapMoi.Enabled = true;
            btnTongKet.Enabled = true;
            btnThanhToan.Enabled = false;

            MessageBox.Show(
                "Khách hàng: " + txtHoTen.Text +
                "\nSố ngày ở: " + soNgay +
                "\nThành tiền: " +
                thanhTien.ToString("N0") +
                " VNĐ",
                "Thanh toán",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // NHẬP MỚI
        // =========================
        private void btnNhapMoi_Click(
            object sender,
            EventArgs e)
        {
            XoaThongTinKhach();

            btnNhapMoi.Enabled = false;
            btnThanhToan.Enabled = false;

            // Vẫn cho phép tổng kết vì đã có
            // ít nhất một khách thanh toán
            btnTongKet.Enabled =
                tongLuotKhach > 0;

            txtHoTen.Focus();
        }

        private void XoaThongTinKhach()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgay.Clear();
            txtThanhTien.Clear();

            rdoPhongDon.Checked = false;
            rdoPhongDoi.Checked = false;
            rdoPhongBa.Checked = false;

            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            errorProvider1.Clear();
        }

        // =========================
        // TỔNG KẾT CUỐI NGÀY
        // =========================
        private void btnTongKet_Click(
            object sender,
            EventArgs e)
        {
            txtTongKhach.Text =
                tongLuotKhach.ToString();

            txtTongTien.Text =
                tongTienTrongNgay.ToString("N0")
                + " VNĐ";

            MessageBox.Show(
                "TỔNG KẾT CUỐI NGÀY" +
                "\nSố lượt khách: " +
                tongLuotKhach +
                "\nTổng số tiền: " +
                tongTienTrongNgay.ToString("N0") +
                " VNĐ",
                "Tổng kết",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Theo đề: tổng kết xong
            // khởi tạo thống kê về 0
            tongLuotKhach = 0;
            tongTienTrongNgay = 0;

            btnTongKet.Enabled = false;
        }

        // =========================
        // THOÁT
        // =========================
        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void frmVeNha1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult kq =
                MessageBox.Show(
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