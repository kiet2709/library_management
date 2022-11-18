using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.Model
{
    public class Sach
    {
        private int id;
        private int trangThai;
        private string viTri;

        public int Id { get => id; set => id = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string ViTri { get => viTri; set => viTri = value; }

        public void addRow(DataRow row)
        {
            id = Convert.ToInt32(row[0]);
            trangThai = Convert.ToInt32(row[1]);
            viTri = Convert.ToString(row[2]);
        }

        public DataGridViewRow getDataSource(DataGridViewRow dr)
        {
            dr.Cells[0].Value = id;
            DataGridViewComboBoxCell tbc = (DataGridViewComboBoxCell)dr.Cells[1];
            string[] list = { "Đã mất", "Đã mượn", "Chưa mượn" };
            ArrayList listTrangThai = new ArrayList();
            listTrangThai.AddRange(list);
            tbc.DataSource = listTrangThai;
            tbc.Value = trangThai + 1; 
            dr.Cells[2].Value = viTri.ToString();
            return dr;
        }
    }
}
