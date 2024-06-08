using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUngDung_Menu
{
    public partial class MonHoc : Form
    {
        private static string stringCN = @"Data Source=B202A-PC04\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public MonHoc()
        {
            InitializeComponent();
        }
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
        private void MonHoc_Load(object sender, EventArgs e)
        {
            dataGridViewMonHoc.DataSource = bll_SinhVien.getDSMonHoc();

            using (SqlConnection connection = new SqlConnection(stringCN))
            {
                string query = "SELECT MAKHOA FROM KHOA"; // Truy vấn để lấy danh sách mã khoa từ bảng KHOA

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query,connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maKhoa = reader["MAKHOA"].ToString();
                        txtMaKhoa.Items.Add(maKhoa); // Thêm mã khoa vào ComboBox
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaMH.Text = dataGridViewMonHoc.Rows[dong].Cells[0].Value.ToString();
            txtSoTinChi.Text = dataGridViewMonHoc.Rows[dong].Cells[1].Value.ToString();
            txtTenMH.Text = dataGridViewMonHoc.Rows[dong].Cells[2].Value.ToString();
            txtMaKhoa.Text = dataGridViewMonHoc.Rows[dong].Cells[3].Value.ToString();
            txtMaMH.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string MAMH = txtMaMH.Text;
            string TENMH = txtTenMH.Text;
            string MAKHOA = txtMaKhoa.Text;
            string SOTINCHI = txtSoTinChi.Text;

            if (bll_SinhVien.kiemTraMaMonHoc(MAMH))
            {
                MessageBox.Show("Mã môn học đã tồn tại");
            }
            else
            {
                if (txtMaMH.Text == string.Empty || txtTenMH.Text == string.Empty || txtMaKhoa.Text == string.Empty)
                {
                    MessageBox.Show("Vui long nhap du lieu");
                }
                else
                {
                    if (handles.checkNumber(txtSoTinChi.Text) == false)
                    {
                        MessageBox.Show("Số tín chỉ không hợp lệ");
                        return;
                    }
                    clsMonHoc monHoc = new clsMonHoc(MAMH, TENMH, MAKHOA,SOTINCHI);
                    if (bll_SinhVien.insertMonHoc(monHoc) >= 0)
                    {
                        MessageBox.Show("Thêm môn học thành công");
                        dataGridViewMonHoc.DataSource = bll_SinhVien.getDSMonHoc();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewMonHoc.SelectedRows.Count > 0)
            {
                string maMH = dataGridViewMonHoc.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult s = MessageBox.Show($"Bạn có muốn xóa môn {txtTenMH.Text} không?", "Delete", MessageBoxButtons.YesNo);
                if(s == DialogResult.Yes)
                {
                    bll_SinhVien.deleteMonHoc(maMH);
                    MessageBox.Show("Xóa môn học thành công");
                    dataGridViewMonHoc.DataSource = bll_SinhVien.getDSMonHoc();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MAMH = txtMaMH.Text;
            string TENMH = txtTenMH.Text;
            string MAKHOA = txtMaKhoa.Text;
            string SOTINCHI = txtSoTinChi.Text;
            clsMonHoc monHoc = new clsMonHoc(MAMH, TENMH, MAKHOA, SOTINCHI);
            if (bll_SinhVien.updateMonHoc(monHoc) >= 0)
            {
                MessageBox.Show("Sửa môn học thành công");
                dataGridViewMonHoc.DataSource = bll_SinhVien.getDSMonHoc();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaMH.Enabled = true;
            txtMaMH.Text = " ";
            txtTenMH.Text = " ";
            txtMaKhoa.Text = " ";
            txtSoTinChi.Text = " ";
        }

        private void txtMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XuatDanhSachMonHoc mh = new XuatDanhSachMonHoc();
            mh.Show();
        }
    }
}
