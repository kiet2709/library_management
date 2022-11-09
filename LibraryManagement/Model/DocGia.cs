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
        private string ho;
        private string mssv;
        private string khoa;
        private int trangthai;
        private string ngaysinh;
        private int gioitinh;
        private string sdt;
        private string email;

        public DocGia(int id, string ten, string ho, string mssv, string khoa, int trangthai, string ngaysinh, int gioitinh, string sdt, string email)
        {
            this.Id = id;
            this.Ten = ten;
            this.Ho = ho;
            this.Mssv = mssv;
            this.Khoa = khoa;
            this.Trangthai = trangthai;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Sdt = sdt;
            this.Email = email;
        }

        public DocGia()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
