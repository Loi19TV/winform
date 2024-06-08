using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnUngDung_Menu
{
    public class clsKhoa
    {
        private string _MAKHOA;
        private string _TENKHOA;

        public clsKhoa(string mAKHOA, string tENKHOA)
        {
            MAKHOA = mAKHOA;
            TENKHOA = tENKHOA;
        }

        public string MAKHOA { get => _MAKHOA; set => _MAKHOA = value; }
        public string TENKHOA { get => _TENKHOA; set => _TENKHOA = value; }
    }
}
