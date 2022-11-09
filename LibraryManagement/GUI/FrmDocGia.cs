using LibraryManagement.BUS;
using LibraryManagement.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class FrmDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        public FrmDocGia()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData ()
        {
            ArrayList docgias = docGiaBUS.getDocGia();
            for (int i =0; i<docgias.Count;i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(dtgDocGia);
                dataGridViewRow.Cells[0].Value = ((DocGiaDTO)docgias[i]).Id;
                dataGridViewRow.Cells[1].Value = ((DocGiaDTO)docgias[i]).Mssv;
                dataGridViewRow.Cells[2].Value = ((DocGiaDTO)docgias[i]).Khoa;
                dataGridViewRow.Cells[3].Value = ((DocGiaDTO)docgias[i]).Ten;
                dataGridViewRow.Cells[4].Value = ((DocGiaDTO)docgias[i]).Trangthai;
                dtgDocGia.Rows.Add(dataGridViewRow);
            }    
        }
        
    }
}
