
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiNangCao01_QuanLyHocVien
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuNhapHocVien;
        private ToolStripMenuItem mnuXoaHocVien;
        private ToolStripMenuItem mnuChuyenLopA;
        private ToolStripMenuItem mnuChuyenLopB;
        private ToolStripMenuItem mnuKetThuc;

        private Label lblTieuDe;
        private Label lblLopA;
        private Label lblLopB;
        private Label lblSoLuongA;
        private Label lblSoLuongB;

        private ListBox lstLopA;
        private ListBox lstLopB;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();

            mnuCapNhat = new ToolStripMenuItem();
            mnuNhapHocVien = new ToolStripMenuItem();
            mnuXoaHocVien = new ToolStripMenuItem();
            mnuChuyenLopA = new ToolStripMenuItem();
            mnuChuyenLopB = new ToolStripMenuItem();
            mnuKetThuc = new ToolStripMenuItem();

            lblTieuDe = new Label();
            lblLopA = new Label();
            lblLopB = new Label();
            lblSoLuongA = new Label();
            lblSoLuongB = new Label();

            lstLopA = new ListBox();
            lstLopB = new ListBox();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 580);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "BaiNangCao01_QuanLyHocVien";
            Text = "Bài nâng cao 1 - Quản lý học viên";

            // MenuStrip
            menuStrip.Dock = DockStyle.Top;
            menuStrip.Font = new Font("Tahoma", 11F);

            mnuCapNhat.Text = "Cập nhật";
            mnuNhapHocVien.Text = "Nhập học viên mới";
            mnuXoaHocVien.Text = "Xóa học viên";
            mnuChuyenLopA.Text = "Chuyển sang lớp A";
            mnuChuyenLopB.Text = "Chuyển sang lớp B";
            mnuKetThuc.Text = "Kết thúc";

            mnuCapNhat.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    mnuNhapHocVien,
                    mnuXoaHocVien,
                    new ToolStripSeparator(),
                    mnuChuyenLopA,
                    mnuChuyenLopB
                });

            menuStrip.Items.Add(mnuCapNhat);
            menuStrip.Items.Add(mnuKetThuc);

            mnuNhapHocVien.Click += mnuNhapHocVien_Click;
            mnuXoaHocVien.Click += mnuXoaHocVien_Click;
            mnuChuyenLopA.Click += mnuChuyenLopA_Click;
            mnuChuyenLopB.Click += mnuChuyenLopB_Click;
            mnuKetThuc.Click += mnuKetThuc_Click;

            // Tiêu đề
            lblTieuDe.Text = "QUẢN LÝ HỌC VIÊN";
            lblTieuDe.Font = new Font(
                "Tahoma", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(150, 55);
            lblTieuDe.Size = new Size(550, 55);

            // Lớp A
            lblLopA.Text = "DANH SÁCH LỚP A";
            lblLopA.Font = new Font(
                "Tahoma", 13F, FontStyle.Bold);
            lblLopA.Location = new Point(65, 130);
            lblLopA.Size = new Size(320, 35);
            lblLopA.TextAlign =
                ContentAlignment.MiddleCenter;

            lstLopA.Location = new Point(65, 175);
            lstLopA.Size = new Size(320, 300);
            lstLopA.SelectionMode =
                SelectionMode.MultiExtended;

            // Lớp B
            lblLopB.Text = "DANH SÁCH LỚP B";
            lblLopB.Font = new Font(
                "Tahoma", 13F, FontStyle.Bold);
            lblLopB.Location = new Point(465, 130);
            lblLopB.Size = new Size(320, 35);
            lblLopB.TextAlign =
                ContentAlignment.MiddleCenter;

            lstLopB.Location = new Point(465, 175);
            lstLopB.Size = new Size(320, 300);
            lstLopB.SelectionMode =
                SelectionMode.MultiExtended;

            // Số lượng
            lblSoLuongA.Text = "Số học viên lớp A: 0";
            lblSoLuongA.Location = new Point(65, 495);
            lblSoLuongA.Size = new Size(320, 35);

            lblSoLuongB.Text = "Số học viên lớp B: 0";
            lblSoLuongB.Location = new Point(465, 495);
            lblSoLuongB.Size = new Size(320, 35);

            // Thêm Controls
            Controls.Add(menuStrip);
            Controls.Add(lblTieuDe);
            Controls.Add(lblLopA);
            Controls.Add(lstLopA);
            Controls.Add(lblLopB);
            Controls.Add(lstLopB);
            Controls.Add(lblSoLuongA);
            Controls.Add(lblSoLuongB);

            MainMenuStrip = menuStrip;

            FormClosing +=
                BaiNangCao01_QuanLyHocVien_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
