using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Model;
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
    public partial class FrmCuonSach : Form
    {
        private int index = 0;
        DanhSachDauSachDTO danhSachDauSach;
        DanhSachCuonSachDTO danhSachCuonSach;

        private DauSachBUS dauSachBUS = new DauSachBUS();

        public FrmCuonSach()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            danhSachDauSach = dauSachBUS.getBookTitles();
            cbcDauSach.DataSource = danhSachDauSach.getDataSource();
            danhSachCuonSach = dauSachBUS.getBooksByIdTitle(danhSachDauSach.ListDauSach[index].Id);
            dtgCuonSach.Rows.Clear();
            dtgCuonSach = danhSachCuonSach.getDataSource(dtgCuonSach);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThemCuonSach_Click(object sender, EventArgs e)
        {
            if(txtViTri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vị trí");
                return;
            }
            Sach sach = new Sach();
            sach.TrangThai = 1;
            sach.ViTri = txtViTri.Text;
            int result = dauSachBUS.insertBook(danhSachDauSach.ListDauSach[index].Id, sach);
            if(result <=0)
            {
                MessageBox.Show("Thêm cuốn sách thất bại!!");
                return;
            }
            else
            {
                MessageBox.Show("Thêm cuốn sách thành công!!");
                loadData();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            for(int i =0; i < dtgCuonSach.Rows.Count; i++)
            {
                try
                {
                    DataGridViewComboBoxCell tbc = (DataGridViewComboBoxCell)dtgCuonSach.Rows[i].Cells[1];
                    danhSachCuonSach.ListSach[i].TrangThai = Convert.ToInt32(tbc.Value);
                    danhSachCuonSach.ListSach[i].ViTri = Convert.ToString(dtgCuonSach.Rows[i].Cells[2].Value);
                }
                catch
                {
                    MessageBox.Show("Lưu thất bại!!");
                    loadData();
                    return;
                }
                
            }
            int result = dauSachBUS.updateBooks(danhSachCuonSach);
            if (result <= 0)
            {
                MessageBox.Show("Lưu thất bại!!");
            }
            else
            {
                MessageBox.Show("Lưu thành công!!");
            }
            loadData();
        }

        private void cbcDauSach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            index = cbcDauSach.SelectedIndex;
            loadData();
        }
    }
}
