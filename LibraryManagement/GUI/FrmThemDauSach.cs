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
using System.Threading;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class FrmThemDauSach : Form
    {
        DauSachBUS dauSachBUS = new DauSachBUS();
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        NgonNguBUS ngonNguBUS = new NgonNguBUS();
        private Form backFrm;
        private ChiTietDauSachDTO chiTietDauSach = new ChiTietDauSachDTO();
        private DanhSachTacGiaDTO danhSachTacGia = new DanhSachTacGiaDTO();
        private DanhSachTacGiaDTO tatCaTacGia;
        private DanhSachNgonNguDTO danhSachNgonNgu;
        private DanhSachTheLoaiDTO danhSachTheLoai;
        private DanhSachNXBDTO danhSachNXB;
        public FrmThemDauSach(Form backFrm)
        {
            this.backFrm = backFrm;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            danhSachNgonNgu = ngonNguBUS.getAllLanguages();
            cb_ngonNgu.DataSource = danhSachNgonNgu.getDataSource();

            danhSachNXB = nhaXuatBanBUS.getAllPublisher();
            cb_nhaXB.DataSource = danhSachNXB.getDataSource();

            danhSachTheLoai = theLoaiBUS.getAllCatetories();
            cb_theLoai.DataSource = danhSachTheLoai.getDataSource();

            

            tatCaTacGia = tacGiaBUS.getAllAuthors();
            cb_tatCa.DataSource = tatCaTacGia.getDataSource();
        }
        private void loadTacGia()
        {
            cb_tacGia.DataSource = danhSachTacGia.getDataSource();
            cb_tacGia.Text = danhSachTacGia.toString();
        }

        private void btn_themTG_Click(object sender, EventArgs e)
        {
            string name = cb_tatCa.Text;
            if (tatCaTacGia.nameInList(name))
            {
                LoadData();
                return;
            }
            int result = tacGiaBUS.addAuthor(new TacGia(name));
            if (result == 0)
            {
                MessageBox.Show("Thêm tác giả thất bại!!!");
            }
            else
            {
                MessageBox.Show("Thêm tác giả thành công!!!");
            }
            LoadData();
        }

        private void btn_themTheLoai_Click(object sender, EventArgs e)
        {
            int result = theLoaiBUS.insertTheLoai(new TheLoai(cb_theLoai.Text));
            if (result <= 0)
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
            if (result <= 0)
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
            if (result <= 0)
            {
                MessageBox.Show("Thêm ngôn ngữ thất bại!!!");
            }
            else
            {
                MessageBox.Show("Thêm ngôn ngữ thành công!!!");
            }
            LoadData();
        }



        private void cb_theLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_tatCa.SelectedIndex;
            if (index < 0) return;
            TacGia temp = tatCaTacGia.ListTacGia[index];
            if (danhSachTacGia.ListTacGia.Contains(temp)) return;
            else
            {
                danhSachTacGia.ListTacGia.Add(temp);
            }
            loadTacGia();
        }

        private void cb_tatCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_tatCa.SelectedIndex;
            TacGia temp = tatCaTacGia.ListTacGia[index];
            if (danhSachTacGia.nameInList(temp.Name))
            {
                loadTacGia();
                return;
            }
            danhSachTacGia.ListTacGia.Add(temp);
            loadTacGia();
        }

        private void cb_tacGia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = cb_tacGia.SelectedIndex;
            danhSachTacGia.ListTacGia.RemoveAt(index);
            loadTacGia();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                chiTietDauSach.TieuDe = txt_tenSach.Text;
                chiTietDauSach.MoTa = txt_moTa.Text;
                chiTietDauSach.DanhMuc = cb_danhMuc.SelectedIndex.ToString();
                chiTietDauSach.NgonNgu = Convert.ToString(danhSachNgonNgu.ListNgonNgu[cb_ngonNgu.SelectedIndex].Id);
                chiTietDauSach.NhaXB = Convert.ToString(danhSachNXB.ListNXB[cb_nhaXB.SelectedIndex].Id);
                chiTietDauSach.TheLoai = Convert.ToString(danhSachTheLoai.ListTheLoai[cb_theLoai.SelectedIndex].Id);
                chiTietDauSach.NgayXB = dtp_ngayXB.Value;
                chiTietDauSach.TrangThai = 1;
                chiTietDauSach.Gia = Convert.ToInt32(txt_gia.Text);
                chiTietDauSach.HinhAnh = "";
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ");
                return;
            }
            int result = dauSachBUS.save(chiTietDauSach, danhSachTacGia);
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmSach);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadData();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenBackFrm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenBackFrm()
        {
            Application.Run(backFrm);
        }
        void OpenFrmSach()
        {
            Application.Run(new FrmSach());
        }
    }
}
