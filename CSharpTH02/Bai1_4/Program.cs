namespace Bai1_4;

class Program
{
    static void Main(string[] args)
    {
        // =====================================
        // KIEM TRA CAC CONSTRUCTOR
        // =====================================

        PhanSo p1 = new PhanSo();
        PhanSo p2 = new PhanSo(5);
        PhanSo p3 = new PhanSo(1, 2);
        PhanSo p4 = new PhanSo(p3);

        Console.WriteLine(
            "=== KIEM TRA CONSTRUCTOR ==="
        );

        Console.WriteLine($"p1 = {p1}");
        Console.WriteLine($"p2 = {p2}");
        Console.WriteLine($"p3 = {p3}");
        Console.WriteLine($"p4 = {p4}");

        // =====================================
        // KIEM TRA 3 CACH CONG
        // =====================================

        PhanSo a = new PhanSo(1, 4);
        PhanSo b = new PhanSo(2, 6);

        Console.WriteLine(
            "\n=== 3 CACH CONG PHAN SO ==="
        );

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");

        // Cach 1: phuong thuc thanh vien
        PhanSo kq1 = a.tinhCong(b);

        // Cach 2: phuong thuc tinh
        PhanSo kq2 =
            PhanSo.tinhCong(a, b);

        // Cach 3: operator +
        PhanSo kq3 = a + b;

        Console.WriteLine(
            $"Thanh vien : {kq1}"
        );

        Console.WriteLine(
            $"Static     : {kq2}"
        );

        Console.WriteLine(
            $"Operator + : {kq3}"
        );

        // =====================================
        // TOAN TU MOT NGOI
        // =====================================

        Console.WriteLine(
            "\n=== TOAN TU MOT NGOI ==="
        );

        Console.WriteLine($"+a = {+a}");
        Console.WriteLine($"-a = {-a}");

        // =====================================
        // TOAN TU HAI NGOI
        // =====================================

        Console.WriteLine(
            "\n=== CAC PHEP TOAN ==="
        );

        Console.WriteLine(
            $"a + b = {a + b}"
        );

        Console.WriteLine(
            $"a - b = {a - b}"
        );

        Console.WriteLine(
            $"a * b = {a * b}"
        );

        Console.WriteLine(
            $"a / b = {a / b}"
        );

        // =====================================
        // TOAN TU SO SANH
        // =====================================

        Console.WriteLine(
            "\n=== SO SANH ==="
        );

        Console.WriteLine(
            $"a > b  : {a > b}"
        );

        Console.WriteLine(
            $"a < b  : {a < b}"
        );

        Console.WriteLine(
            $"a >= b : {a >= b}"
        );

        Console.WriteLine(
            $"a <= b : {a <= b}"
        );

        Console.WriteLine(
            $"a == b : {a == b}"
        );

        Console.WriteLine(
            $"a != b : {a != b}"
        );

        // =====================================
        // KIEM TRA RUT GON
        // =====================================

        Console.WriteLine(
            "\n=== RUT GON ==="
        );

        PhanSo p5 =
            new PhanSo(6, 8);

        Console.WriteLine(
            $"6/8 = {p5}"
        );
    }
}