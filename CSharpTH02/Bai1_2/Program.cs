namespace Bai1_2;

class Program
{
    static void Main(string[] args)
    {
        // Tao hai diem A va B
        Point A = new Point();
        Point B = new Point();

        // Nhap diem A
        Console.WriteLine("=== NHAP DIEM A ===");
        A.Input();

        // Nhap diem B
        Console.WriteLine("\n=== NHAP DIEM B ===");
        B.Input();

        // Xuat hai diem
        Console.WriteLine("\n=== HAI DIEM VUA NHAP ===");
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");

        // =====================================
        // CAC PHEP TOAN
        // =====================================

        Console.WriteLine("\n=== CAC PHEP TOAN ===");

        Point tong = A + B;
        Point hieu = A - B;
        Point amA = -A;

        Console.WriteLine($"A + B = {tong}");
        Console.WriteLine($"A - B = {hieu}");
        Console.WriteLine($"-A = {amA}");

        // =====================================
        // KHOANG CACH
        // =====================================

        Console.WriteLine("\n=== KHOANG CACH A VA B ===");

        // Cach 1: phuong thuc thanh vien
        double kc1 = A.Distance(B);

        // Cach 2: phuong thuc tinh
        double kc2 = Point.Distance(A, B);

        Console.WriteLine($"Phuong thuc thanh vien: {kc1}");
        Console.WriteLine($"Phuong thuc tinh: {kc2}");

        // =====================================
        // TRUNG DIEM
        // =====================================

        Console.WriteLine("\n=== TRUNG DIEM A VA B ===");

        // Cach 1: phuong thuc thanh vien
        Point I1 = A.MidPoint(B);

        // Cach 2: phuong thuc tinh
        Point I2 = Point.MidPoint(A, B);

        Console.WriteLine($"Phuong thuc thanh vien: I = {I1}");
        Console.WriteLine($"Phuong thuc tinh: I = {I2}");
    }
}