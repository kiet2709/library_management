using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    class AddDocGiaDTO
    {
        private int id;
        private string ten;
        private string mssv;
        private string khoa;
        private int gioiTinh;
        private DateTime ngaySinh;
        private string soDT;
        private string email;
        private string hinhAnh;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public AddDocGiaDTO(int id, string ten, string mssv, string khoa, int gioiTinh, DateTime ngaySinh, string soDT, string email, string hinhAnh)
        {
            this.Id = id;
            this.Ten = ten;
            this.Mssv = mssv;
            this.Khoa = khoa;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SoDT = soDT;
            this.Email = email;
            this.HinhAnh = hinhAnh;
        }

        public AddDocGiaDTO()
        {
        }

    }    
}
