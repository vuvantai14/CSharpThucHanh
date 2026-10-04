namespace LAB04C
{
    partial class frmBai4
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTieuDe;
        private Label lblN;
        private Label lblTong;

        private TextBox txtN;
        private TextBox txtTong;

        private Button btnTinh;
        private Button btnXoa;

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
            lblN = new Label();
            lblTong = new Label();
            txtN = new TextBox();
            txtTong = new TextBox();
            btnTinh = new Button();
            btnXoa = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.Location = new Point(230, 60);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(267, 28);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "TỔNG CÁC SỐ NGUYÊN TỐ";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(190, 140);
            lblN.Name = "lblN";
            lblN.Size = new Size(63, 20);
            lblN.TabIndex = 1;
            lblN.Text = "Nhập N:";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(190, 200);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(46, 20);
            lblTong.TabIndex = 3;
            lblTong.Text = "Tổng:";
            // 
            // txtN
            // 
            txtN.Location = new Point(290, 136);
            txtN.Name = "txtN";
            txtN.Size = new Size(180, 27);
            txtN.TabIndex = 2;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(290, 196);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(180, 27);
            txtTong.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(240, 270);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(100, 35);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(370, 270);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 400);
            Controls.Add(lblTieuDe);
            Controls.Add(lblN);
            Controls.Add(txtN);
            Controls.Add(lblTong);
            Controls.Add(txtTong);
            Controls.Add(btnTinh);
            Controls.Add(btnXoa);
            Name = "frmBai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tổng các số nguyên tố";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}