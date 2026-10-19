
namespace LAB06B
{
    partial class QLKhoa
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
            lblTenKhoa = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();

            SuspendLayout();

            // lblMaKhoa
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(35, 40);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Text = "Mã khoa:";

            // lblTenKhoa
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new Point(35, 90);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Text = "Tên khoa:";

            // txtMaKhoa
            txtMaKhoa.Location = new Point(135, 35);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(235, 27);
            txtMaKhoa.TabIndex = 0;

            // txtTenKhoa
            txtTenKhoa.Location = new Point(135, 85);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(235, 27);
            txtTenKhoa.TabIndex = 1;

            // btnThem
            btnThem.Location = new Point(45, 150);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 38);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // btnXoa
            btnXoa.Location = new Point(155, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 38);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // btnSua
            btnSua.Location = new Point(265, 150);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 38);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // Form QLKhoa
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 230);

            Controls.Add(lblMaKhoa);
            Controls.Add(lblTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(txtTenKhoa);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QLKhoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Khoa";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaKhoa;
        private Label lblTenKhoa;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
