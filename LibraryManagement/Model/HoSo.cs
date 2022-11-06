using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement.Model
{
    public class HoSo
    {
        private int id;
        private string ten;
        private string ho;
        private string diachi;
        private string soDT;
        private string hinhanh;
        private string email;
        private DateTime ngaysinh;
        private int luong;

        public HoSo()
        {
        }

        public HoSo(int id, string ten, string ho, string diachi, string soDT, string hinhanh, string email, DateTime ngaysinh, int luong)
        {
            this.Id = id;
            this.Ten = ten;
            this.Ho = ho;
            this.Diachi = diachi;
            this.SoDT = soDT;
            this.Hinhanh = hinhanh;
            this.Email = email;
            this.Ngaysinh = ngaysinh;
            this.Luong = luong;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int Luong { get => luong; set => luong = value; }
    }
}
