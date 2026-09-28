namespace Bai2_1;

public class Point
{
    // Toa do x, y
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

    // Constructor mac dinh
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

    // Nhap toa do
    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine() ?? "0");
    }

    // Xuat toa do
    public void Output()
    {
        Console.WriteLine(this);
    }

    // Chuyen Point thanh chuoi
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}