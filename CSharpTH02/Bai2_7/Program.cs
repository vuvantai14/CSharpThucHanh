namespace Bai2_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 2.7 - TINH LUONG NHAN VIEN ==="
        );

        // Tao phong ban
        PhongBan phongBan = new PhongBan();

        // Nhap danh sach nhan vien
        phongBan.Input();

        // Xuat danh sach
        Console.WriteLine(
            "\n=== DANH SACH NHAN VIEN ==="
        );

        phongBan.Output();

        // Tinh tong luong phong ban
        double tongLuong =
            phongBan.TinhTongLuong();

        Console.WriteLine(
            "\n=== TONG LUONG PHONG BAN ==="
        );

        Console.WriteLine(
            $"Tong luong: {tongLuong:N0} VND"
        );
    }
}