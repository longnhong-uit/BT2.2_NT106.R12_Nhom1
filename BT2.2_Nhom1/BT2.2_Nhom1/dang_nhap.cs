using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BT2._2_Nhom1
{
    public partial class dang_nhap : Form
    {
        bool hopLeMK = true,
             hopLeSDT = true;



        public dang_nhap()
        {
            InitializeComponent();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult cauHoi = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cauHoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            string matkhau = txtPassword.Text;

            if (string.IsNullOrEmpty(sdt))
            {
                lblLoiDangNhap.Text = "Không được để trống SĐT!";
                hopLeSDT = false;
            }
            else if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                lblLoiDangNhap.Text = "SĐT phải gồm 10 số, bắt đầu bằng 0!";
                hopLeSDT = false;
            }
            else
            {
                lblLoiDangNhap.Text = "";
                hopLeSDT = true;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblLoiMatKhau.Text = "Không được để trống mật khẩu!";
                hopLeMK = false;
            }
            else
            {
                lblLoiMatKhau.Text = "";
                hopLeMK = true;
            }

            if (!hopLeMK || !hopLeSDT)
            {
                return;
            }

            btnDangNhap.Text = "Đang xử lý ...";
            btnDangNhap.Enabled = false;
            if (await DataProvider.TestConnection())
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng Nhập";
            }
            else
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng Nhập";
                return;
            }

            btnDangNhap.Enabled = false;
            var user = await DataProvider.GetUserPasswordAndSalt(sdt);

            if (user.UserId != -1)
            {
                if (MatKhau.KiemTra(matkhau, user.Salt, user.MatKhauBam))
                {
                    lblLoiMatKhau.Text = "";
                    await DataProvider.UpdateLoginDate(sdt);
                    giaodien frm = new giaodien(sdt);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    lblLoiMatKhau.Text = "SĐT hoặc mật khẩu không đúng";
                    txtPassword.Text = "";
                }
            }
            else
            {
                lblLoiMatKhau.Text = "SĐT hoặc mật khẩu không đúng";
                txtPassword.Text = "";
            }
            btnDangNhap.Enabled = true;
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
    }
}
