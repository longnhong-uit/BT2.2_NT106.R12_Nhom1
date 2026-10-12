using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT2._2_Nhom1
{
    public partial class giaodien : Form
    {

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public giaodien()
        {
            InitializeComponent();
        }
        private string currentUsername; // Lưu tên đăng nhập được truyền sang

        // Constructor nhận username từ form đăng nhập
        public giaodien(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        // Sự kiện Form_Load (dùng async để gọi hàm lấy dữ liệu bất đồng bộ)
        private async void giaodien_Load(object sender, EventArgs e)
        {
            await LoadUserData();
        }

        // Hàm gọi DataProvider để lấy thông tin user và gán vào Label
        private async Task LoadUserData()
        {
            try
            {
                // Gọi trực tiếp hàm tĩnh GetUser do nhóm đã viết sẵn trong DataProvider.cs
                User user = await DataProvider.GetUser(currentUsername);

                if (user != null && !string.IsNullOrEmpty(user.TenDangNhap))
                {
                    // Gán dữ liệu vào các Label tương ứng trên form chính
                    lblXinChao.Text = "Xin chào, " + user.HoTen;
                    lblTenDangNhap.Text = "Tên đăng nhập: " + user.TenDangNhap;
                    lblEmail.Text = "Email: " + user.Email;
                    lblLanDangNhap.Text = "Lần đăng nhập gần nhất: " + (string.IsNullOrEmpty(user.LanDangNhapCuoi) ? "Chưa có" : user.LanDangNhapCuoi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin người dùng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng nút Đăng xuất
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dang_nhap fLogin = new dang_nhap();
            fLogin.Show();
            this.Close();
        }

    }
}
