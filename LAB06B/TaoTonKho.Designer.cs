
namespace LAB06B
{
    partial class TaoTonKho
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private Label lblTieuDe;
        private Label lblNgay;
        private Label lblSanPham;
        private Label lblSLNhap;
        private Label lblTong;

        private DateTimePicker dtpNgayTon;
        private ComboBox cboSanPham;
        private TextBox txtSLNhap;
        private DataGridView dgvTonKho;

        private Button btnTaoTonKho;
        private Button btnHienThi;
        private Button btnNhapHang;
        private Button btnDong;

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblNgay = new Label();
            lblSanPham = new Label();
            lblSLNhap = new Label();
            lblTong = new Label();

            dtpNgayTon = new DateTimePicker();
            cboSanPham = new ComboBox();
            txtSLNhap = new TextBox();
            dgvTonKho = new DataGridView();

            btnTaoTonKho = new Button();
            btnHienThi = new Button();
            btnNhapHang = new Button();
            btnDong = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvTonKho)
                .BeginInit();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.Text = "QUẢN LÝ TỒN KHO";
            lblTieuDe.Font =
                new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.SetBounds(30, 20, 740, 55);

            // Ngày tồn
            lblNgay.Text = "Ngày tồn:";
            lblNgay.SetBounds(50, 105, 100, 30);

            dtpNgayTon.Format = DateTimePickerFormat.Short;
            dtpNgayTon.SetBounds(150, 100, 180, 30);

            // Tạo tồn kho
            btnTaoTonKho.Text = "Tạo tồn kho";
            btnTaoTonKho.SetBounds(370, 95, 150, 40);
            btnTaoTonKho.Click += btnTaoTonKho_Click;

            // Hiển thị
            btnHienThi.Text = "Hiển thị";
            btnHienThi.SetBounds(550, 95, 150, 40);
            btnHienThi.Click += btnHienThi_Click;

            // Chọn sản phẩm
            lblSanPham.Text = "Sản phẩm:";
            lblSanPham.SetBounds(50, 165, 100, 30);

            cboSanPham.SetBounds(150, 160, 240, 30);
            cboSanPham.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Số lượng nhập
            lblSLNhap.Text = "SL nhập:";
            lblSLNhap.SetBounds(410, 165, 85, 30);

            txtSLNhap.SetBounds(495, 160, 90, 30);

            // Nút nhập hàng
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.SetBounds(610, 155, 140, 40);
            btnNhapHang.Click += btnNhapHang_Click;

            // Bảng tồn kho
            dgvTonKho.SetBounds(35, 220, 730, 270);
            dgvTonKho.ReadOnly = true;
            dgvTonKho.AllowUserToAddRows = false;
            dgvTonKho.AllowUserToDeleteRows = false;
            dgvTonKho.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvTonKho.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Tổng sản phẩm
            lblTong.Text = "Tổng số sản phẩm: 0";
            lblTong.Font =
                new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTong.SetBounds(40, 510, 400, 35);

            // Đóng
            btnDong.Text = "Đóng";
            btnDong.SetBounds(630, 505, 130, 40);
            btnDong.Click += btnDong_Click;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);

            Controls.AddRange(new Control[]
            {
                lblTieuDe,
                lblNgay,
                lblSanPham,
                lblSLNhap,
                lblTong,
                dtpNgayTon,
                cboSanPham,
                txtSLNhap,
                dgvTonKho,
                btnTaoTonKho,
                btnHienThi,
                btnNhapHang,
                btnDong
            });

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            Name = "TaoTonKho";
            Text = "Tạo tồn kho theo ngày";

            ((System.ComponentModel.ISupportInitialize)dgvTonKho)
                .EndInit();

            ResumeLayout(false);
        }
    }
}
