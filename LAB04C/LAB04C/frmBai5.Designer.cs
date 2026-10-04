namespace LAB04C
{
    partial class frmBai5
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblSo;
        private Label lblKetQua;
        private TextBox txtSo;
        private TextBox txtKetQua;
        private Button btnThucHien;
        private Button btnXoa;
        private Button btnThoat;
        private ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTieuDe = new Label();
            lblSo = new Label();
            lblKetQua = new Label();

            txtSo = new TextBox();
            txtKetQua = new TextBox();

            btnThucHien = new Button();
            btnXoa = new Button();
            btnThoat = new Button();

            errorProvider1 = new ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .BeginInit();

            SuspendLayout();

            // lblTieuDe
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font =
                new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.Location = new Point(250, 55);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(190, 28);
            lblTieuDe.Text = "ĐỌC SỐ THÀNH CHỮ";

            // lblSo
            lblSo.AutoSize = true;
            lblSo.Location = new Point(170, 130);
            lblSo.Name = "lblSo";
            lblSo.Text = "Nhập số:";

            // txtSo
            txtSo.Location = new Point(280, 126);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(220, 27);

            // lblKetQua
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(170, 190);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Text = "Kết quả:";

            // txtKetQua
            txtKetQua.Location = new Point(280, 186);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(300, 27);

            // btnThucHien
            btnThucHien.Location = new Point(170, 260);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(110, 35);
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;

            // btnXoa
            btnXoa.Location = new Point(300, 260);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;

            // btnThoat
            btnThoat.Location = new Point(420, 260);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 35);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;

            // errorProvider1
            errorProvider1.ContainerControl = this;

            // frmBai5
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(700, 380);

            Controls.Add(lblTieuDe);
            Controls.Add(lblSo);
            Controls.Add(txtSo);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnThucHien);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);

            Name = "frmBai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đọc số thành chữ";

            ((System.ComponentModel.ISupportInitialize)errorProvider1)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}