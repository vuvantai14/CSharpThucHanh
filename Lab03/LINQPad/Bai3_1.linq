<Query Kind="Program" />

void Main()
{
    int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

    // ==================================================
    // BÀI 3.1 - THỐNG KÊ MẢNG SỐ
    // ==================================================

    // Câu a:
    // Tổng số phần tử, số phần tử chẵn và số phần tử lẻ
    var tongSoPhanTu = mangSo.Count();
    var soChan = mangSo.Count(x => x % 2 == 0);
    var soLe = mangSo.Count(x => x % 2 != 0);

    tongSoPhanTu.Dump("Câu a - Tổng số phần tử");
    soChan.Dump("Câu a - Số phần tử chẵn");
    soLe.Dump("Câu a - Số phần tử lẻ");


    // Câu b:
    // Tổng các giá trị, giá trị lớn nhất và nhỏ nhất
    var tongGiaTri = mangSo.Sum();
    var giaTriLonNhat = mangSo.Max();
    var giaTriNhoNhat = mangSo.Min();

    tongGiaTri.Dump("Câu b - Tổng các giá trị");
    giaTriLonNhat.Dump("Câu b - Giá trị lớn nhất");
    giaTriNhoNhat.Dump("Câu b - Giá trị nhỏ nhất");


    // Câu c:
    // Số lượng giá trị khác nhau trong mảng
    var soGiaTriKhacNhau = mangSo
        .Distinct()
        .Count();

    soGiaTriKhacNhau.Dump("Câu c - Số giá trị khác nhau");


    // Câu d:
    // Phân nhóm các phần tử theo số dư khi chia cho 5
    var cauD = mangSo
        .GroupBy(x => x % 5)
        .OrderBy(nhom => nhom.Key)
        .Select(nhom => new
        {
            SoDu = nhom.Key,
            CacPhanTu = string.Join(", ", nhom)
        });

    cauD.Dump("Câu d - Phân nhóm theo số dư khi chia cho 5");
}