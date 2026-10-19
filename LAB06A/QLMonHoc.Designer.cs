
namespace LAB06A
{
    partial class QLMonHoc
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
            lblMaMonHoc = new Label();
            lblTenMonHoc = new Label();
            txtMaMonHoc = new TextBox();
            txtTenMonHoc = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();

            // lblMaMonHoc
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new Point(30, 35);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Text = "Mã môn học:";

            // lblTenMonHoc
            lblTenMonHoc.AutoSize = true;
            lblTenMonHoc.Location = new Point(30, 80);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Text = "Tên môn học:";

            // txtMaMonHoc
            txtMaMonHoc.Location = new Point(145, 30);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(220, 27);
            txtMaMonHoc.TabIndex = 0;

            // txtTenMonHoc
            txtTenMonHoc.Location = new Point(145, 75);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(220, 27);
            txtTenMonHoc.TabIndex = 1;

            // btnThem
            btnThem.Location = new Point(45, 135);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 35);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // btnXoa
            btnXoa.Location = new Point(155, 135);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 35);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // btnSua
            btnSua.Location = new Point(265, 135);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 35);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // QLMonHoc
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 205);
            Controls.Add(lblMaMonHoc);
            Controls.Add(lblTenMonHoc);
            Controls.Add(txtMaMonHoc);
            Controls.Add(txtTenMonHoc);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QLMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý môn học";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaMonHoc;
        private Label lblTenMonHoc;
        private TextBox txtMaMonHoc;
        private TextBox txtTenMonHoc;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
