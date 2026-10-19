
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06A
{
    public partial class QLLop : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLLop()
        {
            InitializeComponent();
        }

        // Chức năng thêm lớp
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maKhoa == "" || maLop == "" || tenLop == "")
            {
                MessageBox.Show(
                    "Mã khoa, Mã lớp và Tên lớp không được để trống!");
                return;
            }

            ThucThi(
                @"INSERT INTO Lop (MaLop, TenLop, MaKhoa)
                  VALUES (@MaLop, @TenLop, @MaKhoa)",
                maLop, maKhoa, tenLop);
        }

        // Chức năng xóa lớp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return;
            }

            if (txtMaKhoa.Text.Trim() != "" ||
                txtTenLop.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa, Mã khoa và Tên lớp phải để trống!");
                return;
            }

            ThucThi(
                "DELETE FROM Lop WHERE MaLop = @MaLop",
                maLop, null, null);
        }

        // Chức năng sửa lớp
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return;
            }

            if (maKhoa == "" && tenLop == "")
            {
                MessageBox.Show(
                    "Phải nhập ít nhất Mã khoa hoặc Tên lớp cần sửa!");
                return;
            }

            ThucThi(
                @"UPDATE Lop SET
                    MaKhoa = CASE WHEN @MaKhoa IS NULL
                        THEN MaKhoa ELSE @MaKhoa END,
                    TenLop = CASE WHEN @TenLop IS NULL
                        THEN TenLop ELSE @TenLop END
                  WHERE MaLop = @MaLop",
                maLop,
                maKhoa == "" ? null : maKhoa,
                tenLop == "" ? null : tenLop);
        }

        // Thực thi SQL có tham số
        private void ThucThi(
            string sql, string maLop, string? maKhoa, string? tenLop)
        {
            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                    .Value = maLop;

                if (sql.StartsWith("DELETE",
                    StringComparison.OrdinalIgnoreCase))
                {
                    // Xóa chỉ cần mã lớp
                }
                else
                {
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                        .Value = (object?)maKhoa ?? DBNull.Value;

                    cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100)
                        .Value = (object?)tenLop ?? DBNull.Value;
                }

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Thao tác thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy lớp phù hợp!");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Mã lớp đã tồn tại!");
                }
                else if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Mã khoa không tồn tại hoặc lớp đang có sinh viên liên kết!");
                }
                else
                {
                    MessageBox.Show(
                        "Lỗi SQL Server: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void XoaTrang()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaKhoa.Focus();
        }
    }
}
