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
using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.GUI
{
    public partial class FrmPhieuMuon : Form
    {
        private int idPhieuMuon;
        private DanhSachPhieuMuonDTO danhSachPhieuMuon;

        private MuonBUS muonBUS = new MuonBUS();
        private DocGiaBUS docGiaBUS = new DocGiaBUS();
        private LocPhieuMuonDTO locPhieuMuon = new LocPhieuMuonDTO(-1, 2);
        public FrmPhieuMuon()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            if (Properties.Settings.Default.role != null
              && Properties.Settings.Default.role != "" && Properties.Settings.Default.role == "Thủ thư")
            {
                this.pbUser.Enabled = false;
                this.btnFormTaiKhoan.Enabled = false;
            }


            if (Properties.Settings.Default.image != null
               && Properties.Settings.Default.image != "")
            {
                using (FileStream fs = new FileStream(Properties.Settings.Default.image, FileMode.Open))
                {
                    pbAnh.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }

            if (Properties.Settings.Default.username != null
                && Properties.Settings.Default.username != "")
            {
                this.lblTenDangNhap.Text = Properties.Settings.Default.username;
            }
            
            if(locPhieuMuon.Mssv == -1)
            {
                rd_tatCa.Checked = true;
                pl_kiemTraSV.Enabled = false;
                loadKTSV();
            }
            else
            {
                rd_timSV.Checked = true;
                pl_kiemTraSV.Enabled = true;
                txt_mssv.Text = docGiaBUS.getDocGiaById(locPhieuMuon.Mssv).Mssv;
                lb_thongBao.Text = "Tìm thấy";
            }

            cb_trangThai.SelectedIndex = locPhieuMuon.TrangThai;
            
            danhSachPhieuMuon = muonBUS.getFilterListBrrowing(this.locPhieuMuon);
            vcg_phieuMuon.Rows.Clear();
            vcg_phieuMuon = danhSachPhieuMuon.getDataSource(vcg_phieuMuon);
        }

        private void vcg_phieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPhieuMuon = Convert.ToInt32(vcg_phieuMuon.SelectedRows[0].Cells[0].Value);
            this.Close();
            Thread thread = new Thread(OpenFrmChiTietPhieuMuon);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenFrmChiTietPhieuMuon()
        {
            Application.Run(new FrmChiTietPhieuMuon(idPhieuMuon, new FrmPhieuMuon()));
        }

        private void OpenFrmSach()
        {
            Application.Run(new FrmSach());
        }

        private void OpenFrmTheLoai()
        {
            Application.Run(new FrmTheLoai());
        }

        private void OpenFrmNgonNgu()
        {
            Application.Run(new FrmNgonNgu());
        }

        private void OpenFrmNhaXuatBan()
        {
            Application.Run(new FrmNhaXuatBan());
        }
        private void OpenFrmTacGia()
        {
            Application.Run(new FrmTacGia());
        }

        private void OpenFrmPhieuMuon()
        {
            Application.Run(new FrmPhieuMuon());
        }

        private void OpenFrmDocGia()
        {
            Application.Run(new FrmDocGia());
        }

        private void OpenFrmTaiKhoan()
        {
            Application.Run(new FrmTaiKhoan());
        }

        private void OpenFrmThemPhieuMuon()
        {
            Application.Run(new FrmThemPhieuMuon(new FrmPhieuMuon()));
        }

        private void btnFormSach_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmSach);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFormTheLoai_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTheLoai);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnNgonNgu_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNgonNgu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmNhaXuatBan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTacGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmDocGia);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

   

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.image = "";
            this.Close();
            Thread thread = new Thread(OpenFrmDangNhap);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFrmDangNhap()
        {
            Application.Run(new FrmDangNhap());
        }

        private void pbAnh_Click(object sender, EventArgs e)
        {
            FrmThongTinCaNhan frmThongTinCaNhan = new FrmThongTinCaNhan();
            frmThongTinCaNhan.ShowDialog();
        }
        private void OpenFrmThongTinCaNhan()
        {
            Application.Run(new FrmThongTinCaNhan());
        }

        private void btnFormTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmTaiKhoan);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_themPhieuMuon_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmThemPhieuMuon);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void rd_tatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(rd_timSV.Checked)
            {
                pl_kiemTraSV.Enabled = true;
            }
            else
            {
                pl_kiemTraSV.Enabled = false;
            }
        }

        private void loadKTSV()
        {
            txt_mssv.Text = "";
            lb_thongBao.Text = "Kết quả";
        }

        private void txt_mssv_TextChanged(object sender, EventArgs e)
        {
            lb_thongBao.Text = "Kết quả";
        }

        private void btn_kiemTra_Click(object sender, EventArgs e)
        {
            int mssv = -1;
            string thongBao = "";
            try
            {
                mssv = Convert.ToInt32(txt_mssv.Text);
            }
            catch
            {
                thongBao = "Không tìm thấy";
            }
            int id = docGiaBUS.getIdByMSSV(txt_mssv.Text);
            DocGia docGia = new DocGia();
            docGia = docGiaBUS.getDocGiaById(id);
            if(docGia == null)
            {
                thongBao = "Không tìm thấy";
            }
            else
            {
                thongBao = "Tìm thấy";
            }
            lb_thongBao.Text = thongBao;
        }

        private void btn_tatCa_Click(object sender, EventArgs e)
        {
            locPhieuMuon.Mssv = -1;
            locPhieuMuon.TrangThai = 2;
            loadData();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            if (rd_tatCa.Checked)
            {
                locPhieuMuon.Mssv = -1;
            }
            if (rd_timSV.Checked)
            {
                btn_kiemTra_Click(sender, e);
                if(lb_thongBao.Text.CompareTo("Tìm thấy") == 0)
                    locPhieuMuon.Mssv = docGiaBUS.getIdByMSSV(txt_mssv.Text);
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên");
                    return;
                }
            }
            locPhieuMuon.TrangThai = cb_trangThai.SelectedIndex;
            loadData();
        }
    }
}
