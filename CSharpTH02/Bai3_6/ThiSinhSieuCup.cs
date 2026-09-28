namespace Bai3_6;

public class ThiSinhSieuCup : ThiSinh
{
    private double csdl;

    public ThiSinhSieuCup()
        : base()
    {
        csdl = 0;
    }

    public override void Input()
    {
        base.Input();

        Console.Write(
            "Nhap diem CSDL: "
        );

        csdl = double.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public override double TinhTongDiem()
    {
        return bai1
             + bai2
             + bai3
             + csdl;
    }

    public override void Output()
    {
        Console.WriteLine(
            "--- THI SINH SIEU CUP ---"
        );

        base.Output();

        Console.WriteLine(
            $"CSDL: {csdl}"
        );
    }
}