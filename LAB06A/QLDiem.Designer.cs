
namespace LAB06A
{
    partial class QLDiem
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
            lblMaSV = new Label();
            lblMaMH = new Label();
            lblDiem = new Label();

            txtMaSV = new TextBox();
            txtMaMH = new TextBox();
            txtDiem = new TextBox();

            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();

            SuspendLayout();

            // lblMaSV
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(35, 35);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Text = "Mã sinh viên:";

            // lblMaMH
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(35, 80);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Text = "Mã môn học:";

            // lblDiem
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(35, 125);
            lblDiem.Name = "lblDiem";
            lblDiem.Text = "Điểm:";

            // txtMaSV
            txtMaSV.Location = new Point(145, 30);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(220, 27);
            txtMaSV.TabIndex = 0;

            // txtMaMH
            txtMaMH.Location = new Point(145, 75);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(220, 27);
            txtMaMH.TabIndex = 1;

            // txtDiem
            txtDiem.Location = new Point(145, 120);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(220, 27);
            txtDiem.TabIndex = 2;

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

            // QLDiem
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 255);

            Controls.Add(lblMaSV);
            Controls.Add(lblMaMH);
            Controls.Add(lblDiem);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaMH);
            Controls.Add(txtDiem);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QLDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Điểm";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaSV;
        private Label lblMaMH;
        private Label lblDiem;

        private TextBox txtMaSV;
        private TextBox txtMaMH;
        private TextBox txtDiem;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
