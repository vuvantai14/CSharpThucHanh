namespace Bai3_2;

public class SapTangAdapter : ISapXep
{
    public int SoSanh(object a, object b)
    {
        int ia = (int)a;
        int ib = (int)b;

        if (ia < ib)
            return -1;
        else if (ia == ib)
            return 0;

        return 1;
    }
}