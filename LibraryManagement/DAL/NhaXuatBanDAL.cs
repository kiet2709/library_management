using LibraryManagement.DTO;
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
        internal int insertNXB(string nxb)
        {
            string query = "usp_THEM_NXB @TEN";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nxb });
            return result;
        }
        internal DataTable getNhaXuatBan()
        {
            string query = "SELECT * FROM NhaXuatBan";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return result;
        }
        internal int getSumOfBookByCategory(int id)
        {
            string query = "SELECT dbo.fn_Tong_So_Sach_Theo_Nha_Xuat_Ban ( @id )";
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
            string query = "usp_Xoa_Nha_Xuat_Ban @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
        internal DataTable getNhaXuatBanById(int id)
        {
            string query = "usp_Xem_Nha_Xuat_Ban_Theo_Id @id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }
        internal int update(NhaXuatBanQuanLyDTO nhaXuatBanQuanLyDTO)
        {
            string query = "usp_Sua_Thong_Tin_Nha_Xuat_Ban @ID , @TEN ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nhaXuatBanQuanLyDTO.Id, nhaXuatBanQuanLyDTO.Ten });
            return result;
        }
    }
}
