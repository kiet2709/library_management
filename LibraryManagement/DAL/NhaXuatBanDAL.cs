using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class NhaXuatBanDAL
    {
        internal DataTable getAllPublisher()
        {
            string query = "select * from THELOAI_VIEW";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        internal int insertNXB(NhaXuatBan nxb)
        {
            string query = "usp_THEM_NXB @TEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nxb.Name});
            return result;
        }
    }
}
