namespace Bai1_1;

class Program
{
    static void Main(string[] args)
    {
        // Nhap ho ten sinh vien
        Console.Write("Nhap ho ten sinh vien: ");
        string hoTen = Console.ReadLine() ?? "";

        // Nhap nam sinh
        Console.Write("Nhap nam sinh: ");
        int namSinh = int.Parse(Console.ReadLine() ?? "0");

        // Lay nam hien tai cua he thong
        int namHienTai = DateTime.Now.Year;

        // Tinh tuoi sinh vien
        int tuoi = namHienTai - namSinh;

        // Xuat thong tin sinh vien
        Console.WriteLine("\n--- THONG TIN SINH VIEN ---");
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Nam sinh: {namSinh}");
        Console.WriteLine($"Tuoi: {tuoi}");
    }
}