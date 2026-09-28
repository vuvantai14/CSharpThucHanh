namespace Bai3_6;

public class ThiSinh
{
    protected string sbd;
    protected string hoTen;

    protected double bai1;
    protected double bai2;
    protected double bai3;

    public ThiSinh()
    {
        sbd = "";
        hoTen = "";

        bai1 = 0;
        bai2 = 0;
        bai3 = 0;
    }

    public virtual void Input()
    {
        Console.Write("Nhap so bao danh: ");
        sbd = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap diem bai 1: ");
        bai1 = double.Parse(
            Console.ReadLine() ?? "0"
        );

        Console.Write("Nhap diem bai 2: ");
        bai2 = double.Parse(
            Console.ReadLine() ?? "0"
        );

        Console.Write("Nhap diem bai 3: ");
        bai3 = double.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    // Lop con se override
    public virtual double TinhTongDiem()
    {
        return bai1 + bai2 + bai3;
    }

    public virtual void Output()
    {
        Console.WriteLine($"SBD: {sbd}");
        Console.WriteLine($"Ho ten: {hoTen}");

        Console.WriteLine(
            $"Bai 1: {bai1}"
        );

        Console.WriteLine(
            $"Bai 2: {bai2}"
        );

        Console.WriteLine(
            $"Bai 3: {bai3}"
        );

        Console.WriteLine(
            $"Tong diem: {TinhTongDiem()}"
        );
    }
}