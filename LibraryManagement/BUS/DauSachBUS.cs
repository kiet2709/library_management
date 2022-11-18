using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagement.DAL;
using LibraryManagement.DTO;
using LibraryManagement.Model;

namespace LibraryManagement.BUS
{
    public class DauSachBUS
    {
        DauSachDAL dauSachDAL = new DauSachDAL();
        TacGiaDAL tacGiaDAL = new TacGiaDAL();
        public ChiTietDauSachDTO getBookInfo(int id)
        {
            ChiTietDauSachDTO chiTietDauSach = new ChiTietDauSachDTO();
            chiTietDauSach.add(dauSachDAL.getBookInfo(id));
            return chiTietDauSach;
        }

        public DanhSachTacGiaDTO getAuthorOfBook(int id)
        {
            DanhSachTacGiaDTO danhSachTacGia = new DanhSachTacGiaDTO();
            danhSachTacGia.add(dauSachDAL.getAuthorOfBook(id));
            return danhSachTacGia;
        }

        public int getNumberOfBook(int id)
        {
            return Convert.ToInt32(dauSachDAL.getNumberOfBook(id).Rows[0][0]);
        }

        public int updateBookInfo(int id, ChiTietDauSachDTO chiTietDauSach, DanhSachTacGiaDTO danhSachTacGia)
        {
            if (dauSachDAL.updateBookInfo(id, chiTietDauSach) == 1 && updateAuthors(id, danhSachTacGia) == 1) return 1;
            return -1;
        }

        private int updateAuthors(int id, DanhSachTacGiaDTO danhSachTacGia)
        {
            DanhSachTacGiaDTO old = getAuthorOfBook(id);
            DanhSachTacGiaDTO del_list = old.OnlyThere(danhSachTacGia);
            DanhSachTacGiaDTO add_list = danhSachTacGia.OnlyThere(old);
            int del_size = del_list.ListTacGia.Count;
            int add_size = add_list.ListTacGia.Count;
            try
            {
                if (del_size > add_size)
                {
                    for (int i = 0; i < del_list.ListTacGia.Count; i++)
                    {
                        if (i < add_size)
                        {
                            tacGiaDAL.updateAuthorBook(id, del_list.ListTacGia[i].Id, add_list.ListTacGia[i].Id);
                        }
                        else
                        {
                            tacGiaDAL.delAuthorBook(id, del_list.ListTacGia[i].Id);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < add_list.ListTacGia.Count; i++)
                    {
                        if (i < del_size)
                        {
                            tacGiaDAL.updateAuthorBook(id, del_list.ListTacGia[i].Id, add_list.ListTacGia[i].Id);
                        }
                        else
                        {
                            tacGiaDAL.insertAuthorBook(id, add_list.ListTacGia[i].Id);
                        }
                    }
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }

        internal int save(ChiTietDauSachDTO chiTietDauSach, DanhSachTacGiaDTO danhSachTacGia)
        {
            DataTable resultDauSach = dauSachDAL.save(chiTietDauSach);
            int maDauSach;
            try
            {
                maDauSach =  Convert.ToInt32( resultDauSach.Rows[0][0]);
                for (int i=0; i<danhSachTacGia.ListTacGia.Count; i++)
                {
                    int resultTacGia = dauSachDAL.saveAuthorBook(maDauSach, danhSachTacGia.ListTacGia[i].Id);
                }
                return maDauSach;
            }
            catch
            {
                maDauSach = 0;
            }
            return maDauSach;
        }

        internal void saveImage(string imagePath, int result)
        {
            dauSachDAL.saveImage(imagePath, result);
        }

        public DanhSachDauSachDTO getBookTitles()
        {
            DataTable result = dauSachDAL.getBookTitles();
            if (result == null || result.Rows.Count == 0) return null;
            DanhSachDauSachDTO danhSachDauSach = new DanhSachDauSachDTO();
            danhSachDauSach.add(result);
            return danhSachDauSach;
        }

        public DanhSachCuonSachDTO getBooksByIdTitle(int id)
        {
            DataTable result = dauSachDAL.getgetBooksByIdTitle(id);
            if (result == null || result.Rows.Count == 0) return null;
            DanhSachCuonSachDTO danhSachCuonSach = new DanhSachCuonSachDTO();
            danhSachCuonSach.add(result);
            return danhSachCuonSach;
        }

        public int insertBook(int idBookTitle, Sach sach)
        {
            return dauSachDAL.insertBook(idBookTitle, sach);
        }

        public int updateBooks(DanhSachCuonSachDTO danhSachCuonSach)
        {
            foreach(Sach sach in danhSachCuonSach.ListSach)
            {
                if(updateBook(sach) <= 0)
                {
                    return -1;
                }
            }
            return 1;
        }

        public int updateBook(Sach sach)
        {
            return dauSachDAL.updateBook(sach);
        }
    }
}
