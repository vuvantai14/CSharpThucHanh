namespace Bai2_1;

class Program
{
    static void Main(string[] args)
    {
        // Tao danh sach Point
        ArrayPoint ds = new ArrayPoint();

        Console.WriteLine(
            "=== BAI 2.1 - ARRAY POINT ==="
        );

        // =====================================
        // THEM CAC POINT
        // =====================================

        ds.Add(new Point(1, 2));
        ds.Add(new Point(3, 4));
        ds.Add(new Point(5, 6));
        ds.Add(new Point(7, 8));

        Console.WriteLine(
            "\n=== DANH SACH BAN DAU ==="
        );

        ds.Output();

        Console.WriteLine(
            $"\nSo luong Point: {ds.Count}"
        );

        // =====================================
        // SU DUNG INDEXER
        // =====================================

        Console.WriteLine(
            "\n=== TRUY CAP BANG INDEXER ==="
        );

        Console.WriteLine(
            $"ds[0] = {ds[0]}"
        );

        Console.WriteLine(
            $"ds[2] = {ds[2]}"
        );

        // =====================================
        // THAY DOI PHAN TU BANG INDEXER
        // =====================================

        Console.WriteLine(
            "\n=== THAY DOI ds[1] ==="
        );

        ds[1] = new Point(10, 20);

        Console.WriteLine(
            $"ds[1] moi = {ds[1]}"
        );

        // =====================================
        // XOA PHAN TU
        // =====================================

        Console.WriteLine(
            "\n=== XOA PHAN TU VI TRI 2 ==="
        );

        ds.RemoveAt(2);

        // =====================================
        // DANH SACH SAU KHI THAY DOI
        // =====================================

        Console.WriteLine(
            "\n=== DANH SACH CUOI ==="
        );

        ds.Output();

        Console.WriteLine(
            $"\nSo luong Point: {ds.Count}"
        );
    }
}