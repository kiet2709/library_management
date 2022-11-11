using System.Collections;
using System.Data;
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
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();

        internal void delete(int id)
        {
            theLoaiDAO.delete(id);
        }

        internal ArrayList getTheLoai()
        {
            ArrayList theLoaiQuanLyDTOs = new ArrayList();
            DataTable theloais = theLoaiDAO.getTheLoai();
            foreach (DataRow dr in theloais.Rows)
            {
                TheLoaiQuanLyDTO theLoaiQuanLyDTO = new TheLoaiQuanLyDTO();
                theLoaiQuanLyDTO.Id = Convert.ToInt32(dr["id"]);
                theLoaiQuanLyDTO.Ten = dr["ten"].ToString();
                theLoaiQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(theLoaiQuanLyDTO.Id);
                theLoaiQuanLyDTOs.Add(theLoaiQuanLyDTO);
            }
            return theLoaiQuanLyDTOs;
        }

        internal TheLoaiQuanLyDTO getTheLoaiById(int id)
        {
            DataTable theloai = theLoaiDAO.getTheLoaiById(id);
            TheLoaiQuanLyDTO theLoaiQuanLyDTO = new TheLoaiQuanLyDTO();
            DataRow dr = theloai.Rows[0];
            theLoaiQuanLyDTO.Ten = dr["ten"].ToString();
            theLoaiQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(id);
            return theLoaiQuanLyDTO;
        }

        internal void insert(string tenTheLoai)
        {
            theLoaiDAO.insert(tenTheLoai);
        }

        internal int update(TheLoaiQuanLyDTO theLoaiQuanLyDTO)
        {
            return theLoaiDAO.update(theLoaiQuanLyDTO);
        }

        int getSumOfBookByCategory(int id)
        {
            return theLoaiDAO.getSumOfBookByCategory(id);
        }

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
