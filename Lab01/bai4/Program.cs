using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen x: ");

        if (!int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine("Loi: x phai la so nguyen!");
            return;
        }

        Console.Write("Nhap so nguyen y: ");

        if (!int.TryParse(Console.ReadLine(), out int y))
        {
            Console.WriteLine("Loi: y phai la so nguyen!");
            return;
        }

        double ketQua = Math.Pow(x, y);

        Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
    }
}