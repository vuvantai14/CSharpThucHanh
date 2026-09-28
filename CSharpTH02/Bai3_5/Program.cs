namespace Bai3_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 3.5 - TINH LUONG NHAN VIEN ==="
        );

        Console.Write(
            "Nhap so luong nhan vien: "
        );

        int n = int.Parse(
            Console.ReadLine() ?? "0"
        );

        // Mang lop cha
        NhanVien[] ds = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"\n--- Nhan vien thu {i + 1} ---"
            );

            Console.WriteLine(
                "1. Nhan vien kinh doanh"
            );

            Console.WriteLine(
                "2. Nhan vien san xuat"
            );

            Console.Write("Chon loai: ");

            int loai = int.Parse(
                Console.ReadLine() ?? "1"
            );

            if (loai == 1)
            {
                ds[i] = new NhanVienKinhDoanh();
            }
            else
            {
                ds[i] = new NhanVienSanXuat();
            }

            // Goi Input() da hinh
            ds[i].Input();
        }

        Console.WriteLine(
            "\n=== DANH SACH NHAN VIEN ==="
        );

        double tongLuong = 0;

        foreach (NhanVien nv in ds)
        {
            Console.WriteLine();

            // Goi Output() da hinh
            nv.Output();

            // Goi TinhLuong() da hinh
            tongLuong += nv.TinhLuong();
        }

        Console.WriteLine(
            "\n=== TONG LUONG ==="
        );

        Console.WriteLine(
            $"Tong luong: {tongLuong:N0} VND"
        );
    }
}