
namespace LAB06B
{
    partial class DanhSachDiem
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
            lblTieuDe = new Label();
            lblMonHoc = new Label();
            lblTongDiem = new Label();
            lblSoLuong = new Label();

            cboMonHoc = new ComboBox();
            btnLoc = new Button();
            txtTongDiem = new TextBox();

            lvDanhSachDiem = new ListView();

            colSTT = new ColumnHeader();
            colHoTen = new ColumnHeader();
            colNgaySinh = new ColumnHeader();
            colTenMonHoc = new ColumnHeader();
            colDiem = new ColumnHeader();

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.Font = new Font(
                "Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(20, 20);
            lblTieuDe.Size = new Size(810, 45);
            lblTieuDe.Text = "DANH SÁCH ĐIỂM SINH VIÊN";
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // Label Môn học
            lblMonHoc.AutoSize = true;
            lblMonHoc.Location = new Point(45, 90);
            lblMonHoc.Text = "Môn học:";

            // ComboBox môn học
            cboMonHoc.DropDownStyle =
                ComboBoxStyle.DropDownList;
            cboMonHoc.Location = new Point(145, 85);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(280, 28);

            // Nút Lọc dữ liệu
            btnLoc.Location = new Point(460, 82);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(145, 36);
            btnLoc.Text = "Lọc dữ liệu";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;

            // ListView
            lvDanhSachDiem.Location = new Point(30, 145);
            lvDanhSachDiem.Name = "lvDanhSachDiem";
            lvDanhSachDiem.Size = new Size(790, 300);

            lvDanhSachDiem.View = View.Details;
            lvDanhSachDiem.FullRowSelect = true;
            lvDanhSachDiem.GridLines = true;
            lvDanhSachDiem.MultiSelect = false;
            lvDanhSachDiem.HideSelection = false;

            lvDanhSachDiem.Columns.AddRange(
                new ColumnHeader[]
                {
                    colSTT,
                    colHoTen,
                    colNgaySinh,
                    colTenMonHoc,
                    colDiem
                });

            // Các cột ListView
            colSTT.Text = "STT";
            colSTT.Width = 55;
            colSTT.TextAlign = HorizontalAlignment.Center;

            colHoTen.Text = "Tên sinh viên";
            colHoTen.Width = 230;

            colNgaySinh.Text = "Ngày sinh";
            colNgaySinh.Width = 135;

            colTenMonHoc.Text = "Tên môn học";
            colTenMonHoc.Width = 260;

            colDiem.Text = "Điểm";
            colDiem.Width = 100;
            colDiem.TextAlign = HorizontalAlignment.Center;

            // Số bản ghi
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(35, 470);
            lblSoLuong.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            lblSoLuong.Text = "Số bản ghi: 0";

            // Tổng điểm
            lblTongDiem.AutoSize = true;
            lblTongDiem.Location = new Point(550, 470);
            lblTongDiem.Text = "Tổng điểm:";

            txtTongDiem.Location = new Point(645, 465);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.Size = new Size(170, 27);
            txtTongDiem.ReadOnly = true;
            txtTongDiem.Text = "0";
            txtTongDiem.TextAlign =
                HorizontalAlignment.Right;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 530);

            Controls.Add(lblTieuDe);
            Controls.Add(lblMonHoc);
            Controls.Add(cboMonHoc);
            Controls.Add(btnLoc);
            Controls.Add(lvDanhSachDiem);
            Controls.Add(lblSoLuong);
            Controls.Add(lblTongDiem);
            Controls.Add(txtTongDiem);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "DanhSachDiem";
            Text = "Danh sách Điểm sinh viên";

            Load += DanhSachDiem_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTieuDe;
        private Label lblMonHoc;
        private Label lblTongDiem;
        private Label lblSoLuong;

        private ComboBox cboMonHoc;
        private Button btnLoc;
        private TextBox txtTongDiem;

        private ListView lvDanhSachDiem;

        private ColumnHeader colSTT;
        private ColumnHeader colHoTen;
        private ColumnHeader colNgaySinh;
        private ColumnHeader colTenMonHoc;
        private ColumnHeader colDiem;
    }
}
