
using System;
using System.Windows.Forms;

namespace LAB05C
{
    public partial class BaiMau01_ListBox : Form
    {
        public BaiMau01_ListBox()
        {
            InitializeComponent();
        }

        private void ChuyenMot(ListBox nguon, ListBox dich)
        {
            if (nguon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phần tử!");
                return;
            }

            object item = nguon.SelectedItem;

            dich.Items.Add(item);
            nguon.Items.Remove(item);
        }

        private void ChuyenTatCa(ListBox nguon, ListBox dich)
        {
            dich.Items.AddRange(nguon.Items);
            nguon.Items.Clear();
        }

        private void btnQuaPhai_Click(object? sender, EventArgs e)
        {
            ChuyenMot(lst_Trai, lst_Phai);
        }

        private void btnQuaPhaiAll_Click(object? sender, EventArgs e)
        {
            ChuyenTatCa(lst_Trai, lst_Phai);
        }

        private void btnQuaTrai_Click(object? sender, EventArgs e)
        {
            ChuyenMot(lst_Phai, lst_Trai);
        }

        private void btnQuaTraiAll_Click(object? sender, EventArgs e)
        {
            ChuyenTatCa(lst_Phai, lst_Trai);
        }

        private void btnChuyenTuyY_Click(object? sender, EventArgs e)
        {
            if (lst_Trai.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phần tử!");
                return;
            }

            object[] ds =
                new object[lst_Trai.SelectedItems.Count];

            lst_Trai.SelectedItems.CopyTo(ds, 0);

            foreach (object item in ds)
            {
                lst_Phai.Items.Add(item);
                lst_Trai.Items.Remove(item);
            }
        }

        private void BaiMau01_ListBox_FormClosing(
            object? sender, FormClosingEventArgs e)
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
