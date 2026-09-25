using System;

class Program
{
    // Phuong thuc dao chuoi
    static string DaoChuoi(string chuoi)
    {
        string ketQua = "";

        for (int i = chuoi.Length - 1; i >= 0; i--)
        {
            ketQua += chuoi[i];
        }

        return ketQua;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine() ?? "";

        string chuoiDao = DaoChuoi(chuoi);

        Console.WriteLine($"Chuoi ban dau: {chuoi}");
        Console.WriteLine($"Chuoi dao: {chuoiDao}");
    }
}