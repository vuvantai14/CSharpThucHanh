namespace Bai2_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 2.6 - DAY PHAN SO ==="
        );

        // Tao day phan so
        DayPhanSo ds = new DayPhanSo();

        // Nhap
        ds.Input();

        // Xuat
        Console.WriteLine(
            "\n=== DAY PHAN SO VUA NHAP ==="
        );

        ds.Output();

        // Kiem tra Indexer
        Console.WriteLine(
            "\n=== KIEM TRA INDEXER ==="
        );

        Console.WriteLine(
            $"Phan so dau tien: {ds[0]}"
        );

        // Tinh tong
        PhanSo tong = ds.TinhTong();

        Console.WriteLine(
            "\n=== TONG CAC PHAN SO ==="
        );

        Console.WriteLine(
            $"Tong = {tong}"
        );

        // Copy constructor
        DayPhanSo dsCopy =
            new DayPhanSo(ds);

        Console.WriteLine(
            "\n=== DAY PHAN SO SAO CHEP ==="
        );

        dsCopy.Output();
    }
}