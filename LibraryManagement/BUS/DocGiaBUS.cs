using LibraryManagement.DAL;
using LibraryManagement.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.BUS
{
    public class DocGiaBUS
    {
        DocGiaDAO docGiaDAO = new DocGiaDAO();
        internal ArrayList getDocGia()
        {
            ArrayList docgiaDTOs = new ArrayList();
            DataTable docgias = docGiaDAO.getDocGia();

            foreach (DataRow dr in docgias.Rows)
            {
                DocGiaQuanLyDTO docGiaDTO = new DocGiaQuanLyDTO();
                docGiaDTO.Id = Convert.ToInt32(dr["id"]);
                docGiaDTO.Mssv = dr["mssv"].ToString();
                docGiaDTO.Ten = dr["ten"].ToString();
                docGiaDTO.Khoa = dr["khoa"].ToString();
                int trangthai = Convert.ToInt32(dr["trangthai"]);
                if (trangthai == 0)
                {
                    docGiaDTO.Trangthai = "Không được mượn";
                }
                else docGiaDTO.Trangthai = "Được phép mượn";
                docgiaDTOs.Add(docGiaDTO);
            }
            return docgiaDTOs;
        }

        internal int saveDocGia(AddDocGiaDTO addDocGiaDTO)
        {
            return docGiaDAO.saveDocGia(addDocGiaDTO);
        }
    }
}
