using LibraryManagement.DAL;
using LibraryManagement.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.BUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        internal ArrayList getBook()
        {
            ArrayList sachQuanLyDTOs = new ArrayList();
            DataTable sachs = sachDAO.getBook();
            foreach (DataRow dr in sachs.Rows)
            {
                SachQuanLyDTO sachQuanLyDTO = new SachQuanLyDTO();
                sachQuanLyDTO.Id = Convert.ToInt32(dr["id"]);
                sachQuanLyDTO.TuaSach = dr["tieude"].ToString();
                sachQuanLyDTO.TheLoai = dr["theloai"].ToString();
                sachQuanLyDTO.Gia = Convert.ToInt32(dr["gia"]);
                sachQuanLyDTO.SoLuongTrongKho = sachDAO.getQuantityBookById(sachQuanLyDTO.Id);
                sachQuanLyDTOs.Add(sachQuanLyDTO);
            }
            return sachQuanLyDTOs;
        }

        public MuonSachDTO getBookById(int id)
        {
            DataTable result = sachDAO.getBookById(id);
            MuonSachDTO muonSach = new MuonSachDTO();
            if (result == null) return null;
            muonSach.addRow(result.Rows[0]);
            return muonSach;
        }
    }
}
