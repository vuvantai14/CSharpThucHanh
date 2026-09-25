using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập họ tên của bạn: ");
        string hoTen = Console.ReadLine() ?? "";

        Console.WriteLine("Chào bạn " + hoTen + "!");
    }
}