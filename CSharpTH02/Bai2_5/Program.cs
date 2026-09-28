namespace Bai2_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 2.5 - DA THUC ==="
        );

        // Tao da thuc
        DaThuc p = new DaThuc();

        // Nhap da thuc
        p.Input();

        // Xuat da thuc
        Console.WriteLine(
            "\n=== DA THUC VUA NHAP ==="
        );

        p.Output();

        // Kiem tra Indexer
        Console.WriteLine(
            "\n=== KIEM TRA INDEXER ==="
        );

        Console.WriteLine(
            $"He so a[0] = {p[0]}"
        );

        // Nhap x
        Console.Write(
            "\nNhap gia tri x: "
        );

        double x = double.Parse(
            Console.ReadLine() ?? "0"
        );

        // Tinh P(x)
        double result = p.TinhGiaTri(x);

        Console.WriteLine(
            $"P({x}) = {result}"
        );

        // Copy constructor
        DaThuc q = new DaThuc(p);

        Console.WriteLine(
            "\n=== DA THUC SAO CHEP ==="
        );

        q.Output();
    }
}