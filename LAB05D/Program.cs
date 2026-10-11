
using System;
using System.Windows.Forms;

namespace LAB05D
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Chạy Form Main - Bài về nhà 2
            Application.Run(new BaiVeNha02_FormMain());
        }
    }
}
