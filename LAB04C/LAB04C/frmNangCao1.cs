namespace LAB04C
{
    public partial class frmNangCao1 : Form
    {
        // Mảng chứa 15 ghế.
        // Mảng này nằm trong code xử lý nên có thể dùng foreach bình thường.
        private Button[] danhSachGhe;

        public frmNangCao1()
        {
            InitializeComponent();

            // Đưa 15 Button vào một mảng
            danhSachGhe = new Button[]
            {
                btnGhe1,
                btnGhe2,
                btnGhe3,
                btnGhe4,
                btnGhe5,

                btnGhe6,
                btnGhe7,
                btnGhe8,
                btnGhe9,
                btnGhe10,

                btnGhe11,
                btnGhe12,
                btnGhe13,
                btnGhe14,
                btnGhe15
            };

            // Gắn chung sự kiện Click cho 15 ghế
            foreach (Button ghe in danhSachGhe)
            {
                ghe.Click += Ghe_Click;
            }

            // Sự kiện cho hai nút
            btnChon.Click += btnChon_Click;
            btnHuyBo.Click += btnHuyBo_Click;
        }

        // ==============================================
        // CLICK VÀO GHẾ
        // ==============================================
        private void Ghe_Click(object? sender, EventArgs e)
        {
            if (sender is not Button ghe)
                return;

            // Ghế trắng = chưa bán
            // Click -> chuyển xanh = đang chọn
            if (ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
                ghe.ForeColor = Color.White;
            }

            // Ghế xanh = đang chọn
            // Click lại -> bỏ chọn
            else if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
                ghe.ForeColor = Color.Black;
            }

            // Ghế vàng = đã bán
            else if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show(
                    "Ghế này đã được bán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ==============================================
        // LẤY GIÁ VÉ
        // ==============================================
        private int LayGiaVe(int soGhe)
        {
            // Ghế 1 -> 5: Lô A
            if (soGhe >= 1 && soGhe <= 5)
            {
                return 1000;
            }

            // Ghế 6 -> 10: Lô B
            if (soGhe >= 6 && soGhe <= 10)
            {
                return 1500;
            }

            // Ghế 11 -> 15: Lô C
            return 2000;
        }

        // ==============================================
        // NÚT CHỌN
        // ==============================================
        private void btnChon_Click(object? sender, EventArgs e)
        {
            int thanhTien = 0;
            bool coGheDuocChon = false;

            for (int i = 0; i < danhSachGhe.Length; i++)
            {
                Button ghe = danhSachGhe[i];

                // Chỉ xử lý những ghế đang màu xanh
                if (ghe.BackColor == Color.Blue)
                {
                    coGheDuocChon = true;

                    // i + 1 chính là số ghế
                    int soGhe = i + 1;

                    thanhTien += LayGiaVe(soGhe);

                    // Sau khi bán -> chuyển sang vàng
                    ghe.BackColor = Color.Yellow;
                    ghe.ForeColor = Color.Black;
                }
            }

            if (!coGheDuocChon)
            {
                MessageBox.Show(
                    "Bạn chưa chọn ghế!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            txtThanhTien.Text = thanhTien.ToString();
        }

        // ==============================================
        // NÚT HỦY BỎ
        // ==============================================
        private void btnHuyBo_Click(object? sender, EventArgs e)
        {
            foreach (Button ghe in danhSachGhe)
            {
                // Chỉ hủy các ghế đang chọn (màu xanh)
                // Ghế đã bán màu vàng không được thay đổi
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.White;
                    ghe.ForeColor = Color.Black;
                }
            }

            txtThanhTien.Text = "0";
        }
    }
}