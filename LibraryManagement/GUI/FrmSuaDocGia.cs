using LibraryManagement.BUS;
using LibraryManagement.Model;
using LibraryManagement.Utils;
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
    public partial class FrmSuaDocGia : Form
    {
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        DocGia docgia = new DocGia();
        OpenFileDialog open = new OpenFileDialog();
        private Image image;
        public FrmSuaDocGia(int id)
        {
            InitializeComponent();
            loadData(id);
        }
        
        void loadData(int id)
        {
           
            docgia = docGiaBUS.getDocGiaById(id);
            this.txtHoTen.Text = docgia.Ten;
            this.txtMssv.Text = docgia.Mssv;
            this.cbKhoa.SelectedIndex = cbKhoa.FindString(docgia.Khoa);
            if (docgia.Gioitinh == 0)
            {
                this.rbKhac.Checked = true;
            }
            else if (docgia.Gioitinh == 1)
            {
                this.rbNam.Checked = true;
            }
            else
            {
                this.rbNu.Checked = true;
            }
            this.dtpNgaySinh.Value = docgia.Ngaysinh;
            if (docgia.Trangthai == 1)
            {
                this.rbMuon.Checked = true;
            }
            else
            {
                this.rbKhongMuon.Checked = true;
            }
            
            this.txtSdt.Text = docgia.Sdt;
            this.txtEmail.Text = docgia.Email;

            if (docgia.HinhAnh != null && docgia.HinhAnh != "")
            {
                string fullImagePath = AppConstant.getFullDirectory(docgia.HinhAnh);
                using (FileStream fs = new FileStream(fullImagePath, FileMode.Open))
                {
                    pbAnh.Image = Image.FromStream(fs);
                    fs.Close();
                }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            docgia.Ten = txtHoTen.Text;
            docgia.Mssv = txtMssv.Text;
            docgia.Khoa = cbKhoa.SelectedItem.ToString();
            if (rbKhac.Checked)
            {
                docgia.Gioitinh = 0;
            }
            else if (rbNam.Checked)
            {
                docgia.Gioitinh = 1;
            }
            else
            {
                docgia.Gioitinh = 2;
            }
            docgia.Ngaysinh = dtpNgaySinh.Value;
            if (rbMuon.Checked == true)
            {
                docgia.Trangthai = 1;
            }
            else
            {
                docgia.Trangthai = 0;
            }
            docgia.Sdt= txtSdt.Text;
            docgia.Email = txtEmail.Text;
            string imagePath = AppConstant.getDirectory(docgia.Id, "docGia");
            docgia.HinhAnh = imagePath;
            int result = docGiaBUS.updateDocGia(docgia);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                if (open.FileName != null && open.FileName != "")
                {
                    string fullImagePath = AppConstant.getFullDirectory(imagePath);
                    // delete and save again
                    if (File.Exists(fullImagePath))
                    {
                        File.Delete(fullImagePath);

                    }
                    image.Save(fullImagePath);


                }
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmDocGia);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
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
