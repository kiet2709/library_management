using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.DTO;
using LibraryManagement.DAL;
using LibraryManagement.Model;
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
    }
}
