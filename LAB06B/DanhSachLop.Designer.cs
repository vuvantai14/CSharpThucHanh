
namespace LAB06B
{
    partial class DanhSachLop
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
            lvDanhSachLop = new ListView();

            colSTT = new ColumnHeader();
            colMaLop = new ColumnHeader();
            colTenLop = new ColumnHeader();
            colMaKhoa = new ColumnHeader();

            lblTongSo = new Label();
            btnHienThi = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.Font = new Font(
                "Segoe UI", 16F, FontStyle.Bold);

            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(660, 45);
            lblTieuDe.Text = "DANH SÁCH LỚP HỌC";
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // ListView
            lvDanhSachLop.Location = new Point(25, 85);
            lvDanhSachLop.Name = "lvDanhSachLop";
            lvDanhSachLop.Size = new Size(650, 270);

            lvDanhSachLop.View = View.Details;
            lvDanhSachLop.FullRowSelect = true;
            lvDanhSachLop.GridLines = true;
            lvDanhSachLop.MultiSelect = false;
            lvDanhSachLop.HideSelection = false;

            lvDanhSachLop.Columns.AddRange(
                new ColumnHeader[]
                {
                    colSTT,
                    colMaLop,
                    colTenLop,
                    colMaKhoa
                });

            // Các cột
            colSTT.Text = "STT";
            colSTT.Width = 60;
            colSTT.TextAlign = HorizontalAlignment.Center;

            colMaLop.Text = "Mã lớp";
            colMaLop.Width = 130;

            colTenLop.Text = "Tên lớp";
            colTenLop.Width = 280;

            colMaKhoa.Text = "Mã khoa";
            colMaKhoa.Width = 150;

            // Tổng số lớp
            lblTongSo.AutoSize = true;
            lblTongSo.Location = new Point(25, 370);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Text = "Tổng số lớp: 0";
            lblTongSo.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);

            // Nút Hiển thị dữ liệu
            btnHienThi.Location = new Point(180, 415);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(155, 42);
            btnHienThi.Text = "Hiển thị dữ liệu";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;

            // Nút Thoát
            btnThoat.Location = new Point(365, 415);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(155, 42);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 490);

            Controls.Add(lblTieuDe);
            Controls.Add(lvDanhSachLop);
            Controls.Add(lblTongSo);
            Controls.Add(btnHienThi);
            Controls.Add(btnThoat);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "DanhSachLop";
            Text = "Danh sách Lớp";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe;
        private Label lblTongSo;

        private ListView lvDanhSachLop;

        private ColumnHeader colSTT;
        private ColumnHeader colMaLop;
        private ColumnHeader colTenLop;
        private ColumnHeader colMaKhoa;

        private Button btnHienThi;
        private Button btnThoat;
    }
}
