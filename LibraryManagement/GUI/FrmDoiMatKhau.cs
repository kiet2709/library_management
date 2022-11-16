using LibraryManagement.BUS;
using LibraryManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.GUI
{
    public partial class FrmDoiMatKhau : Form
    {
        NhanVienBUS nhanVienBUS = new NhanVienBUS();
        HoSoBUS HoSoBUS = new HoSoBUS();    
        DoiMatKhauDTO doiMatKhauDTO = new DoiMatKhauDTO();
        public FrmDoiMatKhau(int id)
        {

            InitializeComponent();
            doiMatKhauDTO.MaHS = id;
            if (Properties.Settings.Default.role != null
                && Properties.Settings.Default.role != "" && Properties.Settings.Default.role == "Quản lý")
            {
                this.plMatKhau.Enabled = false;
                this.txtMatKhauCu.Enabled = false;
            }
        }

        private void adminChangePassword()
        {
            if (this.txtMatKhauNhapLai.Text != txtMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng");
                this.txtMatKhauMoi.Text = "";
                this.txtMatKhauNhapLai.Text = "";
                this.txtMatKhauCu.Text = "";
            }
            else if (txtMatKhauMoi.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ");
                this.txtMatKhauMoi.Text = "";
                this.txtMatKhauNhapLai.Text = "";
                this.txtMatKhauCu.Text = "";
            }
            else
            {
                doiMatKhauDTO.MatKhauMoi = txtMatKhauMoi.Text;

                int isCurrentUser = 0;
                if(HoSoBUS.getIdByUsername(Properties.Settings.Default.username) == doiMatKhauDTO.MaHS)
                {
                    isCurrentUser = 1;
                }

                int result = nhanVienBUS.updatePasswordForAdmin(doiMatKhauDTO);
                if (result == 0 || result == -1)
                {
                    MessageBox.Show("Mật khẩu sai");
                    this.txtMatKhauMoi.Text = "";
                    this.txtMatKhauNhapLai.Text = "";
                    this.txtMatKhauCu.Text = "";
                }
                else
                {
                    // check if current authenticate user changed
                    if (isCurrentUser == 1)
                    {
                        Properties.Settings.Default.password = txtMatKhauMoi.Text;
                        Properties.Settings.Default.Save();
                        DataProvider dataProvider = DataProvider.Instance;
                        dataProvider.StrConnectionString = $@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyThuVien; User Id={Properties.Settings.Default.username}; Password={Properties.Settings.Default.password};";

                    }

                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
            }
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.role != null
                && Properties.Settings.Default.role != "" && Properties.Settings.Default.role == "Quản lý")
            {
                adminChangePassword();
                return;
            }

            if (this.txtMatKhauNhapLai.Text != txtMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng");
                this.txtMatKhauMoi.Text = "";
                this.txtMatKhauNhapLai.Text = "";
                this.txtMatKhauCu.Text = "";
            }
            else if (txtMatKhauMoi.Text.Length < 8) {
                MessageBox.Show("Mật khẩu mới không hợp lệ");
                this.txtMatKhauMoi.Text = "";
                this.txtMatKhauNhapLai.Text = "";
                this.txtMatKhauCu.Text = "";
            }
            else
            {
                doiMatKhauDTO.MatKhauCu = txtMatKhauCu.Text;
                doiMatKhauDTO.MatKhauMoi = txtMatKhauMoi.Text;
                Console.WriteLine(doiMatKhauDTO.MatKhauMoi);
                int result =  nhanVienBUS.updatePassword(doiMatKhauDTO);
                Console.WriteLine(result);  
                if(result == 0 || result == -1)
                {
                    MessageBox.Show("Mật khẩu sai");
                    this.txtMatKhauMoi.Text = "";
                    this.txtMatKhauNhapLai.Text = "";
                    this.txtMatKhauCu.Text = "";
                }
                else
                {
                    Properties.Settings.Default.password = txtMatKhauMoi.Text;
                    Properties.Settings.Default.Save();
                    DataProvider dataProvider = DataProvider.Instance;
                    dataProvider.StrConnectionString = $@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyThuVien; User Id={Properties.Settings.Default.username}; Password={Properties.Settings.Default.password};";

                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
            }

        }
    }
}
