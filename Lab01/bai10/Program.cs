using System;

class Program
{
    // Phuong thuc kiem tra chuoi doi xung
    static bool KiemTraDoiXung(string chuoi)
    {
        int trai = 0;
        int phai = chuoi.Length - 1;

        while (trai < phai)
        {
            if (chuoi[trai] != chuoi[phai])
            {
                return false;
            }

            trai++;
            phai--;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine() ?? "";

        if (KiemTraDoiXung(chuoi))
        {
            Console.WriteLine("Chuoi doi xung.");
        }
        else
        {
            Console.WriteLine("Chuoi khong doi xung.");
        }
    }
}