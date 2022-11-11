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
    public partial class FrmThongTinCaNhan : Form
    {
        HoSoBUS hoSoBUS = new HoSoBUS();
        HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();
        OpenFileDialog open = new OpenFileDialog();
        private Image image;
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
                using (FileStream fs = new FileStream(hoSoQuanLyDTO.Hinhanh, FileMode.Open))
                {
                    pbAnh.Image = Image.FromStream(fs);
                    fs.Close();
                }
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

            hoSoQuanLyDTO.Ten = this.txtTen.Text;
            hoSoQuanLyDTO.Ho = this.txtHo.Text;
            hoSoQuanLyDTO.Email = this.txtEmail.Text;
            hoSoQuanLyDTO.TenDangNhap = this.txtTenDangNhap.Text;
            hoSoQuanLyDTO.Diachi = this.txtDiaChi.Text;
            hoSoQuanLyDTO.SoDT = this.txtSDT.Text;
            hoSoQuanLyDTO.Ngaysinh = this.dtpNgaySinh.Value;

            String imagePath = @"E:\HCMUTE\School_Project\library_management\LibraryManagement\uploads\nhanVien\" + hoSoQuanLyDTO.Id + ".png";
            hoSoQuanLyDTO.Hinhanh = imagePath;


            
            if (this.rbNam.Checked)
            {
                hoSoQuanLyDTO.GioiTinh = 1;
            }
            else if (this.rbNu.Checked)
            {
                hoSoQuanLyDTO.GioiTinh = 2;
            }
            else
            {
                hoSoQuanLyDTO.GioiTinh = 0;
            }

           
            int result;
            result = hoSoBUS.updateBasicInfo(hoSoQuanLyDTO);

            if (result == 0)
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



                }
                MessageBox.Show("Sửa thành công");
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

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau(hoSoQuanLyDTO.Id);
            frmDoiMatKhau.ShowDialog();
        }



    }
}
