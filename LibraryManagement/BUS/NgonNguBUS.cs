using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.BUS
{
    public class NgonNguBUS
    {
        NgonNguDAL ngonNguDAL = new NgonNguDAL();
        public DanhSachNgonNguDTO getAllLanguages()
        {
            DanhSachNgonNguDTO danhSachNgonNgu = new DanhSachNgonNguDTO();
            danhSachNgonNgu.add(ngonNguDAL.getAllLanguages());
            return danhSachNgonNgu;
        }

        public int insertNgonNgu(NgonNgu ngonNgu)
        {
            return ngonNguDAL.insertNgonNgu(ngonNgu);
        }
    }
}
