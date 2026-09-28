namespace Bai2_4;

public class Mang2Chieu
{
    // Mang 2 chieu chua cac so nguyen
    private int[,] a;

    // Default constructor
    public Mang2Chieu()
    {
        a = new int[0, 0];
    }

    // Constructor co tham so
    public Mang2Chieu(int n, int m)
    {
        a = new int[n, m];
    }

    // Copy constructor
    public Mang2Chieu(Mang2Chieu b)
    {
        int n = b.a.GetLength(0);
        int m = b.a.GetLength(1);

        a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = b.a[i, j];
            }
        }
    }

    // Indexer truy cap phan tu tai vi tri (i, j)
    public int this[int i, int j]
    {
        get
        {
            return a[i, j];
        }

        set
        {
            a[i, j] = value;
        }
    }

    // Nhap mang
    public void Input()
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine() ?? "0");

        a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(
                    Console.ReadLine() ?? "0"
                );
            }
        }
    }

    // Xuat mang
    public void Output()
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"{a[i, j],5}");
            }

            Console.WriteLine();
        }
    }

    // Kiem tra mot so co phai so nguyen to
    private bool IsPrime(int x)
    {
        if (x < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= x; i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    // Tim cac so nguyen to trong mang
    public void TimSoNguyenTo()
    {
        bool found = false;

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (IsPrime(a[i, j]))
                {
                    Console.Write($"{a[i, j]} ");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.Write("Khong co so nguyen to");
        }

        Console.WriteLine();
    }
}