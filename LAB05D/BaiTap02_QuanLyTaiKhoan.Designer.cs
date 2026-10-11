
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiTap02_QuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblSoTaiKhoan;
        private Label lblTenKhachHang;
        private Label lblDiaChi;
        private Label lblSoTien;
        private Label lblTongTien;

        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKhachHang;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private TextBox txtTongTien;

        private ListView lvTaiKhoan;

        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
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
            lblSoTaiKhoan = new Label();
            lblTenKhachHang = new Label();
            lblDiaChi = new Label();
            lblSoTien = new Label();
            lblTongTien = new Label();

            txtSoTaiKhoan = new TextBox();
            txtTenKhachHang = new TextBox();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            txtTongTien = new TextBox();

            lvTaiKhoan = new ListView();

            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // =====================================
            // CẤU HÌNH FORM
            // =====================================
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 670);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "BaiTap02_QuanLyTaiKhoan";
            Text = "Bài tập tại lớp 2 - Quản lý tài khoản ngân hàng";

            // =====================================
            // TIÊU ĐỀ
            // =====================================
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(50, 20);
            lblTieuDe.Size = new Size(800, 55);

            // =====================================
            // SỐ TÀI KHOẢN
            // =====================================
            lblSoTaiKhoan.Text = "Số tài khoản:";
            lblSoTaiKhoan.Location = new Point(90, 105);
            lblSoTaiKhoan.AutoSize = true;

            txtSoTaiKhoan.Location = new Point(300, 100);
            txtSoTaiKhoan.Size = new Size(500, 30);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.TextAlign =
                HorizontalAlignment.Left;

            // =====================================
            // TÊN KHÁCH HÀNG
            // =====================================
            lblTenKhachHang.Text = "Tên khách hàng:";
            lblTenKhachHang.Location = new Point(90, 155);
            lblTenKhachHang.AutoSize = true;

            txtTenKhachHang.Location = new Point(300, 150);
            txtTenKhachHang.Size = new Size(500, 30);
            txtTenKhachHang.Name = "txtTenKhachHang";

            // =====================================
            // ĐỊA CHỈ KHÁCH HÀNG
            // =====================================
            lblDiaChi.Text = "Địa chỉ khách hàng:";
            lblDiaChi.Location = new Point(90, 205);
            lblDiaChi.AutoSize = true;

            txtDiaChi.Location = new Point(300, 200);
            txtDiaChi.Size = new Size(500, 30);
            txtDiaChi.Name = "txtDiaChi";

            // =====================================
            // SỐ TIỀN TRONG TÀI KHOẢN
            // =====================================
            lblSoTien.Text = "Số tiền trong tài khoản:";
            lblSoTien.Location = new Point(90, 255);
            lblSoTien.AutoSize = true;

            txtSoTien.Location = new Point(300, 250);
            txtSoTien.Size = new Size(500, 30);
            txtSoTien.Name = "txtSoTien";

            // ĐÃ SỬA: Căn trái giống Số tài khoản
            txtSoTien.TextAlign =
                HorizontalAlignment.Left;

            // =====================================
            // NÚT THÊM / HỦY
            // =====================================
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(300, 300);
            btnThem.Size = new Size(110, 40);
            btnThem.Name = "btnThem";
            btnThem.Click += btnThem_Click;

            // =====================================
            // NÚT LƯU
            // =====================================
            btnLuu.Text = "Lưu";
            btnLuu.Location = new Point(430, 300);
            btnLuu.Size = new Size(110, 40);
            btnLuu.Name = "btnLuu";
            btnLuu.Enabled = false;
            btnLuu.Click += btnLuu_Click;

            // =====================================
            // NÚT XÓA
            // =====================================
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(560, 300);
            btnXoa.Size = new Size(110, 40);
            btnXoa.Name = "btnXoa";
            btnXoa.Enabled = false;
            btnXoa.Click += btnXoa_Click;

            // =====================================
            // NÚT THOÁT
            // =====================================
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(690, 300);
            btnThoat.Size = new Size(110, 40);
            btnThoat.Name = "btnThoat";
            btnThoat.Click += btnThoat_Click;

            // =====================================
            // LISTVIEW TÀI KHOẢN
            // =====================================
            lvTaiKhoan.Location = new Point(55, 365);
            lvTaiKhoan.Size = new Size(790, 220);
            lvTaiKhoan.Name = "lvTaiKhoan";

            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.MultiSelect = false;
            lvTaiKhoan.HideSelection = false;

            // Các cột ListView
            lvTaiKhoan.Columns.Add(
                "STT",
                55,
                HorizontalAlignment.Left);

            lvTaiKhoan.Columns.Add(
                "Số tài khoản",
                155,
                HorizontalAlignment.Left);

            lvTaiKhoan.Columns.Add(
                "Tên khách hàng",
                195,
                HorizontalAlignment.Left);

            lvTaiKhoan.Columns.Add(
                "Địa chỉ",
                205,
                HorizontalAlignment.Left);

            // Giữ căn phải cho cột Số tiền
            lvTaiKhoan.Columns.Add(
                "Số tiền",
                170,
                HorizontalAlignment.Right);

            lvTaiKhoan.SelectedIndexChanged +=
                lvTaiKhoan_SelectedIndexChanged;

            // =====================================
            // TỔNG TIỀN
            // =====================================
            lblTongTien.Text = "Tổng tiền:";
            lblTongTien.Location = new Point(495, 610);
            lblTongTien.AutoSize = true;

            txtTongTien.Location = new Point(610, 605);
            txtTongTien.Size = new Size(235, 30);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.BackColor = Color.White;

            // Giữ căn phải cho Tổng tiền
            txtTongTien.TextAlign =
                HorizontalAlignment.Right;

            // =====================================
            // THÊM CONTROLS VÀO FORM
            // =====================================
            Controls.Add(lblTieuDe);

            Controls.Add(lblSoTaiKhoan);
            Controls.Add(txtSoTaiKhoan);

            Controls.Add(lblTenKhachHang);
            Controls.Add(txtTenKhachHang);

            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);

            Controls.Add(lblSoTien);
            Controls.Add(txtSoTien);

            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);

            Controls.Add(lvTaiKhoan);

            Controls.Add(lblTongTien);
            Controls.Add(txtTongTien);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
