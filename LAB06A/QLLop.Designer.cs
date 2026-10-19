
namespace LAB06A
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

            txtMaKhoa = new TextBox();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();

            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();

            SuspendLayout();

            // lblMaKhoa
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(35, 35);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Text = "Mã khoa:";

            // lblMaLop
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(35, 80);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Text = "Mã lớp:";

            // lblTenLop
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(35, 125);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Text = "Tên lớp:";

            // txtMaKhoa
            txtMaKhoa.Location = new Point(135, 30);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(230, 27);
            txtMaKhoa.TabIndex = 0;

            // txtMaLop
            txtMaLop.Location = new Point(135, 75);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(230, 27);
            txtMaLop.TabIndex = 1;

            // txtTenLop
            txtTenLop.Location = new Point(135, 120);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(230, 27);
            txtTenLop.TabIndex = 2;

            // btnThem
            btnThem.Location = new Point(45, 180);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 38);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // btnXoa
            btnXoa.Location = new Point(155, 180);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 38);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // btnSua
            btnSua.Location = new Point(265, 180);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 38);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // QLLop
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 255);

            Controls.Add(lblMaKhoa);
            Controls.Add(lblMaLop);
            Controls.Add(lblTenLop);
            Controls.Add(txtMaKhoa);
            Controls.Add(txtMaLop);
            Controls.Add(txtTenLop);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QLLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaKhoa;
        private Label lblMaLop;
        private Label lblTenLop;

        private TextBox txtMaKhoa;
        private TextBox txtMaLop;
        private TextBox txtTenLop;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
