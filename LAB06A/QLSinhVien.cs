
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06A
{
    public partial class QLSinhVien : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLSinhVien()
        {
            InitializeComponent();
        }

        private bool LayNgaySinh(out DateTime ngaySinh)
        {
            ngaySinh = default;
            string s = txtNgaySinh.Text.Trim();

            return DateTime.TryParseExact(
                s, "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out ngaySinh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string ngay = txtNgaySinh.Text.Trim();

            if (maLop == "" || maSV == "" ||
                hoTen == "" || ngay == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!LayNgaySinh(out DateTime ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh phải đúng định dạng dd/MM/yyyy!");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"INSERT INTO SinhVien
                    (MaSinhVien, HoTen, NgaySinh, MaLop)
                    VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                    .Value = maSV;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                    .Value = hoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                    .Value = ngaySinh;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                    .Value = maLop;

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sinh viên thành công!");
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            if (maSV == "" || hoTen == "")
            {
                MessageBox.Show(
                    "Phải nhập Mã SV và Họ tên để xóa!");
                return;
            }

            if (txtMaLop.Text.Trim() != "" ||
                txtNgaySinh.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa, Mã lớp và Ngày sinh phải để trống!");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"DELETE FROM SinhVien
                    WHERE MaSinhVien = @MaSV AND HoTen = @HoTen";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                    .Value = maSV;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                    .Value = hoTen;

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                    ? "Xóa sinh viên thành công!"
                    : "Không tìm thấy sinh viên phù hợp!");

                if (rows > 0) XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string ngay = txtNgaySinh.Text.Trim();

            if (maSV == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!");
                return;
            }

            if (maLop == "" && hoTen == "" && ngay == "")
            {
                MessageBox.Show(
                    "Phải nhập ít nhất một thông tin cần sửa!");
                return;
            }

            DateTime ngaySinh = default;

            if (ngay != "" && !LayNgaySinh(out ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh phải đúng định dạng dd/MM/yyyy!");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"UPDATE SinhVien SET
                    MaLop = CASE WHEN @MaLop IS NULL
                        THEN MaLop ELSE @MaLop END,
                    HoTen = CASE WHEN @HoTen IS NULL
                        THEN HoTen ELSE @HoTen END,
                    NgaySinh = CASE WHEN @NgaySinh IS NULL
                        THEN NgaySinh ELSE @NgaySinh END
                    WHERE MaSinhVien = @MaSV";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                    .Value = maSV;

                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                    .Value = maLop == "" ? DBNull.Value : maLop;

                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                    .Value = hoTen == "" ? DBNull.Value : hoTen;

                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                    .Value = ngay == "" ? DBNull.Value : ngaySinh;

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                    ? "Sửa sinh viên thành công!"
                    : "Không tìm thấy sinh viên!");

                if (rows > 0) XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void XoaTrang()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtMaLop.Focus();
        }
    }
}
