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
    public partial class FrmThemTacGia : Form
    {
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        public FrmThemTacGia()
        {
            InitializeComponent();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTacGia.Text == "")
            {
                this.Close();
                MessageBox.Show("Chưa ghi tác giả!");
            }
            else
            {
                tacGiaBUS.insert(txtTacGia.Text);
                this.Close();
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
