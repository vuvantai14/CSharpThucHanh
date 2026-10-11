
using System;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiMau02_ComboBox : Form
    {
        public BaiMau02_ComboBox()
        {
            InitializeComponent();
        }

        // Nút Load dữ liệu ComboBox
        private void btnLoad_Click(object? sender, EventArgs e)
        {
            string[] danToc =
            {
                "Kinh",
                "Hoa",
                "K’Me",
                "H’Mong",
                "Khác"
            };

            // Xóa dữ liệu cũ để tránh trùng
            cboDanToc.Items.Clear();

            foreach (string dt in danToc)
            {
                cboDanToc.Items.Add(dt);
            }

            cboDanToc.SelectedIndex = -1;
            lblKetQua.Text = "";

            MessageBox.Show(
                "Đã tải 5 dân tộc thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Nút Hiển thị
        private void btnHienThi_Click(object? sender, EventArgs e)
        {
            if (cboDanToc.SelectedIndex >= 0)
            {
                lblKetQua.Text =
                    "Dân tộc được chọn: " +
                    cboDanToc.SelectedItem?.ToString();
            }
            else
            {
                lblKetQua.Text = "Bạn chưa chọn dân tộc";
            }
        }

        // Khi chọn dân tộc trong ComboBox
        private void cboDanToc_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (cboDanToc.SelectedIndex >= 0)
            {
                MessageBox.Show(
                    "Dân tộc được chọn: " +
                    cboDanToc.SelectedItem?.ToString(),
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
