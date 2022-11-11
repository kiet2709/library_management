using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class DauSachDAL
    {
        public DataTable getBookInfo(int id)
        {
            string query = "usp_Thong_Tin_Chi_Tiet_Dau_Sach @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id});
            return result;
        }

        public DataTable getAuthorOfBook(int id)
        {
            string query = "usp_TAC_GIA_SACH_CU_THE @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }

        public DataTable getNumberOfBook(int id)
        {
            string query = "fn_Tong_Sach @ID_DAU_SACH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }

        public int updateBookInfo(int id, ChiTietDauSachDTO chiTietDauSach)
        {
            string query = "usp_CAP_NHAT_THONG_TIN_DAU_SACH @ID , @TIEUDE , @MOTA , @GIA , @NGAYXB , @HINHANH , @LOAI , @TRANGTHAI , @MANXB , @MANGONGU , @MATHELOAI";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,  chiTietDauSach.TieuDe, chiTietDauSach.MoTa, chiTietDauSach.Gia, chiTietDauSach.NgayXB.ToString(), 
            chiTietDauSach.HinhAnh, chiTietDauSach.DanhMuc, chiTietDauSach.TrangThai, chiTietDauSach.NhaXB, chiTietDauSach.NgonNgu, chiTietDauSach.TheLoai});
            return result;
        }
    }
}
