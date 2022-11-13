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
        public ArrayList getNgonNgu()
        {
            ArrayList ngonNguQuanLyDTOs = new ArrayList();
            DataTable ngonngus = ngonNguDAL.getAllLanguages();
            foreach (DataRow dr in ngonngus.Rows)
            {
                NgonNguQuanLyDTO ngonNguQuanLyDTO = new NgonNguQuanLyDTO();
                ngonNguQuanLyDTO.Id = Convert.ToInt32(dr["id"]);
                ngonNguQuanLyDTO.Ten = dr["ten"].ToString();
                ngonNguQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(ngonNguQuanLyDTO.Id);
                ngonNguQuanLyDTOs.Add(ngonNguQuanLyDTO);
            }
            return ngonNguQuanLyDTOs;
        }
        int getSumOfBookByCategory(int id)
        {
            return ngonNguDAL.getSumOfBookByCategory(id);
        }
        internal void delete(int id)
        {
            ngonNguDAL.delete(id);
        }
        internal void insert(string tenTheLoai)
        {
            ngonNguDAL.insert(tenTheLoai);
        }
        internal NgonNguQuanLyDTO getNgonNguById(int id)
        {
            DataTable theloai = ngonNguDAL.getNgonNguById(id);
            NgonNguQuanLyDTO ngonNguQuanLyDTO = new NgonNguQuanLyDTO();
            DataRow dr = theloai.Rows[0];
            ngonNguQuanLyDTO.Ten = dr["ten"].ToString();
            ngonNguQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(id);
            return ngonNguQuanLyDTO;
        }
        internal int update(NgonNguQuanLyDTO ngonNguQuanLyDTO)
        {
            return ngonNguDAL.update(ngonNguQuanLyDTO);
        }
    }
}
