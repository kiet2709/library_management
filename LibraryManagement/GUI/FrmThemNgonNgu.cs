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
    public partial class FrmThemNgonNgu : Form
    {
        NgonNguBUS ngonNguBUS = new NgonNguBUS();
        public FrmThemNgonNgu()
        {
            InitializeComponent();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtNgonNgu.Text == "")
            {
                this.Close();
                MessageBox.Show("Chưa ghi thể loại!");
            }
            else
            {
                ngonNguBUS.insert(txtNgonNgu.Text);
                this.Close();
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
