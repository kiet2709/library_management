using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.DTO
{
    public class DanhSachPhieuMuonDTO
    {
        private List<PhieuMuonDTO> listPhieuMuon = new List<PhieuMuonDTO>();

        public List<PhieuMuonDTO> ListPhieuMuon { get => listPhieuMuon; set => listPhieuMuon = value; }

        public void add(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                PhieuMuonDTO temp = new PhieuMuonDTO();
                temp.addRow(row);
                listPhieuMuon.Add(temp);
            }
        }

        public DataGridView getDataSource(DataGridView view)
        {
            for (int i = 0; i < listPhieuMuon.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(view);
                dr = listPhieuMuon[i].getDataSource(dr);
                view.Rows.Add(dr);
            }
            return view;
        }
    }
}
