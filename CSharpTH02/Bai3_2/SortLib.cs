using System.Collections;

namespace Bai3_2;

public class SortLib
{
    public static void SapXep(
        IList ds,
        ISapXep adapter)
    {
        for (int i = 0; i <= ds.Count - 2; i++)
        {
            for (int j = i + 1;
                 j <= ds.Count - 1;
                 j++)
            {
                if (adapter.SoSanh(
                    ds[i]!,
                    ds[j]!) > 0)
                {
                    object? tmp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = tmp;
                }
            }
        }
    }
}