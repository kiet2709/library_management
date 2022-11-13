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
    public partial class FrmChiTietNgonNgu : Form
    {
        int id;
        NgonNguBUS ngonNguBUS = new NgonNguBUS();
        public FrmChiTietNgonNgu(int id)
        {
            InitializeComponent();
            this.id = id;
            loadThongTinTheLoai(id);
        }
        void loadThongTinTheLoai(int id)
        {
            NgonNguQuanLyDTO ngonNguQuanLyDTO = ngonNguBUS.getNgonNguById(id);
            txtNgonNgu.Text = ngonNguQuanLyDTO.Ten;
            txtTongSoSach.Text = ngonNguQuanLyDTO.TongSachTheoTheLoai.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NgonNguQuanLyDTO ngonNguQuanLyDTO = new NgonNguQuanLyDTO();
            ngonNguQuanLyDTO.Id = this.id;
            ngonNguQuanLyDTO.Ten = txtNgonNgu.Text;
            int result = ngonNguBUS.update(ngonNguQuanLyDTO);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmNgonNgu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmNgonNgu()
        {
            Application.Run(new FrmNgonNgu());
        }
    }
}
