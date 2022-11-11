using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.Model;

namespace LibraryManagement.DTO
{
    public class DanhSachNgonNguDTO
    {
        private List<NgonNgu> listNgonNgu = new List<NgonNgu>();

        public List<NgonNgu> ListNgonNgu { get => listNgonNgu; set => listNgonNgu = value; }

        public void add(DataTable dataTable)
        {
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                NgonNgu temp = new NgonNgu();
                temp.Id = Convert.ToInt32(dataTable.Rows[i][0]);
                temp.Name = Convert.ToString(dataTable.Rows[i][0]);
                listNgonNgu.Add(temp);
            }
        }

        public ArrayList getDataSource()
        {
            ArrayList list = new ArrayList();
            foreach(NgonNgu ngonNgu in listNgonNgu)
            {
                list.Add(ngonNgu.Name);
            }
            return list;
        }
    }
}
