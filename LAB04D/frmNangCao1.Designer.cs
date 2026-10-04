namespace LAB04D
{
    partial class frmNangCao1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblTenKhach;
        private Label lblSoKhach;
        private Label lblTongKhach;
        private Label lblTongTien;

        private TextBox txtTenKhach;
        private TextBox txtSoKhach;
        private TextBox txtTongKhach;
        private TextBox txtTongTien;

        private CheckBox chkSinhVien;

        private GroupBox grpNuocUong;
        private RadioButton rdoCafeDen;
        private RadioButton rdoCafeDa;
        private RadioButton rdoCafeSua;
        private RadioButton rdoCafeSuaDa;
        private RadioButton rdoCafeKem;

        private GroupBox grpThucAn;
        private CheckBox chkBanhMiTrung;
        private CheckBox chkBanhMiCa;
        private CheckBox chkMiTomTrung;
        private CheckBox chkMiXaoBo;
        private CheckBox chkMiCay;

        private Button btnTinhTien;
        private Button btnNhapLai;
        private Button btnThanhToan;
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
            lblTenKhach = new Label();
            lblSoKhach = new Label();
            lblTongKhach = new Label();
            lblTongTien = new Label();

            txtTenKhach = new TextBox();
            txtSoKhach = new TextBox();
            txtTongKhach = new TextBox();
            txtTongTien = new TextBox();

            chkSinhVien = new CheckBox();

            grpNuocUong = new GroupBox();
            rdoCafeDen = new RadioButton();
            rdoCafeDa = new RadioButton();
            rdoCafeSua = new RadioButton();
            rdoCafeSuaDa = new RadioButton();
            rdoCafeKem = new RadioButton();

            grpThucAn = new GroupBox();
            chkBanhMiTrung = new CheckBox();
            chkBanhMiCa = new CheckBox();
            chkMiTomTrung = new CheckBox();
            chkMiXaoBo = new CheckBox();
            chkMiCay = new CheckBox();

            btnTinhTien = new Button();
            btnNhapLai = new Button();
            btnThanhToan = new Button();
            btnThoat = new Button();

            errorProvider1 = new ErrorProvider(components);

            SuspendLayout();

            // =========================
            // TIÊU ĐỀ
            // =========================
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkOrange;
            lblTieuDe.Location = new Point(205, 25);
            lblTieuDe.Text = "CAFE SINH VIÊN";

            // =========================
            // TÊN KHÁCH HÀNG
            // =========================
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(65, 95);
            lblTenKhach.Text = "Tên khách hàng";

            txtTenKhach.Location = new Point(210, 90);
            txtTenKhach.Size = new Size(370, 27);
            txtTenKhach.TextChanged += DuLieu_Changed;

            // =========================
            // SỐ KHÁCH HÀNG
            // =========================
            lblSoKhach.AutoSize = true;
            lblSoKhach.Location = new Point(65, 135);
            lblSoKhach.Text = "Số khách hàng";

            txtSoKhach.Location = new Point(210, 130);
            txtSoKhach.Size = new Size(370, 27);
            txtSoKhach.TextChanged += DuLieu_Changed;
            txtSoKhach.KeyPress += txtSoKhach_KeyPress;

            // =========================
            // SINH VIÊN
            // =========================
            chkSinhVien.AutoSize = true;
            chkSinhVien.Location = new Point(280, 175);
            chkSinhVien.Text = "Sinh viên ?";

            // =========================
            // NƯỚC UỐNG
            // =========================
            grpNuocUong.Location = new Point(65, 215);
            grpNuocUong.Size = new Size(245, 220);
            grpNuocUong.Text = "Nước uống";

            rdoCafeDen.Location = new Point(25, 35);
            rdoCafeDen.Size = new Size(105, 25);
            rdoCafeDen.Text = "Cafe đen";
            rdoCafeDen.CheckedChanged += DuLieu_Changed;

            rdoCafeDa.Location = new Point(135, 35);
            rdoCafeDa.Size = new Size(95, 25);
            rdoCafeDa.Text = "Cafe đá";
            rdoCafeDa.CheckedChanged += DuLieu_Changed;

            rdoCafeSua.Location = new Point(25, 85);
            rdoCafeSua.Size = new Size(105, 25);
            rdoCafeSua.Text = "Cafe sữa";
            rdoCafeSua.CheckedChanged += DuLieu_Changed;

            rdoCafeKem.Location = new Point(135, 85);
            rdoCafeKem.Size = new Size(100, 25);
            rdoCafeKem.Text = "Cafe kem";
            rdoCafeKem.CheckedChanged += DuLieu_Changed;

            rdoCafeSuaDa.Location = new Point(25, 135);
            rdoCafeSuaDa.Size = new Size(125, 25);
            rdoCafeSuaDa.Text = "Cafe sữa đá";
            rdoCafeSuaDa.CheckedChanged += DuLieu_Changed;

            grpNuocUong.Controls.Add(rdoCafeDen);
            grpNuocUong.Controls.Add(rdoCafeDa);
            grpNuocUong.Controls.Add(rdoCafeSua);
            grpNuocUong.Controls.Add(rdoCafeKem);
            grpNuocUong.Controls.Add(rdoCafeSuaDa);

            // =========================
            // THỨC ĂN
            // =========================
            grpThucAn.Location = new Point(335, 215);
            grpThucAn.Size = new Size(245, 220);
            grpThucAn.Text = "Thức ăn";

            chkBanhMiTrung.Location = new Point(20, 35);
            chkBanhMiTrung.Size = new Size(125, 25);
            chkBanhMiTrung.Text = "Bánh mì trứng";

            chkBanhMiCa.Location = new Point(20, 75);
            chkBanhMiCa.Size = new Size(120, 25);
            chkBanhMiCa.Text = "Bánh mì cá";

            chkMiTomTrung.Location = new Point(20, 115);
            chkMiTomTrung.Size = new Size(130, 25);
            chkMiTomTrung.Text = "Mì tôm trứng";

            chkMiXaoBo.Location = new Point(145, 35);
            chkMiXaoBo.Size = new Size(95, 25);
            chkMiXaoBo.Text = "Mì xào bò";

            chkMiCay.Location = new Point(145, 75);
            chkMiCay.Size = new Size(85, 25);
            chkMiCay.Text = "Mì cay";

            grpThucAn.Controls.Add(chkBanhMiTrung);
            grpThucAn.Controls.Add(chkBanhMiCa);
            grpThucAn.Controls.Add(chkMiTomTrung);
            grpThucAn.Controls.Add(chkMiXaoBo);
            grpThucAn.Controls.Add(chkMiCay);

            // =========================
            // BUTTON TÍNH TIỀN
            // =========================
            btnTinhTien.Location = new Point(65, 465);
            btnTinhTien.Size = new Size(110, 45);
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.Enabled = false;
            btnTinhTien.Click += btnTinhTien_Click;

            // =========================
            // BUTTON NHẬP LẠI
            // =========================
            btnNhapLai.Location = new Point(200, 465);
            btnNhapLai.Size = new Size(110, 45);
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.Enabled = false;
            btnNhapLai.Click += btnNhapLai_Click;

            // =========================
            // BUTTON THANH TOÁN
            // =========================
            btnThanhToan.Location = new Point(335, 465);
            btnThanhToan.Size = new Size(110, 45);
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Enabled = false;
            btnThanhToan.Click += btnThanhToan_Click;

            // =========================
            // BUTTON THOÁT
            // =========================
            btnThoat.Location = new Point(470, 465);
            btnThoat.Size = new Size(110, 45);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // =========================
            // TỔNG KHÁCH HÀNG
            // =========================
            lblTongKhach.AutoSize = true;
            lblTongKhach.Font = new Font(
                "Arial",
                11F,
                FontStyle.Bold);

            lblTongKhach.Location = new Point(65, 550);
            lblTongKhach.Text = "Tổng khách hàng";

            txtTongKhach.Location = new Point(280, 545);
            txtTongKhach.Size = new Size(300, 27);
            txtTongKhach.ReadOnly = true;

            // =========================
            // TỔNG TIỀN THANH TOÁN
            // =========================
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font(
                "Arial",
                11F,
                FontStyle.Bold);

            lblTongTien.Location = new Point(65, 595);
            lblTongTien.Text = "Tổng tiền thanh toán";

            txtTongTien.Location = new Point(280, 590);
            txtTongTien.Size = new Size(300, 27);
            txtTongTien.ReadOnly = true;

            // =========================
            // ERROR PROVIDER
            // =========================
            errorProvider1.ContainerControl = this;

            // =========================
            // FORM
            // =========================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(650, 670);

            Controls.Add(lblTieuDe);

            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);

            Controls.Add(lblSoKhach);
            Controls.Add(txtSoKhach);

            Controls.Add(chkSinhVien);

            Controls.Add(grpNuocUong);
            Controls.Add(grpThucAn);

            Controls.Add(btnTinhTien);
            Controls.Add(btnNhapLai);
            Controls.Add(btnThanhToan);
            Controls.Add(btnThoat);

            Controls.Add(lblTongKhach);
            Controls.Add(txtTongKhach);

            Controls.Add(lblTongTien);
            Controls.Add(txtTongTien);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            StartPosition = FormStartPosition.CenterScreen;

            Text = "Thanh toán tiền - Cafe Sinh Viên";

            Load += frmNangCao1_Load;
            FormClosing += frmNangCao1_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}