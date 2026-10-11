
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiTap01_UocSo
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblNhapSo;
        private Label lblDanhSach;
        private Label lblUocSo;

        private TextBox txtNhapSo;
        private ComboBox cboDanhSach;
        private ListBox lstUocSo;

        private Button btnCapNhat;
        private Button btnTongUoc;
        private Button btnUocChan;
        private Button btnUocNguyenTo;
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
            lblDanhSach = new Label();
            lblUocSo = new Label();

            txtNhapSo = new TextBox();
            cboDanhSach = new ComboBox();
            lstUocSo = new ListBox();

            btnCapNhat = new Button();
            btnTongUoc = new Button();
            btnUocChan = new Button();
            btnUocNguyenTo = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "BaiTap01_UocSo";
            Text = "Bài tập 1 - ComboBox và các ước số";
            BackColor = Color.WhiteSmoke;

            // Tiêu đề
            lblTieuDe.Text = "TÍNH TOÁN CÁC ƯỚC SỐ";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.Location = new Point(140, 20);
            lblTieuDe.Size = new Size(520, 50);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // Nhập số
            lblNhapSo.Text = "Nhập số:";
            lblNhapSo.Location = new Point(45, 100);
            lblNhapSo.AutoSize = true;

            txtNhapSo.Location = new Point(155, 95);
            txtNhapSo.Size = new Size(190, 30);
            txtNhapSo.Name = "txtNhapSo";

            // Button Cập nhật
            btnCapNhat.Text = "&Cập nhật";
            btnCapNhat.Location = new Point(365, 92);
            btnCapNhat.Size = new Size(140, 38);
            btnCapNhat.Click += btnCapNhat_Click;

            // Label danh sách số
            lblDanhSach.Text = "Chọn số:";
            lblDanhSach.Location = new Point(45, 165);
            lblDanhSach.AutoSize = true;

            // ComboBox
            cboDanhSach.Location = new Point(155, 160);
            cboDanhSach.Size = new Size(350, 30);
            cboDanhSach.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboDanhSach.SelectedIndexChanged +=
                cboDanhSach_SelectedIndexChanged;

            // Label ước số
            lblUocSo.Text = "Danh sách các ước số";
            lblUocSo.Location = new Point(540, 165);
            lblUocSo.AutoSize = true;

            // ListBox
            lstUocSo.Location = new Point(540, 200);
            lstUocSo.Size = new Size(210, 245);
            lstUocSo.Name = "lstUocSo";

            // Button Tổng các ước số
            btnTongUoc.Text = "&Tổng các ước số";
            btnTongUoc.Location = new Point(50, 240);
            btnTongUoc.Size = new Size(440, 45);
            btnTongUoc.Click += btnTongUoc_Click;

            // Button đếm ước chẵn
            btnUocChan.Text = "Số lượng ước &chẵn";
            btnUocChan.Location = new Point(50, 305);
            btnUocChan.Size = new Size(440, 45);
            btnUocChan.Click += btnUocChan_Click;

            // Button đếm ước nguyên tố
            btnUocNguyenTo.Text =
                "Số lượng ước &nguyên tố";
            btnUocNguyenTo.Location = new Point(50, 370);
            btnUocNguyenTo.Size = new Size(440, 45);
            btnUocNguyenTo.Click += btnUocNguyenTo_Click;

            // Button thoát
            btnThoat.Text = "T&hoát";
            btnThoat.Location = new Point(300, 465);
            btnThoat.Size = new Size(200, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm Controls
            Controls.Add(lblTieuDe);
            Controls.Add(lblNhapSo);
            Controls.Add(txtNhapSo);
            Controls.Add(btnCapNhat);

            Controls.Add(lblDanhSach);
            Controls.Add(cboDanhSach);

            Controls.Add(lblUocSo);
            Controls.Add(lstUocSo);

            Controls.Add(btnTongUoc);
            Controls.Add(btnUocChan);
            Controls.Add(btnUocNguyenTo);
            Controls.Add(btnThoat);

            FormClosing += BaiTap01_UocSo_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
