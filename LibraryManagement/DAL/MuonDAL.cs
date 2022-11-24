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

        public DataTable getFilterListBrrowing(LocPhieuMuonDTO locPhieuMuon)
        {
            string query = "usp_LOC_PHIEU_MUON  @MSSV , @TRANGTHAI ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { locPhieuMuon.Mssv, locPhieuMuon.TrangThai });
            return result;
        }

        public int insertBrrowing(PhieuMuonDTO phieuMuon)
        {
            string query = "usp_Them_Thong_Tin_Phieu_Muon @ngaymuon , @ngaytra , @ngayhethan , @tienphat , @maNhanVien , @maDocGia ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { phieuMuon.NgayMuon.ToString("MM-dd-yyyy"), phieuMuon.NgayTra.ToString("MM-dd-yyyy"), 
                                phieuMuon.HanTra.ToString("MM-dd-yyyy"), phieuMuon.TienPhat, phieuMuon.MaThuThu, Convert.ToInt32(phieuMuon.Mssv) });
            return result;
        }

        public int insertTempBrrowing(MuonSachDTO muonSach)
        {
            string query = "usp_THEM_TAM_SACH_TRONG_PHIEU_MUON @MAMUON , @MASACH , @GHICHU , @TRANGTHAI";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { muonSach.MaMuon, muonSach.Id, muonSach.GhiChu, muonSach.Trangthai});
            return result;
        }

        public int deleteTempBrrowing()
        {
            string query = "usp_XOA_BANG_TAM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { });
            return result;
        }
    }
}
