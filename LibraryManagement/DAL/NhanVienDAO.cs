using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class NhanVienDAO
    {
        public int checkExistAccount(DangNhapDTO dangNhapDTO)
        {
            string query = "usp_Kiem_Tra_Dang_Nhap  @tenDangNhap , @matKhau  ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dangNhapDTO.Taikhoan, dangNhapDTO.Matkhau });
            return Convert.ToInt32(result.Rows[0][0]);
        }
        public string getRole(int id)
        {
            string query = "SELECT dbo.fn_Vai_Tro_Nhan_Vien ( @id ) ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result.Rows[0][0].ToString();
        }

        internal DataTable getCredentials(string username)
        {
            string query = "SELECT usp_Thong_Tin_Dang_Nhap  @TENDANGNHAP ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result;
        }

        public int updatePassword(DoiMatKhauDTO doiMatKhauDTO)
        {
            string query = "usp_Doi_Mat_Khau  @MAHOSO , @MATKHAUCU , @MATKHAUMOI ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { doiMatKhauDTO.MaHS, doiMatKhauDTO.MatKhauCu, doiMatKhauDTO.MatKhauMoi });
            return result;
        }

        internal int updatePasswordForAdmin(DoiMatKhauDTO doiMatKhauDTO)
        {
            string query = "usp_Quan_Ly_Doi_Mat_Khau  @MAHOSO , @MATKHAUMOI ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { doiMatKhauDTO.MaHS, doiMatKhauDTO.MatKhauMoi });
            return result;
        }

        public DataTable getIdByName(string username)
        {
            string query = "usp_MA_NHAN_VIEN_THEO_TEN  @TENDANGNHAP ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result;
        }

        public string getImageByUsername(string username)
        {
            string query = "usp_Hinh_Anh_Nhan_Vien  @TENDANGNHAP ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            if(result != null && result.Rows.Count > 0)
            {
                return result.Rows[0][0].ToString();
            }
            return "";
        }
    }
}
