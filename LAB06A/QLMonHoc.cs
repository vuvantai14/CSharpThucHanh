
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06A
{
    public partial class QLMonHoc : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show(
                    "Mã môn học và Tên môn học không được để trống!");
                return;
            }

            ThucThi(
                "INSERT INTO MonHoc (MaMonHoc, TenMonHoc) VALUES (@Ma, @Ten)",
                ma, ten);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();

            if (ma == "")
            {
                MessageBox.Show("Mã môn học không được để trống!");
                return;
            }

            if (ten != "")
            {
                MessageBox.Show(
                    "Khi xóa, không được nhập Tên môn học!");
                return;
            }

            ThucThi(
                "DELETE FROM MonHoc WHERE MaMonHoc = @Ma",
                ma, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaMonHoc.Text.Trim();
            string ten = txtTenMonHoc.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show(
                    "Mã môn học và Tên môn học không được để trống!");
                return;
            }

            ThucThi(
                "UPDATE MonHoc SET TenMonHoc = @Ten WHERE MaMonHoc = @Ma",
                ma, ten);
        }

        private void ThucThi(string sql, string ma, string? ten)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@Ma", SqlDbType.VarChar, 10).Value = ma;

                    if (ten != null)
                    {
                        cmd.Parameters.Add(
                            "@Ten", SqlDbType.NVarChar, 100).Value = ten;
                    }

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Thao tác thành công!");
                        txtMaMonHoc.Clear();
                        txtTenMonHoc.Clear();
                        txtMaMonHoc.Focus();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy môn học phù hợp!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL Server: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
