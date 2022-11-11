using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class TheLoaiQuanLyDTO
    {
        private int id;
        private string ten;
        private int tongSachTheoTheLoai;

        public TheLoaiQuanLyDTO()
        {
        }

        public TheLoaiQuanLyDTO(int id, string ten, int tongSachTheoTheLoai)
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
