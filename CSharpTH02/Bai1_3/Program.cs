namespace Bai1_3;

class Program
{
    static void Main(string[] args)
    {
        // Tao doi tuong Person bang Default Constructor
        Person person1 = new Person();

        Console.WriteLine("=== NHAP THONG TIN PERSON 1 ===");
        person1.Input();

        // Xuat thong tin Person 1
        Console.WriteLine("\n=== THONG TIN PERSON 1 ===");
        person1.Output();

        // Tao Person 2 bang Copy Constructor
        Person person2 = new Person(person1);

        Console.WriteLine("\n=== PERSON 2 (SAO CHEP TU PERSON 1) ===");
        person2.Output();

        // Kiem tra trang thai song
        Console.WriteLine("\n=== KIEM TRA IsLiving() ===");

        if (person1.IsLiving())
        {
            Console.WriteLine("Person 1 con song.");
        }
        else
        {
            Console.WriteLine("Person 1 da mat.");
        }
    }
}