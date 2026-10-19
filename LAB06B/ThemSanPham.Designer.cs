
namespace LAB06B
{
    partial class ThemSanPham
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
            lblTieuDe = new Label();
            lblTenSP = new Label();
            txtTenSP = new TextBox();

            btnThem = new Button();
            btnLamMoi = new Button();
            btnDong = new Button();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.Font = new Font(
                "Segoe UI", 16F, FontStyle.Bold);

            lblTieuDe.Location = new Point(25, 25);
            lblTieuDe.Size = new Size(450, 45);
            lblTieuDe.Text = "THÊM SẢN PHẨM";
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // Tên sản phẩm
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(40, 115);
            lblTenSP.Text = "Tên sản phẩm:";

            txtTenSP.Location = new Point(165, 110);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(285, 27);
            txtTenSP.MaxLength = 100;

            // Nút Thêm
            btnThem.Location = new Point(55, 190);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // Nút Làm mới
            btnLamMoi.Location = new Point(195, 190);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;

            // Nút Đóng
            btnDong.Location = new Point(335, 190);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(110, 40);
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 280);

            Controls.Add(lblTieuDe);
            Controls.Add(lblTenSP);
            Controls.Add(txtTenSP);
            Controls.Add(btnThem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDong);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            Name = "ThemSanPham";
            Text = "Thêm sản phẩm mới";

            AcceptButton = btnThem;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe;
        private Label lblTenSP;
        private TextBox txtTenSP;

        private Button btnThem;
        private Button btnLamMoi;
        private Button btnDong;
    }
}
