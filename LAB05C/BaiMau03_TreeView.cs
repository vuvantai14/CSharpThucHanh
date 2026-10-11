
using System;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiMau03_TreeView : Form
    {
        public BaiMau03_TreeView()
        {
            InitializeComponent();
        }

        // Load danh sách phòng ban
        private void BaiMau03_TreeView_Load(
            object sender, EventArgs e)
        {
            string[] phongBan =
            {
                "Giám đốc",
                "Tổ chức hành chính",
                "Kế hoạch",
                "Kế Toán"
            };

            trv_DS.Nodes.Clear();
            cbo_phongban.Items.Clear();

            foreach (string pb in phongBan)
            {
                trv_DS.Nodes.Add(pb);
                cbo_phongban.Items.Add(pb);
            }

            cbo_phongban.SelectedIndex = 0;
        }

        // Kiểm tra phòng ban đã tồn tại
        private bool KiemTraPhongBan(string ten)
        {
            foreach (TreeNode node in trv_DS.Nodes)
            {
                if (string.Compare(
                    node.Text,
                    ten,
                    true) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Thêm phòng ban
        private void btn_ThemPB_Click(
            object sender, EventArgs e)
        {
            string ten = txt_phongban.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập tên phòng ban!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_phongban.Focus();
                return;
            }

            if (!KiemTraPhongBan(ten))
            {
                MessageBox.Show(
                    "Phòng ban đã tồn tại!",
                    "Thông báo");
                txt_phongban.Focus();
                return;
            }

            trv_DS.Nodes.Add(ten);
            cbo_phongban.Items.Add(ten);

            txt_phongban.Clear();
            txt_phongban.Focus();

            MessageBox.Show(
                "Thêm phòng ban thành công!");
        }

        // Xóa phòng ban được chọn
        private void btn_XoaPB_Click(
            object sender, EventArgs e)
        {
            TreeNode node = trv_DS.SelectedNode;

            if (node == null || node.Parent != null)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng ban cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa phòng ban " +
                node.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                cbo_phongban.Items.Remove(node.Text);
                trv_DS.Nodes.Remove(node);

                if (cbo_phongban.Items.Count > 0)
                    cbo_phongban.SelectedIndex = 0;
                else
                    cbo_phongban.SelectedIndex = -1;
            }
        }

        // Kiểm tra mã nhân viên trùng
        private bool KiemTraMaNV(string ma)
        {
            foreach (TreeNode pb in trv_DS.Nodes)
            {
                foreach (TreeNode nv in pb.Nodes)
                {
                    if (nv.Tag is string maCu &&
                        string.Equals(
                            maCu, ma,
                            StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Thêm nhân viên vào phòng ban
        private void btn_ThemNV_Click(
            object sender, EventArgs e)
        {
            string ma = txt_maso.Text.Trim();
            string ten = txt_hoten.Text.Trim();
            string diaChi = txt_diachi.Text.Trim();

            if (ma == "" || ten == "" || diaChi == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin nhân viên!",
                    "Thông báo");
                return;
            }

            if (cbo_phongban.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng ban!");
                return;
            }

            if (!KiemTraMaNV(ma))
            {
                MessageBox.Show(
                    "Mã nhân viên đã tồn tại!");
                return;
            }

            foreach (TreeNode pb in trv_DS.Nodes)
            {
                if (pb.Text == cbo_phongban.Text)
                {
                    TreeNode nv = new TreeNode(
                        ten + " (" + ma + ")");

                    nv.Tag = ma;
                    pb.Nodes.Add(nv);
                    pb.Expand();

                    trv_DS.SelectedNode = nv;
                    break;
                }
            }

            txt_maso.Clear();
            txt_hoten.Clear();
            txt_diachi.Clear();
            txt_maso.Focus();

            MessageBox.Show(
                "Thêm nhân viên thành công!");
        }

        // Thoát chương trình
        private void btn_Thoat_Click(
            object sender, EventArgs e)
        {
            Close();
        }

        // Xác nhận thoát
        private void BaiMau03_TreeView_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
