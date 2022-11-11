using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.GUI
{
    public partial class FrmChiTietDauSach : Form
    {
        DauSachBUS dauSachBUS = new DauSachBUS();
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        NgonNguBUS ngonNguBUS = new NgonNguBUS();
        private int id;
        private ChiTietDauSachDTO chiTietDauSach;
        private DanhSachTacGiaDTO danhSachTacGia;
        private DanhSachTacGiaDTO tatCaTacGia;
        private DanhSachNgonNguDTO danhSachNgonNgu;
        private DanhSachTheLoaiDTO danhSachTheLoai;
        private DanhSachNXBDTO danhSachNXB;
        public FrmChiTietDauSach(int id)
        {
            this.id = id;
            LoadData();
            InitializeComponent();
        }

        private void LoadData()
        {
            chiTietDauSach = dauSachBUS.getBookInfo(id);
            txt_tenSach.Text = chiTietDauSach.TieuDe;
            txt_moTa.Text = chiTietDauSach.MoTa;
            cb_danhMuc.Text = chiTietDauSach.DanhMuc;
            txt_gia.Text = chiTietDauSach.Gia.ToString();
            txt_soLuong.Text = dauSachBUS.getNumberOfBook(id).ToString();

            cb_ngonNgu.Text = chiTietDauSach.NgonNgu;
            danhSachNgonNgu = ngonNguBUS.getAllLanguages();
            cb_ngonNgu.DataSource = danhSachNgonNgu.getDataSource();

            cb_nhaXB.Text = chiTietDauSach.NhaXB;
            danhSachNXB = nhaXuatBanBUS.getAllPublisher();
            cb_nhaXB.DataSource = danhSachNXB.getDataSource();

            cb_theLoai.Text = chiTietDauSach.TheLoai;
            danhSachTheLoai = theLoaiBUS.getAllCatetories();
            cb_theLoai.DataSource = danhSachTheLoai.getDataSource();
            
            dtp_ngayXB.Value = chiTietDauSach.NgayXB;
            cb_trangThai.Text = chiTietDauSach.TrangThai.ToString();

            danhSachTacGia = dauSachBUS.getAuthorOfBook(id);
            loadTacGia();

            tatCaTacGia = tacGiaBUS.getAllAuthors();
            cb_tatCa.DataSource = tatCaTacGia.getDataSource();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_themTG_Click(object sender, EventArgs e)
        {
            int result = tacGiaBUS.addAuthor(new TacGia(cb_tatCa.Text));
            if(result == -1)
            {
                MessageBox.Show("Thêm tác giả thất bại!!!");
            }else
            {
                MessageBox.Show("Thêm tác giả thành công!!!");
            }
            LoadData();
        }

        private void btn_themTheLoai_Click(object sender, EventArgs e)
        {
            int result = theLoaiBUS.insertTheLoai(new TheLoai(cb_theLoai.Text));
            if (result == -1)
            {
                MessageBox.Show("Thêm thể loại thất bại!!!");
            }
            else
            {
                MessageBox.Show("Thêm thể loại thành công!!!");
            }
            LoadData();
        }

        private void btn_themNXB_Click(object sender, EventArgs e)
        {
            int result = nhaXuatBanBUS.insertNXB(new NhaXuatBan(cb_nhaXB.Text));
            if (result == -1)
            {
                MessageBox.Show("Thêm nhà xuất bản thất bại!!!");
            }
            else
            {
                MessageBox.Show("Thêm nhà xuất bản thành công!!!");
            }
            LoadData();
        }

        private void btn_themNN_Click(object sender, EventArgs e)
        {
            int result = ngonNguBUS.insertNgonNgu(new NgonNgu(cb_ngonNgu.Text));
            if (result == -1)
            {
                MessageBox.Show("Thêm ngôn ngữ thất bại!!!");
            }
            else
            {
                MessageBox.Show("Thêm ngôn ngữ thành công!!!");
            }
            LoadData();
        }

        private void btn_themAnh_Click(object sender, EventArgs e)
        {
           
        }

        private void loadTacGia()
        {
            cb_tacGia.DataSource = danhSachTacGia.getDataSource();
            cb_tacGia.Text = danhSachTacGia.toString();
        }

        private void cb_tacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_tacGia.SelectedIndex;
            danhSachTacGia.ListTacGia.RemoveAt(index);
            loadTacGia();
        }

        private void cb_theLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_tatCa.SelectedIndex;
            TacGia temp = tatCaTacGia.ListTacGia[index];
            if (danhSachTacGia.ListTacGia.Contains(temp)) return;
            else
            {
                danhSachTacGia.ListTacGia.Add(temp);
            }
            loadTacGia();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                chiTietDauSach.TieuDe = txt_tenSach.Text;
                chiTietDauSach.MoTa = txt_moTa.Text;
                chiTietDauSach.DanhMuc = cb_danhMuc.SelectedIndex.ToString();
                chiTietDauSach.NgonNgu = Convert.ToString(danhSachNgonNgu.ListNgonNgu[cb_ngonNgu.SelectedIndex].Id) ;
                chiTietDauSach.NhaXB = Convert.ToString(danhSachNXB.ListNXB[cb_nhaXB.SelectedIndex].Id);
                chiTietDauSach.TheLoai = Convert.ToString(danhSachTheLoai.ListTheLoai[cb_theLoai.SelectedIndex].Id);
                chiTietDauSach.NgayXB = dtp_ngayXB.Value;
                chiTietDauSach.TrangThai = Convert.ToInt32(cb_trangThai.Text);
                chiTietDauSach.Gia = Convert.ToInt32(txt_gia.Text);
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ");
                return;
            }
            dauSachBUS.updateBookInfo(id, chiTietDauSach, danhSachTacGia);
            LoadData();
        }
    }
}
