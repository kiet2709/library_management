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
    public partial class FrmThemTheLoai : Form
    {
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        public FrmThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTheLoai.Text == "")
            {
                this.Close();
                MessageBox.Show("Chưa ghi thể loại!");
            } else
            {
                theLoaiBUS.insert(txtTheLoai.Text);
                this.Close();
                MessageBox.Show("Thêm thành công");
            }
            
        }
    }
}
