<Query Kind="Program" />

void Main()
{
    string[] monAn =
    {
        "Bún bò Huế",
        "Hủ tiếu heo",
        "Bánh canh",
        "Bánh mì",
        "Nước Cà phê",
        "Mì quảng",
        "Cơm tấm",
        "Nước Chanh dây",
        "Mì xào",
        "Bún riêu",
        "Bánh cuốn",
        "Mì gói",
        "Bún chả",
        "Hủ tiếu Nam vang"
    };

    // ==========================================
    // Câu a: Tìm món ngắn nhất và dài nhất
    // ==========================================

    int minLength = monAn.Min(x => x.Length);
    int maxLength = monAn.Max(x => x.Length);

    var nganNhat = monAn.Where(x => x.Length == minLength);
    var daiNhat = monAn.Where(x => x.Length == maxLength);

    nganNhat.Dump("Câu a - Phần tử ngắn nhất");
    daiNhat.Dump("Câu a - Phần tử dài nhất");


    // ==========================================
    // Câu b: Phân nhóm theo từ đầu tiên
    // ==========================================

    var cacNhom = monAn.GroupBy(x => x.Split(' ')[0]);

    foreach (var nhom in cacNhom)
    {
        $"Nhóm: {nhom.Key}".Dump();

        foreach (var mon in nhom)
        {
            mon.Dump();
        }
    }


    // ==========================================
    // Câu c: Đếm món có từ đầu tiên là "Bánh"
    // ==========================================

    int soMonBanh = monAn.Count(
        x => x.Split(' ')[0] == "Bánh"
    );

    soMonBanh.Dump("Câu c - Số món bắt đầu bằng Bánh");
}