namespace Bai2_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "=== BAI 2.2 - PERSON LIST ==="
        );

        // =====================================
        // NHAP DANH SACH
        // =====================================

        PersonList ds = new PersonList();

        ds.Input();

        // =====================================
        // XUAT DANH SACH
        // =====================================

        Console.WriteLine(
            "\n=== DANH SACH TAT CA MOI NGUOI ==="
        );

        ds.Output();

        // =====================================
        // COPY CONSTRUCTOR
        // =====================================

        PersonList dsCopy =
            new PersonList(ds);

        Console.WriteLine(
            "\n=== DANH SACH SAO CHEP ==="
        );

        dsCopy.Output();

        // =====================================
        // LOC NGUOI CON SONG
        // =====================================

        PersonList dsConSong =
            ds.LivingPeople();

        Console.WriteLine(
            "\n=== DANH SACH NGUOI CON SONG ==="
        );

        dsConSong.Output();
    }
}