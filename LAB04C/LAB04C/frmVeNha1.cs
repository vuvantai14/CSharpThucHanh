namespace LAB04C
{
    public partial class frmVeNha1 : Form
    {
        private double soThuNhat = 0;
        private string phepTinh = "";
        private bool nhapSoMoi = true;

        public frmVeNha1()
        {
            InitializeComponent();
        }

        // Nhấn các số 0 -> 9
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (nhapSoMoi || txtManHinh.Text == "0")
            {
                txtManHinh.Text = btn.Text;
                nhapSoMoi = false;
            }
            else
            {
                txtManHinh.Text += btn.Text;
            }
        }

        // Nhấn + - * /
        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            soThuNhat = double.Parse(txtManHinh.Text);
            phepTinh = btn.Text;

            nhapSoMoi = true;
        }

        // Nhấn =
        private void btnBang_Click(object sender, EventArgs e)
        {
            double soThuHai = double.Parse(txtManHinh.Text);
            double ketQua = 0;

            switch (phepTinh)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            txtManHinh.Text = ketQua.ToString();
            nhapSoMoi = true;
        }

        // Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtManHinh.Text = "0";
            soThuNhat = 0;
            phepTinh = "";
            nhapSoMoi = true;
        }
    }
}