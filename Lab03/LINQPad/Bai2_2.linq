<Query Kind="Program" />

void Main()
{
    string[] mangChuoi =
    {
        "đầu", "lòng", "hai", "ả", "tố", "nga",
        "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân"
    };

    // Câu a: Các phần tử có 4 ký tự,
    // sắp xếp tăng dần theo ký tự đầu tiên
    var cauA = mangChuoi
        .Where(x => x.Length == 4)
        .OrderBy(x => x[0]);

    cauA.Dump("Câu a - Chuỗi có 4 ký tự");
	// Câu b: Biến đổi thành chữ thường - CHỮ HOA
	var cauB = mangChuoi
    .Select(x => $"{x.ToLower()} - {x.ToUpper()}");

	cauB.Dump("Câu b - Chữ thường - CHỮ HOA");
	var cauC = mangChuoi
    .Where(x => x.Contains("u"));

	cauC.Dump("Câu c - Các phần tử chứa ký tự u");
	var cauD = mangChuoi
    .Where(x => char.IsUpper(x[0]));

	cauD.Dump("Câu d - Các từ bắt đầu bằng chữ in hoa");
}