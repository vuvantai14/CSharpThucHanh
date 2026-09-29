<Query Kind="Program" />

void Main()
{
    List<MonHoc> dsMon = DS_Mon();

    // ==================================================
    // CÂU A
    // Tổng số môn học
    // ==================================================
    int cauA = dsMon.Count();

    cauA.Dump("Câu a - Tổng số môn học");


    // ==================================================
    // CÂU B
    // Số môn có tên bắt đầu bằng "Lập trình"
    // ==================================================
    int cauB = dsMon.Count(
        x => x.TenMon.StartsWith("Lập trình")
    );

    cauB.Dump("Câu b - Số môn bắt đầu bằng Lập trình");


    // ==================================================
    // CÂU C
    // Tổng số tiết của hệ KTV
    // ==================================================
    int cauC = dsMon
        .Where(x => x.He == "KTV")
        .Sum(x => x.SoTiet);

    cauC.Dump("Câu c - Tổng số tiết hệ KTV");


    // ==================================================
    // CÂU D
    // Tổng số môn của từng hệ
    // ==================================================
    var cauD = dsMon
        .GroupBy(x => x.He)
        .Select(nhom => new
        {
            He = string.IsNullOrEmpty(nhom.Key)
                ? "(Chưa khai báo)"
                : nhom.Key,

            TongSoMon = nhom.Count()
        });

    cauD.Dump("Câu d - Tổng số môn của từng hệ");


    // ==================================================
    // CÂU E
    // Nhóm theo số tiết
    // In số tiết và tổng số môn
    // Sắp xếp số tiết giảm dần
    // ==================================================
    var cauE = dsMon
        .GroupBy(x => x.SoTiet)
        .OrderByDescending(nhom => nhom.Key)
        .Select(nhom => new
        {
            SoTiet = nhom.Key,
            TongSoMon = nhom.Count()
        });

    cauE.Dump("Câu e - Thống kê theo số tiết");


    // ==================================================
    // CÂU F
    // Thông tin môn có số tiết cao nhất
    // ==================================================
    int maxSoTiet = dsMon.Max(x => x.SoTiet);

    var cauF = dsMon
        .Where(x => x.SoTiet == maxSoTiet);

    cauF.Dump("Câu f - Môn có số tiết cao nhất");


    // ==================================================
    // CÂU G
    // Thống kê theo hệ:
    // Tổng số môn
    // Tổng số tiết
    // Số tiết lớn nhất
    // Số tiết nhỏ nhất
    // ==================================================
    var cauG = dsMon
        .GroupBy(x => x.He)
        .Select(nhom => new
        {
            He = string.IsNullOrEmpty(nhom.Key)
                ? "(Chưa khai báo)"
                : nhom.Key,

            TongSoMon = nhom.Count(),
            TongSoTiet = nhom.Sum(x => x.SoTiet),
            SoTietLonNhat = nhom.Max(x => x.SoTiet),
            SoTietNhoNhat = nhom.Min(x => x.SoTiet)
        });

    cauG.Dump("Câu g - Thống kê theo hệ");


    // ==================================================
    // CÂU H
    // Liệt kê các môn theo từng hệ
    // ==================================================
    var cauH = dsMon
        .GroupBy(x => x.He);

    foreach (var nhom in cauH)
    {
        string tenHe = string.IsNullOrEmpty(nhom.Key)
            ? "(Chưa khai báo)"
            : nhom.Key;

        $"Hệ: {tenHe}".Dump();

        foreach (var mon in nhom)
        {
            $"{mon.MaMon} - {mon.TenMon} - {mon.SoTiet}".Dump();
        }
    }


    // ==================================================
    // CÂU I
    // Nhóm theo số tiết
    // Sắp xếp số tiết tăng dần
    // ==================================================
    var cauI = dsMon
        .GroupBy(x => x.SoTiet)
        .OrderBy(nhom => nhom.Key);

    foreach (var nhom in cauI)
    {
        $"Số tiết: {nhom.Key}".Dump();

        foreach (var mon in nhom)
        {
            $"{mon.MaMon} - {mon.TenMon}".Dump();
        }
    }


    // ==================================================
    // CÂU J
    // Với hệ KTV:
    // Nhóm theo HP2, HP3, HP4, HP5
    // Trong nhóm sắp xếp theo MaMon
    // ==================================================
    var cauJ = dsMon
        .Where(x => x.He == "KTV")
        .GroupBy(x => x.MaMon.Split('_')[0])
        .OrderBy(nhom => nhom.Key);

    foreach (var nhom in cauJ)
    {
        $"Nhóm: {nhom.Key}".Dump();

        foreach (var mon in nhom.OrderBy(x => x.MaMon))
        {
            $"{mon.MaMon} - {mon.TenMon}".Dump();
        }
    }


    // ==================================================
    // CÂU K
    // Nhóm theo hệ
    // Chỉ lấy môn có số tiết > 40
    // Trong mỗi nhóm sắp xếp MaMon
    // ==================================================
    var cauK = dsMon
        .Where(x => x.SoTiet > 40)
        .GroupBy(x => x.He);

    foreach (var nhom in cauK)
    {
        string tenHe = string.IsNullOrEmpty(nhom.Key)
            ? "(Chưa khai báo)"
            : nhom.Key;

        $"Hệ: {tenHe}".Dump();

        foreach (var mon in nhom.OrderBy(x => x.MaMon))
        {
            $"{mon.MaMon} - {mon.TenMon} - {mon.SoTiet}".Dump();
        }
    }
}


