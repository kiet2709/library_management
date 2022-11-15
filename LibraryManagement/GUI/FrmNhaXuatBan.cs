using LibraryManagement.BUS;
using LibraryManagement.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (Properties.Settings.Default.role != null
             && Properties.Settings.Default.role != "" && Properties.Settings.Default.role == "Thủ thư")
            {
                this.pbUser.Enabled = false;
                this.btnFormTaiKhoan.Enabled = false;
            }

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
        private void OpenFrmThongTinCaNhan()
        {
            Application.Run(new FrmThongTinCaNhan());
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
        private void OpenFrmTaiKhoan()
        {
            Application.Run(new FrmTaiKhoan());
        }
        private void OpenFrmDocGia()
        {
            Application.Run(new FrmDocGia());
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

        private void btnFormNhaXuatBan_Click(object sender, EventArgs e)
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

        private void btnFormDocGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFormTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTaiKhoan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFormPhieuMuon_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmPhieuMuon);
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
            FrmThongTinCaNhan frmThongTinCaNhan = new FrmThongTinCaNhan();
            frmThongTinCaNhan.ShowDialog();
        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
