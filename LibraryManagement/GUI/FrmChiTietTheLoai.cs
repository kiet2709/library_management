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
    public partial class FrmChiTietTheLoai : Form
    {
        int id;
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        public FrmChiTietTheLoai(int id)
        {
            InitializeComponent();
            this.id = id;
            loadThongTinTheLoai(id);
        }
        void loadThongTinTheLoai(int id)
        {
            TheLoaiQuanLyDTO theLoaiQuanLyDTO = theLoaiBUS.getTheLoaiById(id);
            txtTheLoai.Text = theLoaiQuanLyDTO.Ten;
            txtTongSoSach.Text = theLoaiQuanLyDTO.TongSachTheoTheLoai.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TheLoaiQuanLyDTO theLoaiQuanLyDTO = new TheLoaiQuanLyDTO();
            theLoaiQuanLyDTO.Id = this.id;
            theLoaiQuanLyDTO.Ten = txtTheLoai.Text;
            int result = theLoaiBUS.update(theLoaiQuanLyDTO);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmTheLoai);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmTheLoai()
        {
            Application.Run(new FrmTheLoai());
        }
    }
}
