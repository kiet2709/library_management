using LibraryManagement.BUS;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class FrmThemNhanVien : Form
    {

        private HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();
        private HoSoBUS hoSoBUS = new HoSoBUS();
        public FrmThemNhanVien()
        {
            InitializeComponent();
            this.rbNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hoSoQuanLyDTO.Ho = txtHo.Text;
            hoSoQuanLyDTO.Ten = txtTen.Text;
            hoSoQuanLyDTO.Email = txtEmail.Text;
            hoSoQuanLyDTO.TenDangNhap = txtTenDangNhap.Text;
            hoSoQuanLyDTO.Diachi = txtDiaChi.Text;
            hoSoQuanLyDTO.Hinhanh = "none";
            hoSoQuanLyDTO.SoDT = txtSDT.Text;
            hoSoQuanLyDTO.Luong = Convert.ToInt32(txtLuong.Text);
            hoSoQuanLyDTO.Ngaysinh = dtpNgaySinh.Value;
            if (rbKhac.Checked)
            {
                hoSoQuanLyDTO.GioiTinh = 0;
            }else if (rbNam.Checked)
            {
                hoSoQuanLyDTO.GioiTinh = 1;
            }
            else
            {
                hoSoQuanLyDTO.GioiTinh = 2;
            }

            hoSoQuanLyDTO.TenDangNhap = txtTenDangNhap.Text;
            hoSoQuanLyDTO.TrangThai = 1;
            hoSoQuanLyDTO.MatKhau = txtMatKhau.Text;
            int result = hoSoBUS.saveInfo(hoSoQuanLyDTO);
            if(result == 0)
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
