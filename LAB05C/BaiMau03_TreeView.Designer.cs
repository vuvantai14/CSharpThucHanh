
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiMau03_TreeView
    {
        private System.ComponentModel.IContainer components = null;

        private TreeView trv_DS;
        private ComboBox cbo_phongban;

        private TextBox txt_phongban;
        private TextBox txt_maso;
        private TextBox txt_hoten;
        private TextBox txt_diachi;

        private Label lblTieuDe;
        private Label lblPhongBan;
        private Label lblMaSo;
        private Label lblHoTen;
        private Label lblDiaChi;
        private Label lblChonPB;

        private Button btn_ThemPB;
        private Button btn_XoaPB;
        private Button btn_ThemNV;
        private Button btn_Thoat;

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
            trv_DS = new TreeView();
            cbo_phongban = new ComboBox();

            txt_phongban = new TextBox();
            txt_maso = new TextBox();
            txt_hoten = new TextBox();
            txt_diachi = new TextBox();

            lblTieuDe = new Label();
            lblPhongBan = new Label();
            lblMaSo = new Label();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblChonPB = new Label();

            btn_ThemPB = new Button();
            btn_XoaPB = new Button();
            btn_ThemNV = new Button();
            btn_Thoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 530);
            Font = new Font("Times New Roman", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "BaiMau03_TreeView";
            Text = "Phòng ban - Nhân viên";
            BackColor = Color.WhiteSmoke;

            // TreeView
            trv_DS.Location = new Point(20, 55);
            trv_DS.Size = new Size(275, 340);
            trv_DS.Name = "trv_DS";

            // Label phòng ban bên trái
            lblPhongBan.Text = "Phòng ban";
            lblPhongBan.Location = new Point(20, 410);
            lblPhongBan.AutoSize = true;

            // TextBox nhập phòng ban
            txt_phongban.Location = new Point(120, 405);
            txt_phongban.Size = new Size(175, 30);
            txt_phongban.Name = "txt_phongban";

            // Button thêm phòng ban
            btn_ThemPB.Text = "Thêm phòng ban";
            btn_ThemPB.Location = new Point(120, 445);
            btn_ThemPB.Size = new Size(175, 35);
            btn_ThemPB.Click += btn_ThemPB_Click;

            // Button xóa phòng ban
            btn_XoaPB.Text = "Xóa phòng ban";
            btn_XoaPB.Location = new Point(120, 485);
            btn_XoaPB.Size = new Size(175, 35);
            btn_XoaPB.Click += btn_XoaPB_Click;

            // Tiêu đề hồ sơ nhân viên
            lblTieuDe.Text = "HỒ SƠ NHÂN VIÊN";
            lblTieuDe.Font = new Font(
                "Times New Roman",
                18F,
                FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Blue;
            lblTieuDe.Location = new Point(365, 35);
            lblTieuDe.Size = new Size(420, 45);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // Mã số
            lblMaSo.Text = "Mã số";
            lblMaSo.Location = new Point(340, 105);
            lblMaSo.AutoSize = true;

            txt_maso.Location = new Point(405, 100);
            txt_maso.Size = new Size(130, 30);

            // Họ tên
            lblHoTen.Text = "Họ tên";
            lblHoTen.Location = new Point(555, 105);
            lblHoTen.AutoSize = true;

            txt_hoten.Location = new Point(625, 100);
            txt_hoten.Size = new Size(195, 30);

            // Địa chỉ
            lblDiaChi.Text = "Địa chỉ";
            lblDiaChi.Location = new Point(340, 160);
            lblDiaChi.AutoSize = true;

            txt_diachi.Location = new Point(405, 155);
            txt_diachi.Size = new Size(415, 30);

            // Chọn phòng ban
            lblChonPB.Text = "Phòng ban";
            lblChonPB.Location = new Point(340, 215);
            lblChonPB.AutoSize = true;

            cbo_phongban.Location = new Point(445, 210);
            cbo_phongban.Size = new Size(375, 30);
            cbo_phongban.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Button thêm nhân viên
            btn_ThemNV.Text = "Thêm";
            btn_ThemNV.Location = new Point(445, 270);
            btn_ThemNV.Size = new Size(110, 40);
            btn_ThemNV.Click += btn_ThemNV_Click;

            // Button thoát
            btn_Thoat.Text = "Thoát";
            btn_Thoat.Location = new Point(575, 270);
            btn_Thoat.Size = new Size(110, 40);
            btn_Thoat.Click += btn_Thoat_Click;

            // Thêm Controls
            Controls.Add(trv_DS);
            Controls.Add(lblPhongBan);
            Controls.Add(txt_phongban);
            Controls.Add(btn_ThemPB);
            Controls.Add(btn_XoaPB);

            Controls.Add(lblTieuDe);
            Controls.Add(lblMaSo);
            Controls.Add(txt_maso);
            Controls.Add(lblHoTen);
            Controls.Add(txt_hoten);
            Controls.Add(lblDiaChi);
            Controls.Add(txt_diachi);
            Controls.Add(lblChonPB);
            Controls.Add(cbo_phongban);
            Controls.Add(btn_ThemNV);
            Controls.Add(btn_Thoat);

            Load += BaiMau03_TreeView_Load;
            FormClosing += BaiMau03_TreeView_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
