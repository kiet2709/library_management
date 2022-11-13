using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.DTO;
using LibraryManagement.DAL;
using LibraryManagement.Model;
using System.Collections;
using System.Data;

namespace LibraryManagement.BUS
{
    public class NhaXuatBanBUS
    {
        NhaXuatBanDAL nhaXuatBanDAL = new NhaXuatBanDAL();
        public DanhSachNXBDTO getAllPublisher()
        {
            DanhSachNXBDTO danhSach = new DanhSachNXBDTO();
            danhSach.add(nhaXuatBanDAL.getAllPublisher());
            return danhSach;
        }

        public int insertNXB(NhaXuatBan nxb)
        {
            return nhaXuatBanDAL.insertNXB(nxb);
        }
        internal ArrayList getNhaXuatBan()
        {
            ArrayList nhaXuatBanQuanLyDTOs = new ArrayList();
            DataTable theloais = nhaXuatBanDAL.getNhaXuatBan();
            foreach (DataRow dr in theloais.Rows)
            {
                NhaXuatBanQuanLyDTO nhaXuatBanQuanLyDTO = new NhaXuatBanQuanLyDTO();
                nhaXuatBanQuanLyDTO.Id = Convert.ToInt32(dr["id"]);
                nhaXuatBanQuanLyDTO.Ten = dr["ten"].ToString();
                nhaXuatBanQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(nhaXuatBanQuanLyDTO.Id);
                nhaXuatBanQuanLyDTOs.Add(nhaXuatBanQuanLyDTO);
            }
            return nhaXuatBanQuanLyDTOs;
        }
        int getSumOfBookByCategory(int id)
        {
            return nhaXuatBanDAL.getSumOfBookByCategory(id);
        }
        internal void insert(string tenTheLoai)
        {
            nhaXuatBanDAL.insertNXB(tenTheLoai);
        }
        internal void delete(int id)
        {
            nhaXuatBanDAL.delete(id);
        }
        internal NhaXuatBanQuanLyDTO getNhaXuatBanById(int id)
        {
            DataTable theloai = nhaXuatBanDAL.getNhaXuatBanById(id);
            NhaXuatBanQuanLyDTO nhaXuatBanQuanLyDTO = new NhaXuatBanQuanLyDTO();
            DataRow dr = theloai.Rows[0];
            nhaXuatBanQuanLyDTO.Ten = dr["ten"].ToString();
            nhaXuatBanQuanLyDTO.TongSachTheoTheLoai = getSumOfBookByCategory(id);
            return nhaXuatBanQuanLyDTO;
        }
        internal int update(NhaXuatBanQuanLyDTO nhaXuatBanQuanLyDTO)
        {
            return nhaXuatBanDAL.update(nhaXuatBanQuanLyDTO);
        }
    }
}
