
using System;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiVeNha02_FormMain : Form
    {
        public BaiVeNha02_FormMain()
        {
            InitializeComponent();
        }

        // Mở Form bài tập trong cửa sổ chính
        private void MoForm(Form form)
        {
            // Nếu Form đã mở thì kích hoạt lại
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == form.GetType())
                {
                    f.Activate();
                    form.Dispose();
                    return;
                }
            }

            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new System.Drawing.Point(10, 10);
            form.Show();
        }

        // Bài mẫu 1 - Timer
        private void mnuBaiMau1_Click(object sender, EventArgs e)
        {
            MoForm(new BaiMau01_Timer());
        }

        // Bài mẫu 2 - ListView
        private void mnuBaiMau2_Click(object sender, EventArgs e)
        {
            MoForm(new BaiMau02_ListView());
        }

        // Bài mẫu 3 - Đọc ghi file TXT
        private void mnuBaiMau3_Click(object sender, EventArgs e)
        {
            MoForm(new BaiMau03_DocGhiFile());
        }

        // Bài tập tại lớp 1
        private void mnuBaiTap1_Click(object sender, EventArgs e)
        {
            MoForm(new BaiTap01_QuanLySinhVien());
        }

        // Bài tập tại lớp 2
        private void mnuBaiTap2_Click(object sender, EventArgs e)
        {
            MoForm(new BaiTap02_QuanLyTaiKhoan());
        }

        // Bài nâng cao 1
        private void mnuNangCao1_Click(object sender, EventArgs e)
        {
            MoForm(new BaiNangCao01_QuanLyHocVien());
        }

        // Bài về nhà 1
        private void mnuVeNha1_Click(object sender, EventArgs e)
        {
            MoForm(new BaiVeNha01_DongHoDemNguoc());
        }

        // Đóng các Form con
        private void mnuDongTatCa_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        // Thoát chương trình
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Xác nhận thoát
        private void BaiVeNha02_FormMain_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình LAB05D?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
