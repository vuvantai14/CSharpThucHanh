namespace Bai2_5;

public class DaThuc
{
    // Mang chua cac he so a0, a1, ..., an
    private double[] a;

    // Default constructor
    public DaThuc()
    {
        a = Array.Empty<double>();
    }

    // Constructor co tham so
    // Bac n -> co n + 1 he so
    public DaThuc(int n)
    {
        a = new double[n + 1];
    }

    // Copy constructor
    public DaThuc(DaThuc p)
    {
        a = new double[p.a.Length];

        for (int i = 0; i < p.a.Length; i++)
        {
            a[i] = p.a[i];
        }
    }

    // Indexer truy cap he so thu i
    public double this[int i]
    {
        get
        {
            return a[i];
        }

        set
        {
            a[i] = value;
        }
    }

    // Nhap da thuc
    public void Input()
    {
        Console.Write("Nhap bac cua da thuc n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        a = new double[n + 1];

        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Nhap a[{i}]: ");
            a[i] = double.Parse(
                Console.ReadLine() ?? "0"
            );
        }
    }

    // Xuat da thuc
    public void Output()
    {
        Console.Write("P(x) = ");

        for (int i = 0; i < a.Length; i++)
        {
            if (i > 0)
            {
                Console.Write(" + ");
            }

            if (i == 0)
            {
                Console.Write($"{a[i]}");
            }
            else if (i == 1)
            {
                Console.Write($"{a[i]}x");
            }
            else
            {
                Console.Write($"{a[i]}x^{i}");
            }
        }

        Console.WriteLine();
    }

    // Tinh gia tri da thuc tai x
    public double TinhGiaTri(double x)
    {
        double result = 0;

        for (int i = 0; i < a.Length; i++)
        {
            result += a[i] * Math.Pow(x, i);
        }

        return result;
    }
}