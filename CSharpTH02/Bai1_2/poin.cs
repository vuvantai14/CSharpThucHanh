namespace Bai1_2;

public class Point
{
    // Field: toa do x, y
    private double x;
    private double y;

    // Property X
    public double X
    {
        get { return x; }
        set { x = value; }
    }

    // Property Y
    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    // Default Constructor
    // Khoi tao diem (0, 0)
    public Point()
    {
        x = 0;
        y = 0;
    }

    // Constructor co tham so
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Nhap toa do diem
    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine() ?? "0");
    }

    // Xuat toa do diem
    public void Output()
    {
        Console.WriteLine($"({x}, {y})");
    }

    // Chuyen Point thanh chuoi
    public override string ToString()
    {
        return $"({x}, {y})";
    }

    // Cong hai diem
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.x + b.x, a.y + b.y);
    }

    // Tru hai diem
    public static Point operator -(Point a, Point b)
    {
        return new Point(a.x - b.x, a.y - b.y);
    }

    // Lay am mot diem
    public static Point operator -(Point a)
    {
        return new Point(-a.x, -a.y);
    }

    // ==========================================
    // KHOANG CACH GIUA HAI DIEM
    // ==========================================

    // Cach 1: Phuong thuc thanh vien
    public double Distance(Point other)
    {
        double dx = x - other.x;
        double dy = y - other.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // Cach 2: Phuong thuc tinh
    public static double Distance(Point a, Point b)
    {
        double dx = a.x - b.x;
        double dy = a.y - b.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    // ==========================================
    // TRUNG DIEM CUA HAI DIEM
    // ==========================================

    // Cach 1: Phuong thuc thanh vien
    public Point MidPoint(Point other)
    {
        return new Point(
            (x + other.x) / 2,
            (y + other.y) / 2
        );
    }

    // Cach 2: Phuong thuc tinh
    public static Point MidPoint(Point a, Point b)
    {
        return new Point(
            (a.x + b.x) / 2,
            (a.y + b.y) / 2
        );
    }
}