namespace Bai3_5;

public class NhanVien
{
    protected string maNV;
    protected string hoTen;

    public NhanVien()
    {
        maNV = "";
        hoTen = "";
    }

    public NhanVien(string maNV, string hoTen)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
    }

    public virtual void Input()
    {
        Console.Write("Nhap ma nhan vien: ");
        maNV = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";
    }

    // Phuong thuc ao de lop con override
    public virtual double TinhLuong()
    {
        return 0;
    }

    public virtual void Output()
    {
        Console.WriteLine($"Ma NV: {maNV}");
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine(
            $"Luong: {TinhLuong():N0} VND"
        );
    }
}