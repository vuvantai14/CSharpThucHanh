namespace Bai3_1;

public class SinhVien : IComparable<SinhVien>
{
    private string maSV;
    private string hoTen;
    private double diem;

    public SinhVien()
    {
        maSV = "";
        hoTen = "";
        diem = 0;
    }

    public SinhVien(string maSV, string hoTen, double diem)
    {
        this.maSV = maSV;
        this.hoTen = hoTen;
        this.diem = diem;
    }

    public void Input()
    {
        Console.Write("Nhap ma sinh vien: ");
        maSV = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap diem: ");
        diem = double.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public void Output()
    {
        Console.WriteLine(
            $"{maSV,-10} {hoTen,-25} {diem,5}"
        );
    }

    // Quy tac so sanh hai sinh vien
    // Sap xep tang dan theo diem
    public int CompareTo(SinhVien? other)
    {
        if (other == null)
            return 1;

        return diem.CompareTo(other.diem);
    }
}