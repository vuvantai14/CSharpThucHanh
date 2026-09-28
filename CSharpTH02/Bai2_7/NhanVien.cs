namespace Bai2_7;

public class NhanVien
{
    // Du lieu cua nhan vien
    private string hoTen;
    private double mucLuong;
    private int soNgayVang;

    // Default constructor
    public NhanVien()
    {
        hoTen = "";
        mucLuong = 0;
        soNgayVang = 0;
    }

    // Constructor co tham so
    public NhanVien(
        string hoTen,
        double mucLuong,
        int soNgayVang)
    {
        this.hoTen = hoTen;
        this.mucLuong = mucLuong;
        this.soNgayVang = soNgayVang;
    }

    // Copy constructor
    public NhanVien(NhanVien nv)
    {
        hoTen = nv.hoTen;
        mucLuong = nv.mucLuong;
        soNgayVang = nv.soNgayVang;
    }

    // Nhap thong tin nhan vien
    public void Input()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap muc luong: ");
        mucLuong = double.Parse(
            Console.ReadLine() ?? "0"
        );

        Console.Write("Nhap so ngay vang: ");
        soNgayVang = int.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    // Tinh luong thuc nhan
    public double TinhLuong()
    {
        return mucLuong - soNgayVang * 100000;
    }

    // Xuat thong tin
    public void Output()
    {
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Muc luong: {mucLuong:N0} VND");
        Console.WriteLine($"So ngay vang: {soNgayVang}");
        Console.WriteLine(
            $"Luong thuc nhan: {TinhLuong():N0} VND"
        );
    }
}