
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class QLDiem : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLDiem()
        {
            InitializeComponent();
            LoadDuLieuComboBox();
        }

        // Đọc mã sinh viên và mã môn học từ Database
        private void LoadDuLieuComboBox()
        {
            try
            {
                cboMaSV.Items.Clear();
                cboMaMonHoc.Items.Clear();

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT MaSinhVien FROM SinhVien ORDER BY MaSinhVien",
                    conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        cboMaSV.Items.Add(reader["MaSinhVien"].ToString());
                }

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT MaMonHoc FROM MonHoc ORDER BY MaMonHoc",
                    conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        cboMaMonHoc.Items.Add(reader["MaMonHoc"].ToString());
                }

                cboMaSV.SelectedIndex = -1;
                cboMaMonHoc.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Kiểm tra sinh viên hoặc môn học tồn tại
        private bool KiemTraTonTai(
            string bang, string cot, string ma)
        {
            // Chỉ gọi với tên bảng/cột cố định trong chương trình
            if (!((bang == "SinhVien" && cot == "MaSinhVien") ||
                  (bang == "MonHoc" && cot == "MaMonHoc")))
                throw new ArgumentException("Bảng hoặc cột không hợp lệ.");

            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd = new SqlCommand(
                $"SELECT COUNT(*) FROM {bang} WHERE {cot} = @Ma",
                conn);

            cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 10)
                .Value = ma;

            conn.Open();

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        // Kiểm tra cặp khóa chính trong bảng Diem
        private bool KiemTraDiem(string maSV, string maMonHoc)
        {
            using SqlConnection conn =
                new SqlConnection(connectionString);

            using SqlCommand cmd = new SqlCommand(
                @"SELECT COUNT(*) FROM Diem
                  WHERE MaSinhVien = @MaSV
                  AND MaMonHoc = @MaMonHoc", conn);

            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                .Value = maSV;
            cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10)
                .Value = maMonHoc;

            conn.Open();

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        // Kiểm tra dữ liệu
        private bool KiemTraNhap(bool canDiem, out decimal diem)
        {
            diem = 0;

            if (cboMaSV.SelectedIndex < 0 ||
                cboMaMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn Mã sinh viên và Mã môn học!");
                return false;
            }

            if (canDiem)
            {
                string giaTri = txtDiem.Text.Trim();

                if (giaTri == "")
                {
                    MessageBox.Show("Vui lòng nhập Điểm!");
                    return false;
                }

                // Chấp nhận dấu phẩy hoặc dấu chấm thập phân
                giaTri = giaTri.Replace(',', '.');

                if (!decimal.TryParse(
                    giaTri,
                    NumberStyles.AllowDecimalPoint |
                    NumberStyles.AllowLeadingSign,
                    CultureInfo.InvariantCulture,
                    out diem))
                {
                    MessageBox.Show("Điểm phải là số hợp lệ!");
                    return false;
                }

                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!");
                    return false;
                }
            }

            return true;
        }

        // THÊM ĐIỂM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(true, out decimal diem))
                return;

            string maSV = cboMaSV.Text;
            string maMonHoc = cboMaMonHoc.Text;

            try
            {
                if (!KiemTraTonTai(
                    "SinhVien", "MaSinhVien", maSV))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!");
                    return;
                }

                if (!KiemTraTonTai(
                    "MonHoc", "MaMonHoc", maMonHoc))
                {
                    MessageBox.Show("Mã môn học không tồn tại!");
                    return;
                }

                if (KiemTraDiem(maSV, maMonHoc))
                {
                    MessageBox.Show(
                        "Sinh viên đã có điểm môn học này!");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem)
                      VALUES (@MaSV, @MaMonHoc, @Diem)", conn);

                ThemThamSo(cmd, maSV, maMonHoc, diem, true);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm điểm thành công!");
                XoaTrang();
            }
            catch (SqlException ex) when (
                ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "Sinh viên đã có điểm môn học này!");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Mã sinh viên hoặc mã môn học không hợp lệ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // XÓA ĐIỂM
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(false, out _))
                return;

            string maSV = cboMaSV.Text;
            string maMonHoc = cboMaMonHoc.Text;

            try
            {
                if (!KiemTraDiem(maSV, maMonHoc))
                {
                    MessageBox.Show("Không tìm thấy điểm cần xóa!");
                    return;
                }

                if (MessageBox.Show(
                    "Bạn có chắc muốn xóa điểm này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"DELETE FROM Diem
                      WHERE MaSinhVien = @MaSV
                      AND MaMonHoc = @MaMonHoc", conn);

                ThemThamSo(cmd, maSV, maMonHoc, 0, false);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Xóa điểm thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm!");
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Không thể xóa vì có ràng buộc dữ liệu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // SỬA ĐIỂM
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap(true, out decimal diem))
                return;

            string maSV = cboMaSV.Text;
            string maMonHoc = cboMaMonHoc.Text;

            try
            {
                if (!KiemTraTonTai(
                    "SinhVien", "MaSinhVien", maSV) ||
                    !KiemTraTonTai(
                    "MonHoc", "MaMonHoc", maMonHoc))
                {
                    MessageBox.Show(
                        "Mã sinh viên hoặc môn học không tồn tại!");
                    return;
                }

                if (!KiemTraDiem(maSV, maMonHoc))
                {
                    MessageBox.Show("Không tìm thấy điểm cần sửa!");
                    return;
                }

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    @"UPDATE Diem SET Diem = @Diem
                      WHERE MaSinhVien = @MaSV
                      AND MaMonHoc = @MaMonHoc", conn);

                ThemThamSo(cmd, maSV, maMonHoc, diem, true);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Sửa điểm thành công!");
                    XoaTrang();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy điểm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Tham số dùng chung
        private void ThemThamSo(
            SqlCommand cmd, string maSV,
            string maMonHoc, decimal diem, bool coDiem)
        {
            cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                .Value = maSV;

            cmd.Parameters.Add("@MaMonHoc", SqlDbType.VarChar, 10)
                .Value = maMonHoc;

            if (coDiem)
            {
                var p = cmd.Parameters.Add(
                    "@Diem", SqlDbType.Decimal);
                p.Precision = 5;
                p.Scale = 2;
                p.Value = diem;
            }
        }

        private void XoaTrang()
        {
            cboMaSV.SelectedIndex = -1;
            cboMaMonHoc.SelectedIndex = -1;
            txtDiem.Clear();
            cboMaSV.Focus();
        }
    }
}
