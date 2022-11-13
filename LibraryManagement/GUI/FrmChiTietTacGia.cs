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
    public partial class FrmChiTietTacGia : Form
    {
        int id;
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        public FrmChiTietTacGia(int id)
        {
            InitializeComponent();
            this.id = id;
            loadThongTinTacGia(id);
        }
        void loadThongTinTacGia(int id)
        {
            TacGiaQuanLyDTO tacGiaQuanLyDTO = tacGiaBUS.getTacGiaById(id);
            txtTacGia.Text = tacGiaQuanLyDTO.Ten;
            txtTongSoSach.Text = tacGiaQuanLyDTO.TongSachTheoTheLoai.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TacGiaQuanLyDTO tacGiaQuanLyDTO = new TacGiaQuanLyDTO();
            tacGiaQuanLyDTO.Id = this.id;
            tacGiaQuanLyDTO.Ten = txtTacGia.Text;
            int result = tacGiaBUS.update(tacGiaQuanLyDTO);
            if (result == 0)
            {
                MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
                Thread thread = new Thread(OpenFrmTacGia);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmTacGia()
        {
            Application.Run(new FrmTacGia());
        }
    }
}
