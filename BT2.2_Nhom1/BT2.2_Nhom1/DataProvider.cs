using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.Data.SqlClient;

namespace BT2._2_Nhom1
{
    internal class DataProvider
    {
        const string connString = "Data Source=.;Initial Catalog=QuanLyNguoiDung;Integrated Security=True;Trust Server Certificate=True";
        //const string connString = "Data Source=localhost\\SQL2025DEV;Initial Catalog=QuanLyNguoiDung;Integrated Security=True;Trust Server Certificate=True";

        public static async Task<bool> TestConnection() {
            var connection = new SqlConnection(connString);

            try
            {
                await connection.OpenAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến Server. Vui lòng kiểm tra lại mạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public static void AddUser(User user)
        {
            string query = "INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email) VALUES (@TenDangNhap, @MatKhauBam, @Salt, @HoTen, @Email)";
            var connection = new SqlConnection(connString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenDangNhap", user.TenDangNhap);
            command.Parameters.AddWithValue("@MatKhauBam", user.MatKhauBam);
            command.Parameters.AddWithValue("@Salt", user.Salt);
            command.Parameters.AddWithValue("@HoTen", user.HoTen);
            command.Parameters.AddWithValue("@Email", user.Email);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public static async Task<User> GetUser(string username)
        {
            var connection = new SqlConnection(connString);
            connection.Open();
            string query = "SELECT * FROM Users WHERE TenDangNhap = @TenDangNhap";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenDangNhap", username);
            using var reader = await command.ExecuteReaderAsync();

            User response = new User();
            if (reader.Read())
            {
                response = new User()
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    TenDangNhap = Convert.ToString(reader["TenDangNhap"]),
                    MatKhauBam = Convert.ToString(reader["MatKhauBam"]),
                    Salt = Convert.ToString(reader["Salt"]),
                    HoTen = Convert.ToString(reader["HoTen"]),
                    Email = Convert.ToString(reader["Email"]),
                    NgayTao = Convert.ToString(reader["NgayTao"]),
                    LanDangNhapCuoi = Convert.ToString(reader["LanDangNhapCuoi"]),
                };
            }

            connection.Close();
            return response;
        }

        public static async Task<User> GetUserPasswordAndSalt(string username)
        {
            var connection = new SqlConnection(connString);
            connection.Open();
            string query = "SELECT UserId, MatKhauBam, Salt FROM Users WHERE TenDangNhap = @TenDangNhap";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenDangNhap", username);
            using var reader = await command.ExecuteReaderAsync();

            User response = new User();
            if (reader.Read())
            {
                response = new User()
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    MatKhauBam = Convert.ToString(reader["MatKhauBam"]),
                    Salt = Convert.ToString(reader["Salt"])
                };
            }

            connection.Close();
            return response;
        }

        public static async Task UpdateLoginDate(string username)
        {
            var connection = new SqlConnection(connString);
            connection.Open();
            string query = "UPDATE Users SET LanDangNhapCuoi = @LanDangNhapCuoi WHERE TenDangNhap = @TenDangNhap";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LanDangNhapCuoi", DateTime.Now);
            command.Parameters.AddWithValue("@TenDangNhap", username);
            await command.ExecuteNonQueryAsync();
            connection.Close();
        }


        public static async Task<bool> IsUserExist(string username)
        {
            var connection = new SqlConnection(connString);
            connection.Open();
            string query = "SELECT UserId FROM Users WHERE TenDangNhap = @TenDangNhap";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenDangNhap", username);

            using var reader = await command.ExecuteReaderAsync();

            if (reader.Read())
            {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }

    }
}
