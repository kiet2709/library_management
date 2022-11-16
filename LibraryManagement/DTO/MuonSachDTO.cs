using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.DTO
{
    public class MuonSachDTO
    {
        private int id;
        private string name;
        private int trangthai;
        private string ghiChu;
        private int daMuon;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int DaMuon { get => daMuon; set => daMuon = value; }

        public void addRow(DataRow row)
        {
            id = Convert.ToInt32(row[0]);
            name = Convert.ToString(row[1]);
            trangthai = Convert.ToInt32(row[2]);
            ghiChu = Convert.ToString(row[3]);
            daMuon = Convert.ToInt32(row[4]);
        }

        public DataGridViewRow getDataSource(DataGridViewRow temp, int index)
        {
            DataGridViewRow dr = (DataGridViewRow) temp.Clone();
            dr.Cells[0].Value = index;
            dr.Cells[1].Value = id;
            dr.Cells[2].Value = name;
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dr.Cells[3];
            if (trangthai == 1)
            {
                chk.Value = true;
                
            }
            else
            {
                chk.Value = false;
            }
            dr.Cells[4].Value = ghiChu;
            return dr;
        }
    }
}
