namespace BT2._2_Nhom1
{
    public partial class dang_nhap : Form
    {
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

            if (sdt == "" || matkhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Số điện thoại và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại gồm 10 chữ số và bắt đầu bằng số 0.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDT.Focus();
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
    }
}
