
using System;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiTap02_QuanLySinhVien : Form
    {
        // Lớp lưu thông tin sinh viên
        private class SinhVien
        {
            public string MaSV { get; set; } = "";
            public string HoTen { get; set; } = "";
            public string DiaChi { get; set; } = "";
        }

        public BaiTap02_QuanLySinhVien()
        {
            InitializeComponent();
        }

        // Load dữ liệu ban đầu
        private void BaiTap02_QuanLySinhVien_Load(
            object sender, EventArgs e)
        {
            string[] danhSachLop =
            {
                "05DHTH1",
                "05DHTH2",
                "05DHTH3",
                "05DHTH4"
            };

            trvDanhSach.Nodes.Clear();
            cboChonLop.Items.Clear();

            TreeNode goc = trvDanhSach.Nodes.Add(
                "Danh sách lớp");

            foreach (string lop in danhSachLop)
            {
                goc.Nodes.Add(lop);
                cboChonLop.Items.Add(lop);
            }

            goc.Expand();

            if (cboChonLop.Items.Count > 0)
                cboChonLop.SelectedIndex = 0;

            chkThemLop.Checked = false;
            grpThongTinLop.Visible = false;
        }

        // Checkbox thêm lớp
        private void chkThemLop_CheckedChanged(
            object sender, EventArgs e)
        {
            grpThongTinLop.Visible = chkThemLop.Checked;
        }

        // Kiểm tra lớp đã tồn tại
        private bool LopDaTonTai(string tenLop)
        {
            TreeNode goc = trvDanhSach.Nodes[0];

            foreach (TreeNode lop in goc.Nodes)
            {
                if (string.Equals(
                    lop.Text,
                    tenLop,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // Thêm lớp mới
        private void btnThemLop_Click(
            object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();

            if (tenLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên lớp!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            if (LopDaTonTai(tenLop))
            {
                MessageBox.Show(
                    "Tên lớp đã tồn tại!",
                    "Thông báo");
                txtTenLop.SelectAll();
                txtTenLop.Focus();
                return;
            }

            TreeNode goc = trvDanhSach.Nodes[0];
            goc.Nodes.Add(tenLop);

            cboChonLop.Items.Add(tenLop);
            cboChonLop.SelectedItem = tenLop;

            txtTenLop.Clear();
            txtTenLop.Focus();

            MessageBox.Show("Thêm lớp thành công!");
        }

        // Kiểm tra mã sinh viên trùng toàn bộ lớp
        private bool MaSVDaTonTai(string maSV)
        {
            TreeNode goc = trvDanhSach.Nodes[0];

            foreach (TreeNode lop in goc.Nodes)
            {
                foreach (TreeNode nodeSV in lop.Nodes)
                {
                    if (nodeSV.Tag is SinhVien sv &&
                        string.Equals(
                            sv.MaSV,
                            maSV,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Thêm sinh viên
        private void btnCapNhat_Click(
            object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (ma == "" || ten == "" || diaChi == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cboChonLop.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return;
            }

            if (MaSVDaTonTai(ma))
            {
                MessageBox.Show(
                    "Mã sinh viên đã tồn tại!",
                    "Thông báo");
                txtMaSV.Focus();
                return;
            }

            SinhVien sv = new SinhVien
            {
                MaSV = ma,
                HoTen = ten,
                DiaChi = diaChi
            };

            TreeNode goc = trvDanhSach.Nodes[0];

            foreach (TreeNode lop in goc.Nodes)
            {
                if (lop.Text == cboChonLop.Text)
                {
                    TreeNode nodeSV = new TreeNode(
                        ma + ", " + ten);

                    nodeSV.Tag = sv;

                    // Node con hiển thị địa chỉ
                    nodeSV.Nodes.Add(diaChi);

                    lop.Nodes.Add(nodeSV);
                    lop.Expand();

                    trvDanhSach.SelectedNode = nodeSV;
                    break;
                }
            }

            MessageBox.Show(
                "Thêm sinh viên thành công!");

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaSV.Focus();
        }

        // Xóa sinh viên
        private void btnXoa_Click(
            object sender, EventArgs e)
        {
            TreeNode node = trvDanhSach.SelectedNode;

            if (node == null || !(node.Tag is SinhVien))
            {
                MessageBox.Show(
                    "Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                node.Remove();

                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();

                MessageBox.Show(
                    "Xóa sinh viên thành công!");
            }
        }

        // Chọn node trên TreeView
        private void trvDanhSach_AfterSelect(
            object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is SinhVien sv)
            {
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                txtDiaChi.Text = sv.DiaChi;

                if (e.Node.Parent != null)
                    cboChonLop.SelectedItem =
                        e.Node.Parent.Text;
            }
        }
    }
}
