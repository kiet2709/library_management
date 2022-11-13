using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.DTO
{
    public class DanhSachSachMuonDTO
    {
        private List<MuonSachDTO> listMuonSach = new List<MuonSachDTO>();

        public List<MuonSachDTO> ListMuonSach { get => listMuonSach; set => listMuonSach = value; }

        public void add(DataTable dataTable)
        {
            foreach(DataRow row in dataTable.Rows)
            {
                MuonSachDTO temp = new MuonSachDTO();
                temp.addRow(row);
                listMuonSach.Add(temp);
            }
        }

        public DataGridView getDataSource(DataGridView viewMuon)
        {
            for(int i=0; i<listMuonSach.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(viewMuon);
                dr=listMuonSach[i].getDataSource(dr, i);
                viewMuon.Rows.Add(dr);
            }
            return viewMuon;
        }
    }
}
