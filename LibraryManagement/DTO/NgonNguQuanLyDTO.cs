using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    internal class NgonNguQuanLyDTO
    {
        private int id;
        private string ten;
        private int tongSachTheoTheLoai;

        public NgonNguQuanLyDTO()
        {
        }

        public NgonNguQuanLyDTO(int id, string ten, int tongSachTheoTheLoai)
        {
            this.Id = id;
            this.Ten = ten;
            this.TongSachTheoTheLoai = tongSachTheoTheLoai;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int TongSachTheoTheLoai { get => tongSachTheoTheLoai; set => tongSachTheoTheLoai = value; }
    }
}
