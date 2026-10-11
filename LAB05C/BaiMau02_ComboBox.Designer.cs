
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiMau02_ComboBox
    {
        private System.ComponentModel.IContainer? components = null;

        private Label lblDanToc;
        private Label lblKetQua;
        private ComboBox cboDanToc;
        private Button btnLoad;
        private Button btnHienThi;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDanToc = new Label();
            lblKetQua = new Label();
            cboDanToc = new ComboBox();
            btnLoad = new Button();
            btnHienThi = new Button();

            SuspendLayout();

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 330);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BaiMau02_ComboBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn dân tộc";
            BackColor = Color.WhiteSmoke;

            // Button Load
            btnLoad.Location = new Point(125, 30);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(250, 45);
            btnLoad.Text = "Load dữ liệu ComboBox";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;

            // Label Dân tộc
            lblDanToc.AutoSize = true;
            lblDanToc.Location = new Point(65, 115);
            lblDanToc.Name = "lblDanToc";
            lblDanToc.Text = "Dân tộc:";

            // ComboBox
            cboDanToc.Location = new Point(180, 110);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(240, 30);
            cboDanToc.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboDanToc.SelectedIndexChanged +=
                cboDanToc_SelectedIndexChanged;

            // Button Hiển thị
            btnHienThi.Location = new Point(180, 165);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(140, 45);
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;

            // Label kết quả
            lblKetQua.Location = new Point(65, 245);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(370, 35);
            lblKetQua.Text = "";
            lblKetQua.ForeColor = Color.Red;
            lblKetQua.TextAlign =
                ContentAlignment.MiddleCenter;

            // Thêm Control vào Form
            Controls.Add(lblDanToc);
            Controls.Add(lblKetQua);
            Controls.Add(cboDanToc);
            Controls.Add(btnLoad);
            Controls.Add(btnHienThi);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
