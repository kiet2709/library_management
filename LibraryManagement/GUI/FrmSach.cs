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
    public partial class FrmSach : Form
    {
        SachBUS sachBUS = new SachBUS();
        private int bookId;
        public FrmSach()
        {
            InitializeComponent();
            loadFormSach();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {

        }
        void loadFormSach()
        {
            ArrayList sachs = sachBUS.getBook();
            //Object[] sachArrs = (SachQuanLyDTO[])sachs.ToArray();
            for (int i=0; i< sachs.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dtgSach);
                dr.Cells[0].Value = ((SachQuanLyDTO)sachs[i]).Id;
                dr.Cells[1].Value = ((SachQuanLyDTO)sachs[i]).TuaSach;
                dr.Cells[2].Value = ((SachQuanLyDTO)sachs[i]).SoLuongTrongKho;
                dr.Cells[3].Value = ((SachQuanLyDTO)sachs[i]).TheLoai;
                dr.Cells[4].Value = ((SachQuanLyDTO)sachs[i]).Gia;
                dtgSach.Rows.Add(dr);
            }
        }

        private void btnFormSach_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFrmSach()
        {
            Application.Run(new FrmSach());
        }

        private void OpenFrmChiTietSach()
        {
            Application.Run(new FrmChiTietDauSach(bookId, new FrmSach()));

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

        private void lblNgonNgu_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNgonNgu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFormNhaXuatBan_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNhaXuatBan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmNhaXuatBan(object obj)
        {
            Application.Run(new FrmNhaXuatBan());

        }

        private void lblFormNhaXuatBan_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNhaXuatBan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFormTacGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTacGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmTacGia()
        {
            Application.Run(new FrmTacGia());
        }

        private void lblTacGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTacGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void dtgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookId = Convert.ToInt32(dtgSach.SelectedRows[0].Cells[0].Value);
            this.Close();
            Thread thread = new Thread(OpenFrmChiTietSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
