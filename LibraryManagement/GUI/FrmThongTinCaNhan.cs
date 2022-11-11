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
    public partial class FrmThongTinCaNhan : Form
    {
        HoSoBUS hoSoBUS = new HoSoBUS();
        HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();

        public FrmThongTinCaNhan()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            if(Properties.Settings.Default.username != null)
            {
                int id = hoSoBUS.getIdByUsername(Properties.Settings.Default.username);
                hoSoQuanLyDTO = hoSoBUS.getProfileById(id);
            }
            
            this.txtHo.Text = hoSoQuanLyDTO.Ho;
            this.txtTen.Text = hoSoQuanLyDTO.Ten;
            this.txtTenDangNhap.Text = hoSoQuanLyDTO.TenDangNhap;
            this.txtDiaChi.Text = hoSoQuanLyDTO.Diachi;
            this.txtEmail.Text = hoSoQuanLyDTO.Email;
            this.txtSDT.Text = hoSoQuanLyDTO.SoDT;

            // set gioiTinh
            if (hoSoQuanLyDTO.GioiTinh == 0)
            {
                this.rbKhac.Checked = true;
            }
            else if (hoSoQuanLyDTO.GioiTinh == 1)
            {
                this.rbNam.Checked = true;
            }
            else
            {
                this.rbNu.Checked = true;
            }

            // set ngaySinh
            this.dtpNgaySinh.Value = hoSoQuanLyDTO.Ngaysinh;

            if (hoSoQuanLyDTO.Hinhanh != null && hoSoQuanLyDTO.Hinhanh != "")
            {
                pbAnh.Image = Image.FromFile(hoSoQuanLyDTO.Hinhanh);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.txtHo.Enabled = true;
            this.txtTen.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtSDT.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.rbKhac.Enabled = true;
            this.rbNam.Enabled = true;
            this.rbNu.Enabled = true;
            this.btnLuu.Visible = true;
            this.btnThemAnh.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.txtHo.Enabled = false;
            this.txtTen.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtSDT.Enabled = false;
            this.dtpNgaySinh.Enabled = false;
            this.rbKhac.Enabled = false;
            this.rbNam.Enabled = false;
            this.rbNu.Enabled = false;
            this.btnLuu.Visible = false;
            this.btnThemAnh.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
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
