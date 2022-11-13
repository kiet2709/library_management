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
using System.Threading;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class FrmDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        int id;
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
                dataGridViewRow.Cells[0].Value = ((DocGiaQuanLyDTO)docgias[i]).Id;
                dataGridViewRow.Cells[1].Value = ((DocGiaQuanLyDTO)docgias[i]).Mssv;
                dataGridViewRow.Cells[2].Value = ((DocGiaQuanLyDTO)docgias[i]).Khoa;
                dataGridViewRow.Cells[3].Value = ((DocGiaQuanLyDTO)docgias[i]).Ten;
                dataGridViewRow.Cells[4].Value = ((DocGiaQuanLyDTO)docgias[i]).Trangthai;
                dtgDocGia.Rows.Add(dataGridViewRow);
            }    
        }
        
        private void OpenFrmThemDocGia()
        {
            Application.Run(new FrmThemDocGia());
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThemDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void dtgDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgDocGia.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                if (e.ColumnIndex == this.edit.Index)
                {
                    this.Close();
                    Thread thread = new Thread(OpenFrmSuaDocGia);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }

            }
        }
        private void OpenFrmSuaDocGia()
        {
            Application.Run(new FrmSuaDocGia(id));
        }
    }
}
