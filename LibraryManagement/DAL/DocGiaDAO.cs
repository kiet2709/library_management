using LibraryManagement.DTO;
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

        internal int saveDocGia(AddDocGiaDTO addDocGiaDTO)
        {
            string query = "usp_Them_Doc_Gia @TEN , @MSSV , @KHOA , @GIOITINH , @TRANGTHAI , @NGAYSINH , @SODT , @EMAIL ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { addDocGiaDTO.Ten, addDocGiaDTO.Mssv, addDocGiaDTO.Khoa, addDocGiaDTO.GioiTinh,1, addDocGiaDTO.NgaySinh, addDocGiaDTO.SoDT, addDocGiaDTO.Email});

            Console.WriteLine(result);
            Console.WriteLine(addDocGiaDTO.Ten);
            Console.WriteLine(addDocGiaDTO.Mssv);
            Console.WriteLine(addDocGiaDTO.Khoa);
            Console.WriteLine(addDocGiaDTO.GioiTinh);
            return result;

        }
    }
}
