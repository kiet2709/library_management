using LibraryManagement.BUS;
using LibraryManagement.DTO;
using LibraryManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FrmDangNhap : Form
    {
        private NhanVienBUS dangNhapBUS = new NhanVienBUS();
        public FrmDangNhap()
        {
            InitializeComponent();
            pnlDangNhap.BackColor = Color.FromArgb(255, 255, 255);
            btnDangNhapp.BackColor = Color.FromArgb(255, 207, 71); 
            pnlDuongTrongDangNhap.BackColor = Color.FromArgb(255, 207, 71);
        }

        private void btnDangNhapp_Click(object sender, EventArgs e)
        {
            DangNhapDTO dangNhap = new DangNhapDTO(txtTenDangNhap.Text, txtMatKhau.Text);
            int result = dangNhapBUS.dangNhap(dangNhap);
            if (result == -1)
            {
                MessageBox.Show("Không tồn tại tài khoản hoặc tài khoản nhập sai, vui lòng đăng nhập lại!!!");
            } else if (result == 1 || result == 2)
            {
                string username = txtTenDangNhap.Text;
                String image = dangNhapBUS.getImageByUsername(username);
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.image = image;
                Properties.Settings.Default.Save();
                this.Close();
                Thread thread = new Thread(OpenFrmSach);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        void OpenFrmSach(object obj)
        {
            Application.Run(new FrmSach());

        }
    }
}
