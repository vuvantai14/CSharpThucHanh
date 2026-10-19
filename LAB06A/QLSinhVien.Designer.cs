
namespace LAB06A
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
            txtMaLop = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();

            // Labels
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(35, 35);
            lblMaLop.Text = "Mã lớp:";

            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(35, 80);
            lblMaSV.Text = "Mã SV:";

            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(35, 125);
            lblHoTen.Text = "Họ tên:";

            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(35, 170);
            lblNgaySinh.Text = "Ngày sinh:";

            // TextBoxes
            txtMaLop.Location = new Point(140, 30);
            txtMaLop.Size = new Size(240, 27);

            txtMaSV.Location = new Point(140, 75);
            txtMaSV.Size = new Size(240, 27);

            txtHoTen.Location = new Point(140, 120);
            txtHoTen.Size = new Size(240, 27);

            txtNgaySinh.Location = new Point(140, 165);
            txtNgaySinh.Size = new Size(240, 27);

            // Buttons
            btnThem.Location = new Point(55, 225);
            btnThem.Size = new Size(90, 38);
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;

            btnXoa.Location = new Point(165, 225);
            btnXoa.Size = new Size(90, 38);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;

            btnSua.Location = new Point(275, 225);
            btnSua.Size = new Size(90, 38);
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 300);
            Controls.Add(lblMaLop);
            Controls.Add(lblMaSV);
            Controls.Add(lblHoTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(txtMaLop);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(txtNgaySinh);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaLop;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private TextBox txtMaLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
