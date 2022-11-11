using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.Model;
namespace LibraryManagement.BUS
{
    public class TheLoaiBUS
    {
        TheLoaiDAL theLoaiDAL = new TheLoaiDAL();

        public DanhSachTheLoaiDTO getAllCatetories()
        {
            DanhSachTheLoaiDTO danhSach = new DanhSachTheLoaiDTO();
            danhSach.add(theLoaiDAL.getAllCatetories());
            return danhSach;
        }

        public int insertTheLoai(TheLoai theLoai)
        {
            return theLoaiDAL.insertTheLoai(theLoai);
        }
    }
}
