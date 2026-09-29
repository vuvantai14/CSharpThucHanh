<Query Kind="Program" />

void Main()
{
    List<MonHoc> dsMon = DS_Mon();
    List<He> dsHe = DS_He();

    // ==================================================
    // CÂU A
    // Join hệ và môn học
    // Hiển thị: TenHe, MaMon, TenMon
    // ==================================================
    var cauA =
        from he in dsHe
        join mon in dsMon
            on he.MaHe equals mon.He
        select new
        {
            he.TenHe,
            mon.MaMon,
            mon.TenMon
        };

    cauA.Dump("Câu a - Join hệ và môn học");


    // ==================================================
    // CÂU B
    // Hiển thị cả hệ không có môn học
    // GroupJoin + DefaultIfEmpty
    // ==================================================
    var cauB =
        from he in dsHe
        join mon in dsMon
            on he.MaHe equals mon.He
            into dsMonTheoHe
        from mon in dsMonTheoHe.DefaultIfEmpty()
        select new
        {
            he.MaHe,
            he.TenHe,

            MaMon = mon == null
                ? "(Không có môn)"
                : mon.MaMon,

            TenMon = mon == null
                ? "(Không có môn)"
                : mon.TenMon
        };

    cauB.Dump("Câu b - Hệ kể cả hệ không có môn");


    // ==================================================
    // CÂU C
    // Hiển thị:
    // - hệ không có môn
    // - môn chưa khai báo hệ
    //
    // Thực hiện full outer join bằng cách:
    // Left Join + các môn không tìm thấy hệ
    // ==================================================

    var leftJoin =
        from he in dsHe
        join mon in dsMon
            on he.MaHe equals mon.He
            into dsMonTheoHe
        from mon in dsMonTheoHe.DefaultIfEmpty()
        select new
        {
            MaHe = he.MaHe,
            TenHe = he.TenHe,

            MaMon = mon == null
                ? "(Không có môn)"
                : mon.MaMon,

            TenMon = mon == null
                ? "(Không có môn)"
                : mon.TenMon
        };

    var monChuaCoHe =
        from mon in dsMon
        join he in dsHe
            on mon.He equals he.MaHe
            into dsHeTheoMon
        from he in dsHeTheoMon.DefaultIfEmpty()
        where he == null
        select new
        {
            MaHe = string.IsNullOrEmpty(mon.He)
                ? "(Chưa khai báo)"
                : mon.He,

            TenHe = "(Chưa khai báo)",

            MaMon = mon.MaMon,
            TenMon = mon.TenMon
        };

    var cauC = leftJoin.Concat(monChuaCoHe);

    cauC.Dump(
        "Câu c - Hệ không có môn và môn chưa khai báo hệ"
    );


    // ==================================================
    // CÂU D
    // Chỉ lấy:
    // - hệ không có môn
    // - môn chưa khai báo hệ
    // ==================================================

    var heKhongCoMon =
        from he in dsHe
        join mon in dsMon
            on he.MaHe equals mon.He
            into dsMonTheoHe
        from mon in dsMonTheoHe.DefaultIfEmpty()
        where mon == null
        select new
        {
            MaHe = he.MaHe,
            TenHe = he.TenHe,
            MaMon = "(Không có môn)",
            TenMon = "(Không có môn)"
        };

    var monKhongCoHe =
        from mon in dsMon
        join he in dsHe
            on mon.He equals he.MaHe
            into dsHeTheoMon
        from he in dsHeTheoMon.DefaultIfEmpty()
        where he == null
        select new
        {
            MaHe = string.IsNullOrEmpty(mon.He)
                ? "(Chưa khai báo)"
                : mon.He,

            TenHe = "(Chưa khai báo)",
            MaMon = mon.MaMon,
            TenMon = mon.TenMon
        };

    var cauD = heKhongCoMon.Concat(monKhongCoHe);

    cauD.Dump(
        "Câu d - Chỉ hệ không có môn và môn không có hệ"
    );


    // ==================================================
    // CÂU E
    // Top 5 môn có số tiết cao nhất
    // Hiển thị:
    // TenHe, MaMon, TenMon, SoTiet
    // ==================================================

    var cauE =
        (
            from mon in dsMon
            join he in dsHe
                on mon.He equals he.MaHe
                into dsHeTheoMon
            from he in dsHeTheoMon.DefaultIfEmpty()

            orderby mon.SoTiet descending

            select new
            {
                TenHe = he == null
                    ? "(Chưa khai báo)"
                    : he.TenHe,

                mon.MaMon,
                mon.TenMon,
                mon.SoTiet
            }
        )
        .Take(5);

    cauE.Dump("Câu e - Top 5 môn có số tiết cao nhất");


    // ==================================================
    // CÂU F
    // Tổng số môn của từng hệ
    // MaHe, TenHe, tổng số môn
    // ==================================================

    var cauF =
        from he in dsHe
        join mon in dsMon
            on he.MaHe equals mon.He
            into dsMonTheoHe
        select new
        {
            he.MaHe,
            he.TenHe,
            TongSoMon = dsMonTheoHe.Count()
        };

    cauF.Dump("Câu f - Tổng số môn của từng hệ");


    // ==================================================
    // CÂU G
    // Số lượng giá trị SoTiet khác nhau
    // ==================================================

    int cauG = dsMon
        .Select(mon => mon.SoTiet)
        .Distinct()
        .Count();

    cauG.Dump(
        "Câu g - Số lượng giá trị SoTiet khác nhau"
    );


    // ==================================================
    // CÂU H
    // Môn đầu tiên có tên bắt đầu bằng "Lập trình"
    // ==================================================

    var cauH = dsMon
        .FirstOrDefault(
            mon => mon.TenMon.StartsWith("Lập trình")
        );

    cauH.Dump(
        "Câu h - Môn đầu tiên bắt đầu bằng Lập trình"
    );


    // ==================================================
    // CÂU I
    // Liệt kê môn học theo từng hệ
    // Đánh số thứ tự trong mỗi nhóm
    // ==================================================

    var cauI =
        from he in dsHe
        join mon in dsMon
            on he.MaHe equals mon.He
            into dsMonTheoHe
        select new
        {
            he.MaHe,
            he.TenHe,
            DanhSachMon = dsMonTheoHe
                .Select((mon, index) => new
                {
                    STT = index + 1,
                    mon.MaMon,
                    mon.TenMon,
                    mon.SoTiet
                })
        };

    foreach (var he in cauI)
    {
        $"Hệ: {he.MaHe} - {he.TenHe}".Dump();

        if (!he.DanhSachMon.Any())
        {
            "(Không có môn học)".Dump();
        }
        else
        {
            he.DanhSachMon.Dump();
        }
    }
}


// ======================================================
// CLASS MON HOC
// ======================================================
public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}


// ======================================================
// CLASS HE
// ======================================================
public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}


// ======================================================
// DỮ LIỆU MÔN HỌC
// ======================================================
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


// ======================================================
// DỮ LIỆU HỆ
// ======================================================
List<He> DS_He()
{
    return new List<He>
    {
        new He
        {
            MaHe = "KTV",
            TenHe = "Kỹ thuật viên"
        },

        new He
        {
            MaHe = "CD",
            TenHe = "Chuyên đề"
        },

        new He
        {
            MaHe = "QT",
            TenHe = "Chứng chỉ quốc tế"
        }
    };
}