namespace Bai2_3;

public class DaySo
{
    // Mang chua cac so nguyen
    private int[] a;

    // =====================================
    // DEFAULT CONSTRUCTOR
    // =====================================

    public DaySo()
    {
        a = Array.Empty<int>();
    }

    // =====================================
    // CONSTRUCTOR CO THAM SO
    // Khoi tao day gom n phan tu
    // =====================================

    public DaySo(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException(
                "So luong phan tu khong duoc am!"
            );
        }

        a = new int[n];
    }

    // =====================================
    // COPY CONSTRUCTOR
    // =====================================

    public DaySo(DaySo other)
    {
        a = new int[other.a.Length];

        for (int i = 0; i < other.a.Length; i++)
        {
            a[i] = other.a[i];
        }
    }

    // =====================================
    // SO LUONG PHAN TU
    // =====================================

    public int Length
    {
        get { return a.Length; }
    }

    // =====================================
    // INDEXER
    // Truy cap phan tu thu i
    // =====================================

    public int this[int i]
    {
        get
        {
            if (i < 0 || i >= a.Length)
            {
                throw new IndexOutOfRangeException(
                    "Chi so khong hop le!"
                );
            }

            return a[i];
        }

        set
        {
            if (i < 0 || i >= a.Length)
            {
                throw new IndexOutOfRangeException(
                    "Chi so khong hop le!"
                );
            }

            a[i] = value;
        }
    }

    // =====================================
    // INPUT
    // =====================================

    public void Input()
    {
        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n < 0)
        {
            throw new ArgumentException(
                "So luong phan tu khong duoc am!"
            );
        }

        a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(
                Console.ReadLine() ?? "0"
            );
        }
    }

    // =====================================
    // OUTPUT
    // =====================================

    public void Output()
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]} ");
        }

        Console.WriteLine();
    }

    // =====================================
    // TIM CAC SO CHAN
    // =====================================

    public void TimSoChan()
    {
        bool found = false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write($"{a[i]} ");
                found = true;
            }
        }

        if (!found)
        {
            Console.Write("Khong co so chan");
        }

        Console.WriteLine();
    }
}