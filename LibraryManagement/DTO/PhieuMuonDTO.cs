using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.DTO
{
    public class PhieuMuonDTO
    {
        private int id;
        private string sinhVien;
        private string mssv;
        private string khoa;
        private string thuThu;
        private DateTime ngayMuon;
        private DateTime hanTra;
        private DateTime ngayTra;
        private int tienPhat;
        private int trangthai;
        private string hinhAnh;

        public string SinhVien { get => sinhVien; set => sinhVien = value; }

        public void addRow(DataRow row)
        {
            id = Convert.ToInt32(row[0]);
            ngayMuon = Convert.ToDateTime(row[1]);
            hanTra = Convert.ToDateTime(row[2]);
            trangthai = Convert.ToInt32(row[3]);
            tienPhat = Convert.ToInt32(row[4]);
        }

        public string Mssv { get => mssv; set => mssv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string ThuThu { get => thuThu; set => thuThu = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public DateTime HanTra { get => hanTra; set => hanTra = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public int TienPhat { get => tienPhat; set => tienPhat = value; }
        public int Id { get => id; set => id = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public void add(DataTable dataTable)
        {
            sinhVien = Convert.ToString(dataTable.Rows[0][0]);
            mssv = Convert.ToString(dataTable.Rows[0][1]);
            khoa = Convert.ToString(dataTable.Rows[0][2]);
            thuThu = Convert.ToString(dataTable.Rows[0][3]);
            ngayMuon = Service.convertDateTime(dataTable.Rows[0][4]);
            hanTra = Service.convertDateTime(dataTable.Rows[0][5]);
            ngayTra = Service.convertDateTime(dataTable.Rows[0][6]);
            tienPhat = Convert.ToInt32(dataTable.Rows[0][7]);
            hinhAnh = Convert.ToString(dataTable.Rows[0][8]);
        }

        public DataGridViewRow getDataSource(DataGridViewRow dr)
        {
            dr.Cells[0].Value = id;
            dr.Cells[1].Value = ngayMuon.ToString("dd-MM-yyyy");
            dr.Cells[2].Value = hanTra.ToString("dd-MM-yyyy");
            dr.Cells[3].Value = trangthai==1 ? "Đã trả đầy đủ":"Chưa trả đầy đủ";
            dr.Cells[4].Value = tienPhat.ToString();
            return dr;
        }
    }
}
