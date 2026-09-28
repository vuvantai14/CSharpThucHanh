namespace Bai1_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 1.5 - DON THUC ==="
        );

        // Nhap he so a
        Console.Write("Nhap he so a: ");
        double a =
            double.Parse(
                Console.ReadLine() ?? "0"
            );

        // Nhap so mu n
        Console.Write("Nhap so mu n: ");
        int n =
            int.Parse(
                Console.ReadLine() ?? "0"
            );

        // Tao don thuc
        DonThuc p = new DonThuc(a, n);

        // Nhap gia tri x
        Console.Write("Nhap x: ");
        double x =
            double.Parse(
                Console.ReadLine() ?? "0"
            );

        Console.WriteLine(
            "\n=== KET QUA ==="
        );

        // Xuat don thuc
        Console.WriteLine(
            $"P(x) = {p}"
        );

        // Tinh gia tri P(x)
        double giaTri =
            p.tinhGiaTri(x);

        Console.WriteLine(
            $"P({x}) = {giaTri}"
        );

        // Tinh dao ham tai x
        double daoHam =
            p.tinhDaoHam(x);

        Console.WriteLine(
            $"P'({x}) = {daoHam}"
        );

        // Kiem tra Copy Constructor
        DonThuc q = new DonThuc(p);

        Console.WriteLine(
            $"\nDon thuc sao chep: {q}"
        );
    }
}