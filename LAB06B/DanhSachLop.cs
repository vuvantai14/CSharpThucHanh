
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class DanhSachLop : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public DanhSachLop()
        {
            InitializeComponent();
        }

        // Hiển thị dữ liệu bảng Lop lên ListView
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                lvDanhSachLop.Items.Clear();

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql =
                    @"SELECT MaLop, TenLop, MaKhoa
                      FROM Lop
                      ORDER BY MaLop";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                int stt = 1;

                while (reader.Read())
                {
                    string maLop =
                        reader["MaLop"].ToString() ?? "";

                    string tenLop =
                        reader["TenLop"].ToString() ?? "";

                    string maKhoa =
                        reader["MaKhoa"].ToString() ?? "";

                    ListViewItem item =
                        new ListViewItem(stt.ToString());

                    item.SubItems.Add(maLop);
                    item.SubItems.Add(tenLop);
                    item.SubItems.Add(maKhoa);

                    lvDanhSachLop.Items.Add(item);
                    stt++;
                }

                lblTongSo.Text =
                    "Tổng số lớp: " + lvDanhSachLop.Items.Count;

                if (lvDanhSachLop.Items.Count == 0)
                {
                    MessageBox.Show(
                        "Bảng Lớp hiện chưa có dữ liệu!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi hiển thị dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Đóng Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
