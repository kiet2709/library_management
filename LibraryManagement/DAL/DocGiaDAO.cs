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
    }
}
