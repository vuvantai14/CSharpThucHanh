namespace LAB04D
{
    partial class frmBai1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private GroupBox grpChon;
        private RadioButton rdoBacNhat;
        private RadioButton rdoBacHai;

        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lblKetQua;

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtKetQua;

        private Button btnGiai;
        private Button btnThoat;

        private ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            grpChon = new GroupBox();
            rdoBacNhat = new RadioButton();
            rdoBacHai = new RadioButton();

            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblKetQua = new Label();

            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtKetQua = new TextBox();

            btnGiai = new Button();
            btnThoat = new Button();

            errorProvider1 = new ErrorProvider(components);

            SuspendLayout();

            // lblTieuDe
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Location = new Point(80, 25);
            lblTieuDe.Text = "GIẢI PHƯƠNG TRÌNH";

            // grpChon
            grpChon.Location = new Point(40, 80);
            grpChon.Size = new Size(340, 100);
            grpChon.Text = "Bạn vui lòng chọn";

            // rdoBacNhat
            rdoBacNhat.AutoSize = true;
            rdoBacNhat.Location = new Point(30, 30);
            rdoBacNhat.Text = "Phương trình bậc nhất";
            rdoBacNhat.Checked = true;
            rdoBacNhat.CheckedChanged += rdoBacNhat_CheckedChanged;

            // rdoBacHai
            rdoBacHai.AutoSize = true;
            rdoBacHai.Location = new Point(30, 62);
            rdoBacHai.Text = "Phương trình bậc hai";
            rdoBacHai.CheckedChanged += rdoBacHai_CheckedChanged;

            grpChon.Controls.Add(rdoBacNhat);
            grpChon.Controls.Add(rdoBacHai);

            // lblA
            lblA.AutoSize = true;
            lblA.Location = new Point(45, 210);
            lblA.Text = "Nhập a";

            // txtA
            txtA.Location = new Point(130, 205);
            txtA.Size = new Size(140, 27);
            txtA.TextChanged += DuLieu_TextChanged;

            // lblB
            lblB.AutoSize = true;
            lblB.Location = new Point(45, 250);
            lblB.Text = "Nhập b";

            // txtB
            txtB.Location = new Point(130, 245);
            txtB.Size = new Size(140, 27);
            txtB.TextChanged += DuLieu_TextChanged;

            // lblC
            lblC.AutoSize = true;
            lblC.Location = new Point(45, 290);
            lblC.Text = "Nhập c";

            // txtC
            txtC.Location = new Point(130, 285);
            txtC.Size = new Size(140, 27);
            txtC.TextChanged += DuLieu_TextChanged;

            // btnGiai
            btnGiai.Location = new Point(300, 205);
            btnGiai.Size = new Size(80, 50);
            btnGiai.Text = "Giải";
            btnGiai.Enabled = false;
            btnGiai.Click += btnGiai_Click;

            // btnThoat
            btnThoat.Location = new Point(300, 270);
            btnThoat.Size = new Size(80, 50);
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;

            // lblKetQua
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(45, 350);
            lblKetQua.Text = "Kết quả";

            // txtKetQua
            txtKetQua.Location = new Point(130, 345);
            txtKetQua.Multiline = true;
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(250, 75);

            // errorProvider
            errorProvider1.ContainerControl = this;

            // frmBai1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 460);

            Controls.Add(lblTieuDe);
            Controls.Add(grpChon);

            Controls.Add(lblA);
            Controls.Add(txtA);

            Controls.Add(lblB);
            Controls.Add(txtB);

            Controls.Add(lblC);
            Controls.Add(txtC);

            Controls.Add(btnGiai);
            Controls.Add(btnThoat);

            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giải phương trình bậc 1-2";

            FormClosing += frmBai1_FormClosing;
            Load += frmBai1_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}