using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnUngDung_Menu
{
   public class clsMonHoc
    {
        private string _MAMH;
        private string _TENMH;
        private string _MAKHOA;
        private string _SOTINCHI;

        public clsMonHoc(string mAMH, string tENMH, string mAKHOA, string sOTINCHI)
        {
            MAMH = mAMH;
            TENMH = tENMH;
            MAKHOA = mAKHOA;
            SOTINCHI = sOTINCHI;
        }

        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public string TENMH { get => _TENMH; set => _TENMH = value; }
        public string MAKHOA { get => _MAKHOA; set => _MAKHOA = value; }
        public string SOTINCHI { get => _SOTINCHI; set => _SOTINCHI = value; }
    }
}
