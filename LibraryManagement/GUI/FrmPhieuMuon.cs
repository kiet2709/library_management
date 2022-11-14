using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (Properties.Settings.Default.image != null
               && Properties.Settings.Default.image != "")
            {
                using (FileStream fs = new FileStream(Properties.Settings.Default.image, FileMode.Open))
                {
                    pbAnh.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }

            if (Properties.Settings.Default.username != null
                && Properties.Settings.Default.username != "")
            {
                this.lblTenDangNhap.Text = Properties.Settings.Default.username;
            }
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

        private void OpenFrmSach()
        {
            Application.Run(new FrmSach());
        }

        private void OpenFrmTheLoai()
        {
            Application.Run(new FrmTheLoai());
        }

        private void OpenFrmNgonNgu()
        {
            Application.Run(new FrmNgonNgu());
        }

        private void OpenFrmNhaXuatBan()
        {
            Application.Run(new FrmNhaXuatBan());
        }
        private void OpenFrmTacGia()
        {
            Application.Run(new FrmTacGia());
        }

        private void OpenFrmPhieuMuon()
        {
            Application.Run(new FrmPhieuMuon());
        }

        private void OpenFrmDocGia()
        {
            Application.Run(new FrmDocGia());
        }

        private void OpenFrmTaiKhoan()
        {
            Application.Run(new FrmTaiKhoan());
        }

        private void btnFormSach_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFormTheLoai_Click(object sender, EventArgs e)
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

        private void panel17_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNhaXuatBan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTacGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTaiKhoan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.image = "";
            this.Close();
            Thread thread = new Thread(OpenFrmDangNhap);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFrmDangNhap()
        {
            Application.Run(new FrmDangNhap());
        }

        private void pbAnh_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThongTinCaNhan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFrmThongTinCaNhan()
        {
            Application.Run(new FrmThongTinCaNhan());
        }
    }
}
