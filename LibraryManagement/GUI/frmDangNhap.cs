using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            pnlDangNhap.BackColor = Color.FromArgb(255, 255, 255);
            btnDangNhapp.BackColor = Color.FromArgb(255, 207, 71); 
            pnlDuongTrongDangNhap.BackColor = Color.FromArgb(255, 207, 71);
        }

       
    }
}
