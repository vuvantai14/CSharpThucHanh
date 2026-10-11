
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiNangCao01_XuLyChuoi
    {
        private System.ComponentModel.IContainer components = null;

        private ListBox lstHoTen;
        private TextBox txtHoTen;
        private TextBox txtTuKhoa;

        private Label lblTieuDe;
        private Label lblHoTen;
        private Label lblTuKhoa;
        private Label lblSoLuong;

        private Button btnNgauNhien;
        private Button btnThem;
        private Button btnXoa;
        private Button btnXoaTheoTen;
        private Button btnChuHoa;
        private Button btnChuThuong;
        private Button btnVietHoaDauTu;
        private Button btnXoaTatCa;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstHoTen = new ListBox();
            txtHoTen = new TextBox();
            txtTuKhoa = new TextBox();

            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblTuKhoa = new Label();
            lblSoLuong = new Label();

            btnNgauNhien = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnXoaTheoTen = new Button();
            btnChuHoa = new Button();
            btnChuThuong = new Button();
            btnVietHoaDauTu = new Button();
            btnXoaTatCa = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 620);
            Font = new Font("Tahoma", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.WhiteSmoke;
            Text = "Bài nâng cao 1 - Xử lý chuỗi";
            Name = "BaiNangCao01_XuLyChuoi";

            // Tiêu đề
            lblTieuDe.Text = "XỬ LÝ DANH SÁCH HỌ TÊN";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.Location = new Point(100, 20);
            lblTieuDe.Size = new Size(650, 45);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // ListBox
            lstHoTen.Location = new Point(30, 90);
            lstHoTen.Size = new Size(370, 440);
            lstHoTen.SelectionMode =
                SelectionMode.MultiExtended;
            lstHoTen.DoubleClick += lstHoTen_DoubleClick;

            // Số lượng
            lblSoLuong.Text = "Tổng số họ tên: 0";
            lblSoLuong.Location = new Point(30, 545);
            lblSoLuong.Size = new Size(370, 30);

            // Nhập họ tên
            lblHoTen.Text = "Nhập họ tên:";
            lblHoTen.Location = new Point(430, 90);
            lblHoTen.AutoSize = true;

            txtHoTen.Location = new Point(430, 120);
            txtHoTen.Size = new Size(380, 30);

            // Thêm họ tên
            btnThem.Text = "Thêm họ tên";
            btnThem.Location = new Point(430, 160);
            btnThem.Size = new Size(180, 40);
            btnThem.Click += btnThem_Click;

            // Ngẫu nhiên
            btnNgauNhien.Text = "Ngẫu nhiên 50 tên";
            btnNgauNhien.Location = new Point(620, 160);
            btnNgauNhien.Size = new Size(190, 40);
            btnNgauNhien.Click += btnNgauNhien_Click;

            // Xóa được chọn
            btnXoa.Text = "Xóa tên đã chọn";
            btnXoa.Location = new Point(430, 215);
            btnXoa.Size = new Size(180, 40);
            btnXoa.Click += btnXoa_Click;

            // Xóa tất cả
            btnXoaTatCa.Text = "Xóa tất cả";
            btnXoaTatCa.Location = new Point(620, 215);
            btnXoaTatCa.Size = new Size(190, 40);
            btnXoaTatCa.Click += btnXoaTatCa_Click;

            // Từ khóa
            lblTuKhoa.Text = "Nhập chuỗi cần xóa:";
            lblTuKhoa.Location = new Point(430, 275);
            lblTuKhoa.AutoSize = true;

            txtTuKhoa.Location = new Point(430, 305);
            txtTuKhoa.Size = new Size(220, 30);

            btnXoaTheoTen.Text = "Xóa theo chuỗi";
            btnXoaTheoTen.Location = new Point(660, 300);
            btnXoaTheoTen.Size = new Size(150, 40);
            btnXoaTheoTen.Click += btnXoaTheoTen_Click;

            // Chữ hoa
            btnChuHoa.Text = "CHỮ IN HOA";
            btnChuHoa.Location = new Point(430, 365);
            btnChuHoa.Size = new Size(180, 45);
            btnChuHoa.Click += btnChuHoa_Click;

            // Chữ thường
            btnChuThuong.Text = "chữ thường";
            btnChuThuong.Location = new Point(620, 365);
            btnChuThuong.Size = new Size(190, 45);
            btnChuThuong.Click += btnChuThuong_Click;

            // Viết hoa đầu từ
            btnVietHoaDauTu.Text = "Viết Hoa Đầu Từ";
            btnVietHoaDauTu.Location = new Point(430, 425);
            btnVietHoaDauTu.Size = new Size(380, 45);
            btnVietHoaDauTu.Click += btnVietHoaDauTu_Click;

            // Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(620, 520);
            btnThoat.Size = new Size(190, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm Controls
            Controls.Add(lblTieuDe);
            Controls.Add(lstHoTen);
            Controls.Add(lblSoLuong);

            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(btnThem);
            Controls.Add(btnNgauNhien);

            Controls.Add(btnXoa);
            Controls.Add(btnXoaTatCa);

            Controls.Add(lblTuKhoa);
            Controls.Add(txtTuKhoa);
            Controls.Add(btnXoaTheoTen);

            Controls.Add(btnChuHoa);
            Controls.Add(btnChuThuong);
            Controls.Add(btnVietHoaDauTu);
            Controls.Add(btnThoat);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
