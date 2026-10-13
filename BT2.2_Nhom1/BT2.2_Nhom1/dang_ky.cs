using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BT2._2_Nhom1
{
    public partial class dang_ky : Form
    {
        public dang_ky()
        {
            InitializeComponent();
        }

        private async void btnDangky_Click(object sender, EventArgs e)
        {
            btnDangKy.Enabled = false;

            lblBaoLoiSDT.Text = "";
            lblBaoLoiHoTen.Text = "";
            lblBaoLoiPassword.Text = "";
            lblBaoLoiXacNhanPassword.Text = "";
            lblBaoLoiEmail.Text = "";

            string sdt = txtSDT.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhan = txtXacNhan.Text;
            string email = txtEmail.Text.Trim();

            // 1. KIỂM TRA SĐT ĐĂNG NHẬP
            // Không được để trống
            if (string.IsNullOrEmpty(sdt))
            {
                lblBaoLoiSDT.Text = "Vui lòng nhập số điện thoại đăng nhập!"; txtSDT.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Bắt buộc bắt đầu bằng số 0, chỉ chứa chữ số từ 0-9, không có chữ cái, ký tự đặc biệt hay khoảng trắng
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                lblBaoLoiSDT.Text = "Số điện thoại không hợp lệ (Phải có 10 số và bắt đầu bằng số 0)"; txtSDT.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // 2. KIỂM TRA HỌ VÀ TÊN
            if (string.IsNullOrEmpty(hoTen))
            {
                lblBaoLoiHoTen.Text = "Vui lòng nhập họ và tên!";
                txtHoTen.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Từ 2 tới 50 ký tự
            if (hoTen.Length < 2 || hoTen.Length > 50)
            {
                lblBaoLoiHoTen.Text = "Họ và tên phải từ 2 đến 50 ký tự!";
                txtHoTen.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Chỉ chứa chữ cái (bao gồm tiếng Việt) và khoảng trắng, không chứa số và ký tự đặc biệt
            if (!Regex.IsMatch(hoTen, @"^[\p{L}\s]+$"))
            {
                lblBaoLoiHoTen.Text = "Họ và tên không chứa số hay ký tự đặc biệt!";
                txtHoTen.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // 3. KIỂM TRA MẬT KHẨU
            if (string.IsNullOrEmpty(matKhau))
            {
                lblBaoLoiPassword.Text = "Vui lòng nhập mật khẩu!";
                txtMatKhau.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Tối thiểu 8 ký tự
            if (matKhau.Length < 8)
            {
                lblBaoLoiPassword.Text = "Mật khẩu phải có tối thiểu 8 ký tự!";
                txtMatKhau.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Không có khoảng trắng
            if (matKhau.Contains(" "))
            {
                lblBaoLoiPassword.Text = "Mật khẩu phải không có khoảng trắng";
                txtMatKhau.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số, 1 ký tự đặc biệt
            bool coChuHoa = matKhau.Any(char.IsUpper);
            bool coChuThuong = matKhau.Any(char.IsLower);
            bool coSo = matKhau.Any(char.IsDigit);
            bool coKyTuDacBiet = matKhau.Any(ch => !char.IsLetterOrDigit(ch));

            if (!coChuHoa || !coChuThuong || !coSo || !coKyTuDacBiet)
            {
                lblBaoLoiPassword.Text = "Mật khẩu yếu! Phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 chữ số và 1 ký tự đặc biệt.";
                txtMatKhau.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // 4. KIỂM TRA XÁC NHẬN MẬT KHẨU
            // Không bị bỏ trống
            if (string.IsNullOrEmpty(xacNhan))
            {
                lblBaoLoiXacNhanPassword.Text = "Vui lòng nhập xác nhận mật khẩu!";
                txtXacNhan.Focus();
                btnDangKy.Enabled = true;
                return;
            }

            // Trùng khớp 100% với mật khẩu
            if (matKhau != xacNhan)
            {
                lblBaoLoiXacNhanPassword.Text = "Xác nhận mật khẩu không trùng khớp!";
                txtXacNhan.Focus();
                btnDangKy.Enabled = true;
                return;
            }
            // 5. Email
            if (string.IsNullOrEmpty(email))
            {
                lblBaoLoiEmail.Text = "Vui lòng nhập Email, không được để trống!";
                txtEmail.Focus();
                btnDangKy.Enabled = true;
                return;
            }
            if (!email.ToLower().EndsWith("@gmail.com"))
            {
                lblBaoLoiEmail.Text = "Email phải đúng định dạng Gmail (ví dụ: abc@gmail.com)!";
                btnDangKy.Enabled = true;
                txtEmail.Focus();
                return;
            }

            var (salt, password) = MatKhau.Tao(matKhau);

            btnDangKy.Text = "Đang xử lý ...";
            btnDangKy.Enabled = false;
            if (await DataProvider.TestConnection())
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng Ký";
            }
            else
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng Ký";
                return;
            }
            // Kiểm tra xem số điện thoại đã được đăng ký chưa
            bool daTonTai = await DataProvider.IsUserExist(sdt);
            if (daTonTai)
            {
                lblBaoLoiSDT.Text = "Số điện thoại này đã được đăng ký!";
                btnDangKy.Enabled = true;
                txtSDT.Focus();
                return;
            }

            var user = new User()
            {
                TenDangNhap = sdt,
                MatKhauBam = password,
                Salt = salt,
                HoTen = hoTen,
                Email = email
            };
            DataProvider.AddUser(user);

            // Xong
            MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDangKy.Enabled = true;

            dang_nhap DangNhap = new dang_nhap();
            DangNhap.Show();
            this.Hide();
            btnDangKy.Enabled = true;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;

            txtSDT.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtXacNhan.Clear();
            txtSDT.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnThoat.Enabled = false;

            this.Close();
        }

        private void llbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dang_nhap DangNhap = new dang_nhap();
            DangNhap.Show();
            this.Hide();
        }
    }
}
