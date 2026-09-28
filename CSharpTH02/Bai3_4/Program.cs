namespace Bai3_4;

class Program
{
    static PTBac2 pt = new PTBac2();

    static void XuLyMenu(
        object sender,
        MenuChooseEventArgs args)
    {
        switch (args.Item)
        {
            case 1:
                Console.WriteLine(
                    "\n=== NHAP PHUONG TRINH ==="
                );

                pt.Input();
                break;

            case 2:
                Console.WriteLine(
                    "\n=== GIAI PHUONG TRINH ==="
                );

                pt.Giai();
                break;

            case 0:
                Console.WriteLine(
                    "\nTam biet!"
                );

                args.IsExit = true;
                break;

            default:
                Console.WriteLine(
                    "\nLua chon khong hop le!"
                );
                break;
        }
    }

    static void Main(string[] args)
    {
        ConsoleMenu menu = new ConsoleMenu(
            "=== GIAI PHUONG TRINH BAC 2 ===",
            "Thuc hien: ",
            "Nhap phuong trinh",
            "Giai phuong trinh"
        );

        // Dang ky Event
        menu.MenuChoose += XuLyMenu;

        // Chay menu
        menu.Process();
    }
}