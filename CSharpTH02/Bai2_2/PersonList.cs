namespace Bai2_2;

public class PersonList
{
    // Danh sach cac Person
    private List<Person> people;

    // =====================================
    // DEFAULT CONSTRUCTOR
    // =====================================

    public PersonList()
    {
        people = new List<Person>();
    }

    // =====================================
    // COPY CONSTRUCTOR
    // =====================================

    public PersonList(PersonList other)
    {
        people = new List<Person>();

        foreach (Person p in other.people)
        {
            people.Add(new Person(p));
        }
    }

    // =====================================
    // ADD
    // Them mot Person vao PersonList
    // =====================================

    public void Add(Person x)
    {
        people.Add(x);
    }

    // =====================================
    // INPUT
    // Nhap danh sach Person
    // =====================================

    public void Input()
    {
        Console.Write("Nhap so luong nguoi: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                $"\n--- Nhap nguoi thu {i + 1} ---"
            );

            Person p = new Person();
            p.Input();

            Add(p);
        }
    }

    // =====================================
    // OUTPUT
    // Xuat danh sach Person
    // =====================================

    public void Output()
    {
        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine(
                $"\n--- Nguoi thu {i + 1} ---"
            );

            people[i].Output();
        }
    }

    // =====================================
    // LIVING PEOPLE
    // Tra ve danh sach nhung nguoi con song
    // =====================================

    public PersonList LivingPeople()
    {
        PersonList result = new PersonList();

        foreach (Person p in people)
        {
            if (p.IsLiving())
            {
                result.Add(new Person(p));
            }
        }

        return result;
    }
}