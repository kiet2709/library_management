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
    public partial class FrmNgonNgu : Form
    {
        NgonNguBUS ngonNguBUS = new NgonNguBUS();
        int idTheLoaiSelected;
        public FrmNgonNgu()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            ArrayList theloais = ngonNguBUS.getNgonNgu();
            for (int i = 0; i < theloais.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dtgNgonNgu);
                dr.Cells[0].Value = ((NgonNguQuanLyDTO)theloais[i]).Id;
                dr.Cells[1].Value = ((NgonNguQuanLyDTO)theloais[i]).Ten;
                dr.Cells[2].Value = ((NgonNguQuanLyDTO)theloais[i]).TongSachTheoTheLoai;
                dtgNgonNgu.Rows.Add(dr);
            }

        }

        private void dtgNgonNgu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgNgonNgu.Rows[e.RowIndex];
            idTheLoaiSelected = Convert.ToInt32(row.Cells[0].Value);
            if (dtgNgonNgu.Columns[e.ColumnIndex].Name == "delete")
            {

                ngonNguBUS.delete(idTheLoaiSelected);
                dtgNgonNgu.Rows.Clear();
                LoadData();
            }
            if (dtgNgonNgu.Columns[e.ColumnIndex].Name == "edit")
            {
                this.Close();
                Thread thread = new Thread(OpenFrmChiTietNgonNgu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void btnNgonNgu_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNgonNgu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmNgonNgu(object obj)
        {
            Application.Run(new FrmNgonNgu());

        }
        void OpenFrmChiTietNgonNgu(object obj)
        {
            Application.Run(new FrmChiTietNgonNgu(idTheLoaiSelected));

        }

        private void lblNgonNgu_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNgonNgu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnThemNgonNgu_Click(object sender, EventArgs e)
        {
            FrmThemNgonNgu frmThemNgonNgu = new FrmThemNgonNgu();
            frmThemNgonNgu.ShowDialog();
            dtgNgonNgu.Rows.Clear();
            LoadData();
        }
    }
}
