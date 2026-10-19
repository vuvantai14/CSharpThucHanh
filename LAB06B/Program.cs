
using System;
using System.Windows.Forms;

namespace LAB06B
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Bài mẫu 1 - Quản lý Khoa
           // Application.Run(new QLKhoa());

            // Bài mẫu 2 - Quản lý Lớp
            // Application.Run(new QLLop());

            // Bài tại lớp 1 - Quản lý Sinh viên
            // Application.Run(new QLSinhVien());

            // Bài tại lớp 2 - Quản lý Điểm
            // Application.Run(new QLDiem());

            // Bài nâng cao 1 - Danh sách Lớp
            // Application.Run(new DanhSachLop());

            // Bài nâng cao 2 - Danh sách Điểm
            // Application.Run(new DanhSachDiem());

            // Bài về nhà 1 - Quản lý Cửa hàng
             Application.Run(new QLCuaHang());
        }
    }
}
