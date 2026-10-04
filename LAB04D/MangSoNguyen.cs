using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB04D
{
    public class MangSoNguyen
    {
        private List<int> mang;

        public MangSoNguyen()
        {
            mang = new List<int>();
        }

        public void NhapMang(string chuoi)
        {
            mang.Clear();

            string[] ds = chuoi.Split(
                new char[] { ' ', ',', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in ds)
            {
                if (!int.TryParse(s, out int n))
                    throw new Exception("Mảng chỉ được chứa số nguyên.");

                mang.Add(n);
            }

            if (mang.Count == 0)
                throw new Exception("Mảng không được để trống.");
        }

        public string XuatMang()
        {
            return string.Join(" ", mang);
        }

        public void SapXepTang()
        {
            mang.Sort();
        }

        public void SapXepGiam()
        {
            mang.Sort();
            mang.Reverse();
        }

        public int TimGiaTri(int giaTri)
        {
            return mang.IndexOf(giaTri);
        }

        public int LayGiaTriTaiViTri(int viTri)
        {
            if (viTri < 0 || viTri >= mang.Count)
                throw new Exception("Vị trí không hợp lệ.");

            return mang[viTri];
        }

        public void Them(int giaTri, int viTri)
        {
            if (viTri < 0 || viTri > mang.Count)
                throw new Exception("Vị trí thêm không hợp lệ.");

            mang.Insert(viTri, giaTri);
        }

        public int TongMang()
        {
            return mang.Sum();
        }

        public int TongChan()
        {
            return mang.Where(x => x % 2 == 0).Sum();
        }

        public int TongLe()
        {
            return mang.Where(x => x % 2 != 0).Sum();
        }

        public int Max()
        {
            if (mang.Count == 0)
                throw new Exception("Mảng rỗng.");

            return mang.Max();
        }

        public int Min()
        {
            if (mang.Count == 0)
                throw new Exception("Mảng rỗng.");

            return mang.Min();
        }

        public bool ThayTheGiaTri(int giaTriCu, int giaTriMoi)
        {
            int viTri = mang.IndexOf(giaTriCu);

            if (viTri == -1)
                return false;

            mang[viTri] = giaTriMoi;
            return true;
        }

        public void ThayTheTaiViTri(int viTri, int giaTriMoi)
        {
            if (viTri < 0 || viTri >= mang.Count)
                throw new Exception("Vị trí không hợp lệ.");

            mang[viTri] = giaTriMoi;
        }
    }
}