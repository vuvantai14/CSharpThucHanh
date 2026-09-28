namespace Bai2_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 2.4 - MANG 2 CHIEU ==="
        );

        // Tao mang bang default constructor
        Mang2Chieu a = new Mang2Chieu();

        // Nhap mang
        a.Input();

        // Xuat mang
        Console.WriteLine(
            "\n=== MANG VUA NHAP ==="
        );

        a.Output();

        // Kiem tra Indexer
        Console.WriteLine(
            "\n=== KIEM TRA INDEXER ==="
        );

        Console.WriteLine(
            $"a[0,0] = {a[0, 0]}"
        );

        // Tim cac so nguyen to
        Console.WriteLine(
            "\n=== CAC SO NGUYEN TO ==="
        );

        a.TimSoNguyenTo();

        // Kiem tra Copy Constructor
        Mang2Chieu b = new Mang2Chieu(a);

        Console.WriteLine(
            "\n=== MANG SAO CHEP ==="
        );

        b.Output();
    }
}