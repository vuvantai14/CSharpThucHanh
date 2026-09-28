using System;

class Program
{
    static void Main(string[] args)
    {
        XuLyMang xuLy = new XuLyMang();

        int[] a = xuLy.NhapMang();

        Console.WriteLine("\n--- KET QUA ---");

        xuLy.XuatMang(a);

        Console.WriteLine($"Phan tu lon nhat: {xuLy.TimMax(a)}");
        Console.WriteLine($"Phan tu nho nhat: {xuLy.TimMin(a)}");

        int[] mangNguyenTo = xuLy.LayMangSoNguyenTo(a);

        Console.Write("Cac so nguyen to: ");
        xuLy.XuatMang(mangNguyenTo);
    }
}