
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiTap02_QuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        private TreeView trvDanhSach;
        private ComboBox cboChonLop;

        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtDiaChi;
        private TextBox txtTenLop;

        private Label lblChonLop;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblDiaChi;
        private Label lblTenLop;

        private GroupBox grpThongTinSV;
        private GroupBox grpThongTinLop;

        private CheckBox chkThemLop;

        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnThemLop;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            trvDanhSach = new TreeView();
            cboChonLop = new ComboBox();

            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtDiaChi = new TextBox();
            txtTenLop = new TextBox();

            lblChonLop = new Label();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblDiaChi = new Label();
            lblTenLop = new Label();

            grpThongTinSV = new GroupBox();
            grpThongTinLop = new GroupBox();

            chkThemLop = new CheckBox();

            btnCapNhat = new Button();
            btnXoa = new Button();
            btnThemLop = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 560);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            Name = "BaiTap02_QuanLySinhVien";
            BackColor = Color.WhiteSmoke;

            // TreeView
            trvDanhSach.Location = new Point(20, 25);
            trvDanhSach.Size = new Size(290, 500);
            trvDanhSach.Name = "trvDanhSach";
            trvDanhSach.AfterSelect +=
                trvDanhSach_AfterSelect;

            // Chọn lớp
            lblChonLop.Text = "Chọn lớp:";
            lblChonLop.Location = new Point(350, 35);
            lblChonLop.AutoSize = true;

            cboChonLop.Location = new Point(470, 30);
            cboChonLop.Size = new Size(310, 30);
            cboChonLop.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // GroupBox thông tin sinh viên
            grpThongTinSV.Text = "Thông tin sinh viên";
            grpThongTinSV.Location = new Point(335, 85);
            grpThongTinSV.Size = new Size(460, 270);

            // Mã sinh viên
            lblMaSV.Text = "Mã SV:";
            lblMaSV.Location = new Point(20, 50);
            lblMaSV.AutoSize = true;

            txtMaSV.Location = new Point(130, 45);
            txtMaSV.Size = new Size(300, 30);

            // Họ tên
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Location = new Point(20, 105);
            lblHoTen.AutoSize = true;

            txtHoTen.Location = new Point(130, 100);
            txtHoTen.Size = new Size(300, 30);

            // Địa chỉ
            lblDiaChi.Text = "Địa chỉ:";
            lblDiaChi.Location = new Point(20, 160);
            lblDiaChi.AutoSize = true;

            txtDiaChi.Location = new Point(130, 155);
            txtDiaChi.Size = new Size(300, 30);

            // Button cập nhật
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Location = new Point(130, 210);
            btnCapNhat.Size = new Size(140, 40);
            btnCapNhat.Click += btnCapNhat_Click;

            // Button xóa
            btnXoa.Text = "Xóa";
            btnXoa.Location = new Point(290, 210);
            btnXoa.Size = new Size(140, 40);
            btnXoa.Click += btnXoa_Click;

            // Thêm controls vào GroupBox SV
            grpThongTinSV.Controls.Add(lblMaSV);
            grpThongTinSV.Controls.Add(txtMaSV);
            grpThongTinSV.Controls.Add(lblHoTen);
            grpThongTinSV.Controls.Add(txtHoTen);
            grpThongTinSV.Controls.Add(lblDiaChi);
            grpThongTinSV.Controls.Add(txtDiaChi);
            grpThongTinSV.Controls.Add(btnCapNhat);
            grpThongTinSV.Controls.Add(btnXoa);

            // Checkbox thêm lớp
            chkThemLop.Text = "Thêm lớp";
            chkThemLop.Location = new Point(340, 380);
            chkThemLop.AutoSize = true;
            chkThemLop.CheckedChanged +=
                chkThemLop_CheckedChanged;

            // GroupBox thông tin lớp
            grpThongTinLop.Text = "Thông tin lớp";
            grpThongTinLop.Location = new Point(335, 420);
            grpThongTinLop.Size = new Size(460, 105);
            grpThongTinLop.Visible = false;

            // Label tên lớp
            lblTenLop.Text = "Tên lớp:";
            lblTenLop.Location = new Point(20, 45);
            lblTenLop.AutoSize = true;

            // TextBox tên lớp
            txtTenLop.Location = new Point(120, 40);
            txtTenLop.Size = new Size(195, 30);

            // Button thêm lớp
            btnThemLop.Text = "Thêm lớp";
            btnThemLop.Location = new Point(325, 38);
            btnThemLop.Size = new Size(115, 36);
            btnThemLop.Click += btnThemLop_Click;

            grpThongTinLop.Controls.Add(lblTenLop);
            grpThongTinLop.Controls.Add(txtTenLop);
            grpThongTinLop.Controls.Add(btnThemLop);

            // Thêm controls vào Form
            Controls.Add(trvDanhSach);
            Controls.Add(lblChonLop);
            Controls.Add(cboChonLop);
            Controls.Add(grpThongTinSV);
            Controls.Add(chkThemLop);
            Controls.Add(grpThongTinLop);

            Load += BaiTap02_QuanLySinhVien_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
