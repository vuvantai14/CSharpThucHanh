using System;

class SinhVien
{
    public string MaSinhVien;
    public string HoTen;
    public string DiaChi;
    public int NamThu;

    public void Nhap()
    {
        Console.Write("Nhap ma sinh vien: ");
        MaSinhVien = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine() ?? "";

        Console.Write("Sinh vien nam thu: ");
        NamThu = int.Parse(Console.ReadLine() ?? "0");
    }

    public void Xuat()
    {
        Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
        Console.WriteLine($"Ma sinh vien: {MaSinhVien}");
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"Dia chi: {DiaChi}");
        Console.WriteLine($"Sinh vien nam thu: {NamThu}");
    }
}