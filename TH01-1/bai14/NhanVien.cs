using System;

class NhanVien
{
    public string HoTen;
    public double MucLuong;
    public int SoNgayVang;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap muc luong: ");
        MucLuong = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap so ngay vang: ");
        SoNgayVang = int.Parse(Console.ReadLine() ?? "0");
    }

    public double TinhLuong()
    {
        return MucLuong - SoNgayVang * 100000;
    }

    public void Xuat()
    {
        Console.WriteLine("\n--- THONG TIN NHAN VIEN ---");
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"Muc luong: {MucLuong:N0} VND");
        Console.WriteLine($"So ngay vang: {SoNgayVang}");
        Console.WriteLine($"Luong thuc nhan: {TinhLuong():N0} VND");
    }
}