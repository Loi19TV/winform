using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class connectDB
    {
        private static string stringCN = @"Data Source=B202A-PC04\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();

        public connectDB()
        {
            try
            {
                conn.ConnectionString = stringCN;
                conn.Open();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
