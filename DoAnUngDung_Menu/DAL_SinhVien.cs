using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DoAnUngDung_Menu;

namespace DAL
{
    public class DAL_SinhVien : connectDB
    {
        public DataTable getDataFromTable(string nameTable)
        {
            DataTable dtSV = new DataTable();
            string query = "Select * From " + nameTable;
            SqlCommand cmdSQL = new SqlCommand(query, conn);
            SqlDataAdapter daSV = new SqlDataAdapter(cmdSQL);
            daSV.Fill(dtSV);
            return dtSV;
        }
        //get info
        public DataTable getInfo(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmdSQL = new SqlCommand(query, conn);
            SqlDataAdapter daSV = new SqlDataAdapter(cmdSQL);
            daSV.Fill(dt);
            return dt;
        }
        //tim kiem dua vao ten sinh vien
        public DataTable Search(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmdSQL = new SqlCommand(query, conn);
            SqlDataAdapter daSV = new SqlDataAdapter(cmdSQL);
            daSV.Fill(dt);
            return dt;
        }
        public DataTable SearchStudentsByName(string studentName)
        {
            DataTable dt = new DataTable();
            SqlCommand cmdSQL = new SqlCommand("sp_SearchStudentByName", conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sTenSV", studentName);

            SqlDataAdapter daSV = new SqlDataAdapter(cmdSQL);
            daSV.Fill(dt);

            return dt;
        }
        public int themSinhVien(clsSinhVien clsSV)
        {
            string sp_InsertSinhVien = "sp_InsertSinhVien";
            SqlCommand cmdSQL = new SqlCommand(sp_InsertSinhVien, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMASV", clsSV.MASV);
            cmdSQL.Parameters.AddWithValue("@sHOTENSV", clsSV.HOTENSV);
            cmdSQL.Parameters.AddWithValue("@sGIOITINH", clsSV.GIOITINH);
            cmdSQL.Parameters.AddWithValue("@sNGAYSINH", clsSV.NGAYSINH);
            cmdSQL.Parameters.AddWithValue("@sDIACHI", clsSV.DIACHI);
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", clsSV.MAKHOA);
            cmdSQL.Parameters.AddWithValue("@sSODIENTHOAI", clsSV.SODIENTHOAI);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }

        public int xoaSinhVien(string maSV)
        {
            string sp_DeleteSinhVien = "sp_DeleteSinhVien";
            SqlCommand cmdSQL = new SqlCommand(sp_DeleteSinhVien, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMASV", maSV);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }

        public int suaSinhVien(clsSinhVien clsSV)
        {
            string sp_UpdateSinhVien = "sp_UpdateSinhVien";
            SqlCommand cmdSQL = new SqlCommand(sp_UpdateSinhVien, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMASV", clsSV.MASV);
            cmdSQL.Parameters.AddWithValue("@sHOTENSV", clsSV.HOTENSV);
            cmdSQL.Parameters.AddWithValue("@sGIOITINH", clsSV.GIOITINH);
            cmdSQL.Parameters.AddWithValue("@sNGAYSINH", clsSV.NGAYSINH);
            cmdSQL.Parameters.AddWithValue("@sDIACHI", clsSV.DIACHI);
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", clsSV.MAKHOA);
            cmdSQL.Parameters.AddWithValue("@sSODIENTHOAI", clsSV.SODIENTHOAI);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Khoa
        //Insert Khoa
        public int themKhoa(clsKhoa clsKhoa)
        {
            string sp_InsertKhoa = "sp_InsertKhoa";
            SqlCommand cmdSQL = new SqlCommand(sp_InsertKhoa, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", clsKhoa.MAKHOA);
            cmdSQL.Parameters.AddWithValue("@sTENKHOA", clsKhoa.TENKHOA);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Delete Khoa
        public int xoaKhoa(string maKhoa)
        {
            string sp_DeleteKhoa = "sp_DeleteKhoa";
            SqlCommand cmdSQL = new SqlCommand(sp_DeleteKhoa, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", maKhoa);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Update Khoa
        public int suaKhoa(clsKhoa clsKhoa)
        {
            string sp_UpdateKhoa = "sp_UpdateKhoa";
            SqlCommand cmdSQL = new SqlCommand(sp_UpdateKhoa, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", clsKhoa.MAKHOA);
            cmdSQL.Parameters.AddWithValue("@sTENKHOA", clsKhoa.TENKHOA);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Mon hoc
        //Insert
        public int themMonHoc(clsMonHoc clsMonHoc)
        {
            string sp_InsertMonHoc = "sp_InsertMonHoc";
            SqlCommand cmdSQL = new SqlCommand(sp_InsertMonHoc, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAMH", clsMonHoc.MAMH);
            cmdSQL.Parameters.AddWithValue("@sTENMH", clsMonHoc.TENMH);
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", clsMonHoc.MAKHOA);
            cmdSQL.Parameters.AddWithValue("@sSOTINCHI", clsMonHoc.SOTINCHI);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Delete
        public int xoaMonHoc(string maMH)
        {
            string sp_DeleteMonHoc = "sp_DeleteMonHoc";
            SqlCommand cmdSQL = new SqlCommand(sp_DeleteMonHoc, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAMH", maMH);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Update
        public int suaMonHoc(clsMonHoc clsMonHoc)
        {
            string sp_UpdateMonHoc = "sp_UpdateMonHoc";
            SqlCommand cmdSQL = new SqlCommand(sp_UpdateMonHoc, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAMH", clsMonHoc.MAMH);
            cmdSQL.Parameters.AddWithValue("@sTENMH", clsMonHoc.TENMH);
            cmdSQL.Parameters.AddWithValue("@sMAKHOA", clsMonHoc.MAKHOA);
            cmdSQL.Parameters.AddWithValue("@sSOTINCHI", clsMonHoc.SOTINCHI);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Ket qua
        //Insert
        public int themDiem(clsKetQua clsKetQua)
        {
            string sp_InsertKetQua = "sp_InsertKetQua";
            SqlCommand cmdSQL = new SqlCommand(sp_InsertKetQua, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            double roundedDIEMTRUNGBINH = Math.Round(clsKetQua.DIEMTRUNGBINH, 2);
            double roundedDIEMTHI = Math.Round(clsKetQua.DIEMTHI, 2);
            double roundedDIEMQUATRINH = Math.Round(clsKetQua.DIEMQUATRINH, 2);
            cmdSQL.Parameters.AddWithValue("@sMASV", clsKetQua.MASV);
            cmdSQL.Parameters.AddWithValue("@sMAMH", clsKetQua.MAMH);
            cmdSQL.Parameters.AddWithValue("@sDIEMQUATRINH", roundedDIEMQUATRINH);
            cmdSQL.Parameters.AddWithValue("@sDIEMTHI", roundedDIEMTHI);
            cmdSQL.Parameters.AddWithValue("@sDIEMTRUNGBINH", roundedDIEMTRUNGBINH);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Delete
        public int xoaDiem(string maSV, string maMH)
        {
            string sp_DeleteKetQua = "sp_DeleteKetQua";
            SqlCommand cmdSQL = new SqlCommand(sp_DeleteKetQua, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sMAMH", maMH);
            cmdSQL.Parameters.AddWithValue("@sMASV", maSV);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //Update
        public int suaDiem(clsKetQua clsKetQua)
        {
            string sp_UpdateKetQua = "sp_UpdateKetQua";
            SqlCommand cmdSQL = new SqlCommand(sp_UpdateKetQua, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            double roundedDIEMTRUNGBINH = Math.Round(clsKetQua.DIEMTRUNGBINH, 2);
            double roundedDIEMTHI = Math.Round(clsKetQua.DIEMTHI, 2);
            double roundedDIEMQUATRINH = Math.Round(clsKetQua.DIEMQUATRINH, 2);
            cmdSQL.Parameters.AddWithValue("@sMASV", clsKetQua.MASV);
            cmdSQL.Parameters.AddWithValue("@sMAMH", clsKetQua.MAMH);
            cmdSQL.Parameters.AddWithValue("@sDIEMQUATRINH", roundedDIEMQUATRINH);
            cmdSQL.Parameters.AddWithValue("@sDIEMTHI", roundedDIEMTHI);
            cmdSQL.Parameters.AddWithValue("@sDIEMTRUNGBINH", roundedDIEMTRUNGBINH);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        public DataTable Sortpointsinascendingorder(string tenKhoa)
        {
            DataTable dataTable = new DataTable();

            string query = "SapXepTangDan";



            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public DataTable Sortpointsindescendingorder(string tenKhoa)
        {
            DataTable dataTable = new DataTable();

            string query = "SapXepGiamDan";


            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public List<float> getDSDiemTrungBinh()
        {
            int iKetQua = -1;
            string sql = "sp_GetDiemTrungBinh";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = sql;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = CommandType.StoredProcedure;

            List<float> dsDiemTB = new List<float>(); ;
            using (SqlDataReader reader = sqlcmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    float diemTB = float.Parse(reader["DIEMTRUNGBINH_TONG"].ToString());
                    dsDiemTB.Add(diemTB);
                }
            }
            return dsDiemTB;
        }
        //doi mat khau
        public int doiMatKhau(string id_NguoiDung, string newPassWord, string xacNhanMatKhau)
        {
            string sp_ChangePassword = "sp_ChangePassword";
            SqlCommand cmdSQL = new SqlCommand(sp_ChangePassword, conn);
            cmdSQL.CommandType = CommandType.StoredProcedure;
            cmdSQL.Parameters.AddWithValue("@sId_NguoiDung", id_NguoiDung);
            cmdSQL.Parameters.AddWithValue("@sNewPassword", newPassWord);
            int result = 0;
            try
            {
                if (cmdSQL.ExecuteNonQuery() >= 0)
                {
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }
        //kiem tra mã môn học co ton tai hay không
        public bool kiemTraMaMonHoc(string maMH)
        {
            bool kiemTra = false;
            string query = "SELECT COUNT(*) FROM MONHOC WHERE MAMH = @MA_MH";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@MA_MH", maMH);
                int userCount = (int)command.ExecuteScalar();

                // Nếu số lượng bằng 1, tức là ID người dùng tồn tại
                kiemTra = (userCount == 1);
            }
            return kiemTra;
        }
        //kiem tra id_nguoi dung co ton tai hay không
        public bool kiemTraNguoiDung(string id)
        {
            bool kiemTra = false;
            string query = "SELECT COUNT(*) FROM NGUOIDUNG WHERE ID_NGUOIDUNG = @UserId";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@UserId", id);
                int userCount = (int)command.ExecuteScalar();

                // Nếu số lượng bằng 1, tức là ID người dùng tồn tại
                kiemTra = (userCount == 1);
            }
            return kiemTra;
        }
        //kiemTraMatKhau
        public bool kiemTraMatKhau(string oldPasss)
        {
            bool kiemTra = false;
            string query = "SELECT COUNT(*) FROM NGUOIDUNG WHERE MATKHAU = @OldPass";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@OldPass", oldPasss);
                int passCount = (int)command.ExecuteScalar();

                // Nếu số lượng bằng 1, tức là ID người dùng tồn tại
                kiemTra = (passCount == 1);
            }
            return kiemTra;
        }
    }
}