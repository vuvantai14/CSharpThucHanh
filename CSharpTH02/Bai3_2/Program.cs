using System.Collections;

namespace Bai3_2;

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

    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 3.2 - SAP XEP BANG INTERFACE ==="
        );

        int[] ds =
        {
            1, 5, 2, 1, 3, 4, 2, 3
        };

        Console.WriteLine(
            "\n=== DAY BAN DAU ==="
        );

        PrintArray(ds);

        // Sap tang
        SortLib.SapXep(
            ds,
            new SapTangAdapter()
        );

        Console.WriteLine(
            "\n=== SAP TANG ==="
        );

        PrintArray(ds);

        // Sap giam
        SortLib.SapXep(
            ds,
            new SapGiamAdapter()
        );

        Console.WriteLine(
            "\n=== SAP GIAM ==="
        );

        PrintArray(ds);
    }
}