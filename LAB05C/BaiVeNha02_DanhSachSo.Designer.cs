
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiVeNha02_DanhSachSo
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblNhapSo;
        private Label lblSoLuong;
        private Label lblDanhSach;

        private TextBox txtNhapSo;
        private ListBox lstDanhSach;

        private Button btnThem;
        private Button btnTinhTong;
        private Button btnXoaDauCuoi;
        private Button btnXoaDaChon;
        private Button btnTangHai;
        private Button btnBinhPhuong;
        private Button btnChonChan;
        private Button btnChonLe;
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
            lblNhapSo = new Label();
            lblSoLuong = new Label();
            lblDanhSach = new Label();

            txtNhapSo = new TextBox();
            lstDanhSach = new ListBox();

            btnThem = new Button();
            btnTinhTong = new Button();
            btnXoaDauCuoi = new Button();
            btnXoaDaChon = new Button();
            btnTangHai = new Button();
            btnBinhPhuong = new Button();
            btnChonChan = new Button();
            btnChonLe = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 610);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
            Name = "BaiVeNha02_DanhSachSo";
            Text = "Bài về nhà 2 - Xử lý danh sách số";

            // Tiêu đề
            lblTieuDe.Text = "XỬ LÝ DANH SÁCH SỐ TỰ NHIÊN";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.Location = new Point(60, 20);
            lblTieuDe.Size = new Size(730, 50);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // Nhập số
            lblNhapSo.Text = "Nhập số:";
            lblNhapSo.Location = new Point(35, 100);
            lblNhapSo.AutoSize = true;

            txtNhapSo.Location = new Point(130, 95);
            txtNhapSo.Size = new Size(160, 30);
            txtNhapSo.Name = "txtNhapSo";

            // Nút thêm
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(310, 92);
            btnThem.Size = new Size(110, 40);
            btnThem.Click += btnThem_Click;

            // Label danh sách
            lblDanhSach.Text = "Danh sách số tự nhiên";
            lblDanhSach.Location = new Point(35, 160);
            lblDanhSach.AutoSize = true;

            // ListBox
            lstDanhSach.Location = new Point(35, 195);
            lstDanhSach.Size = new Size(340, 315);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.SelectionMode =
                SelectionMode.MultiExtended;
            lstDanhSach.HorizontalScrollbar = true;

            // Số lượng
            lblSoLuong.Text = "Số phần tử: 0";
            lblSoLuong.Location = new Point(35, 525);
            lblSoLuong.Size = new Size(340, 30);

            // Tính tổng
            btnTinhTong.Text = "Tổng các phần tử";
            btnTinhTong.Location = new Point(430, 95);
            btnTinhTong.Size = new Size(370, 43);
            btnTinhTong.Click += btnTinhTong_Click;

            // Xóa đầu cuối
            btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            btnXoaDauCuoi.Location = new Point(430, 150);
            btnXoaDauCuoi.Size = new Size(370, 43);
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;

            // Xóa các phần tử được chọn
            btnXoaDaChon.Text = "Xóa các phần tử đang chọn";
            btnXoaDaChon.Location = new Point(430, 205);
            btnXoaDaChon.Size = new Size(370, 43);
            btnXoaDaChon.Click += btnXoaDaChon_Click;

            // Tăng lên 2
            btnTangHai.Text = "Tăng mỗi phần tử lên 2";
            btnTangHai.Location = new Point(430, 260);
            btnTangHai.Size = new Size(370, 43);
            btnTangHai.Click += btnTangHai_Click;

            // Bình phương
            btnBinhPhuong.Text = "Bình phương mỗi phần tử";
            btnBinhPhuong.Location = new Point(430, 315);
            btnBinhPhuong.Size = new Size(370, 43);
            btnBinhPhuong.Click += btnBinhPhuong_Click;

            // Chọn số chẵn
            btnChonChan.Text = "Chọn các số chẵn";
            btnChonChan.Location = new Point(430, 370);
            btnChonChan.Size = new Size(370, 43);
            btnChonChan.Click += btnChonChan_Click;

            // Chọn số lẻ
            btnChonLe.Text = "Chọn các số lẻ";
            btnChonLe.Location = new Point(430, 425);
            btnChonLe.Size = new Size(370, 43);
            btnChonLe.Click += btnChonLe_Click;

            // Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(610, 510);
            btnThoat.Size = new Size(190, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm các Control
            Controls.Add(lblTieuDe);
            Controls.Add(lblNhapSo);
            Controls.Add(txtNhapSo);
            Controls.Add(btnThem);

            Controls.Add(lblDanhSach);
            Controls.Add(lstDanhSach);
            Controls.Add(lblSoLuong);

            Controls.Add(btnTinhTong);
            Controls.Add(btnXoaDauCuoi);
            Controls.Add(btnXoaDaChon);
            Controls.Add(btnTangHai);
            Controls.Add(btnBinhPhuong);
            Controls.Add(btnChonChan);
            Controls.Add(btnChonLe);
            Controls.Add(btnThoat);

            // Enter để thêm số
            AcceptButton = btnThem;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
