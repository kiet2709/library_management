using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class DoiMatKhauDTO
    {
        private int maHS;
        private string matKhauCu;
        private string matKhauMoi;

        public string MatKhauCu { get => matKhauCu; set => matKhauCu = value; }
        public string MatKhauMoi { get => matKhauMoi; set => matKhauMoi = value; }
        public int MaHS { get => maHS; set => maHS = value; }
    }
}
