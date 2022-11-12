using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class ChiTietDauSachDTO
    {
        private string tieuDe;
        private string moTa;
        private int gia;
        private string danhMuc;
        private string theLoai;
        private string nhaXB;
        private DateTime ngayXB;
        private int trangThai;
        private string hinhAnh;
        private string ngonNgu;
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string NhaXB { get => nhaXB; set => nhaXB = value; }
        public DateTime NgayXB { get => ngayXB; set => ngayXB = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string NgonNgu { get => ngonNgu; set => ngonNgu = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int Gia { get => gia; set => gia = value; }

        public string dateString()
        {
            return ngayXB.ToString("MM-dd-yyyy");
        }

        public void add(DataTable dataTable)
        {
            tieuDe = Convert.ToString(dataTable.Rows[0][0]);
            moTa = Convert.ToString(dataTable.Rows[0][1]);
            gia = Convert.ToInt32(dataTable.Rows[0][2]);
            ngayXB = Convert.ToDateTime(dataTable.Rows[0][3]);
            hinhAnh = Convert.ToString(dataTable.Rows[0][4]);
            danhMuc = Convert.ToString(dataTable.Rows[0][5]);
            trangThai = Convert.ToInt32(dataTable.Rows[0][6]);
            nhaXB = Convert.ToString(dataTable.Rows[0][7]);
            ngonNgu = Convert.ToString(dataTable.Rows[0][8]);
            TheLoai = Convert.ToString(dataTable.Rows[0][9]);
        }
    }
}
