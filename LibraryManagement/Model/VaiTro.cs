using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Model
{
    public class VaiTro
    {
        private int id;
        private string ten;
        private string mota;

        public VaiTro()
        {
        }

        public VaiTro(int id, string ten, string mota)
        {
            this.Id = id;
            this.Ten = ten;
            this.Mota = mota;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Mota { get => mota; set => mota = value; }
    }
}
