using LibraryManagement.DAL;
using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryManagement.BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        public int dangNhap(DangNhapDTO dangNhapDTO)
        {
            int isAccountExist = checkExistAccount(dangNhapDTO);
            if (isAccountExist == -1)
            {
                return -1;
            }
            if (getRole(isAccountExist).Contains("1"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        int checkExistAccount(DangNhapDTO dangNhapDTO)
        {
            return nhanVienDAO.checkExistAccount(dangNhapDTO);
        }
        string getRole(int id)
        {
            return nhanVienDAO.getRole(id);
        }


        public string getImageByUsername(string username)
        {
            return nhanVienDAO.getImageByUsername(username);
        }

        public int updatePassword(DoiMatKhauDTO doiMatKhauDTO)
        {
            return nhanVienDAO.updatePassword(doiMatKhauDTO);
        }

        public int updatePasswordForAdmin(DoiMatKhauDTO doiMatKhauDTO)
        {
            return nhanVienDAO.updatePasswordForAdmin(doiMatKhauDTO);
        }
    }
}
