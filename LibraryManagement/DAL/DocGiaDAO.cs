using LibraryManagement.DTO;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    class DocGiaDAO
    {
        internal DataTable getDocGia()
        {
            string query = "usp_Xem_Thong_Tin_Doc_Gia";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        internal int saveDocGia(AddDocGiaDTO addDocGiaDTO)
        {
            string query = "usp_Them_Doc_Gia @TEN , @MSSV , @KHOA , @GIOITINH , @TRANGTHAI , @NGAYSINH , @SODT , @EMAIL , @HINHANH ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { addDocGiaDTO.Ten, addDocGiaDTO.Mssv, addDocGiaDTO.Khoa, addDocGiaDTO.GioiTinh,1, addDocGiaDTO.NgaySinh, addDocGiaDTO.SoDT, addDocGiaDTO.Email, addDocGiaDTO.HinhAnh});
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0][0]);

            }
            return 0;

        }

        internal DataTable getDocGiaById(int id)
        {
            string query = "usp_Lay_Doc_Gia_Theo_Id @ID";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }

        internal int updateDocGia(DocGia docgia)
        {
            string query = "usp_Sua_Doc_Gia @ID , @TEN , @MSSV , @KHOA , @GIOITINH , @TRANGTHAI , @NGAYSINH , @SODT , @EMAIL , @HINHANH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { docgia.Id, docgia.Ten, docgia.Mssv, docgia.Khoa, docgia.Gioitinh, 1, docgia.Ngaysinh, docgia.Sdt, docgia.Email , docgia.HinhAnh});
            return result;
        }

        internal void saveImage(string hinhAnh, int id)
        {
            string query = "usp_Sua_Hinh_Anh_Doc_Gia @ID , @HINHANH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToInt32(id), hinhAnh });
        }
    }
}
