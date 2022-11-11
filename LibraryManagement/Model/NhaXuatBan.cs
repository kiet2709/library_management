using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.Model
{
    public class NhaXuatBan
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public NhaXuatBan(string name)
        {
            this.name = name;
        }

        public NhaXuatBan() { }
    }
}
