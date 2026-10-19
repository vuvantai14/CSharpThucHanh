
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06A
{
    public partial class QLKhoa : Form
    {
        private readonly string connectionString =
                    @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLKhoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            string ten = txtTenKhoa.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ThucThi(
                "INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES (@Ma, @Ten)",
                ma, ten);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();

            if (ma == "")
            {
                MessageBox.Show("Vui lòng nhập mã khoa!");
                return;
            }

            ThucThi(
                "DELETE FROM Khoa WHERE MaKhoa = @Ma",
                ma, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoa.Text.Trim();
            string ten = txtTenKhoa.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            ThucThi(
                "UPDATE Khoa SET TenKhoa = @Ten WHERE MaKhoa = @Ma",
                ma, ten);
        }

        private void ThucThi(string sql, string ma, string ten)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 10).Value = ma;

                    if (ten != null)
                    {
                        cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = ten;
                    }

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(rows > 0
                        ? "Thao tác thành công!"
                        : "Không tìm thấy dữ liệu phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
