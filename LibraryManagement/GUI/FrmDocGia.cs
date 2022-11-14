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
    public partial class FrmDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        int id;
        public FrmDocGia()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData ()
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
            ArrayList docgias = docGiaBUS.getDocGia();
            for (int i =0; i<docgias.Count;i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(dtgDocGia);
                dataGridViewRow.Cells[0].Value = ((DocGiaQuanLyDTO)docgias[i]).Id;
                dataGridViewRow.Cells[1].Value = ((DocGiaQuanLyDTO)docgias[i]).Mssv;
                dataGridViewRow.Cells[2].Value = ((DocGiaQuanLyDTO)docgias[i]).Khoa;
                dataGridViewRow.Cells[3].Value = ((DocGiaQuanLyDTO)docgias[i]).Ten;
                dataGridViewRow.Cells[4].Value = ((DocGiaQuanLyDTO)docgias[i]).Trangthai;
                dtgDocGia.Rows.Add(dataGridViewRow);
            }    
        }
        
        private void OpenFrmThemDocGia()
        {
            Application.Run(new FrmThemDocGia());
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThemDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void dtgDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgDocGia.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                if (e.ColumnIndex == this.edit.Index)
                {
                    this.Close();
                    Thread thread = new Thread(OpenFrmSuaDocGia);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }

            }
        }
        private void OpenFrmSuaDocGia()
        {
            Application.Run(new FrmSuaDocGia(id));
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

   

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmPhieuMuon);
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
        private void OpenFrmDangNhap()
        {
            Application.Run(new FrmDangNhap());
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

        private void pbAnh_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThongTinCaNhan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
