namespace LAB04D
{
    partial class frmVeNha1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblHoTen;
        private Label lblDiaChi;
        private Label lblSoNgay;
        private Label lblThanhTien;
        private Label lblTongKhach;
        private Label lblTongTien;

        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtSoNgay;
        private TextBox txtThanhTien;
        private TextBox txtTongKhach;
        private TextBox txtTongTien;

        private GroupBox grpLoaiPhong;
        private RadioButton rdoPhongDon;
        private RadioButton rdoPhongDoi;
        private RadioButton rdoPhongBa;

        private GroupBox grpTienNghi;
        private CheckBox chkTivi;
        private CheckBox chkInternet;
        private CheckBox chkMayNuocNong;

        private GroupBox grpDichVu;
        private CheckBox chkKaraoke;
        private CheckBox chkAnSang;

        private Button btnThanhToan;
        private Button btnNhapMoi;
        private Button btnTongKet;
        private Button btnThoat;

        private ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblSoNgay = new Label();
            lblThanhTien = new Label();
            lblTongKhach = new Label();
            lblTongTien = new Label();

            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            txtSoNgay = new TextBox();
            txtThanhTien = new TextBox();
            txtTongKhach = new TextBox();
            txtTongTien = new TextBox();

            grpLoaiPhong = new GroupBox();
            rdoPhongDon = new RadioButton();
            rdoPhongDoi = new RadioButton();
            rdoPhongBa = new RadioButton();

            grpTienNghi = new GroupBox();
            chkTivi = new CheckBox();
            chkInternet = new CheckBox();
            chkMayNuocNong = new CheckBox();

            grpDichVu = new GroupBox();
            chkKaraoke = new CheckBox();
            chkAnSang = new CheckBox();

            btnThanhToan = new Button();
            btnNhapMoi = new Button();
            btnTongKet = new Button();
            btnThoat = new Button();

            errorProvider1 = new ErrorProvider(components);

            SuspendLayout();

            // =====================================================
            // TIÊU ĐỀ
            // =====================================================
            lblTieuDe.AutoSize = false;
            lblTieuDe.Font = new Font(
                "Arial",
                16F,
                FontStyle.Bold);

            lblTieuDe.ForeColor = Color.DarkOrange;

            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Size = new Size(660, 55);

            lblTieuDe.Text =
                "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";

            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // =====================================================
            // HỌ VÀ TÊN
            // =====================================================
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(60, 105);
            lblHoTen.Text = "Họ và tên:";

            txtHoTen.Location = new Point(150, 100);
            txtHoTen.Size = new Size(300, 27);
            txtHoTen.TextChanged += DuLieu_Changed;

            // =====================================================
            // ĐỊA CHỈ
            // =====================================================
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(60, 150);
            lblDiaChi.Text = "Địa chỉ:";

            txtDiaChi.Location = new Point(150, 145);
            txtDiaChi.Size = new Size(300, 27);
            txtDiaChi.TextChanged += DuLieu_Changed;

            // =====================================================
            // SỐ NGÀY Ở
            // =====================================================
            lblSoNgay.AutoSize = true;
            lblSoNgay.Location = new Point(60, 195);
            lblSoNgay.Text = "Số ngày ở:";

            txtSoNgay.Location = new Point(150, 190);
            txtSoNgay.Size = new Size(120, 27);

            txtSoNgay.TextChanged += DuLieu_Changed;
            txtSoNgay.KeyPress += txtSoNgay_KeyPress;

            // =====================================================
            // LOẠI PHÒNG
            // =====================================================
            grpLoaiPhong.Location = new Point(60, 245);
            grpLoaiPhong.Size = new Size(180, 180);
            grpLoaiPhong.Text = "Loại phòng";

            rdoPhongDon.Location = new Point(20, 35);
            rdoPhongDon.Size = new Size(130, 25);
            rdoPhongDon.Text = "Phòng đơn";
            rdoPhongDon.CheckedChanged += DuLieu_Changed;

            rdoPhongDoi.Location = new Point(20, 80);
            rdoPhongDoi.Size = new Size(130, 25);
            rdoPhongDoi.Text = "Phòng đôi";
            rdoPhongDoi.CheckedChanged += DuLieu_Changed;

            rdoPhongBa.Location = new Point(20, 125);
            rdoPhongBa.Size = new Size(130, 25);
            rdoPhongBa.Text = "Phòng ba";
            rdoPhongBa.CheckedChanged += DuLieu_Changed;

            grpLoaiPhong.Controls.Add(rdoPhongDon);
            grpLoaiPhong.Controls.Add(rdoPhongDoi);
            grpLoaiPhong.Controls.Add(rdoPhongBa);

            // =====================================================
            // TIỆN NGHI
            // =====================================================
            grpTienNghi.Location = new Point(260, 245);
            grpTienNghi.Size = new Size(180, 180);
            grpTienNghi.Text = "Tiện nghi";

