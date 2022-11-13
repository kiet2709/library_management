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
    public partial class FrmChiTietPhieuMuon : Form
    {
        private int id;
        private Form backFrm;
        private PhieuMuonDTO phieuMuon;
        private DanhSachSachMuonDTO danhSachSachMuon;

        private MuonBUS muonBUS = new MuonBUS();
        public FrmChiTietPhieuMuon(int id, Form backFrm)
        {
            this.id = id;
            this.backFrm = backFrm;
            InitializeComponent();
            loadData();
        }

        private void FrmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            phieuMuon = muonBUS.getBrrowing(id);
            txt_sinhVien.Text = phieuMuon.SinhVien;
            txt_mssv.Text = phieuMuon.Mssv;
            txt_khoa.Text = phieuMuon.Khoa;
            txt_thuThu.Text = phieuMuon.ThuThu;
            txt_tienPhat.Text = phieuMuon.TienPhat.ToString();
            dtp_hanTra.Value = phieuMuon.HanTra;
            dtp_ngayMuon.Value = phieuMuon.NgayMuon;
            dtp_ngayTra.Value = phieuMuon.NgayTra;

            danhSachSachMuon = muonBUS.getBrrowingBooks(id);
            vcg_phieuMuon.Rows.Clear();
            vcg_phieuMuon = danhSachSachMuon.getDataSource(vcg_phieuMuon);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenBackFrm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenBackFrm()
        {
            Application.Run(backFrm);
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                phieuMuon.NgayTra = dtp_ngayTra.Value;
                phieuMuon.TienPhat = Convert.ToInt32(txt_tienPhat.Text);

                for(int i=0; i< vcg_phieuMuon.Rows.Count; i++)
                {
                    danhSachSachMuon.ListMuonSach[i].Trangthai = Convert.ToBoolean(vcg_phieuMuon.Rows[i].Cells[3].Value) ? 1 : 0;
                    danhSachSachMuon.ListMuonSach[i].GhiChu = Convert.ToString(vcg_phieuMuon.Rows[i].Cells[4].Value);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!!!");
            }

            int result = muonBUS.updateBrrowingDetail(id, phieuMuon, danhSachSachMuon);
            if (result == 1)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            loadData();
        }
    }
}
