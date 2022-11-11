using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class ThongTinCaNhanDTO
    {
        private int id;
        private String tenDangNhap;
        private int gioiTinh;
        private string ten;
        private string ho;
        private string diachi;
        private string soDT;
        private string hinhanh;
        private string email;
        private DateTime ngaysinh;

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }
}
