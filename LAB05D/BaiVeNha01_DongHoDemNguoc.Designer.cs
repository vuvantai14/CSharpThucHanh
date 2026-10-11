
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiVeNha01_DongHoDemNguoc
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblDongHo;
        private Label lblPhut;
        private Label lblGiay;

        private ComboBox cboPhut;
        private ComboBox cboGiay;

        private Button btnBatDau;
        private Button btnTamDung;
        private Button btnDatLai;
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
            lblDongHo = new Label();
            lblPhut = new Label();
            lblGiay = new Label();

            cboPhut = new ComboBox();
            cboGiay = new ComboBox();

            btnBatDau = new Button();
            btnTamDung = new Button();
            btnDatLai = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Cấu hình Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 430);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "BaiVeNha01_DongHoDemNguoc";
            Text = "Bài về nhà 1 - Đồng hồ đếm ngược";

            // Tiêu đề
            lblTieuDe.Text = "ĐỒNG HỒ ĐẾM NGƯỢC";
            lblTieuDe.Font = new Font(
                "Tahoma", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(45, 25);
            lblTieuDe.Size = new Size(560, 55);

            // Đồng hồ
            lblDongHo.Text = "00:00";
            lblDongHo.Font = new Font(
                "Consolas", 48F, FontStyle.Bold);
            lblDongHo.ForeColor = Color.Red;
            lblDongHo.BackColor = Color.White;
            lblDongHo.BorderStyle = BorderStyle.FixedSingle;
            lblDongHo.TextAlign =
                ContentAlignment.MiddleCenter;
            lblDongHo.Location = new Point(125, 100);
            lblDongHo.Size = new Size(400, 105);

            // Nhãn phút
            lblPhut.Text = "Phút:";
            lblPhut.Location = new Point(155, 235);
            lblPhut.AutoSize = true;

            // ComboBox phút
            cboPhut.Location = new Point(215, 230);
            cboPhut.Size = new Size(100, 30);
            cboPhut.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Nhãn giây
            lblGiay.Text = "Giây:";
            lblGiay.Location = new Point(340, 235);
            lblGiay.AutoSize = true;

            // ComboBox giây
            cboGiay.Location = new Point(400, 230);
            cboGiay.Size = new Size(100, 30);
            cboGiay.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Dữ liệu phút: 00 - 99
            for (int i = 0; i <= 99; i++)
            {
                cboPhut.Items.Add(i.ToString("00"));
            }

            // Dữ liệu giây: 00 - 59
            for (int i = 0; i <= 59; i++)
            {
                cboGiay.Items.Add(i.ToString("00"));
            }

            // Mặc định 30 phút
            cboPhut.SelectedItem = "30";
            cboGiay.SelectedItem = "00";

            // Nút Bắt đầu
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.Location = new Point(45, 305);
            btnBatDau.Size = new Size(130, 45);
            btnBatDau.Click += btnBatDau_Click;

            // Nút Tạm dừng
            btnTamDung.Text = "Tạm dừng";
            btnTamDung.Location = new Point(185, 305);
            btnTamDung.Size = new Size(130, 45);
            btnTamDung.Click += btnTamDung_Click;

            // Nút Đặt lại
            btnDatLai.Text = "Đặt lại";
            btnDatLai.Location = new Point(325, 305);
            btnDatLai.Size = new Size(130, 45);
            btnDatLai.Click += btnDatLai_Click;

            // Nút Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(465, 305);
            btnThoat.Size = new Size(130, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm Controls
            Controls.Add(lblTieuDe);
            Controls.Add(lblDongHo);
            Controls.Add(lblPhut);
            Controls.Add(cboPhut);
            Controls.Add(lblGiay);
            Controls.Add(cboGiay);
            Controls.Add(btnBatDau);
            Controls.Add(btnTamDung);
            Controls.Add(btnDatLai);
            Controls.Add(btnThoat);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
