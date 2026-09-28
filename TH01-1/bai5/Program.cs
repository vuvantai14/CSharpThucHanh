using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 0;
        double y = 0;
        int luaChon;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");

            if (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("Lua chon khong hop le!");
                continue;
            }

            switch (luaChon)
            {
                case 1:
                    Console.Write("Nhap x: ");
                    while (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.Write("Nhap sai. Nhap lai x: ");
                    }

                    Console.Write("Nhap y: ");
                    while (!double.TryParse(Console.ReadLine(), out y))
                    {
                        Console.Write("Nhap sai. Nhap lai y: ");
                    }

                    Console.WriteLine($"Da nhap x = {x}, y = {y}");
                    break;

                case 2:
                    double luyThua = Math.Pow(x, y);
                    Console.WriteLine($"{x}^{y} = {luyThua}");
                    break;

                case 3:
                    if (x >= 0)
                        Console.WriteLine($"Can bac 2 cua {x} = {Math.Sqrt(x)}");
                    else
                        Console.WriteLine("Khong the tinh can bac 2 cua x am.");

                    if (y >= 0)
                        Console.WriteLine($"Can bac 2 cua {y} = {Math.Sqrt(y)}");
                    else
                        Console.WriteLine("Khong the tinh can bac 2 cua y am.");

                    break;

                case 4:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;

                default:
                    Console.WriteLine("Chuc nang khong hop le!");
                    break;
            }

        } while (luaChon != 4);
    }
}