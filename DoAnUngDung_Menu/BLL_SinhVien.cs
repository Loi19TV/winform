using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DoAnUngDung_Menu;
using DTO;

namespace BLL
{
    public class BLL_SinhVien
    {
        DAL_SinhVien dal_SinhVien = new DAL_SinhVien();
       // doi mat khau
       public int changeNewPassWord(string id_NguoiDung, string newPassWord, string xacNhanMatKhau)
        {
            return dal_SinhVien.doiMatKhau(id_NguoiDung, newPassWord, xacNhanMatKhau);
        }
        //kiem tra ma mon hoc
        public bool kiemTraMaMonHoc(string maMH)
        {
            return dal_SinhVien.kiemTraMaMonHoc(maMH);
        }
        //kiemTraNguoiDung
        public bool kiemTraNguoiDung(string id)
        {
            return dal_SinhVien.kiemTraNguoiDung(id);
        }
        //kiem tra mat khau
        public bool kiemTraMatKhau(string pass)
        {
            return dal_SinhVien.kiemTraMatKhau(pass);
        }
        //get info
        public DataTable getInfo()
        {
            string query = "sp_GetInfo";
            return dal_SinhVien.getInfo(query);
        }
        //Sinh vien
        public int insertSinhVien(clsSinhVien clsSV)
        {
            return dal_SinhVien.themSinhVien(clsSV);
        }
        //Search
        public DataTable getSearch(string studentName)
        {
            return dal_SinhVien.SearchStudentsByName(studentName);

        }

        public int deleteSinhVien(string maSV)
        {
            return dal_SinhVien.xoaSinhVien(maSV);
        }

        public int suaSinhVien(clsSinhVien clsSV)
        {
            return dal_SinhVien.suaSinhVien(clsSV);
        }

        public DataTable getDSSinhVien()
        {
            DataTable dt = new DataTable();
            dt = dal_SinhVien.getDataFromTable("SINHVIEN");
            return dt;
        }
        //Khoa
        public int insertKhoa(clsKhoa clsKhoa)
        {
            return dal_SinhVien.themKhoa(clsKhoa);
        }

        public int deleteKhoa(string maKhoa)
        {
            return dal_SinhVien.xoaKhoa(maKhoa);
        }

        public int updateKhoa(clsKhoa clsKhoa)
        {
            return dal_SinhVien.suaKhoa(clsKhoa);
        }

        public DataTable getDSKhoa()
        {
            DataTable dt = new DataTable();
            dt = dal_SinhVien.getDataFromTable("KHOA");
            return dt;
        }
        //Mon hoc
        public int insertMonHoc(clsMonHoc clsMonHoc)
        {
            return dal_SinhVien.themMonHoc(clsMonHoc);
        }

        public int deleteMonHoc(string maMH)
        {
            return dal_SinhVien.xoaMonHoc(maMH);
        }

        public int updateMonHoc(clsMonHoc clsMonHoc)
        {
            return dal_SinhVien.suaMonHoc(clsMonHoc);
        }

        public DataTable getDSMonHoc()
        {
            DataTable dt = new DataTable();
            dt = dal_SinhVien.getDataFromTable("MONHOC");
            return dt;
        }
        //Ket qua
        public int insertDiem(clsKetQua clsKetQua)
        {
            return dal_SinhVien.themDiem(clsKetQua);
        }

        public int deleteDiem(string maMH, string maSV)
        {
            return dal_SinhVien.xoaDiem(maSV, maMH);
        }

        public int updateDiem(clsKetQua clsKetQua)
        {
            return dal_SinhVien.suaDiem(clsKetQua);
        }

        public DataTable diemTangDan(string tenKhoa)
        {
            DataTable dt = new DataTable();
            dt = dal_SinhVien.Sortpointsinascendingorder(tenKhoa);

            return dt;
        }
        public DataTable diemGiamDan(string tenKhoa)
        {
            DataTable dt = new DataTable();
            dt = dal_SinhVien.Sortpointsindescendingorder(tenKhoa);

            return dt;
        }
        public DataTable getDSDiem()
        {
            DataTable dt = new DataTable();
            dt = dal_SinhVien.getDataFromTable("KETQUA");
            return dt;
        }
       
        public List<float> getDSDiemTrungBinh()
        {
            return dal_SinhVien.getDSDiemTrungBinh();
        }
    }
}
