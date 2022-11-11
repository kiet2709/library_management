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
    public partial class FrmChiTietPhieuMuon : Form
    {
        int id;
        public FrmChiTietPhieuMuon(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FrmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {

        }
    }
}
