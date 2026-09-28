namespace Bai1_3;

public class Person
{
    // Cac field luu thong tin cua mot nguoi
    private string id;
    private string name;
    private int yob; // Year of birth - nam sinh
    private int yod; // Year of death - nam mat

    // Default Constructor
    public Person()
    {
        id = "";
        name = "";
        yob = 0;
        yod = 0;
    }

    // Copy Constructor
    public Person(Person other)
    {
        id = other.id;
        name = other.name;
        yob = other.yob;
        yod = other.yod;
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
        {
            Console.WriteLine("Trang thai: Con song");
        }
        else
        {
            Console.WriteLine("Trang thai: Da mat");
        }
    }

    // Kiem tra nguoi nay con song hay khong
    // yod = 0: con song
    // yod != 0: da mat
    public bool IsLiving()
    {
        return yod == 0;
    }
}