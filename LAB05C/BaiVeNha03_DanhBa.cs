
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiVeNha03_DanhBa : Form
    {
        private class LienHe
        {
            public string HoTen { get; set; } = "";
            public string SoDienThoai { get; set; } = "";
            public string DiaChi { get; set; } = "";
        }

        public BaiVeNha03_DanhBa()
        {
            InitializeComponent();
        }

        // Tạo các node A đến Z khi mở Form
        private void BaiVeNha03_DanhBa_Load(
            object sender, EventArgs e)
        {
            trvDanhBa.Nodes.Clear();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode node = new TreeNode(c.ToString());
                node.Name = c.ToString();
                trvDanhBa.Nodes.Add(node);
            }

            lblSoLuong.Text = "Tổng số liên hệ: 0";
            txtHoTen.Focus();
        }

        // Chuyển ký tự có dấu thành không dấu
        private string BoDau(string s)
        {
            string normalized = s.Normalize(
                NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory category =
                    CharUnicodeInfo.GetUnicodeCategory(c);

                if (category != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString()
                .Normalize(NormalizationForm.FormC)
                .Replace('đ', 'd')
                .Replace('Đ', 'D');
        }

        // Lấy chữ cái đầu của tên (từ cuối họ tên)
        private string LayChuCaiDau(string hoTen)
        {
            string[] parts = hoTen.Trim()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string ten = parts[parts.Length - 1];
            string khongDau = BoDau(ten).ToUpperInvariant();

            if (khongDau.Length == 0)
                return "";

            char c = khongDau[0];

            if (c < 'A' || c > 'Z')
                return "";

            return c.ToString();
        }

        // Kiểm tra số điện thoại đã tồn tại
        private bool SDTDaTonTai(string sdt)
        {
            foreach (TreeNode nhom in trvDanhBa.Nodes)
            {
                foreach (TreeNode node in nhom.Nodes)
                {
                    if (node.Tag is LienHe lh &&
                        lh.SoDienThoai == sdt)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Thêm người vào danh bạ
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (hoTen == "" || sdt == "" || diaChi == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!sdt.All(char.IsDigit) ||
                sdt.Length < 9 || sdt.Length > 11)
            {
                MessageBox.Show(
                    "Số điện thoại phải có từ 9 đến 11 chữ số!");
                txtSoDienThoai.Focus();
                return;
            }

            if (SDTDaTonTai(sdt))
            {
                MessageBox.Show(
                    "Số điện thoại đã tồn tại!");
                txtSoDienThoai.Focus();
                return;
            }

            string chuCai = LayChuCaiDau(hoTen);

            if (chuCai == "")
            {
                MessageBox.Show(
                    "Tên phải bắt đầu bằng một chữ cái!");
                txtHoTen.Focus();
                return;
            }

            LienHe lienHe = new LienHe
            {
                HoTen = hoTen,
                SoDienThoai = sdt,
                DiaChi = diaChi
            };

            TreeNode? nhom = trvDanhBa.Nodes[chuCai];

            if (nhom == null)
                return;

            TreeNode nodeMoi = new TreeNode(hoTen);
            nodeMoi.Tag = lienHe;

            nhom.Nodes.Add(nodeMoi);
            nhom.Expand();
            trvDanhBa.SelectedNode = nodeMoi;

            CapNhatSoLuong();

            MessageBox.Show(
                "Thêm liên hệ thành công!",
                "Thông báo");

            LamMoi();
        }

        // Khi chọn liên hệ
        private void trvDanhBa_AfterSelect(
            object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is LienHe lh)
            {
                txtHoTen.Text = lh.HoTen;
                txtSoDienThoai.Text = lh.SoDienThoai;
                txtDiaChi.Text = lh.DiaChi;
            }
        }

        // Xóa liên hệ được chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode? node = trvDanhBa.SelectedNode;

            if (node == null || !(node.Tag is LienHe))
            {
                MessageBox.Show(
                    "Vui lòng chọn liên hệ cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                node.Remove();
                LamMoi();
                CapNhatSoLuong();

                MessageBox.Show(
                    "Xóa liên hệ thành công!");
            }
        }

        // Tìm kiếm liên hệ theo tên hoặc SĐT
        private void btnTimKiem_Click(
            object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            foreach (TreeNode nhom in trvDanhBa.Nodes)
            {
                foreach (TreeNode node in nhom.Nodes)
                {
                    if (node.Tag is LienHe lh)
                    {
                        bool khopTen = lh.HoTen.Contains(
                            tuKhoa,
                            StringComparison.CurrentCultureIgnoreCase);

                        bool khopSDT =
                            lh.SoDienThoai.Contains(tuKhoa);

                        if (khopTen || khopSDT)
                        {
                            nhom.Expand();
                            trvDanhBa.SelectedNode = node;
                            node.EnsureVisible();
                            trvDanhBa.Focus();
                            return;
                        }
                    }
                }
            }

            MessageBox.Show(
                "Không tìm thấy liên hệ phù hợp!");
        }

        // Xóa dữ liệu nhập
        private void LamMoi()
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtHoTen.Focus();
        }

        private void btnLamMoi_Click(
            object sender, EventArgs e)
        {
            LamMoi();
            trvDanhBa.SelectedNode = null;
        }

        // Đếm số liên hệ
        private void CapNhatSoLuong()
        {
            int dem = 0;

            foreach (TreeNode nhom in trvDanhBa.Nodes)
                dem += nhom.Nodes.Count;

            lblSoLuong.Text = "Tổng số liên hệ: " + dem;
        }

        // Thoát
        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
