using System.Collections;

namespace Bai3_3;

// Delegate dung de so sanh 2 doi tuong
public delegate int SoSanhDelegate(object a, object b);

public class SortLib
{
    public static void SapXep(
        IList ds,
        SoSanhDelegate soSanh)
    {
        for (int i = 0; i <= ds.Count - 2; i++)
        {
            for (int j = i + 1;
                 j <= ds.Count - 1;
                 j++)
            {
                if (soSanh(ds[i]!, ds[j]!) > 0)
                {
                    object? tmp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = tmp;
                }
            }
        }
    }
}