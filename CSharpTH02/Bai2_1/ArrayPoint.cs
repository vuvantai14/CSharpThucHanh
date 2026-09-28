namespace Bai2_1;

public class ArrayPoint
{
    // List dung de chua cac doi tuong Point
    private List<Point> points;

    // Constructor
    public ArrayPoint()
    {
        points = new List<Point>();
    }

    // So luong phan tu trong danh sach
    public int Count
    {
        get { return points.Count; }
    }

    // =====================================
    // THEM POINT
    // =====================================

    public void Add(Point p)
    {
        points.Add(p);
    }

    // =====================================
    // XOA POINT THEO VI TRI
    // =====================================

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= points.Count)
        {
            throw new IndexOutOfRangeException(
                "Chi so khong hop le!"
            );
        }

        points.RemoveAt(index);
    }

    // =====================================
    // INDEXER
    // =====================================

    public Point this[int index]
    {
        get
        {
            if (index < 0 || index >= points.Count)
            {
                throw new IndexOutOfRangeException(
                    "Chi so khong hop le!"
                );
            }

            return points[index];
        }

        set
        {
            if (index < 0 || index >= points.Count)
            {
                throw new IndexOutOfRangeException(
                    "Chi so khong hop le!"
                );
            }

            points[index] = value;
        }
    }

    // =====================================
    // XUAT DANH SACH
    // =====================================

    public void Output()
    {
        for (int i = 0; i < points.Count; i++)
        {
            Console.WriteLine(
                $"[{i}] = {points[i]}"
            );
        }
    }
}