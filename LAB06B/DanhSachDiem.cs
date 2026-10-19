
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class DanhSachDiem : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public DanhSachDiem()
        {
            InitializeComponent();
        }

        // Khi Form mở: tải môn học và toàn bộ điểm
        private void DanhSachDiem_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            HienThiDiem(null);
        }

        // Đưa mã môn học lên ComboBox
        private void LoadMonHoc()
        {
            try
            {
                cboMonHoc.Items.Clear();

                // Mục trống đại diện cho tất cả môn học
                cboMonHoc.Items.Add("");

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlCommand cmd = new SqlCommand(
                    "SELECT MaMonHoc FROM MonHoc ORDER BY MaMonHoc",
                    conn);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboMonHoc.Items.Add(
                        reader["MaMonHoc"].ToString());
                }

                cboMonHoc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải môn học: " + ex.Message);
            }
        }

        // Hiển thị danh sách điểm theo môn học
        private void HienThiDiem(string? maMonHoc)
        {
            try
            {
                lvDanhSachDiem.Items.Clear();
                txtTongDiem.Text = "0";

                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"
                    SELECT
                        sv.HoTen,
                        sv.NgaySinh,
                        mh.TenMonHoc,
                        d.Diem
                    FROM Diem d
                    INNER JOIN SinhVien sv
                        ON d.MaSinhVien = sv.MaSinhVien
                    INNER JOIN MonHoc mh
                        ON d.MaMonHoc = mh.MaMonHoc
                    WHERE (@MaMonHoc IS NULL
                           OR d.MaMonHoc = @MaMonHoc)
                    ORDER BY sv.HoTen, mh.TenMonHoc";

                using SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(
                    "@MaMonHoc", SqlDbType.VarChar, 10)
                    .Value = string.IsNullOrWhiteSpace(maMonHoc)
                        ? DBNull.Value
                        : maMonHoc;

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                int stt = 1;
                decimal tongDiem = 0;

                lvDanhSachDiem.BeginUpdate();

                try
                {
                    while (reader.Read())
                    {
                        string hoTen =
                            reader["HoTen"].ToString() ?? "";

                        string ngaySinh = "";

                        if (reader["NgaySinh"] != DBNull.Value)
                        {
                            ngaySinh = Convert.ToDateTime(
                                reader["NgaySinh"])
                                .ToString("dd/MM/yyyy");
                        }

                        string tenMonHoc =
                            reader["TenMonHoc"].ToString() ?? "";

                        decimal diem =
                            Convert.ToDecimal(reader["Diem"]);

                        ListViewItem item =
                            new ListViewItem(stt.ToString());

                        item.SubItems.Add(hoTen);
                        item.SubItems.Add(ngaySinh);
                        item.SubItems.Add(tenMonHoc);
                        item.SubItems.Add(
                            diem.ToString("0.##",
                            CultureInfo.GetCultureInfo("vi-VN")));

                        lvDanhSachDiem.Items.Add(item);

                        tongDiem += diem;
                        stt++;
                    }
                }
                finally
                {
                    lvDanhSachDiem.EndUpdate();
                }

                // Tổng điểm của các dòng đang hiển thị
                txtTongDiem.Text = tongDiem.ToString(
                    "0.##",
                    CultureInfo.GetCultureInfo("vi-VN"));

                lblSoLuong.Text =
                    "Số bản ghi: " + lvDanhSachDiem.Items.Count;
            }
            catch (Exception ex)
            {
                lvDanhSachDiem.Items.Clear();
                txtTongDiem.Text = "0";
                lblSoLuong.Text = "Số bản ghi: 0";

                MessageBox.Show(
                    "Lỗi hiển thị điểm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Lọc dữ liệu theo mã môn học
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string maMonHoc = cboMonHoc.Text.Trim();

            if (maMonHoc == "")
            {
                // Hiển thị tất cả môn học
                HienThiDiem(null);
            }
            else
            {
                // Chỉ hiển thị môn học được chọn
                HienThiDiem(maMonHoc);
            }
        }
    }
}
