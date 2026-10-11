
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LAB05D
{
    public partial class BaiMau03_DocGhiFile : Form
    {
        public BaiMau03_DocGhiFile()
        {
            InitializeComponent();
        }

        // Lưu nội dung RichTextBox vào file TXT
        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbNoiDung.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập nội dung trước khi lưu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Lưu file văn bản";
                dlg.Filter = "Text files (*.txt)|*.txt";
                dlg.DefaultExt = "txt";
                dlg.AddExtension = true;
                dlg.FileName = "VanBan.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Ghi nội dung vào file UTF-8
                        using (StreamWriter sw =
                            new StreamWriter(
                                dlg.FileName,
                                false,
                                new UTF8Encoding(false)))
                        {
                            sw.Write(rtbNoiDung.Text);
                        }

                        // Hiển thị đường dẫn file
                        txtDuongDan.Text = dlg.FileName;

                        MessageBox.Show(
                            "Lưu file thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Không thể lưu file: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Mở file TXT và hiển thị nội dung
        private void btnMoFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn file văn bản";
                dlg.Filter = "Text files (*.txt)|*.txt";
                dlg.CheckFileExists = true;
                dlg.Multiselect = false;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Đọc toàn bộ nội dung file
                        using (StreamReader sr =
                            new StreamReader(
                                dlg.FileName,
                                Encoding.UTF8,
                                true))
                        {
                            rtbNoiDung.Text = sr.ReadToEnd();
                        }

                        // Hiển thị đường dẫn file
                        txtDuongDan.Text = dlg.FileName;

                        MessageBox.Show(
                            "Mở file thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Không thể mở file: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Xóa nội dung đang hiển thị
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Clear();
            txtDuongDan.Clear();
            rtbNoiDung.Focus();
        }

        // Thoát chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
