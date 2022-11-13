using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class MuonDAL
    {
        public DataTable getBrrowing(int id)
        {
            string query = "usp_THONG_TIN_PHIEU_MUON @ID ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }

        public int updateBrrowingBooks(int idMuon, MuonSachDTO muonSach)
        {
            string query = "usp_CAP_NHAT_MUON_SACH @MAMUON , @MASACH , @TRANGTHAI , @GHICHU ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMuon, muonSach.Id, muonSach.Trangthai, muonSach.GhiChu });
            return result;
        }

        public DataTable getBrrowingBooks(int id)
        {
            string query = "usp_SACH_TRONG_PHIEU_MUON @MAMUON ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }

        public int updateBrrowing(int idMuon, PhieuMuonDTO phieuMuon)
        {
            string query = "usp_CAP_NHAT_THONG_TIN_PHIEU_MUON @ID , @NGAYTRA , @TIENPHAT";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMuon, phieuMuon.NgayTra, phieuMuon.TienPhat});
            return result;
        }

        public DataTable getListBrrowing()
        {
            string query = "usp_PHIEU_MUON";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }
    }
}
