namespace LAB04C
{
    partial class frmBai3
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
            btnTinh = new Button();
            btnXoa = new Button();
            lblTieuDe = new Label();
            lblA = new Label();
            lblB = new Label();
            lblUCLN = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtUCLN = new TextBox();
            txtBCNN = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            lblBCNN = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(324, 293);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(94, 29);
            btnTinh.TabIndex = 0;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(466, 293);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(427, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(132, 20);
            lblTieuDe.TabIndex = 2;
            lblTieuDe.Text = "Tính UCLN - BCNN";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(324, 83);
            lblA.Name = "lblA";
            lblA.Size = new Size(41, 20);
            lblA.TabIndex = 3;
            lblA.Text = "Số a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(324, 131);
            lblB.Name = "lblB";
            lblB.Size = new Size(42, 20);
            lblB.TabIndex = 4;
            lblB.Text = "Số b:";
            // 
            // lblUCLN
            // 
            lblUCLN.AutoSize = true;
            lblUCLN.Location = new Point(324, 183);
            lblUCLN.Name = "lblUCLN";
            lblUCLN.Size = new Size(49, 20);
            lblUCLN.TabIndex = 5;
            lblUCLN.Text = "UCLN:";
            // 
            // txtA
            // 
            txtA.Location = new Point(446, 76);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 6;
            // 
            // txtB
            // 
            txtB.Location = new Point(446, 128);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 7;
            // 
            // txtUCLN
            // 
            txtUCLN.Location = new Point(446, 180);
            txtUCLN.Name = "txtUCLN";
            txtUCLN.ReadOnly = true;
            txtUCLN.Size = new Size(125, 27);
            txtUCLN.TabIndex = 8;
            // 
            // txtBCNN
            // 
            txtBCNN.Location = new Point(446, 232);
            txtBCNN.Name = "txtBCNN";
            txtBCNN.ReadOnly = true;
            txtBCNN.Size = new Size(125, 27);
            txtBCNN.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblBCNN
            // 
            lblBCNN.AutoSize = true;
            lblBCNN.Location = new Point(324, 232);
            lblBCNN.Name = "lblBCNN";
            lblBCNN.Size = new Size(52, 20);
            lblBCNN.TabIndex = 10;
            lblBCNN.Text = "BCNN:";
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBCNN);
            Controls.Add(txtBCNN);
            Controls.Add(txtUCLN);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblUCLN);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblTieuDe);
            Controls.Add(btnXoa);
            Controls.Add(btnTinh);
            Name = "frmBai3";
            Text = "Tính UCLN và BCNN";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private Button btnXoa;
        private Label lblTieuDe;
        private Label lblA;
        private Label lblB;
        private Label lblUCLN;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtUCLN;
        private TextBox txtBCNN;
        private ErrorProvider errorProvider1;
        private Label lblBCNN;
    }
}