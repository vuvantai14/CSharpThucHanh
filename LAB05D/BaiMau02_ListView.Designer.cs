
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiMau02_ListView
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblLop;
        private Label lblSoLuong;

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtLop;

        private ListView lvSinhVien;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
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
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblLop = new Label();
            lblSoLuong = new Label();

            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtLop = new TextBox();

            lvSinhVien = new ListView();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 600);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "BaiMau02_ListView";
            Text = "Bài mẫu 2 - Quản lý sinh viên ListView";

            // Tiêu đề
            lblTieuDe.Text = "QUẢN LÝ SINH VIÊN - LISTVIEW";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(70, 20);
            lblTieuDe.Size = new Size(710, 50);

            // Mã sinh viên
            lblMaSV.Text = "Mã sinh viên:";
            lblMaSV.Location = new Point(45, 105);
            lblMaSV.AutoSize = true;

            txtMaSV.Location = new Point(185, 100);
            txtMaSV.Size = new Size(200, 30);

            // Họ tên
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Location = new Point(425, 105);
            lblHoTen.AutoSize = true;

            txtHoTen.Location = new Point(525, 100);
            txtHoTen.Size = new Size(275, 30);

            // Lớp
            lblLop.Text = "Lớp:";
            lblLop.Location = new Point(45, 160);
            lblLop.AutoSize = true;

            txtLop.Location = new Point(185, 155);
            txtLop.Size = new Size(200, 30);

            // ListView
            lvSinhVien.Location = new Point(45, 220);
            lvSinhVien.Size = new Size(755, 255);
            lvSinhVien.Name = "lvSinhVien";

            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.MultiSelect = false;
            lvSinhVien.HideSelection = false;

            lvSinhVien.Columns.Add("Mã sinh viên", 180);
            lvSinhVien.Columns.Add("Họ và tên", 330);
            lvSinhVien.Columns.Add("Lớp", 235);

            lvSinhVien.SelectedIndexChanged +=
                lvSinhVien_SelectedIndexChanged;

            // Nút Thêm
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(425, 150);
            btnThem.Size = new Size(110, 40);
            btnThem.Click += btnThem_Click;

            // Nút Sửa
            btnSua.Text = "Sửa";
            btnSua.Location = new Point(555, 150);
            btnSua.Size = new Size(110, 40);
            btnSua.Click += btnSua_Click;

            // Nút Xóa
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(690, 150);
            btnXoa.Size = new Size(110, 40);
            btnXoa.Click += btnXoa_Click;

            // Số lượng
            lblSoLuong.Text = "Tổng số sinh viên: 0";
            lblSoLuong.Location = new Point(45, 490);
            lblSoLuong.Size = new Size(300, 35);

            // Làm mới
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Location = new Point(505, 510);
            btnLamMoi.Size = new Size(135, 45);
            btnLamMoi.Click += btnLamMoi_Click;

            // Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(665, 510);
            btnThoat.Size = new Size(135, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm Controls
            Controls.Add(lblTieuDe);
            Controls.Add(lblMaSV);
            Controls.Add(txtMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblLop);
            Controls.Add(txtLop);
            Controls.Add(lvSinhVien);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(lblSoLuong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
    