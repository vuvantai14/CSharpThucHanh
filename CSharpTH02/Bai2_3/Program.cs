namespace Bai2_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 2.3 - MANG 1 CHIEU ==="
        );

        // =====================================
        // DEFAULT CONSTRUCTOR
        // =====================================

        DaySo ds = new DaySo();

        // Nhap day so
        ds.Input();

        // =====================================
        // XUAT DAY SO
        // =====================================

        Console.WriteLine(
            "\n=== DAY SO VUA NHAP ==="
        );

        ds.Output();

        // =====================================
        // SU DUNG INDEXER
        // =====================================

        if (ds.Length > 0)
        {
            Console.WriteLine(
                "\n=== KIEM TRA INDEXER ==="
            );

            Console.WriteLine(
                $"ds[0] = {ds[0]}"
            );

            Console.WriteLine(
                $"ds[{ds.Length - 1}] = " +
                $"{ds[ds.Length - 1]}"
            );
        }

        // =====================================
        // TIM SO CHAN
        // =====================================

        Console.WriteLine(
            "\n=== CAC SO CHAN ==="
        );

        ds.TimSoChan();

        // =====================================
        // COPY CONSTRUCTOR
        // =====================================

        DaySo dsCopy = new DaySo(ds);

        Console.WriteLine(
            "\n=== DAY SO SAO CHEP ==="
        );

        dsCopy.Output();
    }
}