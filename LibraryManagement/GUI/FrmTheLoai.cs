using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Model;
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
    

        private void lblFormSach_Click(object sender, EventArgs e)
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

        void OpenFrmChiTietTheLoai()
        {
            Application.Run(new FrmChiTietTheLoai(idTheLoaiSelected));
        }

        private void btnFormNgonNgu_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNgonNgu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void tbnFormNhaXuatBan_Click(object sender, EventArgs e)
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
            this.Close();
            Thread thread = new Thread(OpenFrmThongTinCaNhan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
