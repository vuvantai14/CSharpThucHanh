<Query Kind="Program" />

void Main()
{
    int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

    // Câu a: Các phần tử chia hết cho 4 và 3
    var cauA = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);

    cauA.Dump("Câu a - Chia hết cho 4 và 3");

    // Câu b: Các phần tử nhỏ hơn hoặc bằng 3
    var cauB = mangSo.Where(x => x <= 3);

    cauB.Dump("Câu b - Các phần tử <= 3");
	// Câu c: Số chẵn chia đôi, số lẻ giữ nguyên
	var cauC = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);

	cauC.Dump("Câu c - Dãy mới");
}
