using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Model
{
    public class TheLoai
    {
        private int id;
        private string ten;

        public TheLoai()
        {
        }

        public TheLoai(int id, string ten)
        {
            this.Id = id;
            this.Ten = ten;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
    }
}
