namespace Bai3_6;

public class CuocThi
{
    private List<ThiSinh> dsThiSinh;

    public CuocThi()
    {
        dsThiSinh = new List<ThiSinh>();
    }

    public void Input()
    {
        Console.Write(
            "Nhap so luong thi sinh: "
        );

        int n = int.Parse(
            Console.ReadLine() ?? "0"
        );

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"\n--- Thi sinh thu {i + 1} ---"
            );

            Console.WriteLine(
                "1. Thi sinh Chuyen"
            );

            Console.WriteLine(
                "2. Thi sinh Sieu Cup"
            );

            Console.Write("Chon loai: ");

            int loai = int.Parse(
                Console.ReadLine() ?? "1"
            );

            ThiSinh ts;

            if (loai == 1)
            {
                ts = new ThiSinhChuyen();
            }
            else
            {
                ts = new ThiSinhSieuCup();
            }

            // Goi Input() da hinh
            ts.Input();

            dsThiSinh.Add(ts);
        }
    }

    public void Output()
    {
        foreach (ThiSinh ts in dsThiSinh)
        {
            Console.WriteLine();

            // Goi Output() da hinh
            ts.Output();

            Console.WriteLine(
                "----------------------------"
            );
        }
    }
}