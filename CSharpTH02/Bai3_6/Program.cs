namespace Bai3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 3.6 - TINH DIEM THI SINH ==="
        );

        CuocThi cuocThi = new CuocThi();

        cuocThi.Input();

        Console.WriteLine(
            "\n=== KET QUA CUOC THI ==="
        );

        cuocThi.Output();
    }
}