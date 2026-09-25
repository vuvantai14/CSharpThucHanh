using System;

class Program
{
    // Phuong thuc tim max va min cua 3 so thuc
    static void TimMaxMin(
        double a,
        double b,
        double c,
        out double max,
        out double min)
    {
        max = a;
        min = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        if (b < min)
            min = b;

        if (c < min)
            min = c;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine() ?? "0");

        TimMaxMin(a, b, c, out double max, out double min);

        Console.WriteLine($"Gia tri lon nhat: {max}");
        Console.WriteLine($"Gia tri nho nhat: {min}");
    }
}