// ==================================================
// CLASS MONHOC
// ==================================================
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}


// ==================================================
// DỮ LIỆU MÔN HỌC
// ==================================================
List<MonHoc> DS_Mon()
{
    return new List<MonHoc>
    {
        new MonHoc
        {
            MaMon = "HP2_1",
            TenMon = "Nền tảng C#",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP2_2",
            TenMon = "Công nghệ ADO.NET",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP3_1",
            TenMon = "Lập trình Windows Forms",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP3_2",
            TenMon = "Xây dựng ứng dụng Windows Forms",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP4_1",
            TenMon = "Lập trình Web với HTML, CSS và JavaScript",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP4_2",
            TenMon = "Xây dựng ứng dụng Web với ASP.NET",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP5_1",
            TenMon = "Lập trình CSDL SQL Server căn bản",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "HP5_2",
            TenMon = "Lập trình CSDL SQL Server nâng cao",
            He = "KTV",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "JLCB",
            TenMon = "Joomla cơ bản",
            He = "CD",
            SoTiet = 72
        },

        new MonHoc
        {
            MaMon = "LINQ",
            TenMon = "Language-Integrated Query",
            He = "CD",
            SoTiet = 64
        },

        new MonHoc
        {
            MaMon = "DAWEB",
            TenMon = "Đồ án thực tế Web với ASP.NET",
            He = "CD",
            SoTiet = 40
        },

        new MonHoc
        {
            MaMon = "DAWIN",
            TenMon = "Đồ án thực tế Windows Forms",
            He = "CD",
            SoTiet = 40
        },

        new MonHoc
        {
            MaMon = "CC++",
            TenMon = "Lập trình hướng đối tượng với C/C++",
            He = "CD",
            SoTiet = 128
        },

        new MonHoc
        {
            MaMon = "JQUE",
            TenMon = "JQuery",
            He = "CD",
            SoTiet = 22
        },

        new MonHoc
        {
            MaMon = "XML",
            TenMon = "Công nghệ XML",
            He = "CD",
            SoTiet = 32
        },

        new MonHoc
        {
            MaMon = "CRYS",
            TenMon = "Crystal Report trong Visual Studio",
            He = "CD",
            SoTiet = 32
        },

        new MonHoc
        {
            MaMon = "BWEB",
            TenMon = "HTML, CSS và JavaScript",
            He = "CD",
            SoTiet = 32
        },

        new MonHoc
        {
            MaMon = "XYZ",
            TenMon = "Chưa đặt tên môn",
            He = "",
            SoTiet = 0
        }
    };
}