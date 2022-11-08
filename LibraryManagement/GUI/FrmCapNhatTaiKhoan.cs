using LibraryManagement.BUS;
using LibraryManagement.DTO;
using System;
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
    public partial class FrmCapNhatTaiKhoan : Form
    {
        private HoSoBUS hoSoBUS = new HoSoBUS();
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();

        public FrmCapNhatTaiKhoan(int profileId)
        {
            InitializeComponent();
            hoSoQuanLyDTO.Id = profileId;
            loadData(profileId);
        }

        private void loadData(int profileId)
        {
            HoSoQuanLyDTO hoSo = hoSoBUS.getProfileById(profileId);
            this.txtHo.Text = hoSo.Ho;
            this.txtTen.Text = hoSo.Ten;
            this.txtTenDangNhap.Text = hoSo.TenDangNhap;
            this.txtDiaChi.Text = hoSo.Diachi;
            this.txtEmail.Text = hoSo.Email;
            this.txtSDT.Text = hoSo.SoDT;
            this.txtLuong.Text = hoSo.Luong.ToString();
            String matKhau = hoSoBUS.getPasswordById(profileId);
            this.txtMatKhau.Text = matKhau;


            // set trangThai
            if (hoSo.TrangThai == 1)
            {
                this.rbHoatDong.Checked = true;
            }
            else
            {
                this.rbKhongHoatDong.Checked = true;
            }

            // set gioiTinh
            if (hoSo.GioiTinh == 0)
            {
                this.rbKhac.Checked = true;
            }
            else if (hoSo.GioiTinh == 1)
            {
                this.rbNam.Checked = true;
            }
            else
            {
                this.rbNu.Checked = true;
            }

            // set ngaySinh
            this.dtpNgaySinh.Value = hoSo.Ngaysinh;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTaiKhoan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFrmTaiKhoan()
        {
            Application.Run(new FrmTaiKhoan());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hoSoQuanLyDTO.Ten = this.txtTen.Text;
            hoSoQuanLyDTO.Ho = this.txtHo.Text;
            hoSoQuanLyDTO.Email = this.txtEmail.Text;
            hoSoQuanLyDTO.TenDangNhap = this.txtTenDangNhap.Text;
            hoSoQuanLyDTO.Diachi = this.txtDiaChi.Text;
            hoSoQuanLyDTO.SoDT = this.txtSDT.Text;
            hoSoQuanLyDTO.Ngaysinh = this.dtpNgaySinh.Value;
            hoSoQuanLyDTO.Luong = Convert.ToInt32(this.txtLuong.Text);
            hoSoQuanLyDTO.Hinhanh = "none";
            if (this.rbNam.Checked)
            {
                hoSoQuanLyDTO.GioiTinh = 1;
            }
            else if(this.rbNu.Checked)
            {
                hoSoQuanLyDTO.GioiTinh = 2;
            }
            else
            {
                hoSoQuanLyDTO.GioiTinh = 0;
            }

            if(this.rbHoatDong.Checked)
            {
                hoSoQuanLyDTO.TrangThai = 1;
            }
            else
            {
                hoSoQuanLyDTO.TrangThai = 0;
            }


            int error = 0;
            error = hoSoBUS.updateProfileById(hoSoQuanLyDTO);

            error = nhanVienBUS.updatePasswordById(hoSoQuanLyDTO.Id, this.txtMatKhau.Text);
       
            if(error == 1)
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmTaiKhoan);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        
        }

        private void FrmCapNhatTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
