using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Model
{
    internal class DocGia
    {
        private int id;
        private string ten;
        private string mssv;
        private string khoa;
        private int trangthai;
        private DateTime ngaysinh;
        private int gioitinh;
        private string sdt;
        private string email;
        private string hinhAnh;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public DocGia(int id, string ten, string mssv, string khoa, int trangthai, DateTime ngaysinh, int gioitinh, string sdt, string email, string hinhAnh)
        {
            this.Id = id;
            this.Ten = ten;
            this.Mssv = mssv;
            this.Khoa = khoa;
            this.Trangthai = trangthai;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Email = email;
            this.HinhAnh = hinhAnh;
        }

        public DocGia()
        {
        }
    }
}
