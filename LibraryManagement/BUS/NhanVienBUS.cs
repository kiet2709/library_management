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
        internal int dangNhap(DangNhapDTO dangNhapDTO)
        {
            int isAccountExist = checkExistAccount(dangNhapDTO);
            if (isAccountExist == -1)
            {
                return -1;
            }
            return getRole(isAccountExist);
        }
        int checkExistAccount(DangNhapDTO dangNhapDTO)
        {
            return nhanVienDAO.checkExistAccount(dangNhapDTO);
        }
        int getRole(int id)
        {
            return nhanVienDAO.getRole(id);
        }

        public int updatePasswordById(int accountID, String password)
        {
            return nhanVienDAO.updatePasswordById(accountID,password);
        }
    }
}
