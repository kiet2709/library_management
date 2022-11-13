using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.BUS
{
    public class TacGiaBUS
    {
        TacGiaDAL tacGiaDAL = new TacGiaDAL();
        public DanhSachTacGiaDTO getAllAuthors()
        {
            DanhSachTacGiaDTO listTacGia = new DanhSachTacGiaDTO();
            listTacGia.add(tacGiaDAL.getAllAuthors());
            return listTacGia;
        }

        public int addAuthor(TacGia tacGia)
        {
            return tacGiaDAL.addAuthor(tacGia);
        }
        public ArrayList getTacGia()
        {
            ArrayList tacGiaQuanLyDTOs = new ArrayList();
            DataTable ngonngus = tacGiaDAL.getAllAuthors();
            foreach (DataRow dr in ngonngus.Rows)
            {
                TacGiaQuanLyDTO tacGiaQuanLyDTO = new TacGiaQuanLyDTO();
                tacGiaQuanLyDTO.Id = Convert.ToInt32(dr["id"]);
                tacGiaQuanLyDTO.Ten = dr["ten"].ToString();
                tacGiaQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(tacGiaQuanLyDTO.Id);
                tacGiaQuanLyDTOs.Add(tacGiaQuanLyDTO);
            }
            return tacGiaQuanLyDTOs;
        }
        int getSumOfBookByCategory(int id)
        {
            return tacGiaDAL.getSumOfBookByCategory(id);
        }

        internal void insert(string tenTacGia)
        {
            tacGiaDAL.addAuthor(tenTacGia);
        }
        internal TacGiaQuanLyDTO getTacGiaById(int id)
        {
            DataTable theloai = tacGiaDAL.getTacGiaById(id);
            TacGiaQuanLyDTO tacGiaQuanLyDTO = new TacGiaQuanLyDTO();
            DataRow dr = theloai.Rows[0];
            tacGiaQuanLyDTO.Ten = dr["ten"].ToString();
            tacGiaQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(id);
            return tacGiaQuanLyDTO;
        }
        internal int update(TacGiaQuanLyDTO tacGiaQuanLyDTO)
        {
            return tacGiaDAL.update(tacGiaQuanLyDTO);
        }
    }
}
