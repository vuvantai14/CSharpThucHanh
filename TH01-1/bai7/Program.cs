using System;

class Program
{
    // Phuong thuc kiem tra so nguyen to
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (LaSoNguyenTo(n))
        {
            Console.WriteLine($"{n} la so nguyen to.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
    }
}