using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.GUI
{
    public partial class FrmThemPhieuMuon : Form
    {
        private Form backFrm;

        private PhieuMuonDTO phieuMuon = new PhieuMuonDTO();
        private DanhSachSachMuonDTO danhSachSachMuon = new DanhSachSachMuonDTO();
        private DocGia docGia;

        MuonBUS muonBUS = new MuonBUS();
        DocGiaBUS docGiaBUS = new DocGiaBUS();
        SachBUS sachBUS = new SachBUS();
        NhanVienBUS nhanVienBUS = new NhanVienBUS();

        public FrmThemPhieuMuon(Form backFrm)
        {
            this.backFrm = backFrm;
            InitializeComponent();
            loadData();
        }

        private void loadVCGSachMuon()
        {
            vcg_sachMuon = danhSachSachMuon.getDataSource(vcg_sachMuon);
        }

        private void loadDataSV()
        {
            pd_anh.Image = null;
            txt_khoa.Text = "";
            txt_sinhVien.Text = "";
        }

        private void loadData()
        {
            loadDataSV();
            loadVCGSachMuon();
            txt_maSach.Text = "";
            dtp_ngayMuon.Value = DateTime.Now;
            dtp_hanTra.Value = Service.convertDateTime("null");
            dtp_hanTra.Value = DateTime.Now;
            txt_tienPhat.Text = "0";
        }

        private void OpenBackFrm()
        {
            Application.Run(backFrm);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenBackFrm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_timSV_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(txt_mssv.Text);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy sinh viên");
                return;
            }
            docGia = docGiaBUS.getDocGiaById(id);
            if(docGia == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên");
                return;
            }
            if(docGia.Trangthai == 0)
            {
                MessageBox.Show("Sinh viên này bị cấm mượn sách");
                return;
            }
            txt_mssv.Text = docGia.Id.ToString();
            txt_khoa.Text = docGia.Khoa;
            txt_sinhVien.Text = docGia.Ten;
        }

        private void txt_mssv_TextChanged(object sender, EventArgs e)
        {
            loadDataSV();
        }

        private void btn_themSach_Click(object sender, EventArgs e)
        {
            int bookId = -1;
            try
            {
                bookId = Convert.ToInt32(txt_maSach.Text);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy sách");
                return;
            }
            MuonSachDTO muonSach = new MuonSachDTO();
            muonSach = sachBUS.getBookById(bookId);
            if(muonSach == null)
            {
                MessageBox.Show("Không tìm thấy sách");
                return;
            } else if (muonSach.DaMuon == 1)
            {
                MessageBox.Show("Sách đã có người mượn");
                return;
            } 
            else if (danhSachSachMuon.ListMuonSach.Contains(muonSach))
            {
                MessageBox.Show("Đã tồn tại");
                return;
            }
            danhSachSachMuon.ListMuonSach.Add(muonSach);
            loadVCGSachMuon();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(txt_khoa.Text == "" || danhSachSachMuon.ListMuonSach.Count == 0)
            {
                MessageBox.Show("Tạo phiếu mượn thất bại");
                return;
            }
            try
            {
                phieuMuon.NgayMuon = dtp_ngayMuon.Value;
                phieuMuon.NgayTra = dtp_ngayTra.Value;
                phieuMuon.HanTra = dtp_hanTra.Value;
                phieuMuon.TienPhat = Convert.ToInt32(txt_tienPhat.Text);
                phieuMuon.Mssv = txt_mssv.Text;
                phieuMuon.MaThuThu = nhanVienBUS.getIdByName(Properties.Settings.Default.username);
            }
            catch
            {
                MessageBox.Show("Tạo phiếu mượn thất bại");
                return;
            }
            int result = muonBUS.insertBrrowing(phieuMuon, danhSachSachMuon);
            if(result <= 0)
            {
                MessageBox.Show("Tạo phiếu mượn thất bại");
                return;
            }
            MessageBox.Show("Tạo phiếu mượn thành công");
            loadData();
        }

        private void vcg_sachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                danhSachSachMuon.ListMuonSach.RemoveAt(e.RowIndex);
                loadVCGSachMuon();
            }
        }
    }
}
