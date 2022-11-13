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
    public partial class FrmNhaXuatBan : Form
    {
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        int idTheLoaiSelected;
        public FrmNhaXuatBan()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            ArrayList theloais = nhaXuatBanBUS.getNhaXuatBan();
            for (int i = 0; i < theloais.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dtgNhaXuatBan);
                dr.Cells[0].Value = ((NhaXuatBanQuanLyDTO)theloais[i]).Id;
                dr.Cells[1].Value = ((NhaXuatBanQuanLyDTO)theloais[i]).Ten;
                dr.Cells[2].Value = ((NhaXuatBanQuanLyDTO)theloais[i]).TongSachTheoTheLoai;
                dtgNhaXuatBan.Rows.Add(dr);
            }

        }

        private void btnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            FrmThemNhaXuatBan frmThemNhaXuatBan = new FrmThemNhaXuatBan();
            frmThemNhaXuatBan.ShowDialog();
            dtgNhaXuatBan.Rows.Clear();
            LoadData();
        }

        private void dtgNhaXuatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgNhaXuatBan.Rows[e.RowIndex];
            idTheLoaiSelected = Convert.ToInt32(row.Cells[0].Value);
            if (dtgNhaXuatBan.Columns[e.ColumnIndex].Name == "delete")
            {

                nhaXuatBanBUS.delete(idTheLoaiSelected);
                dtgNhaXuatBan.Rows.Clear();
                LoadData();
            }
            if (dtgNhaXuatBan.Columns[e.ColumnIndex].Name == "edit")
            {
                this.Close();
                Thread thread = new Thread(OpenFrmChiTietNhaXuatBan);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmChiTietNhaXuatBan()
        {
            Application.Run(new FrmChiTietNhaXuatBan(idTheLoaiSelected));
        }
    }
}
