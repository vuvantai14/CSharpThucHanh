
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiVeNha02_FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;

        private ToolStripMenuItem mnuBaiMau;
        private ToolStripMenuItem mnuBaiMau1;
        private ToolStripMenuItem mnuBaiMau2;
        private ToolStripMenuItem mnuBaiMau3;

        private ToolStripMenuItem mnuBaiTap;
        private ToolStripMenuItem mnuBaiTap1;
        private ToolStripMenuItem mnuBaiTap2;

        private ToolStripMenuItem mnuNangCao;
        private ToolStripMenuItem mnuNangCao1;

        private ToolStripMenuItem mnuVeNha;
        private ToolStripMenuItem mnuVeNha1;

        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDongTatCa;
        private ToolStripMenuItem mnuThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();

            mnuBaiMau = new ToolStripMenuItem();
            mnuBaiMau1 = new ToolStripMenuItem();
            mnuBaiMau2 = new ToolStripMenuItem();
            mnuBaiMau3 = new ToolStripMenuItem();

            mnuBaiTap = new ToolStripMenuItem();
            mnuBaiTap1 = new ToolStripMenuItem();
            mnuBaiTap2 = new ToolStripMenuItem();

            mnuNangCao = new ToolStripMenuItem();
            mnuNangCao1 = new ToolStripMenuItem();

            mnuVeNha = new ToolStripMenuItem();
            mnuVeNha1 = new ToolStripMenuItem();

            mnuHeThong = new ToolStripMenuItem();
            mnuDongTatCa = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();

            SuspendLayout();

            // Cấu hình Form Main
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 750);
            Font = new Font("Tahoma", 11F);
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            BackColor = Color.WhiteSmoke;

            Name = "BaiVeNha02_FormMain";
            Text = "LAB05D - HỆ THỐNG QUẢN LÝ BÀI TẬP WINFORMS";

            // Cho phép chứa nhiều Form con
            IsMdiContainer = true;

            // MenuStrip
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.Font = new Font("Tahoma", 11F);
            menuStrip1.BackColor =
                Color.FromArgb(230, 235, 245);

            // Menu Bài mẫu
            mnuBaiMau.Text = "Bài mẫu";
            mnuBaiMau1.Text = "Bài mẫu 1 - Timer";
            mnuBaiMau2.Text = "Bài mẫu 2 - ListView";
            mnuBaiMau3.Text = "Bài mẫu 3 - Đọc ghi file";

            mnuBaiMau.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    mnuBaiMau1,
                    mnuBaiMau2,
                    mnuBaiMau3
                });

            // Menu Bài tập tại lớp
            mnuBaiTap.Text = "Bài tập tại lớp";
            mnuBaiTap1.Text = "Bài tập 1 - Quản lý sinh viên";
            mnuBaiTap2.Text = "Bài tập 2 - Quản lý tài khoản";

            mnuBaiTap.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    mnuBaiTap1,
                    mnuBaiTap2
                });

            // Menu Bài nâng cao
            mnuNangCao.Text = "Bài nâng cao";
            mnuNangCao1.Text = "Bài nâng cao 1 - Quản lý học viên";
            mnuNangCao.DropDownItems.Add(mnuNangCao1);

            // Menu Bài về nhà
            mnuVeNha.Text = "Bài về nhà";
            mnuVeNha1.Text = "Bài về nhà 1 - Đồng hồ đếm ngược";
            mnuVeNha.DropDownItems.Add(mnuVeNha1);

            // Menu Hệ thống
            mnuHeThong.Text = "Hệ thống";
            mnuDongTatCa.Text = "Đóng tất cả Form";
            mnuThoat.Text = "Thoát chương trình";

            mnuHeThong.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    mnuDongTatCa,
                    new ToolStripSeparator(),
                    mnuThoat
                });

            // Gắn menu lên thanh chính
            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    mnuBaiMau,
                    mnuBaiTap,
                    mnuNangCao,
                    mnuVeNha,
                    mnuHeThong
                });

            // Đăng ký sự kiện Click
            mnuBaiMau1.Click += mnuBaiMau1_Click;
            mnuBaiMau2.Click += mnuBaiMau2_Click;
            mnuBaiMau3.Click += mnuBaiMau3_Click;

            mnuBaiTap1.Click += mnuBaiTap1_Click;
            mnuBaiTap2.Click += mnuBaiTap2_Click;

            mnuNangCao1.Click += mnuNangCao1_Click;
            mnuVeNha1.Click += mnuVeNha1_Click;

            mnuDongTatCa.Click += mnuDongTatCa_Click;
            mnuThoat.Click += mnuThoat_Click;

            // Thêm MenuStrip vào Form
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;

            // Xác nhận trước khi thoát
            FormClosing +=
                BaiVeNha02_FormMain_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
