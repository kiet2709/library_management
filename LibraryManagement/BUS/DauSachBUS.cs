using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.DAL;
using LibraryManagement.DTO;

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
            Console.WriteLine("3");
            if (dauSachDAL.updateBookInfo(id, chiTietDauSach) == 1 && updateAuthors(id, danhSachTacGia) == 1) return 1;
            return -1;
        }

        private int updateAuthors(int id, DanhSachTacGiaDTO danhSachTacGia)
        {
            Console.WriteLine("5");
            DanhSachTacGiaDTO old = getAuthorOfBook(id);
            DanhSachTacGiaDTO del_list = old.OnlyThere(danhSachTacGia);
            DanhSachTacGiaDTO add_list = danhSachTacGia.OnlyThere(old);
            Console.WriteLine(del_list.toString());
            Console.WriteLine(add_list.toString());
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
    }
}
