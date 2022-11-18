using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class DanhSachDauSachDTO
    {
        private List<DauSachDTO> dauSachDTOs;

        public List<DauSachDTO> DauSachDTOs { get => dauSachDTOs; set => dauSachDTOs = value; }
        public void add(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                PhieuMuonDTO temp = new PhieuMuonDTO();
                temp.addRow(row);
                
            }
        }
    }
}
