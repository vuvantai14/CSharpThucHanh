
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class QLLop : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLLop()
        {
            InitializeComponent();
            LoadDanhSachKhoa();
        }

        // Hiển thị mã khoa lên ComboBox bằng SqlDataReader
        private void LoadDanhSachKhoa()
        {
            try
            {
                cboMaKhoa.Items.Clear();

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    "SELECT MaKhoa FROM Khoa ORDER BY MaKhoa", conn);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboMaKhoa.Items.Add(
                        reader["MaKhoa"].ToString());
                }

                cboMaKhoa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách khoa: " + ex.Message);
            }
        }

        // Kiểm tra khóa chính: mã lớp đã tồn tại?
        private bool KiemTraMaLop(string maLop)
        {
            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd = new SqlCommand(
                "SELECT MaLop FROM Lop WHERE MaLop = @MaLop",
                conn);

            cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                .Value = maLop;

            conn.Open();

            using SqlDataReader reader = cmd.ExecuteReader();
            return reader.Read();
        }

        // Kiểm tra khóa ngoại: mã khoa tồn tại?
        private bool KiemTraMaKhoa(string maKhoa)
        {
            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd = new SqlCommand(
                "SELECT MaKhoa FROM Khoa WHERE MaKhoa = @MaKhoa",
                conn);

            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                .Value = maKhoa;

            conn.Open();

            using SqlDataReader reader = cmd.ExecuteReader();
            return reader.Read();
        }

        // THÊM LỚP
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string maKhoa = cboMaKhoa.SelectedItem?.ToString() ?? "";

            if (maLop == "" || tenLop == "" || maKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                if (KiemTraMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp đã tồn tại!");
                    return;
                }

                if (!KiemTraMaKhoa(maKhoa))
                {
                    MessageBox.Show("Mã khoa không tồn tại!");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Lop (MaLop, TenLop, MaKhoa)
                      VALUES (@MaLop, @TenLop, @MaKhoa)", conn);

                ThemThamSo(cmd, maLop, tenLop, maKhoa);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm lớp thành công!");
                XoaTrang();
            }
            catch (SqlException ex) when (
                ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Mã khoa không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XÓA LỚP
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Vui lòng nhập Mã lớp!");
                return;
            }

            try
            {
                if (!KiemTraMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp không tồn tại!");
                    return;
                }

                if (MessageBox.Show(
                    "Bạn có chắc muốn xóa lớp này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Lop WHERE MaLop = @MaLop", conn);

                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                    .Value = maLop;

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Xóa lớp thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp!");
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể xóa lớp vì đang có sinh viên liên kết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // SỬA LỚP
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string maKhoa = cboMaKhoa.SelectedItem?.ToString() ?? "";

            if (maLop == "" || tenLop == "" || maKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                if (!KiemTraMaLop(maLop))
                {
                    MessageBox.Show("Mã lớp không tồn tại!");
                    return;
                }

                if (!KiemTraMaKhoa(maKhoa))
                {
                    MessageBox.Show("Mã khoa không tồn tại!");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"UPDATE Lop
                      SET TenLop = @TenLop,
                          MaKhoa = @MaKhoa
                      WHERE MaLop = @MaLop", conn);

                ThemThamSo(cmd, maLop, tenLop, maKhoa);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Sửa lớp thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp!");
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Mã khoa không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Tham số SQL dùng chung
        private void ThemThamSo(
            SqlCommand cmd, string maLop,
            string tenLop, string maKhoa)
        {
            cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10)
                .Value = maLop;

            cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100)
                .Value = tenLop;

            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10)
                .Value = maKhoa;
        }

        private void XoaTrang()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            cboMaKhoa.SelectedIndex = -1;
            txtMaLop.Focus();
        }
    }
}
