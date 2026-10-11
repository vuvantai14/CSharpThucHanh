
using System;
using System.Windows.Forms;

namespace LAB05C
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Bài mẫu 1
            // Application.Run(new BaiMau01_ListBox());

            // Bài mẫu 2
            // Application.Run(new BaiMau02_ComboBox());

            // Bài mẫu 3
            // Application.Run(new BaiMau03_TreeView());

            // Bài tập tại lớp 1
            // Application.Run(new BaiTap01_UocSo());

            // Bài tập tại lớp 2
            // Application.Run(new BaiTap02_QuanLySinhVien());

            // Bài nâng cao 1
            // Application.Run(new BaiNangCao01_XuLyChuoi());

            // Bài về nhà 1
            // Application.Run(new BaiVeNha01_TuDien());

            // Bài về nhà 2
            // Application.Run(new BaiVeNha02_DanhSachSo());

            // Bài về nhà 3
           Application.Run(new BaiVeNha03_DanhBa());
        }
    }
}
