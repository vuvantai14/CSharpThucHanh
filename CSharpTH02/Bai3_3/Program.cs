using System.Collections;

namespace Bai3_3;

class Program
{
    static void PrintArray(IList ds)
    {
        Console.Write(
            $"Day so co {ds.Count} phan tu: "
        );

        for (int i = 0; i < ds.Count; i++)
        {
            Console.Write($"{ds[i]} ");
        }

        Console.WriteLine();
    }

    // So sanh tang dan
    static int SapTang(object a, object b)
    {
        int ia = (int)a;
        int ib = (int)b;

        if (ia < ib)
            return -1;
        else if (ia == ib)
            return 0;

        return 1;
    }

    // So sanh giam dan
    static int SapGiam(object a, object b)
    {
        int ia = (int)a;
        int ib = (int)b;

        if (ia < ib)
            return 1;
        else if (ia == ib)
            return 0;

        return -1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 3.3 - SAP XEP BANG DELEGATE ==="
        );

        int[] ds =
        {
            1, 5, 2, 1, 3, 4, 2, 3
        };

        Console.WriteLine(
            "\n=== DAY BAN DAU ==="
        );

        PrintArray(ds);

        // Delegate tro den ham SapTang
        SortLib.SapXep(ds, SapTang);

        Console.WriteLine(
            "\n=== SAP TANG ==="
        );

        PrintArray(ds);

        // Delegate tro den ham SapGiam
        SortLib.SapXep(ds, SapGiam);

        Console.WriteLine(
            "\n=== SAP GIAM ==="
        );

        PrintArray(ds);
    }
}