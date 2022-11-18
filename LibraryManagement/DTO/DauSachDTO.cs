using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class DauSachDTO
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public void addRow(DataRow row)
        {
            id = Convert.ToInt32(row[0]);
            name = Convert.ToString(row[1]);
        }
    }
}
