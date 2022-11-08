using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    internal class HoSoQuanLyDTO
    {
        private int id;
        private String tenDangNhap;
        private String vaiTro;
        private int trangThai;
        private int gioiTinh;
        private string ten;
        private string ho;
        private string diachi;
        private string soDT;
        private string hinhanh;
        private string email;
        private DateTime ngaysinh;
        private int luong;

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Luong { get => luong; set => luong = value; }
        public string VaiTro { get => vaiTro; set => vaiTro = value; }
        
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
