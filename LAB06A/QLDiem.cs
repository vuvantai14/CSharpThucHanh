
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06A
{
    public partial class QLDiem : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public QLDiem()
        {
            InitializeComponent();
        }

        // Kiểm tra điểm là số từ 0 đến 10
        private bool KiemTraDiem(out double diem)
        {
            diem = 0;
            string s = txtDiem.Text.Trim();

            bool hopLe =
                double.TryParse(s, NumberStyles.Float,
                    CultureInfo.CurrentCulture, out diem)
                || double.TryParse(s, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out diem);

            if (!hopLe || double.IsNaN(diem) ||
                double.IsInfinity(diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show(
                    "Điểm phải là số hợp lệ từ 0 đến 10!");
                return false;
            }

            return true;
        }

        // Thêm điểm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMH.Text.Trim();

            if (maSV == "" || maMH == "" ||
                txtDiem.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!KiemTraDiem(out double diem))
                return;

            ThucThi(
                @"INSERT INTO Diem
                  (MaSinhVien, MaMonHoc, Diem)
                  VALUES (@MaSV, @MaMH, @Diem)",
                maSV, maMH, diem);
        }

        // Xóa điểm
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMH.Text.Trim();

            if (maSV == "" || maMH == "")
            {
                MessageBox.Show(
                    "Mã sinh viên và Mã môn học không được để trống!");
                return;
            }

            if (txtDiem.Text.Trim() != "")
            {
                MessageBox.Show(
                    "Khi xóa, trường Điểm phải để trống!");
                return;
            }

            ThucThi(
                @"DELETE FROM Diem
                  WHERE MaSinhVien = @MaSV
                  AND MaMonHoc = @MaMH",
                maSV, maMH, null);
        }

        // Sửa điểm
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMH.Text.Trim();

            if (maSV == "" || maMH == "" ||
                txtDiem.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!KiemTraDiem(out double diem))
                return;

            ThucThi(
                @"UPDATE Diem SET Diem = @Diem
                  WHERE MaSinhVien = @MaSV
                  AND MaMonHoc = @MaMH",
                maSV, maMH, diem);
        }

        // Thực thi SQL có tham số
        private void ThucThi(
            string sql, string maSV, string maMH, double? diem)
        {
            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar, 10)
                    .Value = maSV;

                cmd.Parameters.Add("@MaMH", SqlDbType.VarChar, 10)
                    .Value = maMH;

                if (diem.HasValue)
                {
                    cmd.Parameters.Add("@Diem", SqlDbType.Float)
                        .Value = diem.Value;
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
                        "Không tìm thấy dữ liệu phù hợp!");
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "Sinh viên đã có điểm môn học này!");
                }
                else if (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Mã sinh viên hoặc Mã môn học không hợp lệ!");
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
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }
    }
}
