using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    class DocGiaQuanLyDTO
    {
        private int id;
        private string mssv;
        private string khoa;
        private string ten;
        private string trangthai;

        public DocGiaQuanLyDTO(int id, string mssv, string khoa, string ten, string trangthai)
        {
            this.id = id;
            this.mssv = mssv;
            this.khoa = khoa;
            this.ten = ten;
            this.trangthai = trangthai;
        }

        public DocGiaQuanLyDTO()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
