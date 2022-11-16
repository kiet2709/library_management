using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement.DTO
{
    public class LocPhieuMuonDTO
    {
        private int mssv; //-1 : Tất cả
        private int trangThai; // 0: Chưa trả hết, 1: Đã trả hết, 2: Tất cả

        public int Mssv { get => mssv; set => mssv = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }

        public LocPhieuMuonDTO()
        {

        }

        public LocPhieuMuonDTO(int mssv, int trangThai)
        {
            this.mssv = mssv;
            this.trangThai = trangThai;
        }
    }
}
