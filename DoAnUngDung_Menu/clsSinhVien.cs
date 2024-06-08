using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSinhVien
    {
        private string _MASV;
        private string _HOTENSV;
        private string _GIOITINH;
        private DateTime _NGAYSINH;
        private string _DIACHI;
        private string _MAKHOA;
        private string _SODIENTHOAI;

        public clsSinhVien(string mASV, string hOTENSV, string gIOITINH, DateTime nGAYSINH, string dIACHI, string mAKHOA, string sODIENTHOAI)
        {
            MASV = mASV;
            HOTENSV = hOTENSV;
            GIOITINH = gIOITINH;
            NGAYSINH = nGAYSINH;
            DIACHI = dIACHI;
            MAKHOA = mAKHOA;
            SODIENTHOAI = sODIENTHOAI;
        }

        public string MASV { get => _MASV; set => _MASV = value; }
        public string HOTENSV { get => _HOTENSV; set => _HOTENSV = value; }
        public string GIOITINH { get => _GIOITINH; set => _GIOITINH = value; }
        public DateTime NGAYSINH { get => _NGAYSINH; set => _NGAYSINH = value; }
        public string DIACHI { get => _DIACHI; set => _DIACHI = value; }
        public string MAKHOA { get => _MAKHOA; set => _MAKHOA = value; }
        public string SODIENTHOAI { get => _SODIENTHOAI; set => _SODIENTHOAI = value; }
    }
}
