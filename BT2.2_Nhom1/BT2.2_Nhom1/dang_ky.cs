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

        private void btndangky_Click(object sender, EventArgs e)
        {
            btndangky.Enabled = false;

            string sdt = txtSDT.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhan = txtXacNhan.Text;

            // 1. KIỂM TRA SĐT ĐĂNG NHẬP
            // Không được để trống
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Bắt buộc bắt đầu bằng số 0, chỉ chứa chữ số từ 0-9, không có chữ cái, ký tự đặc biệt hay khoảng trắng
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("SĐT phải bắt đầu bằng số 0 và chỉ chứa các chữ số (0-9), không chứa khoảng trắng hay ký tự đặc biệt! và phải đủ 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                btndangky.Enabled = true;
                return;
            }

            //Kiểm tra số điện thoại đã đăng ký
            List<string> danhSachSDTDaDangKy = new List<string> { "0901234567", "0987654321" };
            if (danhSachSDTDaDangKy.Contains(sdt))
            {
                MessageBox.Show("Số điện thoại này đã có tài khoản đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                btndangky.Enabled = true;
                return;
            }

            // 2. KIỂM TRA HỌ VÀ TÊN
            if (hoTen == null || hoTen == " ")
            {
                MessageBox.Show("Họ và tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Từ 2 tới 50 ký tự
            if (hoTen.Length < 2 || hoTen.Length > 50)
            {
                MessageBox.Show("Họ và tên phải từ 2 đến 50 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Chỉ chứa chữ cái (bao gồm tiếng Việt) và khoảng trắng, không chứa số và ký tự đặc biệt
            if (!Regex.IsMatch(hoTen, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Họ và tên chỉ chứa chữ cái và khoảng trắng, không chứa số hay ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                btndangky.Enabled = true;
                return;
            }

            // 3. KIỂM TRA MẬT KHẨU
            if (matKhau == null || matKhau == " ")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Tối thiểu 8 ký tự
            if (matKhau.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có tối thiểu 8 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Không có khoảng trắng
            if (matKhau.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số, 1 ký tự đặc biệt
            bool coChuHoa = matKhau.Any(char.IsUpper);
            bool coChuThuong = matKhau.Any(char.IsLower);
            bool coSo = matKhau.Any(char.IsDigit);
            bool coKyTuDacBiet = matKhau.Any(ch => !char.IsLetterOrDigit(ch));

            if (!coChuHoa || !coChuThuong || !coSo || !coKyTuDacBiet)
            {
                MessageBox.Show("Mật khẩu yếu! Phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 chữ số và 1 ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                btndangky.Enabled = true;
                return;
            }

            // 4. KIỂM TRA XÁC NHẬN MẬT KHẨU
            // Không bị bỏ trống
            if (xacNhan == null || xacNhan == " ")
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhan.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Trùng khớp 100% với mật khẩu
            if (matKhau != xacNhan)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhan.Focus();
                btndangky.Enabled = true;
                return;
            }

            // Xong
            MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btndangky.Enabled = true;

            dang_nhap DangNhap = new dang_nhap();
            DangNhap.Show();
            this.Hide();
        }


        private void huy_Click(object sender, EventArgs e)
        {
            huy.Enabled = false;

            txtSDT.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtXacNhan.Clear();
            txtSDT.Focus();

        }

        private void txtthoat_Click(object sender, EventArgs e)
        {
            txtthoat.Enabled = false;

            this.Close();
        }

        private void dang_nhap_ngay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dang_nhap DangNhap = new dang_nhap();
            DangNhap.Show();
            this.Hide();
        }
    }
}
