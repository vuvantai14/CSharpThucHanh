
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiVeNha03_DanhBa
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblHoTen;
        private Label lblSoDienThoai;
        private Label lblDiaChi;
        private Label lblTimKiem;
        private Label lblSoLuong;

        private TextBox txtHoTen;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTimKiem;

        private TreeView trvDanhBa;
        private GroupBox grpThongTin;

        private Button btnThem;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblSoDienThoai = new Label();
            lblDiaChi = new Label();
            lblTimKiem = new Label();
            lblSoLuong = new Label();

            txtHoTen = new TextBox();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTimKiem = new TextBox();

            trvDanhBa = new TreeView();
            grpThongTin = new GroupBox();

            btnThem = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 610);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
            Name = "BaiVeNha03_DanhBa";
            Text = "Bài về nhà 3 - Quản lý danh bạ";

            // Tiêu đề
            lblTieuDe.Text = "QUẢN LÝ DANH BẠ ĐIỆN THOẠI";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.Location = new Point(100, 20);
            lblTieuDe.Size = new Size(700, 50);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // TreeView
            trvDanhBa.Location = new Point(30, 100);
            trvDanhBa.Size = new Size(300, 420);
            trvDanhBa.Name = "trvDanhBa";
            trvDanhBa.AfterSelect +=
                trvDanhBa_AfterSelect;

            // Tổng số liên hệ
            lblSoLuong.Text = "Tổng số liên hệ: 0";
            lblSoLuong.Location = new Point(30, 535);
            lblSoLuong.Size = new Size(300, 35);

            // GroupBox thông tin
            grpThongTin.Text = "Thông tin liên hệ";
            grpThongTin.Location = new Point(355, 100);
            grpThongTin.Size = new Size(510, 305);

            // Họ tên
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Location = new Point(20, 45);
            lblHoTen.AutoSize = true;

            txtHoTen.Location = new Point(155, 40);
            txtHoTen.Size = new Size(325, 30);

            // Số điện thoại
            lblSoDienThoai.Text = "Số điện thoại:";
            lblSoDienThoai.Location = new Point(20, 100);
            lblSoDienThoai.AutoSize = true;

            txtSoDienThoai.Location = new Point(155, 95);
            txtSoDienThoai.Size = new Size(325, 30);

            // Địa chỉ
            lblDiaChi.Text = "Địa chỉ:";
            lblDiaChi.Location = new Point(20, 155);
            lblDiaChi.AutoSize = true;

            txtDiaChi.Location = new Point(155, 150);
            txtDiaChi.Size = new Size(325, 30);

            // Nút thêm
            btnThem.Text = "Thêm liên hệ";
            btnThem.Location = new Point(155, 220);
            btnThem.Size = new Size(150, 45);
            btnThem.Click += btnThem_Click;

            // Nút xóa
            btnXoa.Text = "Xóa liên hệ";
            btnXoa.Location = new Point(325, 220);
            btnXoa.Size = new Size(155, 45);
            btnXoa.Click += btnXoa_Click;

            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblSoDienThoai);
            grpThongTin.Controls.Add(txtSoDienThoai);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(btnXoa);

            // Tìm kiếm
            lblTimKiem.Text = "Tìm kiếm:";
            lblTimKiem.Location = new Point(355, 430);
            lblTimKiem.AutoSize = true;

            txtTimKiem.Location = new Point(455, 425);
            txtTimKiem.Size = new Size(250, 30);

            btnTimKiem.Text = "Tìm";
            btnTimKiem.Location = new Point(715, 422);
            btnTimKiem.Size = new Size(150, 38);
            btnTimKiem.Click += btnTimKiem_Click;

            // Làm mới
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Location = new Point(455, 490);
            btnLamMoi.Size = new Size(170, 45);
            btnLamMoi.Click += btnLamMoi_Click;

            // Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(695, 490);
            btnThoat.Size = new Size(170, 45);
            btnThoat.Click += btnThoat_Click;

            // Controls
            Controls.Add(lblTieuDe);
            Controls.Add(trvDanhBa);
            Controls.Add(lblSoLuong);
            Controls.Add(grpThongTin);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);

            Load += BaiVeNha03_DanhBa_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
