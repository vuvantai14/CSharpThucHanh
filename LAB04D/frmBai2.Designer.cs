namespace LAB04D
{
    partial class frmBai2
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblNhapMang;
        private Label lblKetQua;

        private TextBox txtNhapMang;
        private TextBox txtKetQua;

        private Button btnThucHien;
        private Button btnReset;
        private Button btnThoat;

        private GroupBox grpSapXep;
        private RadioButton rdoTang;
        private RadioButton rdoGiam;

        private GroupBox grpTimKiem;
        private RadioButton rdoTimGiaTri;
        private RadioButton rdoTimViTri;
        private TextBox txtTim;
        private TextBox txtTimKetQua;

        private GroupBox grpThem;
        private TextBox txtGiaTriThem;
        private TextBox txtViTriThem;

        private GroupBox grpTong;
        private TextBox txtTong;
        private TextBox txtTongChan;
        private TextBox txtTongLe;
        private Button btnTinhTong;

        private GroupBox grpMaxMin;
        private TextBox txtMax;
        private TextBox txtMin;
        private Button btnTimMaxMin;

        private GroupBox grpThayThe;
        private RadioButton rdoThayGiaTri;
        private RadioButton rdoThayViTri;
        private TextBox txtCanThay;
        private TextBox txtSoThayThe;
        private Button btnThayThe;

        private ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblNhapMang = new Label();
            lblKetQua = new Label();

            txtNhapMang = new TextBox();
            txtKetQua = new TextBox();

            btnThucHien = new Button();
            btnReset = new Button();
            btnThoat = new Button();

            grpSapXep = new GroupBox();
            rdoTang = new RadioButton();
            rdoGiam = new RadioButton();

            grpTimKiem = new GroupBox();
            rdoTimGiaTri = new RadioButton();
            rdoTimViTri = new RadioButton();
            txtTim = new TextBox();
            txtTimKetQua = new TextBox();

            grpThem = new GroupBox();
            txtGiaTriThem = new TextBox();
            txtViTriThem = new TextBox();

            grpTong = new GroupBox();
            txtTong = new TextBox();
            txtTongChan = new TextBox();
            txtTongLe = new TextBox();
            btnTinhTong = new Button();

            grpMaxMin = new GroupBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            btnTimMaxMin = new Button();

            grpThayThe = new GroupBox();
            rdoThayGiaTri = new RadioButton();
            rdoThayViTri = new RadioButton();
            txtCanThay = new TextBox();
            txtSoThayThe = new TextBox();
            btnThayThe = new Button();

            errorProvider1 = new ErrorProvider(components);

            SuspendLayout();

            // Tiêu đề
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Location = new Point(250, 20);
            lblTieuDe.Text = "MẢNG SỐ NGUYÊN";

            // Nhập mảng
            lblNhapMang.AutoSize = true;
            lblNhapMang.Location = new Point(35, 85);
            lblNhapMang.Text = "Nhập mảng:";

            txtNhapMang.Location = new Point(135, 80);
            txtNhapMang.Size = new Size(430, 27);

            btnReset.Location = new Point(590, 78);
            btnReset.Size = new Size(90, 30);
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;

            // Kết quả
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(35, 125);
            lblKetQua.Text = "Kết quả mảng:";

            txtKetQua.Location = new Point(135, 120);
            txtKetQua.Size = new Size(430, 27);
            txtKetQua.ReadOnly = true;

            btnThoat.Location = new Point(590, 118);
            btnThoat.Size = new Size(90, 30);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // Sắp xếp
            grpSapXep.Location = new Point(35, 170);
            grpSapXep.Size = new Size(645, 75);
            grpSapXep.Text = "Sắp xếp";

            rdoTang.Location = new Point(150, 30);
            rdoTang.Size = new Size(130, 25);
            rdoTang.Text = "Sắp xếp tăng";
            rdoTang.Checked = true;

            rdoGiam.Location = new Point(350, 30);
            rdoGiam.Size = new Size(130, 25);
            rdoGiam.Text = "Sắp xếp giảm";

            grpSapXep.Controls.Add(rdoTang);
            grpSapXep.Controls.Add(rdoGiam);

            // Tìm kiếm
            grpTimKiem.Location = new Point(35, 260);
            grpTimKiem.Size = new Size(310, 150);
            grpTimKiem.Text = "Tìm kiếm";

            rdoTimGiaTri.Location = new Point(15, 30);
            rdoTimGiaTri.Size = new Size(140, 25);
            rdoTimGiaTri.Text = "Tìm giá trị cần tìm";
            rdoTimGiaTri.Checked = true;

            rdoTimViTri.Location = new Point(15, 65);
            rdoTimViTri.Size = new Size(140, 25);
            rdoTimViTri.Text = "Tìm vị trí cần tìm";

            txtTim.Location = new Point(170, 30);
            txtTim.Size = new Size(100, 27);

            txtTimKetQua.Location = new Point(170, 70);
            txtTimKetQua.Size = new Size(100, 27);
            txtTimKetQua.ReadOnly = true;

            grpTimKiem.Controls.Add(rdoTimGiaTri);
            grpTimKiem.Controls.Add(rdoTimViTri);
            grpTimKiem.Controls.Add(txtTim);
            grpTimKiem.Controls.Add(txtTimKetQua);

            // Thêm
            grpThem.Location = new Point(370, 260);
            grpThem.Size = new Size(310, 150);
            grpThem.Text = "Thêm";

            Label lblThem1 = new Label();
            lblThem1.Location = new Point(15, 35);
            lblThem1.Size = new Size(140, 25);
            lblThem1.Text = "Giá trị cần thêm:";

            txtGiaTriThem.Location = new Point(170, 30);
            txtGiaTriThem.Size = new Size(100, 27);

            Label lblThem2 = new Label();
            lblThem2.Location = new Point(15, 75);
            lblThem2.Size = new Size(140, 25);
            lblThem2.Text = "Vị trí cần thêm:";

            txtViTriThem.Location = new Point(170, 70);
            txtViTriThem.Size = new Size(100, 27);

            grpThem.Controls.Add(lblThem1);
            grpThem.Controls.Add(txtGiaTriThem);
            grpThem.Controls.Add(lblThem2);
            grpThem.Controls.Add(txtViTriThem);

            // Tổng
            grpTong.Location = new Point(35, 425);
            grpTong.Size = new Size(310, 180);
            grpTong.Text = "Tổng";

            Label lblTong1 = new Label();
            lblTong1.Location = new Point(15, 35);
            lblTong1.Size = new Size(100, 25);
            lblTong1.Text = "Tổng mảng:";

            txtTong.Location = new Point(120, 30);
            txtTong.Size = new Size(90, 27);
            txtTong.ReadOnly = true;

            Label lblTong2 = new Label();
            lblTong2.Location = new Point(15, 75);
            lblTong2.Size = new Size(100, 25);
            lblTong2.Text = "Tổng chẵn:";

            txtTongChan.Location = new Point(120, 70);
            txtTongChan.Size = new Size(90, 27);
            txtTongChan.ReadOnly = true;

            Label lblTong3 = new Label();
            lblTong3.Location = new Point(15, 115);
            lblTong3.Size = new Size(100, 25);
            lblTong3.Text = "Tổng lẻ:";

            txtTongLe.Location = new Point(120, 110);
            txtTongLe.Size = new Size(90, 27);
            txtTongLe.ReadOnly = true;

            btnTinhTong.Location = new Point(220, 30);
            btnTinhTong.Size = new Size(70, 110);
            btnTinhTong.Text = "Tổng";
            btnTinhTong.Click += btnTinhTong_Click;

            grpTong.Controls.Add(lblTong1);
            grpTong.Controls.Add(txtTong);
            grpTong.Controls.Add(lblTong2);
            grpTong.Controls.Add(txtTongChan);
            grpTong.Controls.Add(lblTong3);
            grpTong.Controls.Add(txtTongLe);
            grpTong.Controls.Add(btnTinhTong);

            // Max Min
            grpMaxMin.Location = new Point(370, 425);
            grpMaxMin.Size = new Size(310, 180);
            grpMaxMin.Text = "Max - Min";

            Label lblMax = new Label();
            lblMax.Location = new Point(15, 40);
            lblMax.Size = new Size(110, 25);
            lblMax.Text = "Giá trị lớn nhất:";

            txtMax.Location = new Point(140, 35);
            txtMax.Size = new Size(80, 27);
            txtMax.ReadOnly = true;

            Label lblMin = new Label();
            lblMin.Location = new Point(15, 85);
            lblMin.Size = new Size(110, 25);
            lblMin.Text = "Giá trị nhỏ nhất:";

            txtMin.Location = new Point(140, 80);
            txtMin.Size = new Size(80, 27);
            txtMin.ReadOnly = true;

            btnTimMaxMin.Location = new Point(230, 35);
            btnTimMaxMin.Size = new Size(65, 75);
            btnTimMaxMin.Text = "Tìm";
            btnTimMaxMin.Click += btnTimMaxMin_Click;

            grpMaxMin.Controls.Add(lblMax);
            grpMaxMin.Controls.Add(txtMax);
            grpMaxMin.Controls.Add(lblMin);
            grpMaxMin.Controls.Add(txtMin);
            grpMaxMin.Controls.Add(btnTimMaxMin);

            // Thay thế
            grpThayThe.Location = new Point(35, 620);
            grpThayThe.Size = new Size(645, 150);
            grpThayThe.Text = "Thay thế";

            rdoThayGiaTri.Location = new Point(15, 30);
            rdoThayGiaTri.Size = new Size(160, 25);
            rdoThayGiaTri.Text = "Giá trị cần thay thế";
            rdoThayGiaTri.Checked = true;

            rdoThayViTri.Location = new Point(15, 70);
            rdoThayViTri.Size = new Size(160, 25);
            rdoThayViTri.Text = "Vị trí cần thay thế";

            txtCanThay.Location = new Point(190, 30);
            txtCanThay.Size = new Size(100, 27);

            Label lblSoThay = new Label();
            lblSoThay.Location = new Point(320, 35);
            lblSoThay.Size = new Size(100, 25);
            lblSoThay.Text = "Số thay thế:";

            txtSoThayThe.Location = new Point(420, 30);
            txtSoThayThe.Size = new Size(100, 27);

            btnThayThe.Location = new Point(535, 28);
            btnThayThe.Size = new Size(90, 35);
            btnThayThe.Text = "Thay thế";
            btnThayThe.Click += btnThayThe_Click;

            grpThayThe.Controls.Add(rdoThayGiaTri);
            grpThayThe.Controls.Add(rdoThayViTri);
            grpThayThe.Controls.Add(txtCanThay);
            grpThayThe.Controls.Add(lblSoThay);
            grpThayThe.Controls.Add(txtSoThayThe);
            grpThayThe.Controls.Add(btnThayThe);

            // Thực hiện
            btnThucHien.Location = new Point(275, 790);
            btnThucHien.Size = new Size(150, 45);
            btnThucHien.Text = "THỰC HIỆN";
            btnThucHien.Click += btnThucHien_Click;

            errorProvider1.ContainerControl = this;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 870);

            Controls.Add(lblTieuDe);
            Controls.Add(lblNhapMang);
            Controls.Add(txtNhapMang);
            Controls.Add(btnReset);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnThoat);

            Controls.Add(grpSapXep);
            Controls.Add(grpTimKiem);
            Controls.Add(grpThem);
            Controls.Add(grpTong);
            Controls.Add(grpMaxMin);
            Controls.Add(grpThayThe);
            Controls.Add(btnThucHien);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mảng Số Nguyên";

            FormClosing += frmBai2_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}