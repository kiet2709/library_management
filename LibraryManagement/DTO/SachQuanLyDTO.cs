using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    internal class SachQuanLyDTO
    {
        private int id;
        private string tuaSach;
        private int soLuongTrongKho;
        private string theLoai;
        private int gia;

        public SachQuanLyDTO()
        {
        }

        public SachQuanLyDTO(int id, string tuaSach, int soLuongTrongKho, string theLoai, int gia)
        {
            this.Id = id;
            this.TuaSach = tuaSach;
            this.SoLuongTrongKho = soLuongTrongKho;
            this.TheLoai = theLoai;
            this.Gia = gia;
        }

        public int Id { get => id; set => id = value; }
        public string TuaSach { get => tuaSach; set => tuaSach = value; }
        public int SoLuongTrongKho { get => soLuongTrongKho; set => soLuongTrongKho = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public int Gia { get => gia; set => gia = value; }
    }
}
