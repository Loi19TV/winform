using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Data.SqlClient;

namespace DoAnUngDung_Menu
{
    public partial class SapXepDiem : Form
    {
        private static string stringCN = @"Data Source=B202A-PC04\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public SapXepDiem()
        {
            InitializeComponent();
        }
        BLL_SinhVien bill = new BLL_SinhVien();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dtgvSapXepDiem.DataSource = bill.getInfo();
        }

        private void btnDiemTangDan_Click(object sender, EventArgs e)
        {
          
            DataTable dttable = bill.diemTangDan(comboBoxTenKhoa.Text);
            dtgvSapXepDiem.DataSource = dttable;

        }

        private void DiemGiamDan_Click(object sender, EventArgs e)
        {

         
            DataTable dttable = bill.diemGiamDan(comboBoxTenKhoa.Text);
            dtgvSapXepDiem.DataSource = dttable;
        }

        private void SapXepDiem_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(stringCN))
            {
                string query = "SELECT TENKHOA FROM KHOA"; // Truy vấn để lấy danh sách mã khoa từ bảng KHOA

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string tenKhoa = reader["TENKHOA"].ToString();
                        comboBoxTenKhoa.Items.Add(tenKhoa); // Thêm mã khoa vào ComboBox
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SapXepSVTangDan tangDan = new SapXepSVTangDan();
            tangDan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SapXepSVGiamDan giamDan = new SapXepSVGiamDan();
            giamDan.Show();
        }
    }
}
   
