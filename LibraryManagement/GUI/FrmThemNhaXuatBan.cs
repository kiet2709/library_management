using LibraryManagement.BUS;
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
    public partial class FrmThemNhaXuatBan : Form
    {
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        public FrmThemNhaXuatBan()
        {
            InitializeComponent();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtNhaXuatBan.Text == "")
            {
                this.Close();
                MessageBox.Show("Chưa ghi thể loại!");
            }
            else
            {
                nhaXuatBanBUS.insert(txtNhaXuatBan.Text);
                this.Close();
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
