
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class TaoTonKho : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLCuaHang;Integrated Security=True;TrustServerCertificate=True;";

        public TaoTonKho()
        {
            InitializeComponent();
            Load += TaoTonKho_Load;
        }

        private void TaoTonKho_Load(object sender, EventArgs e)
        {
            dtpNgayTon.Value = DateTime.Today;
            TaiSanPham();
            TaiDuLieu();
        }

        private void TaiSanPham()
        {
            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                using SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MaSP, TenSP FROM SANPHAM ORDER BY TenSP",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboSanPham.DataSource = dt;
                cboSanPham.DisplayMember = "TenSP";
                cboSanPham.ValueMember = "MaSP";
                cboSanPham.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void TaiDuLieu()
        {
            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                string sql = @"
                    SELECT
                        sp.MaSP,
                        sp.TenSP,
                        tk.NgayTon,
                        tk.SLDau,
                        tk.SLNhap,
                        tk.SLBan,
                        tk.SLDau + tk.SLNhap - tk.SLBan AS TonCuoi
                    FROM TONKHO tk
                    JOIN SANPHAM sp ON sp.MaSP = tk.MaSP
                    WHERE tk.NgayTon = @NgayTon
                    ORDER BY sp.MaSP";

                using SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn);

                da.SelectCommand.Parameters.Add(
                    "@NgayTon", SqlDbType.Date)
                    .Value = dtpNgayTon.Value.Date;

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTonKho.DataSource = dt;

                lblTong.Text =
                    "Tổng số sản phẩm: " + dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tồn kho: " + ex.Message);
            }
        }

        private void btnTaoTonKho_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtpNgayTon.Value.Date;

            if (ngay > DateTime.Today)
            {
                MessageBox.Show("Không được tạo tồn kho ngày tương lai.");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                using SqlTransaction tran =
                    conn.BeginTransaction(IsolationLevel.Serializable);

                try
                {
                    string sql = @"
                        INSERT INTO TONKHO
                            (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                        SELECT
                            sp.MaSP,
                            @NgayTon,
                            ISNULL(
                                prev.SLDau + prev.SLNhap - prev.SLBan,
                                0
                            ),
                            0,
                            0
                        FROM SANPHAM sp
                        OUTER APPLY
                        (
                            SELECT TOP 1
                                tk.SLDau,
                                tk.SLNhap,
                                tk.SLBan
                            FROM TONKHO tk WITH (UPDLOCK, HOLDLOCK)
                            WHERE tk.MaSP = sp.MaSP
                              AND tk.NgayTon < @NgayTon
                            ORDER BY tk.NgayTon DESC
                        ) prev
                        WHERE NOT EXISTS
                        (
                            SELECT 1
                            FROM TONKHO tk WITH (UPDLOCK, HOLDLOCK)
                            WHERE tk.MaSP = sp.MaSP
                              AND tk.NgayTon = @NgayTon
                        )";

                    using SqlCommand cmd =
                        new SqlCommand(sql, conn, tran);

                    cmd.Parameters.Add(
                        "@NgayTon", SqlDbType.Date).Value = ngay;

                    int soDong = cmd.ExecuteNonQuery();

                    tran.Commit();

                    MessageBox.Show(
                        soDong > 0
                        ? $"Đã tạo tồn kho cho {soDong} sản phẩm!"
                        : "Tồn kho đã tồn tại hoặc chưa có sản phẩm.");
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }

                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tồn kho: " + ex.Message);
            }
        }

        // Nhập thêm hàng vào tồn kho theo ngày
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null ||
                !int.TryParse(
                    cboSanPham.SelectedValue.ToString(),
                    out int maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            if (!int.TryParse(txtSLNhap.Text.Trim(), out int slNhap)
                || slNhap <= 0)
            {
                MessageBox.Show(
                    "Số lượng nhập phải là số nguyên dương.");
                return;
            }

            if (dtpNgayTon.Value.Date != DateTime.Today)
            {
                MessageBox.Show(
                    "Chỉ được nhập hàng cho ngày hiện tại.");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                string sql = @"
                    UPDATE TONKHO
                    SET SLNhap = SLNhap + @SLNhap
                    WHERE MaSP = @MaSP
                      AND NgayTon = @NgayTon";

                using SqlCommand cmd =
                    new SqlCommand(sql, conn);

                cmd.Parameters.Add(
                    "@SLNhap", SqlDbType.Int).Value = slNhap;

                cmd.Parameters.Add(
                    "@MaSP", SqlDbType.Int).Value = maSP;

                cmd.Parameters.Add(
                    "@NgayTon", SqlDbType.Date)
                    .Value = dtpNgayTon.Value.Date;

                int ketQua = cmd.ExecuteNonQuery();

                if (ketQua == 0)
                {
                    MessageBox.Show(
                        "Chưa có tồn kho ngày này.\n" +
                        "Hãy nhấn Tạo tồn kho trước.");
                    return;
                }

                MessageBox.Show(
                    $"Nhập thêm {slNhap} sản phẩm thành công!");

                txtSLNhap.Clear();
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập hàng: " + ex.Message);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
