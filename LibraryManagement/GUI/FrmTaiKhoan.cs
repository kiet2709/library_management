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
    public partial class FrmTaiKhoan : Form
    {
        private HoSoBUS hoSoBUS = new HoSoBUS();
        private HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();

        public FrmTaiKhoan()
        {
            InitializeComponent();
            loadData();


        }

        private void loadData()
        {

            if (Properties.Settings.Default.role != null
             && Properties.Settings.Default.role != "" && Properties.Settings.Default.role == "Thủ thư")
            {
               MessageBox.Show("Bạn không có quyền truy cập vào mục này");
               this.Close();
               Thread thread = new Thread(OpenFrmSach);
               thread.SetApartmentState(ApartmentState.STA);
               thread.Start();
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


            this.dtgvHoSo.Columns[8].FillWeight = 2;
            this.dtgvHoSo.Columns[9].FillWeight = 2;
            ArrayList hoso = hoSoBUS.getAllProfile();
            if (hoso.Count <= 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào đây");
                this.Close();
            }
            for (int i = 0; i < hoso.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(this.dtgvHoSo);
                dr.Cells[0].Value = ((HoSoQuanLyDTO) hoso[i]).Id;
                dr.Cells[1].Value = ((HoSoQuanLyDTO)hoso[i]).VaiTro.Contains("Quản lý")?"Quản lý":"Thủ thư";    
                dr.Cells[2].Value = ((HoSoQuanLyDTO) hoso[i]).Ten;
                dr.Cells[3].Value = ((HoSoQuanLyDTO) hoso[i]).Ho;
                dr.Cells[4].Value = ((HoSoQuanLyDTO) hoso[i]).Email;
                dr.Cells[5].Value = ((HoSoQuanLyDTO) hoso[i]).SoDT;
                if (((HoSoQuanLyDTO)hoso[i]).GioiTinh == 0)
                {
                    dr.Cells[6].Value = "Khác";
                }
                else if (((HoSoQuanLyDTO)hoso[i]).GioiTinh == 1)
                {
                    dr.Cells[6].Value = "Nam";
                }
                else
                {
                    dr.Cells[6].Value = "Nữ";
                }
                dr.Cells[7].Value = ((HoSoQuanLyDTO) hoso[i]).Ngaysinh.ToShortDateString();
                dr.Cells[8].Value = ((HoSoQuanLyDTO) hoso[i]).Luong + " VNĐ";
                if (((HoSoQuanLyDTO)hoso[i]).TrangThai == 1)
                {
                    dr.Cells[9].Value = "Hoạt động";
                }
                else
                {
                    dr.Cells[9].Value = "Không hoạt động";
                }
                
               
                dtgvHoSo.Rows.Add(dr);
            }
        }
    

        private void dtgvHoSo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHoSo.Rows[e.RowIndex];
                hoSoQuanLyDTO.Id = Convert.ToInt32(row.Cells[0].Value);
                if (e.ColumnIndex == this.edit.Index)
                {
                    this.Close();
                    Thread thread = new Thread(OpenFrmCapNhatTaiKhoan);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                
            }
        }

        private void OpenFrmCapNhatTaiKhoan()
        {
            Application.Run(new FrmCapNhatTaiKhoan(hoSoQuanLyDTO.Id));
        }

        private void OpenFrmThemTaiKhoan()
        {
            Application.Run(new FrmThemNhanVien());
        }

      

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThemTaiKhoan);
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
        private void OpenFrmTaiKhoan()
        {
            Application.Run(new FrmTaiKhoan());
        }
        private void OpenFrmPhieuMuon()
        {
            Application.Run(new FrmPhieuMuon());
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

        private void panel3_Click(object sender, EventArgs e)
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

        private void btnFormDocGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void lblFormSach_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
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

        private void lblNgonNgu_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNgonNgu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblFormNhaXuatBan_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNhaXuatBan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblTacGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTacGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTaiKhoan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblDocGia_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void lblPhieuMuon_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmPhieuMuon);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
