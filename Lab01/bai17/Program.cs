using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[] a = new int[n];

        Random random = new Random();

        // Sinh mang ngau nhien tu 10 den 100
        for (int i = 0; i < n; i++)
        {
            a[i] = random.Next(10, 101);
        }

        // Xuat mang
        Console.WriteLine("\nMang ngau nhien:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();

        // Tao danh sach chan va le
        List<int> mangChan = new List<int>();
        List<int> mangLe = new List<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                mangChan.Add(a[i]);
            }
            else
            {
                mangLe.Add(a[i]);
            }
        }

        // Xuat mang chan
        Console.WriteLine("\nMang so chan:");

        foreach (int x in mangChan)
        {
            Console.Write(x + " ");
        }

        // Xuat mang le
        Console.WriteLine("\n\nMang so le:");

        foreach (int x in mangLe)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}