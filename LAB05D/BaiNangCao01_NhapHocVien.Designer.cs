
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    partial class BaiNangCao01_NhapHocVien
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblHoTen;
        private Label lblLop;

        private TextBox txtHoTen;
        private ComboBox cboLop;

        private Button btnCapNhat;
        private Button btnTroVe;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblLop = new Label();

            txtHoTen = new TextBox();
            cboLop = new ComboBox();

            btnCapNhat = new Button();
            btnTroVe = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 350);
            Font = new Font("Tahoma", 11F);
            BackColor = Color.WhiteSmoke;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            Name = "BaiNangCao01_NhapHocVien";
            Text = "Nhập học viên mới";

            // Tiêu đề
            lblTieuDe.Text = "NHẬP THÔNG TIN HỌC VIÊN";
            lblTieuDe.Font = new Font(
                "Tahoma", 17F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;
            lblTieuDe.Location = new Point(30, 25);
            lblTieuDe.Size = new Size(490, 55);

            // Họ tên
            lblHoTen.Text = "Họ và tên:";
            lblHoTen.Location = new Point(55, 120);
            lblHoTen.AutoSize = true;

            txtHoTen.Location = new Point(190, 115);
            txtHoTen.Size = new Size(300, 30);
            txtHoTen.Name = "txtHoTen";

            // Lớp
            lblLop.Text = "Lớp:";
            lblLop.Location = new Point(55, 180);
            lblLop.AutoSize = true;

            cboLop.Location = new Point(190, 175);
            cboLop.Size = new Size(300, 30);
            cboLop.Name = "cboLop";
            cboLop.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Cập nhật
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Location = new Point(190, 245);
            btnCapNhat.Size = new Size(135, 45);
            btnCapNhat.Click += btnCapNhat_Click;

            // Trở về
            btnTroVe.Text = "Trở về";
            btnTroVe.Location = new Point(355, 245);
            btnTroVe.Size = new Size(135, 45);
            btnTroVe.Click += btnTroVe_Click;

            // Thêm Controls
            Controls.Add(lblTieuDe);
            Controls.Add(lblHoTen);
            Controls.Add(txtHoTen);
            Controls.Add(lblLop);
            Controls.Add(cboLop);
            Controls.Add(btnCapNhat);
            Controls.Add(btnTroVe);

            AcceptButton = btnCapNhat;
            CancelButton = btnTroVe;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
