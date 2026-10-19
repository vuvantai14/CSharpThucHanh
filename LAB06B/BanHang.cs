
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class BanHang : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLCuaHang;Integrated Security=True;TrustServerCertificate=True;";

        private int maHD = 0;

        public BanHang()
        {
            InitializeComponent();
            Load += BanHang_Load;
            FormClosing += BanHang_FormClosing;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            TaiSanPham();
            CapNhatTrangThai(false);
        }

        private void TaiSanPham()
        {
            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"
                    SELECT MaSP, TenSP
                    FROM SANPHAM
                    ORDER BY TenSP";

                using SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboSanPham.DataSource = dt;
                cboSanPham.DisplayMember = "TenSP";
                cboSanPham.ValueMember = "MaSP";
                cboSanPham.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void CapNhatTrangThai(bool dangBan)
        {
            btnTaoHoaDon.Enabled = !dangBan;
            btnThem.Enabled = dangBan;
            btnHuy.Enabled = dangBan;
            btnThanhToan.Enabled = dangBan;

            cboSanPham.Enabled = dangBan;
            txtSoLuong.Enabled = dangBan;

            txtMaHD.Text =
                maHD == 0 ? "" : maHD.ToString();
        }

        // Tạo hóa đơn mới
        private void btnTaoHoaDon_Click(
            object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                string sql = @"
                    INSERT INTO HOADON
                    (NgayTao, TinhTrangThanhToan)
                    OUTPUT INSERTED.MaHD
                    VALUES (CAST(GETDATE() AS DATE), 0)";

                using SqlCommand cmd =
                    new SqlCommand(sql, conn);

                maHD = Convert.ToInt32(
                    cmd.ExecuteScalar());

                CapNhatTrangThai(true);
                TaiChiTiet();

                MessageBox.Show(
                    "Tạo hóa đơn thành công!\nMã: " + maHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tạo hóa đơn: " + ex.Message);
            }
        }

        // Hiển thị chi tiết hóa đơn
        private void TaiChiTiet()
        {
            if (maHD == 0)
            {
                dgvChiTiet.DataSource = null;
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"
                    SELECT
                        ct.MaSP AS [Mã SP],
                        sp.TenSP AS [Tên sản phẩm],
                        ct.SoLuong AS [Số lượng]
                    FROM CHITIET_HOADON ct
                    JOIN SANPHAM sp
                        ON ct.MaSP = sp.MaSP
                    WHERE ct.MaHD = @MaHD";

                using SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add(
                    "@MaHD", SqlDbType.Int).Value = maHD;

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvChiTiet.DataSource = dt;
                lblTong.Text =
                    "Số loại sản phẩm: " + dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải chi tiết: " + ex.Message);
            }
        }

        // Thêm sản phẩm vào hóa đơn
        private void btnThem_Click(
            object sender, EventArgs e)
        {
            if (maHD == 0 || cboSanPham.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng tạo hóa đơn và chọn sản phẩm.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên dương.");
                return;
            }

            int maSP =
                Convert.ToInt32(cboSanPham.SelectedValue);

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                using SqlTransaction tran =
                    conn.BeginTransaction(IsolationLevel.Serializable);

                try
                {
                    // Khóa hóa đơn để tránh sửa khi đã thanh toán
                    string sqlHD = @"
                        SELECT TinhTrangThanhToan
                        FROM HOADON WITH (UPDLOCK, HOLDLOCK)
                        WHERE MaHD = @MaHD
                          AND NgayTao = CAST(GETDATE() AS DATE)";

                    using SqlCommand cmdHD =
                        new SqlCommand(sqlHD, conn, tran);

                    cmdHD.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    object? trangThai = cmdHD.ExecuteScalar();

                    if (trangThai == null ||
                        Convert.ToInt32(trangThai) != 0)
                    {
                        throw new Exception(
                            "Hóa đơn không hợp lệ hoặc đã thanh toán.");
                    }

                    // Kiểm tra sản phẩm trùng trong hóa đơn
                    string sqlKiemTra = @"
                        SELECT COUNT(*)
                        FROM CHITIET_HOADON
                        WHERE MaHD = @MaHD AND MaSP = @MaSP";

                    using SqlCommand cmdKT =
                        new SqlCommand(sqlKiemTra, conn, tran);

                    cmdKT.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    cmdKT.Parameters.Add(
                        "@MaSP", SqlDbType.Int).Value = maSP;

                    if (Convert.ToInt32(cmdKT.ExecuteScalar()) > 0)
                    {
                        throw new Exception(
                            "Sản phẩm đã có trong hóa đơn.");
                    }

                    // Kiểm tra tồn và tăng số lượng bán
                    string sqlTonKho = @"
                        UPDATE TONKHO
                        SET SLBan = SLBan + @SoLuong
                        WHERE MaSP = @MaSP
                          AND NgayTon = CAST(GETDATE() AS DATE)
                          AND SLDau + SLNhap - SLBan > @SoLuong";

                    using SqlCommand cmdTK =
                        new SqlCommand(sqlTonKho, conn, tran);

                    cmdTK.Parameters.Add(
                        "@MaSP", SqlDbType.Int).Value = maSP;

                    cmdTK.Parameters.Add(
                        "@SoLuong", SqlDbType.Int).Value = soLuong;

                    if (cmdTK.ExecuteNonQuery() != 1)
                    {
                        throw new Exception(
                            "Không đủ tồn kho hoặc chưa tạo tồn kho hôm nay.");
                    }

                    // Thêm chi tiết hóa đơn
                    string sqlChiTiet = @"
                        INSERT INTO CHITIET_HOADON
                        (MaHD, MaSP, SoLuong)
                        VALUES (@MaHD, @MaSP, @SoLuong)";

                    using SqlCommand cmdCT =
                        new SqlCommand(sqlChiTiet, conn, tran);

                    cmdCT.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    cmdCT.Parameters.Add(
                        "@MaSP", SqlDbType.Int).Value = maSP;

                    cmdCT.Parameters.Add(
                        "@SoLuong", SqlDbType.Int).Value = soLuong;

                    cmdCT.ExecuteNonQuery();

                    tran.Commit();

                    MessageBox.Show(
                        "Thêm sản phẩm vào hóa đơn thành công!");

                    txtSoLuong.Clear();
                    TaiChiTiet();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm sản phẩm: " + ex.Message);
            }
        }

        // Hủy hóa đơn và hoàn tồn kho
        private void btnHuy_Click(
            object sender, EventArgs e)
        {
            if (maHD == 0) return;

            if (MessageBox.Show(
                "Bạn có chắc muốn hủy hóa đơn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                using SqlTransaction tran =
                    conn.BeginTransaction(IsolationLevel.Serializable);

                try
                {
                    string sqlTrangThai = @"
                        SELECT TinhTrangThanhToan
                        FROM HOADON WITH (UPDLOCK, HOLDLOCK)
                        WHERE MaHD = @MaHD
                          AND NgayTao = CAST(GETDATE() AS DATE)";

                    using SqlCommand cmdTT =
                        new SqlCommand(sqlTrangThai, conn, tran);

                    cmdTT.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    object? trangThai = cmdTT.ExecuteScalar();

                    if (trangThai == null ||
                        Convert.ToInt32(trangThai) != 0)
                    {
                        throw new Exception(
                            "Chỉ được hủy hóa đơn chưa thanh toán trong ngày.");
                    }

                    // Đếm số dòng chi tiết cần hoàn
                    using SqlCommand cmdDem =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM CHITIET_HOADON WHERE MaHD=@MaHD",
                            conn, tran);

                    cmdDem.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    int soDong = Convert.ToInt32(
                        cmdDem.ExecuteScalar());

                    // Hoàn lại tồn kho
                    string sqlHoan = @"
                        UPDATE tk
                        SET tk.SLBan = tk.SLBan - ct.SoLuong
                        FROM TONKHO tk
                        JOIN CHITIET_HOADON ct
                            ON tk.MaSP = ct.MaSP
                        WHERE ct.MaHD = @MaHD
                          AND tk.NgayTon = CAST(GETDATE() AS DATE)
                          AND tk.SLBan >= ct.SoLuong";

                    using SqlCommand cmdHoan =
                        new SqlCommand(sqlHoan, conn, tran);

                    cmdHoan.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    if (cmdHoan.ExecuteNonQuery() != soDong)
                    {
                        throw new Exception(
                            "Không thể hoàn tồn kho đầy đủ.");
                    }

                    // Xóa chi tiết
                    using SqlCommand cmdXoaCT =
                        new SqlCommand(
                            "DELETE FROM CHITIET_HOADON WHERE MaHD=@MaHD",
                            conn, tran);

                    cmdXoaCT.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    cmdXoaCT.ExecuteNonQuery();

                    // Xóa hóa đơn
                    using SqlCommand cmdXoaHD =
                        new SqlCommand(
                            "DELETE FROM HOADON WHERE MaHD=@MaHD AND TinhTrangThanhToan=0",
                            conn, tran);

                    cmdXoaHD.Parameters.Add(
                        "@MaHD", SqlDbType.Int).Value = maHD;

                    if (cmdXoaHD.ExecuteNonQuery() != 1)
                        throw new Exception("Không thể xóa hóa đơn.");

                    tran.Commit();

                    maHD = 0;
                    CapNhatTrangThai(false);
                    TaiChiTiet();

                    MessageBox.Show("Hủy hóa đơn thành công!");
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi hủy hóa đơn: " + ex.Message);
            }
        }

        // Thanh toán hóa đơn
        private void btnThanhToan_Click(
            object sender, EventArgs e)
        {
            if (maHD == 0) return;

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                string sql = @"
                    UPDATE HOADON
                    SET TinhTrangThanhToan = 1
                    WHERE MaHD = @MaHD
                      AND TinhTrangThanhToan = 0
                      AND EXISTS
                      (
                          SELECT 1
                          FROM CHITIET_HOADON
                          WHERE MaHD = @MaHD
                      )";

                using SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add(
                    "@MaHD", SqlDbType.Int).Value = maHD;

                if (cmd.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show(
                        "Hóa đơn trống hoặc đã thanh toán.");
                    return;
                }

                MessageBox.Show(
                    "Thanh toán hóa đơn thành công!");

                maHD = 0;
                CapNhatTrangThai(false);
                TaiChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thanh toán: " + ex.Message);
            }
        }

        private void BanHang_FormClosing(
            object? sender, FormClosingEventArgs e)
        {
            if (maHD != 0)
            {
                MessageBox.Show(
                    "Hãy thanh toán hoặc hủy hóa đơn trước khi đóng.");
                e.Cancel = true;
            }
        }
    }
}
