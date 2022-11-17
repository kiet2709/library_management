using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.Model;
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

        internal DocGia getDocGiaById(int id)
        {
            DataTable result = docGiaDAO.getDocGiaById(id);
            DocGia docGia = new DocGia();
            if (result == null) return null;
            if (result.Rows.Count == 0) return null;
            DataRow dr = result.Rows[0];

            docGia.Id = Convert.ToInt32(dr["id"]);
            docGia.Ten = dr["ten"].ToString();
            docGia.Mssv = dr["mssv"].ToString();
            docGia.Khoa = dr["khoa"].ToString();
            docGia.HinhAnh = dr["hinhAnh"].ToString();
            docGia.Gioitinh = Convert.ToInt32(dr["gioiTinh"]);
            docGia.Trangthai = Convert.ToInt32(dr["trangThai"]);
            docGia.Ngaysinh = (DateTime)dr["ngaySinh"];
            docGia.Sdt = dr["soDT"].ToString();
            docGia.Email = dr["email"].ToString();

            return docGia;


        }

        internal int saveDocGia(AddDocGiaDTO addDocGiaDTO)
        {
            return docGiaDAO.saveDocGia(addDocGiaDTO);
        }

        internal void saveImage(string hinhAnh, int result)
        {
            docGiaDAO.saveImage(hinhAnh, result);
        }

        internal int updateDocGia(DocGia docgia)
        {
            return docGiaDAO.updateDocGia(docgia);
        }

        public int getIdByMSSV(string mssv)
        {
            DataTable result = docGiaDAO.getIdByMSSV(mssv);
            if (result == null) return -1;
            int id = Convert.ToInt32(result.Rows[0][0]);
            if (id < 0) return -1;
            return id;
        }
    }
}
