namespace LAB04C
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDangKy = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtTenDangNhap = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            lblXacNhan = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(139, 321);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(251, 105);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(251, 199);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(251, 246);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(125, 27);
            txtXacNhanMatKhau.TabIndex = 4;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(139, 38);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(128, 20);
            lblTieuDe.TabIndex = 5;
            lblTieuDe.Text = "Đăng ký tài khoản";
            lblTieuDe.Click += label1_Click;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(70, 105);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(107, 20);
            lblTenDangNhap.TabIndex = 6;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(70, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Địa chỉ email";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(70, 202);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Location = new Point(70, 246);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(134, 20);
            lblXacNhan.TabIndex = 9;
            lblXacNhan.Text = "Xác nhận mật khẩu";
            // 
            // frmBai2
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(lblXacNhan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTieuDe);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnDangKy);
            Name = "frmBai2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            Load += frmBai2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private ErrorProvider errorProvider1;
        private Label lblXacNhan;
        private Label lblMatKhau;
        private Label lblEmail;
        private Label lblTenDangNhap;
        private Label lblTieuDe;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtTenDangNhap;
    }
}