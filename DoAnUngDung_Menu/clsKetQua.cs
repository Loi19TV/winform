using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnUngDung_Menu
{
    public class clsKetQua
    {
        private string _MASV;
        private string _MAMH;
        private float _DIEMQUATRINH;
        private float _DIEMTHI;
        private float _DIEMTRUNGBINH;

        public clsKetQua(string mASV, string mAMH, float dIEMQUATRINH, float dIEMTHI, float dIEMTRUNGBINH)
        {
            MASV = mASV;
            MAMH = mAMH;
            DIEMQUATRINH = dIEMQUATRINH;
            DIEMTHI = dIEMTHI;
            DIEMTRUNGBINH = dIEMTRUNGBINH;
        }

        public string MASV { get => _MASV; set => _MASV = value; }
        public string MAMH { get => _MAMH; set => _MAMH = value; }
        public float DIEMQUATRINH { get => _DIEMQUATRINH; set => _DIEMQUATRINH = value; }
        public float DIEMTHI { get => _DIEMTHI; set => _DIEMTHI = value; }
        public float DIEMTRUNGBINH
        {
            get => (float)(DIEMQUATRINH * 0.4 + DIEMTHI * 0.6);
            set => _DIEMTRUNGBINH = value;
        }
    }
}
