using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.Model;

namespace LibraryManagement.DTO
{
    public class DanhSachTheLoaiDTO
    {
        private List<TheLoai> listTheLoai = new List<TheLoai>();

        public List<TheLoai> ListTheLoai { get => listTheLoai; set => listTheLoai = value; }

        public void add(DataTable dataTable)
        {
            for(int i=0; i< dataTable.Rows.Count; i++)
            {
                TheLoai temp = new TheLoai();
                temp.Id = Convert.ToInt32(dataTable.Rows[i][0]);
                temp.Name = Convert.ToString(dataTable.Rows[i][1]);
                listTheLoai.Add(temp);
            }
        }

        public ArrayList getDataSource()
        {
            ArrayList list = new ArrayList();
            foreach(TheLoai theLoai in listTheLoai)
            {
                list.Add(theLoai.Name);
            }
            return list;
        }

        public int index(string name)
        {
            for (int i = 0; i < listTheLoai.Count; i++)
            {
                if (listTheLoai[i].Name.CompareTo(name) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
