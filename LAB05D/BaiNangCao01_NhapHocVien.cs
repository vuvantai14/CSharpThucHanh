
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiNangCao01_NhapHocVien : Form
    {
        public string HoTen { get; private set; } = "";
        public string Lop { get; private set; } = "";

        public BaiNangCao01_NhapHocVien()
        {
            InitializeComponent();

            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.SelectedIndex = 0;
        }

        // Cập nhật học viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ và tên học viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            HoTen = hoTen;
            Lop = cboLop.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        // Trở về Form chính
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
