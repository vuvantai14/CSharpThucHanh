
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiTap01_QuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblDanToc;
        private Label lblSoLuong;

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private ComboBox cboDanToc;
        private ListView lvSinhVien;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThoat;

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem mnuXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblDanToc = new Label();
            lblSoLuong = new Label();

            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            cboDanToc = new ComboBox();
            lvSinhVien = new ListView();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();

            contextMenu = new ContextMenuStrip(components);
            mnuXoa = new ToolStripMenuItem();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 630);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "BaiTap01_QuanLySinhVien";
            Text = "Bài tập tại lớp 1 - Quản lý sinh viên";

            // Tiêu đề
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            lblTieuDe.Font =
                new Font("Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(65, 20);
            lblTieuDe.Size = new Size(770, 55);

            // Mã sinh viên
            lblMaSV.Text = "Mã sinh viên:";
            lblMaSV.Location = new Point(45, 110);
            lblMaSV.AutoSize = true;

            txtMaSV.Location = new Point(185, 105);
            txtMaSV.Size = new Size(225, 30);

            // Họ tên
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Location = new Point(465, 110);
            lblHoTen.AutoSize = true;

            txtHoTen.Location = new Point(565, 105);
            txtHoTen.Size = new Size(285, 30);

            // Dân tộc
            lblDanToc.Text = "Dân tộc:";
            lblDanToc.Location = new Point(45, 165);
            lblDanToc.AutoSize = true;

            cboDanToc.Location = new Point(185, 160);
            cboDanToc.Size = new Size(225, 30);
            cboDanToc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Thêm
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(465, 155);
            btnThem.Size = new Size(110, 42);
            btnThem.Click += btnThem_Click;

            // Sửa
            btnSua.Text = "Sửa";
            btnSua.Location = new Point(600, 155);
            btnSua.Size = new Size(110, 42);
            btnSua.Click += btnSua_Click;

            // Xóa
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(740, 155);
            btnXoa.Size = new Size(110, 42);
            btnXoa.Click += btnXoa_Click;

            // ListView
            lvSinhVien.Location = new Point(45, 230);
            lvSinhVien.Size = new Size(805, 275);

            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.MultiSelect = false;
            lvSinhVien.HideSelection = false;

            lvSinhVien.Columns.Add("Mã sinh viên", 200);
            lvSinhVien.Columns.Add("Họ và tên", 350);
            lvSinhVien.Columns.Add("Dân tộc", 245);

            lvSinhVien.SelectedIndexChanged +=
                lvSinhVien_SelectedIndexChanged;

            lvSinhVien.MouseDown +=
                lvSinhVien_MouseDown;

            // ContextMenuStrip
            mnuXoa.Text = "Xóa sinh viên";
            mnuXoa.Click += mnuXoa_Click;

            contextMenu.Items.Add(mnuXoa);
            lvSinhVien.ContextMenuStrip = contextMenu;

            // Số lượng
            lblSoLuong.Text = "Tổng số sinh viên: 0";
            lblSoLuong.Location = new Point(45, 525);
            lblSoLuong.Size = new Size(300, 35);

            // Làm mới
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Location = new Point(550, 540);
            btnLamMoi.Size = new Size(135, 45);
            btnLamMoi.Click += btnLamMoi_Click;

            // Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(715, 540);
            btnThoat.Size = new Size(135, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm Controls
            Controls.Add(lblTieuDe);
            Controls.Add(lblMaSV);
            Controls.Add(txtMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblDanToc);
            Controls.Add(cboDanToc);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(lvSinhVien);
            Controls.Add(lblSoLuong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);

            Load += BaiTap01_QuanLySinhVien_Load;
            FormClosing += BaiTap01_QuanLySinhVien_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
