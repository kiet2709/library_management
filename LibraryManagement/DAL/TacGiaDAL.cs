using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using LibraryManagement.DTO;
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
            string query = "usp_TAC_GIA_SACH @TEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tacGia.Name});
            return result;
        }
        public void addAuthor(string tacGia)
        {
            string query = "INSERT INTO TacGia VALUES(N'"+ tacGia +"')";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { });
            //return result;
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

        internal int getSumOfBookByCategory(int id)
        {
            string query = "SELECT dbo.fn_Tong_So_Sach_Theo_Tac_Gia ( @id )";
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
        public DataTable getListBookByAuthorID(int id)
        {
            string query = "usp_Xem_Danh_Sach_Dau_Sach_Theo_Tac_Gia @id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }
        internal DataTable getTacGiaById(int id)
        {
            string query = "usp_Xem_Tac_Gia_Theo_Id @id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }
        internal int update(TacGiaQuanLyDTO tacGiaQuanLyDTO)
        {
            string query = "usp_Sua_Thong_Tin_Tac_Gia  @ID , @TEN ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tacGiaQuanLyDTO.Id, tacGiaQuanLyDTO.Ten });
            return result;
        }
    }
}
