using System;

class Program
{
    static int DemSoTu(string chuoi)
    {
        string[] cacTu = chuoi.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        return cacTu.Length;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một chuỗi: ");
        string chuoi = Console.ReadLine() ?? "";

        Console.WriteLine("Chuỗi chữ thường: " + chuoi.ToLower());
        Console.WriteLine("Chuỗi chữ hoa: " + chuoi.ToUpper());
        Console.WriteLine("Số từ trong chuỗi: " + DemSoTu(chuoi));
    }
}