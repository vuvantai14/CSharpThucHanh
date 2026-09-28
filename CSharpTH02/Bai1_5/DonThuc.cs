namespace Bai1_5;

public class DonThuc
{
    // He so a
    private double a;

    // So mu n
    private int n;

    // Property he so
    public double A
    {
        get { return a; }
        set { a = value; }
    }

    // Property so mu
    public int N
    {
        get { return n; }

        set
        {
            // Theo de bai, n la so nguyen khong am
            if (value < 0)
                throw new Exception(
                    "So mu n phai la so nguyen khong am!"
                );

            n = value;
        }
    }

    // Constructor mac dinh
    public DonThuc()
    {
        a = 0;
        n = 0;
    }

    // Constructor co tham so
    public DonThuc(double a, int n)
    {
        if (n < 0)
            throw new Exception(
                "So mu n phai la so nguyen khong am!"
            );

        this.a = a;
        this.n = n;
    }

    // Copy Constructor
    public DonThuc(DonThuc p)
    {
        this.a = p.a;
        this.n = p.n;
    }

    // Xuat don thuc
    public override string ToString()
    {
        if (n == 0)
            return $"{a}";

        if (n == 1)
            return $"{a}x";

        return $"{a}x^{n}";
    }

    // =====================================
    // TINH GIA TRI DON THUC
    // P(x) = a * x^n
    // =====================================

    public double tinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    // =====================================
    // DAO HAM
    // P'(x) = a * n * x^(n-1)
    // =====================================

    public double tinhDaoHam(double x)
    {
        // Don thuc bac 0 la hang so
        // Dao ham bang 0
        if (n == 0)
            return 0;

        return a * n * Math.Pow(x, n - 1);
    }
}