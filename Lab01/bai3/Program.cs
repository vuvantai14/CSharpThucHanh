using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap x: ");
        int x = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap y: ");
        int y = int.Parse(Console.ReadLine() ?? "0");

        double ketQua = Math.Pow(x, y);

        Console.WriteLine($"{x}^{y} = {ketQua}");
    }
}