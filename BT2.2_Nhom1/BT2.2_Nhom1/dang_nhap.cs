namespace BT2._2_Nhom1
{
    public partial class dang_nhap : Form
    {
        string otpHeThongTaoRa = "";
        bool hopLe = true;

        public dang_nhap()
        {
            InitializeComponent();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult cauHoi = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cauHoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            string sdt = txt_SDT.Text;
            string matkhau = txt_password.Text;

            if (!hopLe)
            {
                return;
            }

            if (sdt == "0123456789" && matkhau == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                giaodien frm = new giaodien();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Số điện thoại hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llb_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dang_ky frm = new dang_ky();
            frm.Show();
            this.Hide();
        }

        private void llb_quen_mk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txt_SDT_Leave(object sender, EventArgs e)
        {
            string sdt = txt_SDT.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                lb_loidangnhap.Text = "Không được để trống SĐT!";
                hopLe = false;
            }
            else if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                lb_loidangnhap.Text = "SĐT phải gồm 10 số, bắt đầu bằng 0!";
                hopLe = false;
            }
            else
            {
                lb_loidangnhap.Text = "";
                hopLe = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                lb_loimatkhau.Text = "Không được để trống mật khẩu!";
                hopLe = false;
            }
            else
            {
                lb_loimatkhau.Text = "";
                hopLe = true;
            }
        }
    }
}
