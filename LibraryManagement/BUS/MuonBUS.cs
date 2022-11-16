using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.BUS
{
    public class MuonBUS
    {
        MuonDAL muonDAL = new MuonDAL();

        public PhieuMuonDTO getBrrowing(int id)
        {
            PhieuMuonDTO phieuMuon = new PhieuMuonDTO();
            phieuMuon.add(muonDAL.getBrrowing(id));
            return phieuMuon;
        }

        public int updateBrrowing(int idMuon, PhieuMuonDTO phieuMuon)
        {
            return muonDAL.updateBrrowing(idMuon, phieuMuon);
        }

        public int updateBrrowingBooks(int idMuon, MuonSachDTO muonSach)
        {
            return muonDAL.updateBrrowingBooks(idMuon, muonSach);
        }

        public DanhSachSachMuonDTO getBrrowingBooks(int id)
        {
            DanhSachSachMuonDTO danhSachSachMuon = new DanhSachSachMuonDTO();
            danhSachSachMuon.add(muonDAL.getBrrowingBooks(id));
            return danhSachSachMuon;
        }

        public DanhSachPhieuMuonDTO getListBrrowing()
        {
            DanhSachPhieuMuonDTO danhSachPhieuMuon = new DanhSachPhieuMuonDTO();
            danhSachPhieuMuon.add(muonDAL.getListBrrowing());
            return danhSachPhieuMuon;
        }

        public int updateBrrowingDetail(int id, PhieuMuonDTO phieuMuon, DanhSachSachMuonDTO danhSachSachMuon)
        {
            if (updateBrrowing(id, phieuMuon) == 0) return 0;
            foreach(MuonSachDTO muonSach in danhSachSachMuon.ListMuonSach)
            {
                int result = updateBrrowingBooks(id, muonSach);
                if (result == 0) return 0;
            }
            return 1;
        }

        public int insertBrrowing(PhieuMuonDTO phieuMuon, DanhSachSachMuonDTO danhSachSachMuon)
        {
            if(insertTempBrrowing(danhSachSachMuon) == 1)
            {
                return muonDAL.insertBrrowing(phieuMuon);
            }
            return 0;
        }

        public int insertTempBrrowing(DanhSachSachMuonDTO danhSachSachMuon)
        {
            foreach(MuonSachDTO muonSach in danhSachSachMuon.ListMuonSach)
            {
                int result = muonDAL.insertTempBrrowing(muonSach);
                if (result <= 0) return 0;
            }
            return 1;
        }

        public DanhSachPhieuMuonDTO getFilterListBrrowing(LocPhieuMuonDTO locPhieuMuon)
        {
            DanhSachPhieuMuonDTO danhSachPhieuMuon = new DanhSachPhieuMuonDTO();
            danhSachPhieuMuon.add(muonDAL.getFilterListBrrowing(locPhieuMuon));
            return danhSachPhieuMuon;
        }
    }
}
