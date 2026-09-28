namespace Bai3_6;

public class ThiSinhChuyen : ThiSinh
{
    private double tiengAnh;

    public ThiSinhChuyen()
        : base()
    {
        tiengAnh = 0;
    }

    public override void Input()
    {
        base.Input();

        Console.Write(
            "Nhap diem tieng Anh: "
        );

        tiengAnh = double.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public override double TinhTongDiem()
    {
        double tong =
            bai1 + bai2 + bai3;

        if (tiengAnh >= 7 &&
            tiengAnh <= 8)
        {
            tong += 1;
        }
        else if (tiengAnh >= 9 &&
                 tiengAnh <= 10)
        {
            tong += 2;
        }

        return tong;
    }

    public override void Output()
    {
        Console.WriteLine(
            "--- THI SINH CHUYEN ---"
        );

        base.Output();

        Console.WriteLine(
            $"Tieng Anh: {tiengAnh}"
        );
    }
}