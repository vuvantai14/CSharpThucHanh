
namespace LAB06B
{
    partial class QLCuaHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuThemSanPham = new ToolStripMenuItem();
            mnuTaoTonKho = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            lblTieuDe = new Label();

            menuStrip1.SuspendLayout();
            SuspendLayout();

            // MenuStrip
            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    mnuThemSanPham,
                    mnuTaoTonKho,
                    mnuBanHang,
                    mnuThoat
                });

            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(750, 28);

            // Thêm sản phẩm
            mnuThemSanPham.Name = "mnuThemSanPham";
            mnuThemSanPham.Text = "Thêm sản phẩm";
            mnuThemSanPham.Click += mnuThemSanPham_Click;

            // Tạo tồn kho
            mnuTaoTonKho.Name = "mnuTaoTonKho";
            mnuTaoTonKho.Text = "Tạo tồn kho";
            mnuTaoTonKho.Click += mnuTaoTonKho_Click;

            // Bán hàng
            mnuBanHang.Name = "mnuBanHang";
            mnuBanHang.Text = "Bán hàng";
            mnuBanHang.Click += mnuBanHang_Click;

            // Thoát
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;

            // Tiêu đề
            lblTieuDe.Font = new Font(
                "Segoe UI", 20F, FontStyle.Bold);

            lblTieuDe.Location = new Point(50, 130);
            lblTieuDe.Size = new Size(650, 70);
            lblTieuDe.Text = "QUẢN LÝ CỬA HÀNG";
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);

            Controls.Add(lblTieuDe);
            Controls.Add(menuStrip1);

            MainMenuStrip = menuStrip1;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "QLCuaHang";
            Text = "Quản lý Cửa hàng";

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuThemSanPham;
        private ToolStripMenuItem mnuTaoTonKho;
        private ToolStripMenuItem mnuBanHang;
        private ToolStripMenuItem mnuThoat;
        private Label lblTieuDe;
    }
}
