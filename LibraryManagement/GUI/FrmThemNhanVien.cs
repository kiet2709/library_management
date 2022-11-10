using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Utils;
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

namespace LibraryManagement.GUI
{
    public partial class FrmThemNhanVien : Form
    {

        private HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();
        private HoSoBUS hoSoBUS = new HoSoBUS();
        OpenFileDialog open = new OpenFileDialog();
        private Image image;
        public FrmThemNhanVien()
        {
            InitializeComponent();
            this.rbNam.Checked = true;
            this.rbNhanVien.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hoSoQuanLyDTO.Ho = txtHo.Text;
            hoSoQuanLyDTO.Ten = txtTen.Text;
            hoSoQuanLyDTO.Email = txtEmail.Text;
            hoSoQuanLyDTO.TenDangNhap = txtTenDangNhap.Text;
            hoSoQuanLyDTO.Diachi = txtDiaChi.Text;
            hoSoQuanLyDTO.Hinhanh = "";
            hoSoQuanLyDTO.SoDT = txtSDT.Text;
            hoSoQuanLyDTO.Luong = Convert.ToInt32(txtLuong.Text);
            hoSoQuanLyDTO.Ngaysinh = dtpNgaySinh.Value;

            if (rbQuanLy.Checked)
            {
                hoSoQuanLyDTO.VaiTro = "Quản lý";
            }
            else
            {
                hoSoQuanLyDTO.VaiTro = "Thủ thư";
            }

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
            else
            {
                if (open.FileName != null)
                {
                    String imageName = Path.GetFileName(open.FileName);
                    String imagePath = @"E:\HCMUTE\School_Project\library_management\LibraryManagement\uploads\nhanVien\" + result + ".png";
                    image.Save(imagePath);
                    hoSoQuanLyDTO.Hinhanh = imagePath;
                    hoSoBUS.saveImage(hoSoQuanLyDTO.Hinhanh, result);
                }

                MessageBox.Show("Thêm thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmTaiKhoan);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

           

            
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

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png)|*.jpg;*.jpeg;.*.gif;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(open.FileName);
                pbAnh.Image = image;
            }
        }
    }
}
