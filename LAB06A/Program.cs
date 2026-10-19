
using System;
using System.Windows.Forms;

namespace LAB06A
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Bài mẫu 1 - Quản lý Khoa
            // Application.Run(new QLKhoa());

            // Bài tại lớp 1 - Quản lý Môn học
            // Application.Run(new QLMonHoc());

            // Bài nâng cao 1 - Quản lý Sinh viên
            // Application.Run(new QLSinhVien());

            // Bài nâng cao 2 - Quản lý Điểm
            // Application.Run(new QLDiem());

            // Bài về nhà 1 - Quản lý Lớp
             Application.Run(new QLLop());
        }
    }
}
