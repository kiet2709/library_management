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
    }
}
