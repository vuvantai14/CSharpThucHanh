namespace Bai3_5;

public class NhanVienKinhDoanh : NhanVien
{
    private double luongCoBan;
    private int soHopDong;

    public NhanVienKinhDoanh()
        : base()
    {
        luongCoBan = 0;
        soHopDong = 0;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Nhap luong co ban: ");
        luongCoBan = double.Parse(
            Console.ReadLine() ?? "0"
        );

        Console.Write("Nhap so hop dong: ");
        soHopDong = int.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public override double TinhLuong()
    {
        return luongCoBan
               + soHopDong * 500000;
    }

    public override void Output()
    {
        Console.WriteLine(
            "--- NHAN VIEN KINH DOANH ---"
        );

        base.Output();

        Console.WriteLine(
            $"Luong co ban: {luongCoBan:N0} VND"
        );

        Console.WriteLine(
            $"So hop dong: {soHopDong}"
        );
    }
}