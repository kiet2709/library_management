using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Model;
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
    public partial class FrmTheLoai : Form
    {
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        int idTheLoaiSelected;
        public FrmTheLoai()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            ArrayList theloais = theLoaiBUS.getTheLoai();
            for (int i = 0; i < theloais.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dtgTheLoai);
                dr.Cells[0].Value = ((TheLoaiQuanLyDTO)theloais[i]).Id;
                dr.Cells[1].Value = ((TheLoaiQuanLyDTO)theloais[i]).Ten;
                dr.Cells[2].Value = ((TheLoaiQuanLyDTO)theloais[i]).TongSachTheoTheLoai;
                dtgTheLoai.Rows.Add(dr);
            }
            
        }

        private void btnFormSach_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmSach(object obj)
        {
            Application.Run(new FrmSach());

        }

        private void lblFormSach_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmTheLoai(object obj)
        {
            Application.Run(new FrmTheLoai());

        }

        private void btnFormTheLoai_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTheLoai);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblFormTheLoai_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTheLoai);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            FrmThemTheLoai frmThemTheLoai = new FrmThemTheLoai();
            frmThemTheLoai.ShowDialog();
            dtgTheLoai.Rows.Clear();
            LoadData();
        }

        private void dtgTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgTheLoai.Rows[e.RowIndex];
            idTheLoaiSelected = Convert.ToInt32(row.Cells[0].Value);
            if (dtgTheLoai.Columns[e.ColumnIndex].Name == "delete")
            {
                
                theLoaiBUS.delete(idTheLoaiSelected);
                dtgTheLoai.Rows.Clear();
                LoadData(); 
            }
            if (dtgTheLoai.Columns[e.ColumnIndex].Name == "edit")
            {
                this.Close();
                Thread thread = new Thread(OpenFrmChiTietTheLoai);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmChiTietTheLoai()
        {
            Application.Run(new FrmChiTietTheLoai(idTheLoaiSelected));
        }
    }
}
