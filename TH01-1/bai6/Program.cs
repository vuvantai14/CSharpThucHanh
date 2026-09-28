using System;

class Program
{
    // Phuong thuc tim so lon nhat trong 3 so nguyen
    static int TimMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        return max;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap c: ");
        int c = int.Parse(Console.ReadLine() ?? "0");

        int ketQua = TimMax(a, b, c);

        Console.WriteLine($"Gia tri lon nhat la: {ketQua}");
    }
}