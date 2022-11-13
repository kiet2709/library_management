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
    public partial class FrmTacGia : Form
    {
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        int idTheLoaiSelected;
        public FrmTacGia()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            ArrayList theloais = tacGiaBUS.getTacGia();
            for (int i = 0; i < theloais.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dtgTacGia);
                dr.Cells[0].Value = ((TacGiaQuanLyDTO)theloais[i]).Id;
                dr.Cells[1].Value = ((TacGiaQuanLyDTO)theloais[i]).Ten;
                dr.Cells[2].Value = ((TacGiaQuanLyDTO)theloais[i]).TongSachTheoTheLoai;
                dtgTacGia.Rows.Add(dr);
            }

        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            FrmThemTacGia frmThemTacGia = new FrmThemTacGia();
            frmThemTacGia.ShowDialog();
            dtgTacGia.Rows.Clear();
            LoadData();
        }

        private void dtgTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgTacGia.Rows[e.RowIndex];
            idTheLoaiSelected = Convert.ToInt32(row.Cells[0].Value);
            if (dtgTacGia.Columns[e.ColumnIndex].Name == "edit")
            {
                this.Close();
                Thread thread = new Thread(OpenFrmChiTietTacGia);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmChiTietTacGia()
        {
            Application.Run(new FrmChiTietTacGia(idTheLoaiSelected));
        }
    }
}
