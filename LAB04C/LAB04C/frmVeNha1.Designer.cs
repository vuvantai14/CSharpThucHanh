namespace LAB04C
{
    partial class frmVeNha1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtManHinh;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnBang;
        private Button btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtManHinh = new TextBox();

            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();

            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnBang = new Button();
            btnXoa = new Button();

            SuspendLayout();

            // Màn hình
            txtManHinh.Location = new Point(80, 40);
            txtManHinh.Name = "txtManHinh";
            txtManHinh.ReadOnly = true;
            txtManHinh.Size = new Size(290, 27);
            txtManHinh.Text = "0";
            txtManHinh.TextAlign = HorizontalAlignment.Right;
            txtManHinh.Font = new Font("Segoe UI", 14F);

            // Hàng 1
            TaoNut(btn7, "7", 80, 100);
            TaoNut(btn8, "8", 150, 100);
            TaoNut(btn9, "9", 220, 100);
            TaoNut(btnChia, "/", 300, 100);

            // Hàng 2
            TaoNut(btn4, "4", 80, 160);
            TaoNut(btn5, "5", 150, 160);
            TaoNut(btn6, "6", 220, 160);
            TaoNut(btnNhan, "*", 300, 160);

            // Hàng 3
            TaoNut(btn1, "1", 80, 220);
            TaoNut(btn2, "2", 150, 220);
            TaoNut(btn3, "3", 220, 220);
            TaoNut(btnTru, "-", 300, 220);

            // Hàng 4
            TaoNut(btn0, "0", 80, 280);
            TaoNut(btnXoa, "C", 150, 280);
            TaoNut(btnBang, "=", 220, 280);
            TaoNut(btnCong, "+", 300, 280);

            // Sự kiện số
            btn0.Click += btnSo_Click;
            btn1.Click += btnSo_Click;
            btn2.Click += btnSo_Click;
            btn3.Click += btnSo_Click;
            btn4.Click += btnSo_Click;
            btn5.Click += btnSo_Click;
            btn6.Click += btnSo_Click;
            btn7.Click += btnSo_Click;
            btn8.Click += btnSo_Click;
            btn9.Click += btnSo_Click;

            // Sự kiện phép toán
            btnCong.Click += btnPhepTinh_Click;
            btnTru.Click += btnPhepTinh_Click;
            btnNhan.Click += btnPhepTinh_Click;
            btnChia.Click += btnPhepTinh_Click;

            btnBang.Click += btnBang_Click;
            btnXoa.Click += btnXoa_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 390);

            Controls.Add(txtManHinh);

            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);

            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnBang);
            Controls.Add(btnXoa);

            Name = "frmVeNha1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính bỏ túi";

            ResumeLayout(false);
            PerformLayout();
        }

        private void TaoNut(Button btn, string text, int x, int y)
        {
            btn.Location = new Point(x, y);
            btn.Name = "btn" + text;
            btn.Size = new Size(60, 45);
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 11F);
            btn.UseVisualStyleBackColor = true;
        }
    }
}