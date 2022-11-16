using LibraryManagement.BUS;
using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.GUI;
using LibraryManagement.Utils;
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


            DataProvider dataProvider = DataProvider.Instance;
            dataProvider.StrConnectionString = $@"Data Source=LAPTOP-7A94G7MF\SQLEXPRESS;Initial Catalog=QuanLyThuVien; User Id={txtTenDangNhap.Text}; Password={txtMatKhau.Text};";
            int result = dangNhapBUS.dangNhap(dangNhap);
            if (result == -1)
            {
                MessageBox.Show("Không tồn tại tài khoản hoặc tài khoản nhập sai, vui lòng đăng nhập lại!!!");
            } else 
            {
                if (result == 1 )
                {
                    Properties.Settings.Default.role = "Quản lý";
                }
                else
                {
                    Properties.Settings.Default.role = "Thủ thư";
                }
                string image = dangNhapBUS.getImageByUsername(txtTenDangNhap.Text);
                Properties.Settings.Default.username = txtTenDangNhap.Text;
                Properties.Settings.Default.password = txtMatKhau.Text;
                if (image != "")
                {
                    string fullImagePath = AppConstant.getFullDirectory(image);
                    Properties.Settings.Default.image = fullImagePath;
                }
                else
                {
                    Properties.Settings.Default.image = "";
                }
                
                Properties.Settings.Default.Save();
                dataProvider.StrConnectionString = $@"Data Source=LAPTOP-7A94G7MF\SQLEXPRESS;Initial Catalog=QuanLyThuVien; User Id={Properties.Settings.Default.username}; Password={Properties.Settings.Default.password};";
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
