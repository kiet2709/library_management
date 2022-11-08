using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class DangNhapDTO
    {
        private string taikhoan;
        private string matkhau;

        public DangNhapDTO()
        {
        }

        public DangNhapDTO(string taikhoan, string matkhau)
        {
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
