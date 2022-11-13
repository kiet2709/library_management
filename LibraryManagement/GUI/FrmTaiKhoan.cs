using LibraryManagement.BUS;
using LibraryManagement.DTO;
using System;
using System.Collections;
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
    public partial class FrmTaiKhoan : Form
    {
        private HoSoBUS hoSoBUS = new HoSoBUS();
        private HoSoQuanLyDTO hoSoQuanLyDTO = new HoSoQuanLyDTO();

        public FrmTaiKhoan()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            this.dtgvHoSo.Columns[8].FillWeight = 2;
            this.dtgvHoSo.Columns[9].FillWeight = 2;
            ArrayList hoso = hoSoBUS.getAllProfile();
        
            for (int i = 0; i < hoso.Count; i++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(this.dtgvHoSo);
                dr.Cells[0].Value = ((HoSoQuanLyDTO) hoso[i]).Id;

                dr.Cells[1].Value = ((HoSoQuanLyDTO) hoso[i]).VaiTro;
                dr.Cells[2].Value = ((HoSoQuanLyDTO) hoso[i]).Ten;
                dr.Cells[3].Value = ((HoSoQuanLyDTO) hoso[i]).Ho;
                dr.Cells[4].Value = ((HoSoQuanLyDTO) hoso[i]).Email;
                dr.Cells[5].Value = ((HoSoQuanLyDTO) hoso[i]).SoDT;
                if (((HoSoQuanLyDTO)hoso[i]).GioiTinh == 0)
                {
                    dr.Cells[6].Value = "Khác";
                }
                else if (((HoSoQuanLyDTO)hoso[i]).GioiTinh == 1)
                {
                    dr.Cells[6].Value = "Nam";
                }
                else
                {
                    dr.Cells[6].Value = "Nữ";
                }
                dr.Cells[7].Value = ((HoSoQuanLyDTO) hoso[i]).Ngaysinh.ToShortDateString();
                dr.Cells[8].Value = ((HoSoQuanLyDTO) hoso[i]).Luong + " VNĐ";
                if (((HoSoQuanLyDTO)hoso[i]).TrangThai == 1)
                {
                    dr.Cells[9].Value = "Hoạt động";
                }
                else
                {
                    dr.Cells[9].Value = "Không hoạt động";
                }
                
               
                dtgvHoSo.Rows.Add(dr);
            }
        }
    

        private void dtgvHoSo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHoSo.Rows[e.RowIndex];
                hoSoQuanLyDTO.Id = Convert.ToInt32(row.Cells[0].Value);
                if (e.ColumnIndex == this.edit.Index)
                {
                    this.Close();
                    Thread thread = new Thread(OpenFrmCapNhatTaiKhoan);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                
            }
        }

        private void OpenFrmCapNhatTaiKhoan()
        {
            Application.Run(new FrmCapNhatTaiKhoan(hoSoQuanLyDTO.Id));
        }

        private void OpenFrmThemTaiKhoan()
        {
            Application.Run(new FrmThemNhanVien());
        }

        private void OpenFrmSach()
        {
            Application.Run(new FrmSach());
        }

        private void OpenFrmPhieuMuon()
        {
            Application.Run(new FrmPhieuMuon());
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThemTaiKhoan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void sellCarPanel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmPhieuMuon);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
