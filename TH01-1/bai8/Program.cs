using System;

class Program
{
    // Phuong thuc hoan vi hai so thuc
    static void HoanVi(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");

        HoanVi(ref a, ref b);

        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
    }
}