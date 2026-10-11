
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiVeNha01_TuDien
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblTuCanTra;
        private Label lblNghia;
        private Label lblTrangThai;

        private GroupBox grpCheDo;
        private RadioButton radAnhViet;
        private RadioButton radVietAnh;

        private ComboBox cboTuCanTra;
        private TextBox txtNghia;

        private Button btnEnter;
        private Button btnLamMoi;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblTuCanTra = new Label();
            lblNghia = new Label();
            lblTrangThai = new Label();

            grpCheDo = new GroupBox();
            radAnhViet = new RadioButton();
            radVietAnh = new RadioButton();

            cboTuCanTra = new ComboBox();
            txtNghia = new TextBox();

            btnEnter = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 510);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
            Name = "BaiVeNha01_TuDien";
            Text = "Từ điển Anh - Việt và Việt - Anh";

            // Tiêu đề
            lblTieuDe.Text = "TỪ ĐIỂN ANH - VIỆT / VIỆT - ANH";
            lblTieuDe.Font = new Font(
                "Tahoma", 17F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkBlue;
            lblTieuDe.Location = new Point(40, 20);
            lblTieuDe.Size = new Size(740, 50);
            lblTieuDe.TextAlign =
                ContentAlignment.MiddleCenter;

            // GroupBox chế độ
            grpCheDo.Text = "Chọn loại từ điển";
            grpCheDo.Location = new Point(45, 90);
            grpCheDo.Size = new Size(730, 85);

            // Radio Anh - Việt
            radAnhViet.Text = "Anh - Việt";
            radAnhViet.Location = new Point(100, 35);
            radAnhViet.Size = new Size(180, 35);
            radAnhViet.Checked = true;
            radAnhViet.CheckedChanged +=
                radTuDien_CheckedChanged;

            // Radio Việt - Anh
            radVietAnh.Text = "Việt - Anh";
            radVietAnh.Location = new Point(400, 35);
            radVietAnh.Size = new Size(180, 35);
            radVietAnh.CheckedChanged +=
                radTuDien_CheckedChanged;

            grpCheDo.Controls.Add(radAnhViet);
            grpCheDo.Controls.Add(radVietAnh);

            // Label từ cần tra
            lblTuCanTra.Text = "Từ cần tra:";
            lblTuCanTra.Location = new Point(45, 205);
            lblTuCanTra.AutoSize = true;

            // ComboBox từ cần tra
            cboTuCanTra.Location = new Point(45, 240);
            cboTuCanTra.Size = new Size(310, 32);
            cboTuCanTra.Name = "cboTuCanTra";
            cboTuCanTra.DropDownStyle =
                ComboBoxStyle.DropDown;

            cboTuCanTra.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;

            cboTuCanTra.AutoCompleteSource =
                AutoCompleteSource.ListItems;

            cboTuCanTra.KeyDown +=
                cboTuCanTra_KeyDown;

            cboTuCanTra.DoubleClick +=
                cboTuCanTra_DoubleClick;

            cboTuCanTra.TextUpdate +=
                cboTuCanTra_TextUpdate;

            // Label nghĩa
            lblNghia.Text = "Nghĩa của từ:";
            lblNghia.Location = new Point(440, 205);
            lblNghia.AutoSize = true;

            // TextBox nghĩa
            txtNghia.Location = new Point(440, 240);
            txtNghia.Size = new Size(335, 120);
            txtNghia.Multiline = true;
            txtNghia.ReadOnly = true;
            txtNghia.ScrollBars =
                ScrollBars.Vertical;
            txtNghia.BackColor = Color.White;
            txtNghia.Name = "txtNghia";

            // Nút Enter
            btnEnter.Text = "Enter";
            btnEnter.Location = new Point(45, 305);
            btnEnter.Size = new Size(140, 45);
            btnEnter.Click += btnEnter_Click;

            // Nút làm mới
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Location = new Point(205, 305);
            btnLamMoi.Size = new Size(150, 45);
            btnLamMoi.Click += btnLamMoi_Click;

            // Trạng thái
            lblTrangThai.Text = "Sẵn sàng tra cứu";
            lblTrangThai.Location = new Point(45, 390);
            lblTrangThai.Size = new Size(550, 35);
            lblTrangThai.ForeColor = Color.DarkGreen;

            // Nút thoát
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(635, 430);
            btnThoat.Size = new Size(140, 45);
            btnThoat.Click += btnThoat_Click;

            // Thêm Control
            Controls.Add(lblTieuDe);
            Controls.Add(grpCheDo);
            Controls.Add(lblTuCanTra);
            Controls.Add(cboTuCanTra);
            Controls.Add(lblNghia);
            Controls.Add(txtNghia);
            Controls.Add(btnEnter);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTrangThai);
            Controls.Add(btnThoat);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
