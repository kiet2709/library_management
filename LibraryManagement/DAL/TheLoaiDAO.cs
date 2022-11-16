using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class TheLoaiDAO
    {
        internal void delete(int id)
        {
            string query = "usp_Xoa_The_Loai @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }

        internal int getSumOfBookByCategory(int id)
        {
            string query = "SELECT dbo.fn_Tong_So_Sach_Theo_The_Loai ( @id )";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            try
            {
                return Convert.ToInt32(result.Rows[0][0]);
            } catch
            {
                return 0;
            }
            
        }

        internal DataTable getTheLoai()
        {
            string query = "usp_Xem_The_Loai";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        internal DataTable getTheLoaiById(int id)
        {
            string query = "usp_Xem_The_Loai_Theo_Id @id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }

        internal void insert(string tenTheLoai)
        {
            string query = "INSERT INTO TheLoai VALUES(N'"+ tenTheLoai +"');";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {  });
            
        }

        internal int update(TheLoaiQuanLyDTO theLoaiQuanLyDTO)
        {
            string query = "usp_Sua_Thong_Tin_The_Loai @ID , @TEN ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { theLoaiQuanLyDTO.Id ,theLoaiQuanLyDTO.Ten });
            return result;
        }
    }
}
