
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiMau01_Timer
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblDongHo;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblDongHo = new Label();

            timer1 = new System.Windows.Forms.Timer(components);

            SuspendLayout();

            // Cấu hình Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 300);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.WhiteSmoke;
            Font = new Font("Tahoma", 12F);

            Name = "BaiMau01_Timer";
            Text = "Bài mẫu 1 - Đồng hồ Timer";

            // Tiêu đề
            lblTieuDe.Text = "ĐỒNG HỒ THỜI GIAN HỆ THỐNG";
            lblTieuDe.Font = new Font(
                "Tahoma", 17F, FontStyle.Bold);

            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            lblTieuDe.Location = new Point(30, 35);
            lblTieuDe.Size = new Size(540, 50);

            // Label hiển thị đồng hồ
            lblDongHo.Text = "00/00/0000 00:00:00";

            lblDongHo.Font = new Font(
                "Tahoma", 25F, FontStyle.Bold);

            lblDongHo.ForeColor = Color.Red;
            lblDongHo.TextAlign =
                ContentAlignment.MiddleCenter;

            lblDongHo.Location = new Point(30, 125);
            lblDongHo.Size = new Size(540, 75);

            lblDongHo.BorderStyle =
                BorderStyle.FixedSingle;

            lblDongHo.BackColor = Color.White;

            // Cấu hình Timer
            timer1.Interval = 1000;
            timer1.Enabled = false;
            timer1.Tick += timer1_Tick;

            // Thêm các Control vào Form
            Controls.Add(lblTieuDe);
            Controls.Add(lblDongHo);

            ResumeLayout(false);
        }
    }
}
