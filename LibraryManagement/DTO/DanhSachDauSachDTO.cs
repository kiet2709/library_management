using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.DTO
{
    public class DanhSachDauSachDTO
    {
        private List<DauSachDTO> listDauSach = new List<DauSachDTO>();

        public List<DauSachDTO> ListDauSach { get => listDauSach; set => listDauSach = value; }
        public void add(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                DauSachDTO temp = new DauSachDTO();
                temp.addRow(row);
                listDauSach.Add(temp);
            }

        }

        public ArrayList getDataSource()
        {
            ArrayList list = new ArrayList();
            foreach(DauSachDTO dauSach in listDauSach)
            {
                list.Add(dauSach.Name);
            }
            return list;
        }
    }
}
