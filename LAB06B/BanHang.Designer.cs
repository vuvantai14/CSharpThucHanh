
namespace LAB06B
{
    partial class BanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMaHD = new Label();
            lblSanPham = new Label();
            lblSoLuong = new Label();
            lblTong = new Label();

            txtMaHD = new TextBox();
            txtSoLuong = new TextBox();

            cboSanPham = new ComboBox();
            dgvChiTiet = new DataGridView();

            btnTaoHoaDon = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnThanhToan = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvChiTiet)
                .BeginInit();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.Text = "QUẢN LÝ BÁN HÀNG";
            lblTieuDe.Font = new Font(
                "Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.SetBounds(25, 15, 750, 55);

            // Mã hóa đơn
            lblMaHD.Text = "Mã hóa đơn:";
            lblMaHD.SetBounds(55, 95, 120, 30);

            txtMaHD.SetBounds(180, 90, 180, 30);
            txtMaHD.ReadOnly = true;

            // Tạo hóa đơn
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.SetBounds(430, 85, 180, 40);
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;

            // Sản phẩm
            lblSanPham.Text = "Sản phẩm:";
            lblSanPham.SetBounds(55, 155, 120, 30);

            cboSanPham.SetBounds(180, 150, 300, 30);
            cboSanPham.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Số lượng
            lblSoLuong.Text = "Số lượng:";
            lblSoLuong.SetBounds(510, 155, 90, 30);

            txtSoLuong.SetBounds(605, 150, 120, 30);

            // Các nút
            btnThem.Text = "Thêm";
            btnThem.SetBounds(100, 215, 150, 40);
            btnThem.Click += btnThem_Click;

            btnHuy.Text = "Hủy hóa đơn";
            btnHuy.SetBounds(320, 215, 150, 40);
            btnHuy.Click += btnHuy_Click;

            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.SetBounds(540, 215, 150, 40);
            btnThanhToan.Click += btnThanhToan_Click;

            // DataGridView
            dgvChiTiet.SetBounds(35, 285, 730, 220);
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;

            dgvChiTiet.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvChiTiet.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            // Tổng số loại sản phẩm
            lblTong.Text = "Số loại sản phẩm: 0";
            lblTong.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);
            lblTong.SetBounds(45, 525, 350, 30);

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);

            Controls.AddRange(new Control[]
            {
                lblTieuDe,
                lblMaHD,
                lblSanPham,
                lblSoLuong,
                lblTong,
                txtMaHD,
                txtSoLuong,
                cboSanPham,
                dgvChiTiet,
                btnTaoHoaDon,
                btnThem,
                btnHuy,
                btnThanhToan
            });

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            Name = "BanHang";
            Text = "Quản lý Bán hàng";

            ((System.ComponentModel.ISupportInitialize)dgvChiTiet)
                .EndInit();

            ResumeLayout(false);
        }

        private Label lblTieuDe;
        private Label lblMaHD;
        private Label lblSanPham;
        private Label lblSoLuong;
        private Label lblTong;

        private TextBox txtMaHD;
        private TextBox txtSoLuong;

        private ComboBox cboSanPham;
        private DataGridView dgvChiTiet;

        private Button btnTaoHoaDon;
        private Button btnThem;
        private Button btnHuy;
        private Button btnThanhToan;
    }
}
