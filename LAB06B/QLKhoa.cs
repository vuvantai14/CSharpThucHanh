
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class QLKhoa : Form
    {
        // Chuỗi kết nối SQL Server
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLKhoa()
        {
            InitializeComponent();
        }

        // Kiểm tra mã khoa đã tồn tại hay chưa
        private bool KiemTraMaKhoa(string maKhoa)
        {
            using SqlConnection conn =
                new SqlConnection(connectionString);

            string sql =
                "SELECT COUNT(*) FROM Khoa WHERE MaKhoa = @MaKhoa";

            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                .Value = maKhoa;

            conn.Open();

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }

        // Chức năng THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenKhoa = txtTenKhoa.Text.Trim();

            if (maKhoa == "" || tenKhoa == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Mã khoa và Tên khoa!");
                return;
            }

            try
            {
                if (KiemTraMaKhoa(maKhoa))
                {
                    MessageBox.Show(
                        "Mã khoa đã tồn tại! Không thể thêm.");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql =
                    @"INSERT INTO Khoa (MaKhoa, TenKhoa)
                      VALUES (@MaKhoa, @TenKhoa)";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                    .Value = maKhoa;

                cmd.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 100)
                    .Value = tenKhoa;

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Thêm khoa thành công!");
                    XoaTrang();
                }
            }
            catch (SqlException ex) when (
                ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã khoa đã tồn tại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Chức năng XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();

            if (maKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập Mã khoa cần xóa!");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc muốn xóa khoa này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql =
                    "DELETE FROM Khoa WHERE MaKhoa = @MaKhoa";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                    .Value = maKhoa;

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Xóa khoa thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khoa!");
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể xóa khoa vì đang có lớp liên kết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Chức năng SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenKhoa = txtTenKhoa.Text.Trim();

            if (maKhoa == "" || tenKhoa == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã khoa và Tên khoa!");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql =
                    @"UPDATE Khoa
                      SET TenKhoa = @TenKhoa
                      WHERE MaKhoa = @MaKhoa";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                    .Value = maKhoa;

                cmd.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 100)
                    .Value = tenKhoa;

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Sửa khoa thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khoa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Xóa dữ liệu trên các TextBox
        private void XoaTrang()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Focus();
        }
    }
}
