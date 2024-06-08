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
    public partial class KetQua : Form
    {
        public KetQua()
        {
            InitializeComponent();
        }
        private static string stringCN = @"Data Source=B202A-PC04\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        BLL_SinhVien bLL_SinhVien = new BLL_SinhVien();
        private void KetQua_Load(object sender, EventArgs e)
        {

            dataGridViewKetQua.DataSource = bLL_SinhVien.getDSDiem();
            using (SqlConnection connection = new SqlConnection(stringCN))
            {
                string query = "SELECT MASV FROM SINHVIEN"; // Truy vấn để lấy danh sách mã khoa từ bảng KHOA

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maKhoa = reader["MASV"].ToString();
                        txtMaSV.Items.Add(maKhoa); // Thêm mã khoa vào ComboBox
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            using (SqlConnection connection = new SqlConnection(stringCN))
            {
                string query = "SELECT MAMH FROM MONHOC"; // Truy vấn để lấy danh sách mã khoa từ bảng KHOA

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maKhoa = reader["MAMH"].ToString();
                        txtMaMH.Items.Add(maKhoa); // Thêm mã khoa vào ComboBox
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            //if (handles.checkNumber(txtDiemQuaTrinh.Text))
            //{
            //    errorProvider1.SetError(txtDiemQuaTrinh, "Diem khong hop le!!!");
            //}
            // else if (txtDiemThi.Text == "")
            //{
            //    errorProvider1.SetError(txtDiemThi, "Can Phai Nhap Diem Thi");
            //}
            //else
            //{
            //    errorProvider1.SetError(txtDiemThi, "");
            //}

            //if (txtDiemQuaTrinh.Text == "")
            //{
            //    errorProvider1.SetError(txtDiemQuaTrinh, "Can Phai Nhap Diem Qua Trinh");
            //}
            //else
            //{
            //    errorProvider1.SetError(txtDiemQuaTrinh, "");
            //}
        }

        private void dataGridViewKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSV.Text = dataGridViewKetQua.Rows[dong].Cells[0].Value.ToString();
            txtMaMH.Text = dataGridViewKetQua.Rows[dong].Cells[1].Value.ToString();
            txtDiemQuaTrinh.Text = dataGridViewKetQua.Rows[dong].Cells[2].Value.ToString();
            txtDiemThi.Text = dataGridViewKetQua.Rows[dong].Cells[3].Value.ToString();
            txtMaMH.Enabled = false;
            txtMaSV.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float DIEMTRUNGBINH = 0;
            string MASV = txtMaSV.Text;
            string MAMH = txtMaMH.Text;

            if (string.IsNullOrEmpty(txtDiemQuaTrinh.Text) || string.IsNullOrEmpty(txtDiemThi.Text) ||
                string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu!!!");
                return; // Exit the method if input is incomplete
            }

            if (!float.TryParse(txtDiemQuaTrinh.Text, out float DIEMQUATRINH) ||
                !float.TryParse(txtDiemThi.Text, out float DIEMTHI))
            {
                MessageBox.Show("Điểm quá trình hoặc điểm thi không hợp lệ!");
                return; // Exit the method if parsing fails
            }

            DIEMTRUNGBINH = (float)(DIEMQUATRINH * 0.4 + DIEMTHI * 0.6);
            clsKetQua ketQua = new clsKetQua(MASV, MAMH, DIEMQUATRINH, DIEMTHI, DIEMTRUNGBINH);

            if (bLL_SinhVien.insertDiem(ketQua) >= 0)
            {
                MessageBox.Show("Thêm điểm thành công");
                dataGridViewKetQua.DataSource = bLL_SinhVien.getDSDiem();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MASV = txtMaSV.Text;
            string MAMH = txtMaMH.Text;
            if (txtDiemQuaTrinh.Text == string.Empty || txtDiemQuaTrinh.Text == string.Empty)
            {
                MessageBox.Show("Vui long nhap du lieu!!!");
            }
            float DIEMQUATRINH = float.Parse(txtDiemQuaTrinh.Text);
            float DIEMTHI = float.Parse(txtDiemThi.Text);
            float DIEMTRUNGBINH = (float)(DIEMQUATRINH * 0.4 + DIEMTHI * 0.6);
            clsKetQua ketQua = new clsKetQua(MASV, MAMH, DIEMQUATRINH, DIEMTHI, DIEMTRUNGBINH);
            if (bLL_SinhVien.updateDiem(ketQua) >= 0)
            {
                MessageBox.Show("Sửa điểm thành công");
                dataGridViewKetQua.DataSource = bLL_SinhVien.getDSDiem();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewKetQua.SelectedRows.Count > 0)
            {
                string maSV = dataGridViewKetQua.SelectedRows[0].Cells[0].Value.ToString();
                string maMH = dataGridViewKetQua.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult s = MessageBox.Show($"Bạn có muốn xóa điểm không?", "Delete", MessageBoxButtons.YesNo);
                if (s == DialogResult.Yes)
                {
                    bLL_SinhVien.deleteDiem(maMH, maSV);
                    MessageBox.Show("Xóa điểm thành công");
                    dataGridViewKetQua.DataSource = bLL_SinhVien.getDSDiem();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa!!!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaMH.Enabled = true;
            txtMaSV.Enabled = true;
            txtMaSV.Text = " ";
            txtMaMH.Text = " ";
            txtDiemQuaTrinh.Text = " ";
            txtDiemThi.Text = " ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDiemQuaTrinh_TextChanged(object sender, EventArgs e)
        {

            if (handles.checkNumber(txtDiemQuaTrinh.Text) == false || txtDiemQuaTrinh.Text == "")
            {
                errorProvider1.SetError(txtDiemQuaTrinh, "Ky Tu Khong Hop LE Hoac Chua Nhap Diem Qua Trinh");
            }
            else
            {
                errorProvider1.SetError(txtDiemQuaTrinh, "");
            }
        }

        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {

            if (handles.checkNumber(txtDiemThi.Text) == false || txtDiemThi.Text == "")
            {
                errorProvider1.SetError(txtDiemThi, "Ky Tu Khong Hop LE Hoac Chua Nhap Diem Thi");
            }
            else
            {
                errorProvider1.SetError(txtDiemThi, "");
            }
        }
    }
}
