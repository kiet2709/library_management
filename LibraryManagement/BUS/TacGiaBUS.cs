using System;
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
    }
}
