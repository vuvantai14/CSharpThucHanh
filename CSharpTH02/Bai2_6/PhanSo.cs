namespace Bai2_6;

public class PhanSo
{
    private int tuSo;
    private int mauSo;

    public int TuSo
    {
        get { return tuSo; }
        set { tuSo = value; }
    }

    public int MauSo
    {
        get { return mauSo; }

        set
        {
            if (value == 0)
                throw new Exception("Mau so phai khac 0!");

            mauSo = value;
        }
    }

    // Default constructor
    public PhanSo()
    {
        tuSo = 0;
        mauSo = 1;
    }

    // Constructor so nguyen
    public PhanSo(int n)
    {
        tuSo = n;
        mauSo = 1;
    }

    // Constructor tu so, mau so
    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
            throw new Exception("Mau so phai khac 0!");

        this.tuSo = tuSo;
        this.mauSo = mauSo;

        rutGon();
    }

    // Copy constructor
    public PhanSo(PhanSo p)
    {
        tuSo = p.tuSo;
        mauSo = p.mauSo;
    }

    // Xuat phan so
    public override string ToString()
    {
        if (mauSo == 1)
            return $"[{tuSo}]";

        return $"[{tuSo}/{mauSo}]";
    }

    // Cong phan so - phuong thuc thanh vien
    public PhanSo tinhCong(PhanSo b)
    {
        return new PhanSo(
            tuSo * b.mauSo + b.tuSo * mauSo,
            mauSo * b.mauSo
        );
    }

    // Cong phan so - phuong thuc static
    public static PhanSo tinhCong(PhanSo a, PhanSo b)
    {
        return a.tinhCong(b);
    }

    // Operator +
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        return a.tinhCong(b);
    }

    // Rut gon phan so
    public void rutGon()
    {
        int ucln = uocSoChungLonNhat(tuSo, mauSo);

        tuSo /= ucln;
        mauSo /= ucln;

        if (mauSo < 0)
        {
            tuSo = -tuSo;
            mauSo = -mauSo;
        }
    }

    private static int uocSoChungLonNhat(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        return a == 0 ? 1 : a;
    }
}