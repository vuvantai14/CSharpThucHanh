namespace Bai3_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 3.1 - ARRAY.SORT ==="
        );

        Console.Write(
            "Nhap so luong sinh vien: "
        );

        int n = int.Parse(
            Console.ReadLine() ?? "0"
        );

        SinhVien[] ds = new SinhVien[n];

        // Nhap danh sach
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"\n--- Sinh vien thu {i + 1} ---"
            );

            ds[i] = new SinhVien();
            ds[i].Input();
        }

        // Danh sach truoc khi sap xep
        Console.WriteLine(
            "\n=== TRUOC KHI SAP XEP ==="
        );

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }

        // Dung Array.Sort theo yeu cau de bai
        Array.Sort(ds);

        // Danh sach sau khi sap xep
        Console.WriteLine(
            "\n=== SAU KHI SAP XEP TANG THEO DIEM ==="
        );

        foreach (SinhVien sv in ds)
        {
            sv.Output();
        }
    }
}