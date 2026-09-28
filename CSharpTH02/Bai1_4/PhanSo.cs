namespace Bai1_4;

public class PhanSo
{
    // Field: tu so va mau so
    private int tuSo;
    private int mauSo;

    // Property TuSo
    public int TuSo
    {
        get { return tuSo; }
        set { tuSo = value; }
    }

    // Property MauSo
    public int MauSo
    {
        get { return mauSo; }
        set
        {
            if (value == 0)
                throw new Exception("Mau so bang 0!");

            mauSo = value;
        }
    }

    // =========================================
    // CONSTRUCTOR
    // =========================================

    // Ham tao mac dinh: 0/1
    public PhanSo()
    {
        this.tuSo = 0;
        this.mauSo = 1;
    }

    // Tao phan so tu mot so nguyen
    public PhanSo(int n)
    {
        this.tuSo = n;
        this.mauSo = 1;
    }

    // Ham tao co tu so va mau so
    public PhanSo(int tu, int mau)
    {
        if (mau == 0)
            throw new Exception("Mau so bang 0!");

        this.tuSo = tu;
        this.mauSo = mau;

        rutGon();
    }

    // Ham tao sao chep
    public PhanSo(PhanSo p)
    {
        this.tuSo = p.tuSo;
        this.mauSo = p.mauSo;
    }

    // =========================================
    // TOSTRING
    // =========================================

    public override string ToString()
    {
        if (this.mauSo == 1)
        {
            return string.Format("[{0}]", this.tuSo);
        }

        return string.Format(
            "[{0}/{1}]",
            this.tuSo,
            this.mauSo
        );
    }

    // =========================================
    // PHEP CONG - PHUONG THUC THANH VIEN
    // =========================================

    public PhanSo tinhCong(PhanSo b)
    {
        int tu_moi =
            this.tuSo * b.mauSo
            + this.mauSo * b.tuSo;

        int mau_moi =
            this.mauSo * b.mauSo;

        PhanSo kq =
            new PhanSo(tu_moi, mau_moi);

        kq.rutGon();

        return kq;
    }

    // =========================================
    // PHEP CONG - PHUONG THUC TINH
    // =========================================

    public static PhanSo tinhCong(
        PhanSo a,
        PhanSo b)
    {
        int tu_moi =
            a.tuSo * b.mauSo
            + a.mauSo * b.tuSo;

        int mau_moi =
            a.mauSo * b.mauSo;

        PhanSo kq =
            new PhanSo(tu_moi, mau_moi);

        kq.rutGon();

        return kq;
    }

    // =========================================
    // TOAN TU MOT NGOI
    // =========================================

    // +a
    public static PhanSo operator +(PhanSo a)
    {
        return new PhanSo(a);
    }

    // -a
    public static PhanSo operator -(PhanSo a)
    {
        return new PhanSo(
            -a.tuSo,
            a.mauSo
        );
    }

    // =========================================
    // TOAN TU HAI NGOI
    // =========================================

    // a + b
    public static PhanSo operator +(
        PhanSo a,
        PhanSo b)
    {
        return PhanSo.tinhCong(a, b);
    }

    // a - b
    public static PhanSo operator -(
        PhanSo a,
        PhanSo b)
    {
        PhanSo kq = new PhanSo(
            a.tuSo * b.mauSo
            - a.mauSo * b.tuSo,

            a.mauSo * b.mauSo
        );

        kq.rutGon();

        return kq;
    }

    // a * b
    public static PhanSo operator *(
        PhanSo a,
        PhanSo b)
    {
        PhanSo kq = new PhanSo(
            a.tuSo * b.tuSo,
            a.mauSo * b.mauSo
        );

        kq.rutGon();

        return kq;
    }

    // a / b
    public static PhanSo operator /(
        PhanSo a,
        PhanSo b)
    {
        if (b.tuSo == 0)
        {
            throw new DivideByZeroException(
                "Khong the chia cho phan so 0!"
            );
        }

        PhanSo kq = new PhanSo(
            a.tuSo * b.mauSo,
            a.mauSo * b.tuSo
        );

        kq.rutGon();

        return kq;
    }

    // =========================================
    // TOAN TU SO SANH
    // =========================================

    // a > b
    public static bool operator >(
        PhanSo a,
        PhanSo b)
    {
        return (long)a.tuSo * b.mauSo
             > (long)b.tuSo * a.mauSo;
    }

    // a < b
    public static bool operator <(
        PhanSo a,
        PhanSo b)
    {
        return (long)a.tuSo * b.mauSo
             < (long)b.tuSo * a.mauSo;
    }

    // a >= b
    public static bool operator >=(
        PhanSo a,
        PhanSo b)
    {
        return (long)a.tuSo * b.mauSo
             >= (long)b.tuSo * a.mauSo;
    }

    // a <= b
    public static bool operator <=(
        PhanSo a,
        PhanSo b)
    {
        return (long)a.tuSo * b.mauSo
             <= (long)b.tuSo * a.mauSo;
    }

    // a == b
    public static bool operator ==(
        PhanSo? a,
        PhanSo? b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return (long)a.tuSo * b.mauSo
             == (long)b.tuSo * a.mauSo;
    }

    // a != b
    public static bool operator !=(
        PhanSo? a,
        PhanSo? b)
    {
        return !(a == b);
    }

    // Override Equals vi da overload == va !=
    public override bool Equals(object? obj)
    {
        if (obj is PhanSo p)
        {
            return this == p;
        }

        return false;
    }

    // Override GetHashCode
    public override int GetHashCode()
    {
        return HashCode.Combine(tuSo, mauSo);
    }

    // =========================================
    // RUT GON PHAN SO
    // =========================================

    public void rutGon()
    {
        int uc =
            PhanSo.uocSoChungLonNhat(
                this.tuSo,
                this.mauSo
            );

        if (uc != 0)
        {
            this.tuSo =
                this.tuSo / uc;

            this.mauSo =
                this.mauSo / uc;
        }

        // Neu mau am thi dua dau am len tu
        if (this.mauSo < 0)
        {
            this.tuSo = -this.tuSo;
            this.mauSo = -this.mauSo;
        }
    }

    // Tim uoc so chung lon nhat
    private static int uocSoChungLonNhat(
        int a,
        int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int tmp = a;
            a = b;
            b = tmp % a;
        }

        return a;
    }
}