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
    public partial class FrmThemDocGia : Form
    {
        AddDocGiaDTO addDocGiaDTO = new AddDocGiaDTO();
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        OpenFileDialog open = new OpenFileDialog();
        private Image image;
        public FrmThemDocGia()
        {
            InitializeComponent();
            rbNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addDocGiaDTO.Ten = txtHoTen.Text;
            addDocGiaDTO.Mssv = txtMssv.Text;
            addDocGiaDTO.Khoa = cbKhoa.SelectedItem.ToString();
            if (rbKhac.Checked)
            {
                addDocGiaDTO.GioiTinh = 0;
            }
            else if (rbNam.Checked)
            {
                addDocGiaDTO.GioiTinh = 1;
            }
            else
            {
                addDocGiaDTO.GioiTinh = 2;
            }
            addDocGiaDTO.NgaySinh = dtpNgaySinh.Value;
            addDocGiaDTO.SoDT = txtSdt.Text;
            addDocGiaDTO.Email = txtEmail.Text;
            addDocGiaDTO.HinhAnh = "";
            int result = docGiaBUS.saveDocGia(addDocGiaDTO);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                if (open.FileName != null)
                {
                    String imagePath = @"C:\Users\Nguyen Duc Thinh\Documents\Workspace\Three Year\HeCSDL\project\library_management\LibraryManagement\uploads\docGia\" + result + ".png";
                    image.Save(imagePath);
                    addDocGiaDTO.HinhAnh = imagePath;
                    docGiaBUS.saveImage(addDocGiaDTO.HinhAnh, result);
                }
                MessageBox.Show("Thêm thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmDocGia);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFrmDocGia()
        {
            Application.Run(new FrmDocGia());
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
