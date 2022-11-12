using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.Model;

namespace LibraryManagement.DTO
{
    public class DanhSachNXBDTO
    {
        private List<NhaXuatBan> listNXB = new List<NhaXuatBan>();

        public List<NhaXuatBan> ListNXB { get => listNXB; set => listNXB = value; }

        public void add(DataTable dataTable)
        {
            for(int i =0; i < dataTable.Rows.Count; i++)
            {
                NhaXuatBan temp = new NhaXuatBan();
                temp.Id = Convert.ToInt32(dataTable.Rows[i][0]);
                temp.Name = Convert.ToString(dataTable.Rows[i][1]);
                ListNXB.Add(temp);
            }
        }

        public ArrayList getDataSource()
        {
            ArrayList list = new ArrayList();
            foreach(NhaXuatBan nxb in ListNXB)
            {
                list.Add(nxb.Name);
            }
            return list;
        }

        public int index(string name)
        {
            for (int i = 0; i < listNXB.Count; i++)
            {
                if (listNXB[i].Name.CompareTo(name) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
