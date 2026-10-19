
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB06B
{
    public partial class ThemSanPham : Form
    {
        private readonly string connectionString =
            @"Server=.\SERVER;Database=QLCuaHang;Integrated Security=True;TrustServerCertificate=True;";

        public ThemSanPham()
        {
            InitializeComponent();
        }

        // Thêm sản phẩm và tạo tồn kho ban đầu
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenSP))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên sản phẩm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenSP.Focus();
                return;
            }

            if (tenSP.Length > 100)
            {
                MessageBox.Show(
                    "Tên sản phẩm không được quá 100 ký tự!");
                return;
            }

            try
            {
                using SqlConnection conn =
                    new SqlConnection(connectionString);

                conn.Open();

                using SqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    // 1. Thêm sản phẩm, lấy MaSP vừa tạo
                    string sqlSanPham = @"
                        INSERT INTO SANPHAM (TenSP)
                        OUTPUT INSERTED.MaSP
                        VALUES (@TenSP)";

                    using SqlCommand cmdSP =
                        new SqlCommand(
                            sqlSanPham, conn, transaction);

                    cmdSP.Parameters.Add(
                        "@TenSP", SqlDbType.NVarChar, 100)
                        .Value = tenSP;

                    int maSP = Convert.ToInt32(
                        cmdSP.ExecuteScalar());

                    // 2. Tạo tồn kho ban đầu
                    string sqlTonKho = @"
                        INSERT INTO TONKHO
                        (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                        VALUES
                        (@MaSP, @NgayTon, 0, 0, 0)";

                    using SqlCommand cmdTonKho =
                        new SqlCommand(
                            sqlTonKho, conn, transaction);

                    cmdTonKho.Parameters.Add(
                        "@MaSP", SqlDbType.Int)
                        .Value = maSP;

                    cmdTonKho.Parameters.Add(
                        "@NgayTon", SqlDbType.Date)
                        .Value = DateTime.Today;

                    cmdTonKho.ExecuteNonQuery();

                    // 3. Lưu toàn bộ thay đổi
                    transaction.Commit();

                    MessageBox.Show(
                        "Thêm sản phẩm thành công!\n" +
                        "Mã sản phẩm: " + maSP +
                        "\nTên sản phẩm: " + tenSP,
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtTenSP.Clear();
                    txtTenSP.Focus();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm sản phẩm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Làm mới ô nhập
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            txtTenSP.Focus();
        }

        // Đóng Form
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
