using System;
using System.Collections.Generic;

class Program
{
    // Sinh ngau nhien mang A[n x m] trong doan [10, 100]
    static int[,] SinhMang(int n, int m)
    {
        int[,] a = new int[n, m];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = random.Next(10, 101);
            }
        }

        return a;
    }

    // In mang 2 chieu
    static void XuatMang(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{a[i, j],5}");
            }

            Console.WriteLine();
        }
    }

    // Tra ve hai mang: mang chan va mang le
    static void TachChanLe(
        int[,] a,
        out int[] mangChan,
        out int[] mangLe)
    {
        List<int> dsChan = new List<int>();
        List<int> dsLe = new List<int>();

        int n = a.GetLength(0);
        int m = a.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] % 2 == 0)
                {
                    dsChan.Add(a[i, j]);
                }
                else
                {
                    dsLe.Add(a[i, j]);
                }
            }
        }

        mangChan = dsChan.ToArray();
        mangLe = dsLe.ToArray();
    }

    // In mang 1 chieu
    static void XuatMangMotChieu(int[] a)
    {
        foreach (int x in a)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine() ?? "0");

        int[,] a = SinhMang(n, m);

        Console.WriteLine("\nMang A:");
        XuatMang(a);

        TachChanLe(
            a,
            out int[] mangChan,
            out int[] mangLe
        );

        Console.WriteLine("\nMang cac so chan:");
        XuatMangMotChieu(mangChan);

        Console.WriteLine("\nMang cac so le:");
        XuatMangMotChieu(mangLe);
    }
}