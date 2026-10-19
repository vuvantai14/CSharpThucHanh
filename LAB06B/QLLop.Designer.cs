
namespace LAB06B
{
    partial class QLLop
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
            lblMaKhoa = new Label();
            lblMaLop = new Label();
            lblTenLop = new Label();

            cboMaKhoa = new ComboBox();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();

            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();

            SuspendLayout();

            // Mã khoa
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(40, 40);
            lblMaKhoa.Text = "Mã khoa:";

            cboMaKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaKhoa.Location = new Point(145, 35);
            cboMaKhoa.Name = "cboMaKhoa";
            cboMaKhoa.Size = new Size(235, 28);
            cboMaKhoa.TabIndex = 0;

            // Mã lớp
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(40, 90);
            lblMaLop.Text = "Mã lớp:";

            txtMaLop.Location = new Point(145, 85);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(235, 27);
            txtMaLop.TabIndex = 1;

            // Tên lớp
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(40, 140);
            lblTenLop.Text = "Tên lớp:";

            txtTenLop.Location = new Point(145, 135);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(235, 27);
            txtTenLop.TabIndex = 2;

            // Nút Thêm
            btnThem.Location = new Point(45, 200);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 38);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // Nút Xóa
            btnXoa.Location = new Point(165, 200);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 38);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // Nút Sửa
            btnSua.Location = new Point(285, 200);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 38);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // Form QLLop
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 280);

            Controls.Add(lblMaKhoa);
            Controls.Add(lblMaLop);
            Controls.Add(lblTenLop);
            Controls.Add(cboMaKhoa);
            Controls.Add(txtMaLop);
            Controls.Add(txtTenLop);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QLLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Lớp";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaKhoa;
        private Label lblMaLop;
        private Label lblTenLop;

        private ComboBox cboMaKhoa;
        private TextBox txtMaLop;
        private TextBox txtTenLop;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
