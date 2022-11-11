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
    }
}
