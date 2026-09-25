using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguoi n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        string[] hoTen = new string[n];

        // Nhap danh sach ho ten
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
            hoTen[i] = Console.ReadLine() ?? "";
        }

        Console.WriteLine("\nDanh sach truoc khi sap xep:");

        for (int i = 0; i < hoTen.Length; i++)
        {
            Console.WriteLine(hoTen[i]);
        }

        // Sap xep tang dan
        Array.Sort(hoTen);

        Console.WriteLine("\nDanh sach sau khi sap xep tang dan:");

        for (int i = 0; i < hoTen.Length; i++)
        {
            Console.WriteLine(hoTen[i]);
        }
    }
}