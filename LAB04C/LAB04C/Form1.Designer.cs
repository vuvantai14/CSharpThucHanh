namespace LAB04C
{
    partial class frmBai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblA = new Label();
            txtA = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            lblB = new Label();
            lblKetQua = new Label();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(181, 46);
            lblA.Name = "lblA";
            lblA.Size = new Size(27, 20);
            lblA.TabIndex = 0;
            lblA.Text = "a=";
            lblA.Click += lblA_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(231, 46);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 1;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(194, 151);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(94, 29);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += button1_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(319, 151);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(94, 29);
            btnTru.TabIndex = 3;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(449, 151);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(94, 29);
            btnNhan.TabIndex = 4;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(579, 151);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(94, 29);
            btnChia.TabIndex = 5;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(468, 46);
            lblB.Name = "lblB";
            lblB.Size = new Size(28, 20);
            lblB.TabIndex = 7;
            lblB.Text = "b=";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(181, 104);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(58, 20);
            lblKetQua.TabIndex = 8;
            lblKetQua.Text = "kết quả";
            // 
            // txtB
            // 
            txtB.Location = new Point(502, 46);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 9;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(271, 101);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(125, 27);
            txtKetQua.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(lblKetQua);
            Controls.Add(lblB);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "frmBai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cộng trừ nhân chia";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label lblB;
        private Label lblKetQua;
        private TextBox txtB;
        private TextBox txtKetQua;
        private ErrorProvider errorProvider1;
    }
}
