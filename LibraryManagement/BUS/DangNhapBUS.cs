using LibraryManagement.DAL;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.BUS
{
    public class DangNhapBUS
    {
        internal int dangNhap(DangNhapDTO dangNhapDTO)
        {
            int isAccountExist = checkExistAccount(dangNhapDTO);
            if (isAccountExist == -1)
            {
                return -1;
            }
            return getRole(isAccountExist);
        }
        int checkExistAccount(DangNhapDTO dangNhapDTO)
        {
            string query = "usp_Kiem_Tra_Dang_Nhap  @tenDangNhap , @matKhau  ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { dangNhapDTO.Taikhoan, dangNhapDTO.Matkhau });
            return Convert.ToInt32(result.Rows[0][0]);
        }
        int getRole(int id)
        {
            string query = "SELECT dbo.fn_Vai_Tro_Nhan_Vien ( @id ) ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return Convert.ToInt32(result.Rows[0][0]);
        }
    }
}
