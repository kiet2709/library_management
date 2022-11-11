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
        public FrmThemDocGia()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            addDocGiaDTO.Ten = txtHoTen.Text;
            addDocGiaDTO.Mssv = txtMssv.Text;
            addDocGiaDTO.Khoa = cbKhoa.Text;
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

            int result = docGiaBUS.saveDocGia(addDocGiaDTO);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
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
    }
}
