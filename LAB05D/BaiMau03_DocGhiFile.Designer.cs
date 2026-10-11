
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiMau03_DocGhiFile
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblDuongDan;
        private Label lblNoiDung;

        private TextBox txtDuongDan;
        private RichTextBox rtbNoiDung;

        private Button btnMoFile;
        private Button btnLuuFile;
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
            lblDuongDan = new Label();
            lblNoiDung = new Label();

            txtDuongDan = new TextBox();
            rtbNoiDung = new RichTextBox();

            btnMoFile = new Button();
            btnLuuFile = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Cấu hình Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 600);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Name = "BaiMau03_DocGhiFile";
            Text = "Bài mẫu 3 - Đọc và ghi file TXT";

            // Tiêu đề
            lblTieuDe.Text = "ĐỌC VÀ GHI FILE VĂN BẢN";
            lblTieuDe.Font = new Font(
                "Tahoma", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(80, 20);
            lblTieuDe.Size = new Size(690, 55);

            // Label đường dẫn
            lblDuongDan.Text = "Đường dẫn file:";
            lblDuongDan.Location = new Point(40, 105);
            lblDuongDan.AutoSize = true;

            // TextBox đường dẫn
            txtDuongDan.Location = new Point(195, 100);
            txtDuongDan.Size = new Size(610, 30);
            txtDuongDan.ReadOnly = true;
            txtDuongDan.BackColor = Color.White;
            txtDuongDan.Name = "txtDuongDan";

            // Label nội dung
            lblNoiDung.Text = "Nội dung văn bản:";
            lblNoiDung.Location = new Point(40, 155);
            lblNoiDung.AutoSize = true;

            // RichTextBox
            rtbNoiDung.Location = new Point(40, 190);
            rtbNoiDung.Size = new Size(765, 285);
            rtbNoiDung.Font = new Font("Tahoma", 12F);
            rtbNoiDung.BackColor = Color.White;
            rtbNoiDung.BorderStyle = BorderStyle.FixedSingle;
            rtbNoiDung.ScrollBars =
                RichTextBoxScrollBars.Vertical;
            rtbNoiDung.Name = "rtbNoiDung";

            // Nút Mở File
            btnMoFile.Text = "Mở File";
            btnMoFile.Location = new Point(40, 505);
            btnMoFile.Size = new Size(170, 45);
            btnMoFile.Click += btnMoFile_Click;

            // Nút Lưu File
            btnLuuFile.Text = "Lưu File";
            btnLuuFile.Location = new Point(235, 505);
            btnLuuFile.Size = new Size(170, 45);
            btnLuuFile.Click += btnLuuFile_Click;

            // Nút Làm mới
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Location = new Point(430, 505);
            btnLamMoi.Size = new Size(170, 45);
            btnLamMoi.Click += btnLamMoi_Click;

            // Nút Thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(635, 505);
            btnThoat.Size = new Size(170, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm các Control
            Controls.Add(lblTieuDe);
            Controls.Add(lblDuongDan);
            Controls.Add(txtDuongDan);
            Controls.Add(lblNoiDung);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnMoFile);
            Controls.Add(btnLuuFile);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
