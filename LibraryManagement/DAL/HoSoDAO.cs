using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    internal class HoSoDAO
    {
        internal DataTable getAllProfile()
        {
            string query = "usp_Xem_Toan_Bo_Thong_Tin_Nhan_Vien";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        internal DataTable getProfileById(int profileId)
        {
            string query = "usp_Xem_Thong_Tin_Nhan_Vien @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { profileId });
            return result;
        }

        internal int updateProfileById(HoSoQuanLyDTO hoSoQuanLyDTO)
        {
            string query = "usp_Sua_Thong_Tin_Nhan_Vien @ID , @TEN , @HO , @TENDANGNHAP , @DIACHI , @SODT , @HINHANH , @EMAIL , @GIOITINH , @NGAYSINH , @LUONG , @TRANGTHAI ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoSoQuanLyDTO.Id, hoSoQuanLyDTO.Ten, hoSoQuanLyDTO.Ho, hoSoQuanLyDTO.TenDangNhap, hoSoQuanLyDTO.Diachi, hoSoQuanLyDTO.SoDT, hoSoQuanLyDTO.Hinhanh, hoSoQuanLyDTO.Email, hoSoQuanLyDTO.GioiTinh, hoSoQuanLyDTO.Ngaysinh, hoSoQuanLyDTO.Luong , hoSoQuanLyDTO.TrangThai  });
            return result;
        }

        internal DataTable getPasswordById(int profileId)
        {
            string query = "usp_Xem_Mat_Khau_Nhan_Vien @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { profileId });
            return result;
        }
    }
}