            chkTivi.Location = new Point(20, 35);
            chkTivi.Size = new Size(120, 25);
            chkTivi.Text = "Tivi";

            chkInternet.Location = new Point(20, 80);
            chkInternet.Size = new Size(120, 25);
            chkInternet.Text = "Internet";

            chkMayNuocNong.Location = new Point(20, 125);
            chkMayNuocNong.Size = new Size(150, 25);
            chkMayNuocNong.Text = "Máy nước nóng";

            grpTienNghi.Controls.Add(chkTivi);
            grpTienNghi.Controls.Add(chkInternet);
            grpTienNghi.Controls.Add(chkMayNuocNong);

            // =====================================================
            // DỊCH VỤ
            // =====================================================
            grpDichVu.Location = new Point(460, 245);
            grpDichVu.Size = new Size(180, 180);
            grpDichVu.Text = "Dịch vụ";

            chkKaraoke.Location = new Point(20, 50);
            chkKaraoke.Size = new Size(120, 25);
            chkKaraoke.Text = "Karaoke";

            chkAnSang.Location = new Point(20, 100);
            chkAnSang.Size = new Size(120, 25);
            chkAnSang.Text = "Ăn sáng";

            grpDichVu.Controls.Add(chkKaraoke);
            grpDichVu.Controls.Add(chkAnSang);

            // =====================================================
            // NÚT THANH TOÁN
            // =====================================================
            btnThanhToan.Location = new Point(60, 465);
            btnThanhToan.Size = new Size(125, 45);

            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Enabled = false;

            btnThanhToan.Click += btnThanhToan_Click;

            // =====================================================
            // NÚT NHẬP MỚI
            // =====================================================
            btnNhapMoi.Location = new Point(210, 465);
            btnNhapMoi.Size = new Size(125, 45);

            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.Enabled = false;

            btnNhapMoi.Click += btnNhapMoi_Click;

            // =====================================================
            // NÚT TỔNG KẾT
            // =====================================================
            btnTongKet.Location = new Point(360, 465);
            btnTongKet.Size = new Size(125, 45);

            btnTongKet.Text = "Tổng kết";
            btnTongKet.Enabled = false;

            btnTongKet.Click += btnTongKet_Click;

            // =====================================================
            // NÚT THOÁT
            // =====================================================
            btnThoat.Location = new Point(515, 465);
            btnThoat.Size = new Size(125, 45);

            btnThoat.Text = "Thoát";

            btnThoat.Click += btnThoat_Click;

            // =====================================================
            // THÀNH TIỀN
            // =====================================================
            lblThanhTien.AutoSize = true;

            lblThanhTien.Font = new Font(
                "Arial",
                11F,
                FontStyle.Bold);

            lblThanhTien.Location = new Point(60, 555);
            lblThanhTien.Text = "Thành tiền:";

            txtThanhTien.Location = new Point(235, 550);
            txtThanhTien.Size = new Size(405, 27);
            txtThanhTien.ReadOnly = true;

            // =====================================================
            // SỐ LƯỢT KHÁCH
            // =====================================================
            lblTongKhach.AutoSize = true;

            lblTongKhach.Font = new Font(
                "Arial",
                11F,
                FontStyle.Bold);

            lblTongKhach.Location = new Point(60, 600);
            lblTongKhach.Text = "Số lượt khách:";

            txtTongKhach.Location = new Point(235, 595);
            txtTongKhach.Size = new Size(405, 27);
            txtTongKhach.ReadOnly = true;

            // =====================================================
            // TỔNG SỐ TIỀN
            // =====================================================
            lblTongTien.AutoSize = true;

            lblTongTien.Font = new Font(
                "Arial",
                11F,
                FontStyle.Bold);

            lblTongTien.Location = new Point(60, 645);
            lblTongTien.Text = "Tổng số tiền:";

            txtTongTien.Location = new Point(235, 640);
            txtTongTien.Size = new Size(405, 27);
            txtTongTien.ReadOnly = true;

            // =====================================================
            // ERROR PROVIDER
            // =====================================================
            errorProvider1.ContainerControl = this;

            // =====================================================
            // FORM
            // =====================================================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(700, 720);

            Controls.Add(lblTieuDe);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);

            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);

            Controls.Add(lblSoNgay);
            Controls.Add(txtSoNgay);

            Controls.Add(grpLoaiPhong);
            Controls.Add(grpTienNghi);
            Controls.Add(grpDichVu);

            Controls.Add(btnThanhToan);
            Controls.Add(btnNhapMoi);
            Controls.Add(btnTongKet);
            Controls.Add(btnThoat);

            Controls.Add(lblThanhTien);
            Controls.Add(txtThanhTien);

            Controls.Add(lblTongKhach);
            Controls.Add(txtTongKhach);

            Controls.Add(lblTongTien);
            Controls.Add(txtTongTien);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Khách sạn Thanh Thanh - Trả phòng";

            Load += frmVeNha1_Load;
            FormClosing += frmVeNha1_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}