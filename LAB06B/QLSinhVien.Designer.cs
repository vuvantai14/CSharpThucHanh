
namespace LAB06B
{
    partial class QLSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaLop = new Label();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();

            cboMaLop = new ComboBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();

            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();

            SuspendLayout();

            // Mã lớp
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(40, 35);
            lblMaLop.Text = "Mã lớp:";

            cboMaLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaLop.Location = new Point(145, 30);
            cboMaLop.Name = "cboMaLop";
            cboMaLop.Size = new Size(245, 28);
            cboMaLop.TabIndex = 0;

            // Mã sinh viên
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(40, 85);
            lblMaSV.Text = "Mã SV:";

            txtMaSV.Location = new Point(145, 80);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(245, 27);
            txtMaSV.TabIndex = 1;

            // Họ tên
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(40, 135);
            lblHoTen.Text = "Họ tên:";

            txtHoTen.Location = new Point(145, 130);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(245, 27);
            txtHoTen.TabIndex = 2;

            // Ngày sinh
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(40, 185);
            lblNgaySinh.Text = "Ngày sinh:";

            txtNgaySinh.Location = new Point(145, 180);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(245, 27);
            txtNgaySinh.PlaceholderText = "dd/MM/yyyy";
            txtNgaySinh.TabIndex = 3;

            // Thêm
            btnThem.Location = new Point(50, 250);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 38);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // Xóa
            btnXoa.Location = new Point(175, 250);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 38);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // Sửa
            btnSua.Location = new Point(300, 250);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 38);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // Form QLSinhVien
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 330);

            Controls.Add(lblMaLop);
            Controls.Add(lblMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(lblNgaySinh);

            Controls.Add(cboMaLop);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(txtNgaySinh);

            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "QLSinhVien";
            Text = "Quản lý Sinh viên";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaLop;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblNgaySinh;

        private ComboBox cboMaLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
