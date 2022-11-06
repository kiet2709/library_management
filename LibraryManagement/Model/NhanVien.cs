using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Model
{
    public class NhanVien
    {
        private int id;
        private string tenDangNhap;
        private string matkhau;
        private string trangthai;
        private string maHoSo;

        public NhanVien()
        {
        }

        public NhanVien(int id, string tenDangNhap, string matkhau, string trangthai, string maHoSo)
        {
            this.Id = id;
            this.TenDangNhap = tenDangNhap;
            this.Matkhau = matkhau;
            this.Trangthai = trangthai;
            this.MaHoSo = maHoSo;
        }

        public int Id { get => id; set => id = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public string MaHoSo { get => maHoSo; set => maHoSo = value; }
    }
}
