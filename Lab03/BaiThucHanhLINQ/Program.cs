using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main()
    {
        // Chọn bài muốn chạy
        // Bai21();
        // Bai22();
        // Bai31();
        // Bai32();
        // Bai41();
        // Bai51();
        // Bai52();
        // Bai61();
        Bai62();
    }

    // ==================================================
    // BÀI 2.1
    // ==================================================
    static void Bai21()
    {
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

        Console.WriteLine("=== BAI 2.1: TRUY VAN MANG SO NGUYEN ===");

        var cauA = mangSo
            .Where(x => x % 4 == 0 && x % 3 == 0);

        Console.WriteLine("\na. Cac phan tu chia het cho 4 va 3:");
        foreach (var x in cauA)
            Console.Write(x + " ");

        var cauB = mangSo
            .Where(x => x <= 3);

        Console.WriteLine("\n\nb. Cac phan tu <= 3:");
        foreach (var x in cauB)
            Console.Write(x + " ");

        var cauC = mangSo
            .Select(x => x % 2 == 0 ? x / 2 : x);

        Console.WriteLine("\n\nc. Day moi:");
        foreach (var x in cauC)
            Console.Write(x + " ");

        Console.WriteLine();
    }

    // ==================================================
    // BÀI 2.2
    // ==================================================
    static void Bai22()
    {
        string[] mangChuoi =
        {
            "đầu", "lòng", "hai", "ả", "tố", "nga",
            "Thúy", "Kiều", "là", "chị", "em", "là",
            "Thúy", "Vân"
        };

        Console.WriteLine("=== BAI 2.2: TRUY VAN MANG CHUOI ===");

        var cauA = mangChuoi
            .Where(x => x.Length == 4)
            .OrderBy(x => x[0]);

        Console.WriteLine("\na. Chuoi co 4 ky tu:");
        foreach (var x in cauA)
            Console.WriteLine(x);

        var cauB = mangChuoi
            .Select(x => $"{x.ToLower()} - {x.ToUpper()}");

        Console.WriteLine("\nb. Chu thuong - CHU HOA:");
        foreach (var x in cauB)
            Console.WriteLine(x);

        var cauC = mangChuoi
            .Where(x => x.Contains("u"));

        Console.WriteLine("\nc. Cac phan tu chua ky tu u:");
        foreach (var x in cauC)
            Console.WriteLine(x);

        var cauD = mangChuoi
            .Where(x => char.IsUpper(x[0]));

        Console.WriteLine("\nd. Cac tu bat dau bang chu in hoa:");
        Console.WriteLine(string.Join(" ", cauD));
    }

    // ==================================================
    // BÀI 3.1
    // ==================================================
    static void Bai31()
    {
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };

        Console.WriteLine("=== BAI 3.1: THONG KE MANG SO ===");

        int tongSoPhanTu = mangSo.Count();
        int soChan = mangSo.Count(x => x % 2 == 0);
        int soLe = mangSo.Count(x => x % 2 != 0);

        Console.WriteLine("\na. Thong ke:");
        Console.WriteLine($"Tong so phan tu: {tongSoPhanTu}");
        Console.WriteLine($"So chan: {soChan}");
        Console.WriteLine($"So le: {soLe}");

        int tong = mangSo.Sum();
        int max = mangSo.Max();
        int min = mangSo.Min();

        Console.WriteLine("\nb. Tong - Max - Min:");
        Console.WriteLine($"Tong: {tong}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");

        int soGiaTriKhacNhau = mangSo
            .Distinct()
            .Count();

        Console.WriteLine("\nc. So gia tri khac nhau:");
        Console.WriteLine(soGiaTriKhacNhau);

        var cauD = mangSo
            .GroupBy(x => x % 5)
            .OrderBy(nhom => nhom.Key);

        Console.WriteLine("\nd. Nhom theo so du khi chia 5:");

        foreach (var nhom in cauD)
        {
            Console.WriteLine(
                $"So du {nhom.Key}: {string.Join(", ", nhom)}"
            );
        }
    }

    // ==================================================
    // BÀI 3.2
    // ==================================================
    static void Bai32()
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

        Console.WriteLine("=== BAI 3.2: THONG KE MANG CHUOI ===");

        int minLength = monAn.Min(x => x.Length);
        int maxLength = monAn.Max(x => x.Length);

        var nganNhat = monAn
            .Where(x => x.Length == minLength);

        var daiNhat = monAn
            .Where(x => x.Length == maxLength);

        Console.WriteLine("\na. Phan tu ngan nhat:");
        foreach (var mon in nganNhat)
            Console.WriteLine(mon);

        Console.WriteLine("\nPhan tu dai nhat:");
        foreach (var mon in daiNhat)
            Console.WriteLine(mon);

        var cauB = monAn
            .GroupBy(x => x.Split(' ')[0]);

        Console.WriteLine("\nb. Nhom theo tu dau tien:");

        foreach (var nhom in cauB)
        {
            Console.WriteLine($"Nhom {nhom.Key}:");

            foreach (var mon in nhom)
                Console.WriteLine($"  {mon}");
        }

        int cauC = monAn
            .Count(x => x.Split(' ')[0] == "Bánh");

        Console.WriteLine("\nc. So mon bat dau bang Banh:");
        Console.WriteLine(cauC);
    }

    // ==================================================
    // BÀI 4.1
    // ==================================================
    static void Bai41()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();

        Console.WriteLine("=== BAI 4.1: DANH SACH MON HOC ===");
        Console.WriteLine();

        Console.WriteLine(
            "{0,-8} {1,-45} {2,-5} {3,7}",
            "Ma mon",
            "Ten mon",
            "He",
            "So tiet"
        );

        Console.WriteLine(new string('-', 70));

        foreach (var mon in dsMon)
        {
            Console.WriteLine(
                "{0,-8} {1,-45} {2,-5} {3,7}",
                mon.MaMon,
                mon.TenMon,
                mon.He,
                mon.SoTiet
            );
        }

        Console.WriteLine();
        Console.WriteLine($"Tong so mon: {dsMon.Count}");
    }

    // ==================================================
    // BÀI 5.1
    // ==================================================
    static void Bai51()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();

        Console.WriteLine("=== BAI 5.1: TRUY VAN DANH SACH MON HOC ===");

        var cauA = dsMon
            .Where(x => x.TenMon.StartsWith("Lập trình"));

        Console.WriteLine(
            "\na. Mon bat dau bang \"Lap trinh\":"
        );

        foreach (var mon in cauA)
        {
            Console.WriteLine(
                $"{mon.MaMon} - {mon.TenMon} - {mon.He} - {mon.SoTiet}"
            );
        }

        var cauB = dsMon
            .Where(x => x.He == "CD")
            .OrderByDescending(x => x.SoTiet)
            .ThenBy(x => x.MaMon);

        Console.WriteLine(
            "\nb. He CD, SoTiet giam dan, MaMon tang dan:"
        );

        foreach (var mon in cauB)
        {
            Console.WriteLine(
                $"{mon.MaMon} - {mon.TenMon} - {mon.He} - {mon.SoTiet}"
            );
        }

        var cauC = dsMon
            .Where(x => x.TenMon.Contains(
                "web",
                StringComparison.OrdinalIgnoreCase))
            .Select(x => new
            {
                x.TenMon,
                x.He
            });

        Console.WriteLine(
            "\nc. Mon co ten chua \"web\":"
        );

        foreach (var mon in cauC)
        {
            Console.WriteLine(
                $"{mon.TenMon} - {mon.He}"
            );
        }

        var cauD = dsMon
            .Where(x => x.He == "KTV")
            .OrderBy(x => x.MaMon);

        Console.WriteLine(
            "\nd. He KTV, MaMon tang dan:"
        );

        foreach (var mon in cauD)
        {
            Console.WriteLine(
                $"{mon.MaMon} - {mon.TenMon} - {mon.He} - {mon.SoTiet}"
            );
        }
    }

    // ==================================================
    // BÀI 5.2
    // ==================================================
    static void Bai52()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();

        Console.WriteLine(
            "=== BAI 5.2: THONG KE VA PHAN NHOM MON HOC ==="
        );

        // Câu a
        int cauA = dsMon.Count();

        Console.WriteLine("\na. Tong so mon hoc:");
        Console.WriteLine(cauA);

        // Câu b
        int cauB = dsMon
            .Count(x => x.TenMon.StartsWith("Lập trình"));

        Console.WriteLine(
            "\nb. So mon bat dau bang \"Lap trinh\":"
        );
        Console.WriteLine(cauB);

        // Câu c
        int cauC = dsMon
            .Where(x => x.He == "KTV")
            .Sum(x => x.SoTiet);

        Console.WriteLine("\nc. Tong so tiet he KTV:");
        Console.WriteLine(cauC);

        // Câu d
        var cauD = dsMon
            .GroupBy(x => x.He)
            .Select(nhom => new
            {
                He = string.IsNullOrEmpty(nhom.Key)
                    ? "(Chua khai bao)"
                    : nhom.Key,

                TongSoMon = nhom.Count()
            });

        Console.WriteLine("\nd. Tong so mon cua tung he:");

        foreach (var item in cauD)
        {
            Console.WriteLine(
                $"{item.He}: {item.TongSoMon} mon"
            );
        }

        // Câu e
        var cauE = dsMon
            .GroupBy(x => x.SoTiet)
            .OrderByDescending(nhom => nhom.Key)
            .Select(nhom => new
            {
                SoTiet = nhom.Key,
                TongSoMon = nhom.Count()
            });

        Console.WriteLine(
            "\ne. Nhom theo SoTiet giam dan:"
        );

        foreach (var item in cauE)
        {
            Console.WriteLine(
                $"{item.SoTiet} tiet: {item.TongSoMon} mon"
            );
        }

        // Câu f
        int maxSoTiet = dsMon.Max(x => x.SoTiet);

        var cauF = dsMon
            .Where(x => x.SoTiet == maxSoTiet);

        Console.WriteLine("\nf. Mon co so tiet cao nhat:");

        foreach (var mon in cauF)
        {
            Console.WriteLine(
                $"{mon.MaMon} - {mon.TenMon} - {mon.He} - {mon.SoTiet}"
            );
        }

        // Câu g
        var cauG = dsMon
            .GroupBy(x => x.He)
            .Select(nhom => new
            {
                He = string.IsNullOrEmpty(nhom.Key)
                    ? "(Chua khai bao)"
                    : nhom.Key,

                TongSoMon = nhom.Count(),
                TongSoTiet = nhom.Sum(x => x.SoTiet),
                SoTietLonNhat = nhom.Max(x => x.SoTiet),
                SoTietNhoNhat = nhom.Min(x => x.SoTiet)
            });

        Console.WriteLine("\ng. Thong ke theo he:");

        foreach (var item in cauG)
        {
            Console.WriteLine(
                $"He {item.He}: " +
                $"Tong mon = {item.TongSoMon}, " +
                $"Tong tiet = {item.TongSoTiet}, " +
                $"Max = {item.SoTietLonNhat}, " +
                $"Min = {item.SoTietNhoNhat}"
            );
        }

        // Câu h
        var cauH = dsMon
            .GroupBy(x => x.He);

        Console.WriteLine(
            "\nh. Danh sach mon hoc theo tung he:"
        );

        foreach (var nhom in cauH)
        {
            string tenHe = string.IsNullOrEmpty(nhom.Key)
                ? "(Chua khai bao)"
                : nhom.Key;

            Console.WriteLine($"\nHe: {tenHe}");

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    $"  {mon.MaMon} - {mon.TenMon} - {mon.SoTiet}"
                );
            }
        }

        // Câu i
        var cauI = dsMon
            .GroupBy(x => x.SoTiet)
            .OrderBy(nhom => nhom.Key);

        Console.WriteLine(
            "\ni. Nhom theo SoTiet tang dan:"
        );

        foreach (var nhom in cauI)
        {
            Console.WriteLine($"\nSo tiet: {nhom.Key}");

            foreach (var mon in nhom)
            {
                Console.WriteLine(
                    $"  {mon.MaMon} - {mon.TenMon}"
                );
            }
        }

        // Câu j
        var cauJ = dsMon
            .Where(x => x.He == "KTV")
            .GroupBy(x => x.MaMon.Split('_')[0])
            .OrderBy(nhom => nhom.Key);

        Console.WriteLine(
            "\nj. He KTV nhom theo HP2, HP3, HP4, HP5:"
        );

        foreach (var nhom in cauJ)
        {
            Console.WriteLine($"\nNhom: {nhom.Key}");

            foreach (var mon in nhom.OrderBy(x => x.MaMon))
            {
                Console.WriteLine(
                    $"  {mon.MaMon} - {mon.TenMon}"
                );
            }
        }

        // Câu k
        var cauK = dsMon
            .Where(x => x.SoTiet > 40)
            .GroupBy(x => x.He);

        Console.WriteLine(
            "\nk. Nhom theo he, SoTiet > 40:"
        );

        foreach (var nhom in cauK)
        {
            string tenHe = string.IsNullOrEmpty(nhom.Key)
                ? "(Chua khai bao)"
                : nhom.Key;

            Console.WriteLine($"\nHe: {tenHe}");

            foreach (var mon in nhom.OrderBy(x => x.MaMon))
            {
                Console.WriteLine(
                    $"  {mon.MaMon} - {mon.TenMon} - {mon.SoTiet}"
                );
            }
        }
    }

    // ==================================================
    // BÀI 6.1
    // ==================================================
    static void Bai61()
    {
        List<He> dsHe = DuLieu.DS_He();

        Console.WriteLine("=== BAI 6.1: DANH SACH HE ===");
        Console.WriteLine();

        Console.WriteLine(
            "{0,-10} {1,-30}",
            "Ma he",
            "Ten he"
        );

        Console.WriteLine(new string('-', 40));

        foreach (var he in dsHe)
        {
            Console.WriteLine(
                "{0,-10} {1,-30}",
                he.MaHe,
                he.TenHe
            );
        }

        Console.WriteLine();
        Console.WriteLine($"Tong so he: {dsHe.Count}");
    }

    // ==================================================
    // BÀI 6.2
    // ==================================================
    static void Bai62()
    {
        List<MonHoc> dsMon = DuLieu.DS_Mon();
        List<He> dsHe = DuLieu.DS_He();

        Console.WriteLine(
            "=== BAI 6.2: JOIN - GROUPJOIN - DEFAULTIFEMPTY ==="
        );

        // ==================================================
        // CÂU A
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

        Console.WriteLine("\na. Join he va mon hoc:");

        foreach (var item in cauA)
        {
            Console.WriteLine(
                $"{item.TenHe} - {item.MaMon} - {item.TenMon}"
            );
        }

        // ==================================================
        // CÂU B
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
                    ? "(Khong co mon)"
                    : mon.MaMon,

                TenMon = mon == null
                    ? "(Khong co mon)"
                    : mon.TenMon
            };

        Console.WriteLine(
            "\nb. He ke ca he khong co mon:"
        );

        foreach (var item in cauB)
        {
            Console.WriteLine(
                $"{item.MaHe} - {item.TenHe} - " +
                $"{item.MaMon} - {item.TenMon}"
            );
        }

        // ==================================================
        // CÂU C
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
                    ? "(Khong co mon)"
                    : mon.MaMon,

                TenMon = mon == null
                    ? "(Khong co mon)"
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
                    ? "(Chua khai bao)"
                    : mon.He,

                TenHe = "(Chua khai bao)",
                MaMon = mon.MaMon,
                TenMon = mon.TenMon
            };

        var cauC = leftJoin.Concat(monChuaCoHe);

        Console.WriteLine(
            "\nc. He khong co mon va mon chua khai bao he:"
        );

        foreach (var item in cauC)
        {
            Console.WriteLine(
                $"{item.MaHe} - {item.TenHe} - " +
                $"{item.MaMon} - {item.TenMon}"
            );
        }

        // ==================================================
        // CÂU D
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
                MaMon = "(Khong co mon)",
                TenMon = "(Khong co mon)"
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
                    ? "(Chua khai bao)"
                    : mon.He,

                TenHe = "(Chua khai bao)",
                MaMon = mon.MaMon,
                TenMon = mon.TenMon
            };

        var cauD = heKhongCoMon.Concat(monKhongCoHe);

        Console.WriteLine(
            "\nd. Chi he khong co mon va mon khong co he:"
        );

        foreach (var item in cauD)
        {
            Console.WriteLine(
                $"{item.MaHe} - {item.TenHe} - " +
                $"{item.MaMon} - {item.TenMon}"
            );
        }

        // ==================================================
        // CÂU E
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
                        ? "(Chua khai bao)"
                        : he.TenHe,

                    mon.MaMon,
                    mon.TenMon,
                    mon.SoTiet
                }
            )
            .Take(5);

        Console.WriteLine(
            "\ne. Top 5 mon co so tiet cao nhat:"
        );

        foreach (var item in cauE)
        {
            Console.WriteLine(
                $"{item.TenHe} - {item.MaMon} - " +
                $"{item.TenMon} - {item.SoTiet}"
            );
        }

        // ==================================================
        // CÂU F
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

        Console.WriteLine(
            "\nf. Tong so mon cua tung he:"
        );

        foreach (var item in cauF)
        {
            Console.WriteLine(
                $"{item.MaHe} - {item.TenHe}: " +
                $"{item.TongSoMon} mon"
            );
        }

        // ==================================================
        // CÂU G
        // ==================================================
        int cauG = dsMon
            .Select(mon => mon.SoTiet)
            .Distinct()
            .Count();

        Console.WriteLine(
            "\ng. So luong gia tri SoTiet khac nhau:"
        );

        Console.WriteLine(cauG);

        // ==================================================
        // CÂU H
        // ==================================================
        var cauH = dsMon
            .FirstOrDefault(
                mon => mon.TenMon.StartsWith("Lập trình")
            );

        Console.WriteLine(
            "\nh. Mon dau tien bat dau bang \"Lap trinh\":"
        );

        if (cauH != null)
        {
            Console.WriteLine(
                $"{cauH.MaMon} - {cauH.TenMon} - " +
                $"{cauH.He} - {cauH.SoTiet}"
            );
        }
        else
        {
            Console.WriteLine("Khong tim thay mon hoc.");
        }

        // ==================================================
        // CÂU I
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

        Console.WriteLine(
            "\ni. Danh sach mon hoc theo tung he:"
        );

        foreach (var he in cauI)
        {
            Console.WriteLine(
                $"\nHe: {he.MaHe} - {he.TenHe}"
            );

            if (!he.DanhSachMon.Any())
            {
                Console.WriteLine(
                    "  (Khong co mon hoc)"
                );
            }
            else
            {
                foreach (var mon in he.DanhSachMon)
                {
                    Console.WriteLine(
                        $"  {mon.STT}. " +
                        $"{mon.MaMon} - " +
                        $"{mon.TenMon} - " +
                        $"{mon.SoTiet}"
                    );
                }
            }
        }
    }
}