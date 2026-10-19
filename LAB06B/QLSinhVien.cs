
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class QLSinhVien : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLSinhVien()
        {
            InitializeComponent();
            LoadDanhSachLop();
        }

        // Đọc danh sách mã lớp từ SQL Server
        private void LoadDanhSachLop()
        {
            try
            {
                cboMaLop.Items.Clear();

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    "SELECT MaLop FROM Lop ORDER BY MaLop", conn);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboMaLop.Items.Add(
                        reader["MaLop"].ToString());
                }

                cboMaLop.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        // Kiểm tra mã sinh viên đã tồn tại
        private bool KiemTraMaSinhVien(string maSV)
        {
            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*) FROM SinhVien
                  WHERE MaSinhVien = @MaSV", conn);

            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                .Value = maSV;

            conn.Open();

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        // Kiểm tra lớp tồn tại
        private bool KiemTraMaLop(string maLop)
        {
            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Lop WHERE MaLop = @MaLop",
                conn);

            cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                .Value = maLop;

            conn.Open();

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu(out DateTime ngaySinh)
        {
            ngaySinh = DateTime.MinValue;

            if (cboMaLop.SelectedIndex < 0 ||
                txtMaSV.Text.Trim() == "" ||
                txtHoTen.Text.Trim() == "" ||
                txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin sinh viên!");
                return false;
            }

            if (!DateTime.TryParseExact(
                txtNgaySinh.Text.Trim(),
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out ngaySinh))
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ! Nhập dd/MM/yyyy.");
                return false;
            }

            // Tuổi tính theo năm sinh, đúng yêu cầu PDF
            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (ngaySinh > DateTime.Today || tuoi < 17)
            {
                MessageBox.Show(
                    "Sinh viên phải từ 17 tuổi trở lên!");
                return false;
            }

            return true;
        }

        // THÊM SINH VIÊN
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out DateTime ngaySinh))
                return;

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string maLop = cboMaLop.Text;

            try
            {
                if (KiemTraMaSinhVien(maSV))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                if (!KiemTraMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp không tồn tại!");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO SinhVien
                      (MaSinhVien, HoTen, NgaySinh, MaLop)
                      VALUES (@MaSV, @HoTen, @NgaySinh, @MaLop)",
                    conn);

                ThemThamSo(cmd, maSV, hoTen, ngaySinh, maLop);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    XoaTrang();
                }
            }
            catch (SqlException ex) when (
                ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Mã lớp không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XÓA SINH VIÊN
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (maSV == "")
            {
                MessageBox.Show("Vui lòng nhập Mã sinh viên!");
                return;
            }

            try
            {
                if (!KiemTraMaSinhVien(maSV))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!");
                    return;
                }

                if (MessageBox.Show(
                    "Bạn có chắc muốn xóa sinh viên này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM SinhVien
                      WHERE MaSinhVien = @MaSV", conn);

                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                    .Value = maSV;

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!");
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể xóa vì sinh viên đã có điểm liên kết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // SỬA SINH VIÊN
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out DateTime ngaySinh))
                return;

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string maLop = cboMaLop.Text;

            try
            {
                if (!KiemTraMaSinhVien(maSV))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!");
                    return;
                }

                if (!KiemTraMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp không tồn tại!");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"UPDATE SinhVien
                      SET HoTen = @HoTen,
                          NgaySinh = @NgaySinh,
                          MaLop = @MaLop
                      WHERE MaSinhVien = @MaSV", conn);

                ThemThamSo(cmd, maSV, hoTen, ngaySinh, maLop);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Sửa sinh viên thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!");
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Mã lớp không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Thêm tham số SQL an toàn
        private void ThemThamSo(
            SqlCommand cmd, string maSV, string hoTen,
            DateTime ngaySinh, string maLop)
        {
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                .Value = maSV;

            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100)
                .Value = hoTen;

            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                .Value = ngaySinh.Date;

            cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                .Value = maLop;
        }

        private void XoaTrang()
        {
            cboMaLop.SelectedIndex = -1;
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtMaSV.Focus();
        }
    }
}
