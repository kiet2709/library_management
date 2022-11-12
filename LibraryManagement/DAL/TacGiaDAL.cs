using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.Model;

namespace LibraryManagement.DAL
{
    public class TacGiaDAL
    {
        public DataTable getAllAuthors()
        {
            string query = "usp_TAC_GIA_SACH";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        } 

        public int addAuthor(TacGia tacGia)
        {
            string query = "usp_THEM_TAC_GIA @TEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tacGia.Name});
            return result;
        }

        public int delAuthorBook(int idBook, int idAuthor)
        {
            string query = "usp_XOA_TAC_GIA_SACH @idSach , @idTacGia";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBook, idAuthor });
            return result;
        }

        public int updateAuthorBook(int idBook, int oldAuthor, int newAuthor)
        {
            string query = "usp_SUA_TAC_GIA_SACH @idSach , @idTacGiaCu , @idTacGiaMoi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBook, oldAuthor, newAuthor });
            return result;
        }

        public int insertAuthorBook(int idBook, int idAuthor)
        {
            string query = "usp_THEM_TAC_GIA_SACH @idSach , @idTacGia";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBook, idAuthor });
            return result;
        }
    }
}
