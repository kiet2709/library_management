using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.DTO
{
    public class DanhSachCuonSachDTO
    {
        private List<Sach> listSach = new List<Sach>();

        public List<Sach> ListSach { get => listSach; set => listSach = value; }

        public void add(DataTable dataTable)
        {
            foreach(DataRow row in dataTable.Rows)
            {
                Sach temp = new Sach();
                temp.addRow(row);
                listSach.Add(temp);
            }
        }

        public DataGridView getDataSource(DataGridView view)
        {
            for (int i = 0; i < listSach.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(view);
                dr = listSach[i].getDataSource(dr);
                view.Rows.Add(dr);
            }
            return view;
        }
    }
}
