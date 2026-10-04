namespace LAB04D
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            rdoBacNhat.Checked = true;

            lblC.Enabled = false;
            txtC.Enabled = false;

            btnGiai.Enabled = false;

            txtA.Focus();
        }

        private void rdoBacNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                lblC.Enabled = false;
                txtC.Enabled = false;
                txtC.Clear();

                txtKetQua.Clear();
                KiemTraDuLieu();
            }
        }

        private void rdoBacHai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacHai.Checked)
            {
                lblC.Enabled = true;
                txtC.Enabled = true;

                txtKetQua.Clear();
                KiemTraDuLieu();
            }
        }

        private void DuLieu_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void KiemTraDuLieu()
        {
            bool duA = !string.IsNullOrWhiteSpace(txtA.Text);
            bool duB = !string.IsNullOrWhiteSpace(txtB.Text);

            if (rdoBacNhat.Checked)
            {
                btnGiai.Enabled = duA && duB;
            }
            else
            {
                bool duC = !string.IsNullOrWhiteSpace(txtC.Text);
                btnGiai.Enabled = duA && duB && duC;
            }
        }

        private bool LayDuLieu(out double a, out double b, out double c)
        {
            a = b = c = 0;

            errorProvider1.Clear();

            bool hopLe = true;

            if (!double.TryParse(txtA.Text.Trim(), out a))
            {
                errorProvider1.SetError(txtA, "a phải là số.");
                hopLe = false;
            }

            if (!double.TryParse(txtB.Text.Trim(), out b))
            {
                errorProvider1.SetError(txtB, "b phải là số.");
                hopLe = false;
            }

            if (rdoBacHai.Checked)
            {
                if (!double.TryParse(txtC.Text.Trim(), out c))
                {
                    errorProvider1.SetError(txtC, "c phải là số.");
                    hopLe = false;
                }
            }

            return hopLe;
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (!LayDuLieu(out double a, out double b, out double c))
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại dữ liệu nhập.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);

            if (rdoBacNhat.Checked)
                txtKetQua.Text = pt.GiaiBacNhat();
            else
                txtKetQua.Text = pt.GiaiBacHai();

            btnGiai.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
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