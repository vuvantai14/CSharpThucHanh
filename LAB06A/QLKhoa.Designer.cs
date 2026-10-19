
namespace LAB06A
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
            lblMaKhoa.Location = new Point(30, 35);
            lblMaKhoa.Text = "Mã khoa:";

            // lblTenKhoa
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new Point(30, 80);
            lblTenKhoa.Text = "Tên khoa:";

            // txtMaKhoa
            txtMaKhoa.Location = new Point(125, 30);
            txtMaKhoa.Size = new Size(220, 27);

            // txtTenKhoa
            txtTenKhoa.Location = new Point(125, 75);
            txtTenKhoa.Size = new Size(220, 27);

            // btnThem
            btnThem.Location = new Point(35, 135);
            btnThem.Size = new Size(90, 35);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            // btnXoa
            btnXoa.Location = new Point(145, 135);
            btnXoa.Size = new Size(90, 35);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            // btnSua
            btnSua.Location = new Point(255, 135);
            btnSua.Size = new Size(90, 35);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            // QLKhoa
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 205);
            Controls.Add(lblMaKhoa);
            Controls.Add(lblTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(txtTenKhoa);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
