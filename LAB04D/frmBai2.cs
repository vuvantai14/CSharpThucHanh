namespace LAB04D
{
    public partial class frmBai2 : Form
    {
        private MangSoNguyen mang = new MangSoNguyen();

        public frmBai2()
        {
            InitializeComponent();
        }

        private bool NapMang()
        {
            try
            {
                errorProvider1.Clear();

                mang.NhapMang(txtNhapMang.Text);
                return true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNhapMang, ex.Message);

                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!NapMang())
                return;

            try
            {
                // Sắp xếp
                if (rdoTang.Checked)
                    mang.SapXepTang();
                else
                    mang.SapXepGiam();

                txtKetQua.Text = mang.XuatMang();

                // Tìm kiếm
                if (!string.IsNullOrWhiteSpace(txtTim.Text))
                {
                    if (!int.TryParse(txtTim.Text, out int n))
                        throw new Exception("Dữ liệu tìm kiếm phải là số nguyên.");

                    if (rdoTimGiaTri.Checked)
                    {
                        int viTri = mang.TimGiaTri(n);

                        if (viTri == -1)
                            txtTimKetQua.Text = "Không có";
                        else
                            txtTimKetQua.Text = viTri.ToString();
                    }
                    else
                    {
                        txtTimKetQua.Text =
                            mang.LayGiaTriTaiViTri(n).ToString();
                    }
                }

                // Thêm
                if (!string.IsNullOrWhiteSpace(txtGiaTriThem.Text) ||
                    !string.IsNullOrWhiteSpace(txtViTriThem.Text))
                {
                    if (!int.TryParse(txtGiaTriThem.Text, out int giaTri))
                        throw new Exception("Giá trị thêm không hợp lệ.");

                    if (!int.TryParse(txtViTriThem.Text, out int viTri))
                        throw new Exception("Vị trí thêm không hợp lệ.");

                    mang.Them(giaTri, viTri);

                    txtKetQua.Text = mang.XuatMang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (!NapMang())
                return;

            txtTong.Text = mang.TongMang().ToString();
            txtTongChan.Text = mang.TongChan().ToString();
            txtTongLe.Text = mang.TongLe().ToString();
        }

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            if (!NapMang())
                return;

            txtMax.Text = mang.Max().ToString();
            txtMin.Text = mang.Min().ToString();
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (!NapMang())
                return;

            try
            {
                if (!int.TryParse(txtCanThay.Text, out int canThay))
                    throw new Exception(
                        "Giá trị hoặc vị trí cần thay không hợp lệ.");

                if (!int.TryParse(txtSoThayThe.Text, out int soMoi))
                    throw new Exception("Số thay thế không hợp lệ.");

                if (rdoThayGiaTri.Checked)
                {
                    bool ketQua =
                        mang.ThayTheGiaTri(canThay, soMoi);

                    if (!ketQua)
                    {
                        MessageBox.Show(
                            "Không tìm thấy giá trị cần thay.");

                        return;
                    }
                }
                else
                {
                    mang.ThayTheTaiViTri(canThay, soMoi);
                }

                txtNhapMang.Text = mang.XuatMang();
                txtKetQua.Text = mang.XuatMang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNhapMang.Clear();
            txtKetQua.Clear();

            txtTim.Clear();
            txtTimKetQua.Clear();

            txtGiaTriThem.Clear();
            txtViTriThem.Clear();

            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtMax.Clear();
            txtMin.Clear();

            txtCanThay.Clear();
            txtSoThayThe.Clear();

            rdoTang.Checked = true;
            rdoTimGiaTri.Checked = true;
            rdoThayGiaTri.Checked = true;

            errorProvider1.Clear();

            txtNhapMang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBai2_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}