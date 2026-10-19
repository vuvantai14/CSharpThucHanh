
namespace LAB06B
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
            lblMaMonHoc = new Label();
            lblDiem = new Label();

            cboMaSV = new ComboBox();
            cboMaMonHoc = new ComboBox();
            txtDiem = new TextBox();

            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();

            SuspendLayout();

            // Mã sinh viên
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(35, 40);
            lblMaSV.Text = "Mã sinh viên:";

            cboMaSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaSV.Location = new Point(150, 35);
            cboMaSV.Name = "cboMaSV";
            cboMaSV.Size = new Size(245, 28);
            cboMaSV.TabIndex = 0;

            // Mã môn học
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.Location = new Point(35, 95);
            lblMaMonHoc.Text = "Mã môn học:";

            cboMaMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaMonHoc.Location = new Point(150, 90);
            cboMaMonHoc.Name = "cboMaMonHoc";
            cboMaMonHoc.Size = new Size(245, 28);
            cboMaMonHoc.TabIndex = 1;

            // Điểm
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(35, 150);
            lblDiem.Text = "Điểm:";

            txtDiem.Location = new Point(150, 145);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(245, 27);
            txtDiem.TabIndex = 2;

            // Thêm
            btnThem.Location = new Point(50, 210);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 38);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // Xóa
            btnXoa.Location = new Point(175, 210);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 38);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // Sửa
            btnSua.Location = new Point(300, 210);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 38);
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 290);

            Controls.Add(lblMaSV);
            Controls.Add(lblMaMonHoc);
            Controls.Add(lblDiem);

            Controls.Add(cboMaSV);
            Controls.Add(cboMaMonHoc);
            Controls.Add(txtDiem);

            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "QLDiem";
            Text = "Quản lý Điểm";

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblMaSV;
        private Label lblMaMonHoc;
        private Label lblDiem;

        private ComboBox cboMaSV;
        private ComboBox cboMaMonHoc;
        private TextBox txtDiem;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
