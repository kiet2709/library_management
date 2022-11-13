using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibraryManagement.BUS;
using LibraryManagement.DTO;

namespace LibraryManagement.GUI
{
    public partial class FrmPhieuMuon : Form
    {
        private int idPhieuMuon;
        private DanhSachPhieuMuonDTO danhSachPhieuMuon;

        private MuonBUS muonBUS = new MuonBUS();

        public FrmPhieuMuon()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            danhSachPhieuMuon = muonBUS.getListBrrowing();
            vcg_phieuMuon = danhSachPhieuMuon.getDataSource(vcg_phieuMuon);
        }

        private void vcg_phieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPhieuMuon = Convert.ToInt32(vcg_phieuMuon.SelectedRows[0].Cells[0].Value);
            this.Close();
            Thread thread = new Thread(OpenFrmChiTietPhieuMuon);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFrmChiTietPhieuMuon()
        {
            Application.Run(new FrmChiTietPhieuMuon(idPhieuMuon, new FrmPhieuMuon()));
        }
    }
}
