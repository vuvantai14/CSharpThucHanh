namespace Bai3_4;

public class PTBac2
{
    private double a;
    private double b;
    private double c;

    public void Input()
    {
        Console.Write("Nhap a: ");
        a = double.Parse(
            Console.ReadLine() ?? "0"
        );

        Console.Write("Nhap b: ");
        b = double.Parse(
            Console.ReadLine() ?? "0"
        );

        Console.Write("Nhap c: ");
        c = double.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public void Giai()
    {
        if (a == 0)
        {
            GiaiBac1();
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine(
                "Phuong trinh vo nghiem."
            );
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine(
                $"Phuong trinh co nghiem kep x = {x}"
            );
        }
        else
        {
            double x1 =
                (-b + Math.Sqrt(delta)) /
                (2 * a);

            double x2 =
                (-b - Math.Sqrt(delta)) /
                (2 * a);

            Console.WriteLine(
                $"x1 = {x1}"
            );

            Console.WriteLine(
                $"x2 = {x2}"
            );
        }
    }

    private void GiaiBac1()
    {
        if (b == 0)
        {
            if (c == 0)
            {
                Console.WriteLine(
                    "Phuong trinh vo so nghiem."
                );
            }
            else
            {
                Console.WriteLine(
                    "Phuong trinh vo nghiem."
                );
            }
        }
        else
        {
            double x = -c / b;

            Console.WriteLine(
                $"Phuong trinh co nghiem x = {x}"
            );
        }
    }
}