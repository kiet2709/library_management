using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.DAL
{
    public class TheLoaiDAL
    {
        internal DataTable getAllCatetories()
        {
            string query = "select * from TheLoai";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }

        internal int insertTheLoai(TheLoai theLoai)
        {
            string query = "usp_THEM_THE_LOAI @TEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { theLoai.Name});
            return result;
        }
    }
}
