using LibraryManagement.DTO;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class NgonNguDAL
    {
        internal DataTable getAllLanguages()
        {
            string query = "select * from NgonNgu";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        internal int insertNgonNgu(NgonNgu ngonNgu)
        {
            string query = "usp_THEM_NGON_NGU @TEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngonNgu.Name});
            return result;
        }
        internal int getSumOfBookByCategory(int id)
        {
            string query = "SELECT dbo.fn_Tong_So_Sach_Theo_Ngon_Ngu ( @id )";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            try
            {
                return Convert.ToInt32(result.Rows[0][0]);
            }
            catch
            {
                Console.WriteLine(result.Rows[0][0]);
                return 0;
            }

        }
        internal void delete(int id)
        {
            string query = "usp_Xoa_Ngon_Ngu @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        internal void insert(string tenTheLoai)
        {
            string query = "INSERT INTO NgonNgu VALUES(N'" + tenTheLoai + "');";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { });
        }
        internal DataTable getNgonNguById(int id)
        {
            string query = "usp_Xem_Ngon_Ngu_Theo_Id @id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }
        internal int update(NgonNguQuanLyDTO ngonNguQuanLyDTO)
        {
            string query = "usp_Sua_Thong_Tin_Ngon_Ngu @ID , @TEN ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngonNguQuanLyDTO.Id, ngonNguQuanLyDTO.Ten });
            return result;
        }
    }
}
