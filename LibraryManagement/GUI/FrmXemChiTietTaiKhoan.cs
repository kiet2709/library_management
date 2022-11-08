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
    public partial class FrmXemChiTietTaiKhoan : Form
    {
        private HoSoBUS hoSoBUS = new HoSoBUS();

        public FrmXemChiTietTaiKhoan(int profileId)
        {
            InitializeComponent();
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
                this.txtTrangThai.Text = "Hoạt động";
            }
            else
            {
                this.txtTrangThai.Text = "Không hoạt động";
            }
            
            // set gioiTinh
            if(hoSo.GioiTinh == 0)
            {
                this.rbKhac.Checked = true;
            }else if(hoSo.GioiTinh == 1)
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
    }
}
