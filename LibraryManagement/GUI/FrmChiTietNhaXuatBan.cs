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
    public partial class FrmChiTietNhaXuatBan : Form
    {
        int id;
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        public FrmChiTietNhaXuatBan(int id)
        {
            InitializeComponent();
            this.id = id;
            loadThongTinTheLoai(id);
        }
        void loadThongTinTheLoai(int id)
        {
            NhaXuatBanQuanLyDTO nhaXuatBanQuanLyDTO = nhaXuatBanBUS.getNhaXuatBanById(id);
            txtNhaXuatBan.Text = nhaXuatBanQuanLyDTO.Ten;
            txtTongSoSach.Text = nhaXuatBanQuanLyDTO.TongSachTheoTheLoai.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaXuatBanQuanLyDTO nhaXuatBanQuanLyDTO = new NhaXuatBanQuanLyDTO();
            nhaXuatBanQuanLyDTO.Id = this.id;
            nhaXuatBanQuanLyDTO.Ten = txtNhaXuatBan.Text;
            int result = nhaXuatBanBUS.update(nhaXuatBanQuanLyDTO);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmNhaXuatBan);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmNhaXuatBan()
        {
            Application.Run(new FrmNhaXuatBan());
        }
    }
}
