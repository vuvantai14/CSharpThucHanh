using System;
using System.Collections.Generic;

class XuLyMang
{
    public int[] NhapMang()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        return a;
    }

    public void XuatMang(int[] a)
    {
        Console.Write("Mang: ");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    public int TimMax(int[] a)
    {
        int max = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
        }

        return max;
    }

    public int TimMin(int[] a)
    {
        int min = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }

        return min;
    }

    public bool LaSoNguyenTo(int n)
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

    public int[] LayMangSoNguyenTo(int[] a)
    {
        List<int> ketQua = new List<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (LaSoNguyenTo(a[i]))
            {
                ketQua.Add(a[i]);
            }
        }

        return ketQua.ToArray();
    }
}