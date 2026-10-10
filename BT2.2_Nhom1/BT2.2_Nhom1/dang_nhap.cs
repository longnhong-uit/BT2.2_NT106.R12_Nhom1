using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BT2._2_Nhom1
{
    public static class MatKhau
    {
        private const int VONG_LAP = 600_000;

        // Gọi khi đăng ký
        public static (string Salt, string Bam) Tao(string matKhau)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] bam = Rfc2898DeriveBytes.Pbkdf2(
                matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
            return (Convert.ToBase64String(salt), Convert.ToBase64String(bam));
        }

        // Gọi khi đăng nhập
        public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
        {
            byte[] salt = Convert.FromBase64String(saltLuu);
            byte[] bamCu = Convert.FromBase64String(bamLuu);
            byte[] bamMoi = Rfc2898DeriveBytes.Pbkdf2(
                matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
            return CryptographicOperations.FixedTimeEquals(bamCu, bamMoi);
        }
    }
    public partial class dang_nhap : Form
    {

        private const string ChuoiKetNoi =
            @"Server=localhost\SQLEXPRESS;Database=QuanLyNguoiDung;" +
            @"Trusted_Connection=True;TrustServerCertificate=True;";
        bool hopLeMK = true,
             hopLeSDT = true;

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


        private async void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            string sdt = txt_SDT.Text;
            string matkhau = txt_password.Text;

            if (!hopLeMK || !hopLeSDT)
            {
                return;
            }

            btn_dang_nhap.Enabled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(ChuoiKetNoi))
                {
                    await conn.OpenAsync();

                    string query = "SELECT MatKhauBam, Salt FROM Users WHERE TenDangNhap = @TenDangNhap";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", sdt);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                string dbHash = reader["MatKhauBam"].ToString().Trim();
                                string dbSalt = reader["Salt"].ToString().Trim();

                                bool dungMatKhau = MatKhau.KiemTra(matkhau, dbSalt, dbHash);

                                if (dungMatKhau)
                                {
                                    MessageBox.Show("Đăng nhập thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    giaodien frm = new giaodien();
                                    frm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_dang_nhap.Enabled = true;
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
                hopLeSDT = false;
            }
            else if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                lb_loidangnhap.Text = "SĐT phải gồm 10 số, bắt đầu bằng 0!";
                hopLeSDT = false;
            }
            else
            {
                lb_loidangnhap.Text = "";
                hopLeSDT = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                lb_loimatkhau.Text = "Không được để trống mật khẩu!";
                hopLeMK = false;
            }
            else
            {
                lb_loimatkhau.Text = "";
                hopLeMK = true;
            }
        }
    }
}
