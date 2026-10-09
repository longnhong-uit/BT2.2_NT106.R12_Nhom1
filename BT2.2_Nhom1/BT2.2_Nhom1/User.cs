using System;
using System.Collections.Generic;
using System.Text;

namespace BT2._2_Nhom1
{
    internal class User
    {
        public int UserId { get; set; } = -1;
        public string? TenDangNhap { get; set; }
        public string MatKhauBam { get; set; } = "";
        public string Salt { get; set; } = "";
        public string? HoTen { get; set; }
        public string? Email { get; set; }
        public string? NgayTao { get; set; }
        public string? LanDangNhapCuoi { get; set; }
    }
}
