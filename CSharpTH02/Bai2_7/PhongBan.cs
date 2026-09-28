namespace Bai2_7;

public class PhongBan
{
    // Danh sach nhan vien
    private List<NhanVien> dsNhanVien;

    // Default constructor
    public PhongBan()
    {
        dsNhanVien = new List<NhanVien>();
    }

    // Them nhan vien
    public void Add(NhanVien nv)
    {
        dsNhanVien.Add(nv);
    }

    // Nhap danh sach nhan vien
    public void Input()
    {
        Console.Write("Nhap so luong nhan vien n: ");
        int n = int.Parse(
            Console.ReadLine() ?? "0"
        );

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"\n--- Nhan vien thu {i + 1} ---"
            );

            NhanVien nv = new NhanVien();

            nv.Input();

            Add(nv);
        }
    }

    // Xuat danh sach nhan vien
    public void Output()
    {
        for (int i = 0; i < dsNhanVien.Count; i++)
        {
            Console.WriteLine(
                $"\n--- Nhan vien thu {i + 1} ---"
            );

            dsNhanVien[i].Output();
        }
    }

    // Tinh tong luong cua phong ban
    public double TinhTongLuong()
    {
        double tong = 0;

        foreach (NhanVien nv in dsNhanVien)
        {
            tong += nv.TinhLuong();
        }

        return tong;
    }
}