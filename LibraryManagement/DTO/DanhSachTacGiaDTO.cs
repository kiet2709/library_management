using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.Model;

namespace LibraryManagement.DTO
{
    public class DanhSachTacGiaDTO
    {
        private List<TacGia> listTacGia = new List<TacGia>();

        public List<TacGia> ListTacGia { get => listTacGia; set => listTacGia = value; }

        public void add(DataTable dataTable)
        {
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                TacGia temp = new TacGia();
                temp.Id = Convert.ToInt32(dataTable.Rows[i][0]);
                temp.Name = Convert.ToString(dataTable.Rows[i][1]);
                listTacGia.Add(temp);
            }
        }

        public ArrayList getDataSource()
        {
            ArrayList list = new ArrayList();
            foreach(TacGia tacGia in listTacGia)
            {
                list.Add(tacGia.Name);
            }
            return list;
        }

        public string toString()
        {
            string str = "";
            foreach (TacGia tacGia in listTacGia)
            {
                str += tacGia.Name + ", ";
            }
            if (str.Length < 2) return str;
            str = str.Remove(str.Length - 2, 2);

            return str;
        }

        public DanhSachTacGiaDTO OnlyThere(DanhSachTacGiaDTO other)
        {
            DanhSachTacGiaDTO list = new DanhSachTacGiaDTO();
            foreach(TacGia tacGia in listTacGia)
            {
                if(other.ListTacGia.Contains(tacGia) == false)
                {
                    list.listTacGia.Add(tacGia);
                }
            }
            return list;
        }

        public bool nameInList(string name)
        {
            foreach(TacGia tacGia in listTacGia)
            {
                if(tacGia.Name.CompareTo(name) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
