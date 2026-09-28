namespace Bai3_5;

public class NhanVienSanXuat : NhanVien
{
    private int soSanPham;

    public NhanVienSanXuat()
        : base()
    {
        soSanPham = 0;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Nhap so san pham: ");
        soSanPham = int.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;

        if (soSanPham > 3000)
        {
            luong += luong * 0.05;
        }

        return luong;
    }

    public override void Output()
    {
        Console.WriteLine(
            "--- NHAN VIEN SAN XUAT ---"
        );

        base.Output();

        Console.WriteLine(
            $"So san pham: {soSanPham}"
        );
    }
}