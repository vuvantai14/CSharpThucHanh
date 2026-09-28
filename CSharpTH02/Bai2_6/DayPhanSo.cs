namespace Bai2_6;

public class DayPhanSo
{
    // Mang chua cac phan so
    private PhanSo[] ds;

    // Default constructor
    public DayPhanSo()
    {
        ds = Array.Empty<PhanSo>();
    }

    // Constructor co tham so
    public DayPhanSo(int n)
    {
        ds = new PhanSo[n];

        for (int i = 0; i < n; i++)
        {
            ds[i] = new PhanSo();
        }
    }

    // Copy constructor
    public DayPhanSo(DayPhanSo other)
    {
        ds = new PhanSo[other.ds.Length];

        for (int i = 0; i < ds.Length; i++)
        {
            ds[i] = new PhanSo(other.ds[i]);
        }
    }

    // Indexer
    public PhanSo this[int i]
    {
        get
        {
            return ds[i];
        }

        set
        {
            ds[i] = value;
        }
    }

    // Nhap day phan so
    public void Input()
    {
        Console.Write("Nhap so luong phan so n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        ds = new PhanSo[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"\n--- Phan so thu {i + 1} ---"
            );

            Console.Write("Nhap tu so: ");
            int tu = int.Parse(
                Console.ReadLine() ?? "0"
            );

            Console.Write("Nhap mau so: ");
            int mau = int.Parse(
                Console.ReadLine() ?? "1"
            );

            ds[i] = new PhanSo(tu, mau);
        }
    }

    // Xuat day phan so
    public void Output()
    {
        for (int i = 0; i < ds.Length; i++)
        {
            Console.Write($"{ds[i]} ");
        }

        Console.WriteLine();
    }

    // Tinh tong tat ca phan so
    public PhanSo TinhTong()
    {
        PhanSo tong = new PhanSo(0);

        foreach (PhanSo p in ds)
        {
            tong = tong + p;
        }

        return tong;
    }
}