using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    internal class NhanVienDAO
    {
        public int checkExistAccount(DangNhapDTO dangNhapDTO)
        {
            string query = "usp_Kiem_Tra_Dang_Nhap  @tenDangNhap , @matKhau  ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dangNhapDTO.Taikhoan, dangNhapDTO.Matkhau });
            return Convert.ToInt32(result.Rows[0][0]);
        }
        public int getRole(int id)
        {
            string query = "SELECT dbo.fn_Vai_Tro_Nhan_Vien ( @id ) ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return Convert.ToInt32(result.Rows[0][0]);
        }

        public int updatePasswordById(int accountID,String password)
        {
            string query = "usp_Sua_Mat_Khau_Nhan_Vien @ID , @MATKHAU ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { accountID,password });
            return result;
        }
    }
}
