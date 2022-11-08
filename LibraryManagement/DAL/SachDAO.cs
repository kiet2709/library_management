using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    internal class SachDAO
    {
        public DataTable getBook()
        {
            string query = "usp_Xem_DauSachDTO";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }
        public int getQuantityBookById(int id)
        {
            
            string query = "SELECT dbo.fn_Tong_Sach ( @id );";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return Convert.ToInt32(result.Rows[0][0]);
        }
    }
}
