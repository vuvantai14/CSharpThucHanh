<Query Kind="Program" />

void Main()
{
    List<MonHoc> dsMon = DS_Mon();

    // ==========================================
    // CÂU A
    // Các môn có tên bắt đầu bằng "Lập trình"
    // ==========================================
    var cauA = dsMon
        .Where(x => x.TenMon.StartsWith("Lập trình"));

    cauA.Dump("Câu a - Các môn bắt đầu bằng Lập trình");


    // ==========================================
    // CÂU B
    // Các môn thuộc hệ CD
    // Số tiết giảm dần, Mã môn tăng dần
    // ==========================================
    var cauB = dsMon
        .Where(x => x.He == "CD")
        .OrderByDescending(x => x.SoTiet)
        .ThenBy(x => x.MaMon);

    cauB.Dump("Câu b - Các môn hệ CD");


    // ==========================================
    // CÂU C
    // Tên môn chứa "web"
    // Chỉ lấy Tên môn và Hệ
    // ==========================================
    var cauC = dsMon
        .Where(x => x.TenMon.Contains(
            "web",
            StringComparison.OrdinalIgnoreCase))
        .Select(x => new
        {
            x.TenMon,
            x.He
        });

    cauC.Dump("Câu c - Các môn có tên chứa web");


    // ==========================================
    // CÂU D
    // Các môn thuộc hệ KTV
    // Sắp xếp Mã môn tăng dần
    // ==========================================
    var cauD = dsMon
        .Where(x => x.He == "KTV")
        .OrderBy(x => x.MaMon);

    cauD.Dump("Câu d - Các môn hệ KTV");


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