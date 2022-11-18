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
        public DataTable getAllProfile()
        {
            string query = "usp_Xem_Toan_Bo_Thong_Tin_Nhan_Vien";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        public DataTable getProfileById(int profileId)
        {
            string query = "usp_Xem_Thong_Tin_Nhan_Vien @id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { profileId });
            return result;
        }

        public int updateInfo(HoSoQuanLyDTO hoSoQuanLyDTO)
        {
            string query = "usp_Sua_Thong_Tin_Nhan_Vien @ID , @TEN , @HO  , @DIACHI , @SODT , @HINHANH , @EMAIL , @GIOITINH , @NGAYSINH , @LUONG  , @TRANGTHAI ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoSoQuanLyDTO.Id, hoSoQuanLyDTO.Ten, hoSoQuanLyDTO.Ho, hoSoQuanLyDTO.Diachi, hoSoQuanLyDTO.SoDT, hoSoQuanLyDTO.Hinhanh, hoSoQuanLyDTO.Email, hoSoQuanLyDTO.GioiTinh, hoSoQuanLyDTO.Ngaysinh, hoSoQuanLyDTO.Luong, hoSoQuanLyDTO.TrangThai});
            return result;
        }

        internal int getIdByUsername(string username)
        {
            string query = "usp_Lay_MaHS @TENDANGNHAP";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            if (result != null && result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0][0]);

            }
            return 0;

        }

        public int saveInfo(HoSoQuanLyDTO hoSoQuanLyDTO)
        {

            string query = "usp_Them_Thong_Tin_Nhan_Vien @TEN , @HO , @DIACHI , @SODT , @HINHANH , @EMAIL , @GIOITINH , @NGAYSINH , @LUONG , @TENTK , @MK , @TRANGTHAI ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { hoSoQuanLyDTO.Ten, hoSoQuanLyDTO.Ho, hoSoQuanLyDTO.Diachi, hoSoQuanLyDTO.SoDT, hoSoQuanLyDTO.Hinhanh, hoSoQuanLyDTO.Email , hoSoQuanLyDTO.GioiTinh, hoSoQuanLyDTO.Ngaysinh , hoSoQuanLyDTO.Luong, hoSoQuanLyDTO.TenDangNhap, hoSoQuanLyDTO.MatKhau, hoSoQuanLyDTO.TrangThai});
            if(result!=null && result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0][0]);
                
            }
            return 0;

        }
        internal int saveImage(string hinhanh, int id)
        {
            string query = "usp_Them_Hinh_Anh_Nhan_Vien @ID , @HINHANH ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, hinhanh });
            return result;
        }

        internal int updateBasicInfo(HoSoQuanLyDTO hoSoQuanLyDTO)
        {
            string query = "usp_Sua_Ho_So @ID , @TEN , @HO  , @DIACHI , @SODT , @HINHANH , @EMAIL , @GIOITINH , @NGAYSINH ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoSoQuanLyDTO.Id, hoSoQuanLyDTO.Ten, hoSoQuanLyDTO.Ho, hoSoQuanLyDTO.Diachi, hoSoQuanLyDTO.SoDT, hoSoQuanLyDTO.Hinhanh, hoSoQuanLyDTO.Email, hoSoQuanLyDTO.GioiTinh, hoSoQuanLyDTO.Ngaysinh });
            return result;
        }
    }
}
