namespace Bai2_2;

public class Person
{
    private string id;
    private string name;
    private int yob; // Nam sinh
    private int yod; // Nam mat

    // Default Constructor
    public Person()
    {
        id = "";
        name = "";
        yob = 0;
        yod = 0;
    }

    // Copy Constructor
    public Person(Person p)
    {
        id = p.id;
        name = p.name;
        yob = p.yob;
        yod = p.yod;
    }

    // Nhap thong tin
    public void Input()
    {
        Console.Write("Nhap ID: ");
        id = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine() ?? "0");
    }

    // Xuat thong tin
    public void Output()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Ho ten: {name}");
        Console.WriteLine($"Nam sinh: {yob}");
        Console.WriteLine($"Nam mat: {yod}");

        if (IsLiving())
            Console.WriteLine("Trang thai: Con song");
        else
            Console.WriteLine("Trang thai: Da mat");
    }

    // Kiem tra con song
    public bool IsLiving()
    {
        return yod == 0;
    }
}