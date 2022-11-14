using LibraryManagement.BUS;
using LibraryManagement.DTO;
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
    public partial class FrmCapNhatTaiKhoan : Form
    {
        private HoSoBUS hoSoBUS = new HoSoBUS();
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();
        OpenFileDialog open = new OpenFileDialog();
        private Image image;

        public FrmCapNhatTaiKhoan(int profileId)
        {
            InitializeComponent();
            hoSoQuanLyDTO.Id = profileId;
            loadData(profileId);
        }

        private void loadData(int profileId)
        {
            hoSoQuanLyDTO = hoSoBUS.getProfileById(profileId);
            this.txtHo.Text = hoSoQuanLyDTO.Ho;
            this.txtTen.Text = hoSoQuanLyDTO.Ten;
            this.txtTenDangNhap.Text = hoSoQuanLyDTO.TenDangNhap;
            this.txtDiaChi.Text = hoSoQuanLyDTO.Diachi;
            this.txtEmail.Text = hoSoQuanLyDTO.Email;
            this.txtSDT.Text = hoSoQuanLyDTO.SoDT;
            this.txtLuong.Text = hoSoQuanLyDTO.Luong.ToString();
            String matKhau = hoSoBUS.getPasswordById(profileId);
            this.txtMatKhau.Text = matKhau;


            // set vai trò
            if(hoSoQuanLyDTO.VaiTro == "Quản lý")
            {
                rbQuanLy.Checked = true;
            }
            else
            {
                rbNhanVien.Checked = true;
            }

            // set trangThai
            if (hoSoQuanLyDTO.TrangThai == 1)
            {
                this.rbHoatDong.Checked = true;
            }
            else
            {
                this.rbKhongHoatDong.Checked = true;
            }

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
                using (FileStream fs = new FileStream(hoSoQuanLyDTO.Hinhanh, FileMode.Open))
                {
                    pbAnh.Image = Image.FromStream(fs);
                    fs.Close();
                }
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
            

            String imagePath = @"E:\HCMUTE\School_Project\library_management\LibraryManagement\uploads\nhanVien\" + hoSoQuanLyDTO.Id + ".png";
            hoSoQuanLyDTO.Hinhanh = imagePath;
     

            if (this.rbNhanVien.Checked)
            {
                hoSoQuanLyDTO.VaiTro = "Thủ thư";
            }
            else
            {
                hoSoQuanLyDTO.VaiTro = "Quản lý";
            }
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

            hoSoQuanLyDTO.TenDangNhap = txtTenDangNhap.Text;
            hoSoQuanLyDTO.MatKhau = txtMatKhau.Text;
            int result;
            result = hoSoBUS.updateInfo(hoSoQuanLyDTO);
           
            if(result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                if (open.FileName != null && open.FileName != "")
                {
                    
                    // delete and save again
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                        
                    }
                    image.Save(imagePath);

                    if(Properties.Settings.Default.image == "")
                    {
                        Properties.Settings.Default.image = imagePath;
                    }

                }
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmTaiKhoan);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        
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
