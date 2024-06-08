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
using BLL;
using DoAnUngDung_Menu;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLISINHVIEN
{
    public partial class frmDSSV : Form
    {
        private static string stringCN = @"Data Source=B202A-PC04\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public frmDSSV()
        {
            InitializeComponent();
        }
        private void frmDSSV_Load(object sender, EventArgs e)
        {
            dataGridViewDSSV.DataSource = bll_SinhVien.getDSSinhVien();
            using (SqlConnection connection = new SqlConnection(stringCN))
            {
                string query = "SELECT MAKHOA FROM KHOA"; // Truy vấn để lấy danh sách mã khoa từ bảng KHOA

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
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

        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTenSV = txtHoTenSV.Text;
            string gioiTinh = "";
            if (rdoNam.Checked == true)
            {
                gioiTinh = rdoNam.Text;
            }
            if (rdoNu.Checked == true)
            {
                gioiTinh = rdoNu.Text;
            }
            DateTime ngaySinh = DateTime.Parse(dateNgaySinh.Text);
            string diaChi = txtDiaChi.Text;
            string maKhoa = txtMaKhoa.Text;
            string soDT = txtSoDienThoai.Text;
            if (rdoNam.Checked == false && rdoNu.Checked == false || txtMaSV.Text == "" || txtHoTenSV.Text == "" || txtHoTenSV.Text == "" || txtDiaChi.Text == "" || txtMaKhoa.Text == "" || txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Vui long nhap du lieu");
            }
            else
            {
                clsSinhVien sinhVien = new clsSinhVien(maSV, hoTenSV, gioiTinh, ngaySinh, diaChi, maKhoa, soDT);
                if (bll_SinhVien.insertSinhVien(sinhVien) >= 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công");
                    dataGridViewDSSV.DataSource = bll_SinhVien.getDSSinhVien();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSSV.SelectedRows.Count > 0)
            {
                string maSV = dataGridViewDSSV.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có muốn xóa sinh viên {txtHoTenSV.Text} không?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bll_SinhVien.deleteSinhVien(maSV);
                    dataGridViewDSSV.DataSource = bll_SinhVien.getDSSinhVien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                dataGridViewDSSV.DataSource = bll_SinhVien.getDSSinhVien();
            }
        }



        private void dataGridViewDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSV.Text = dataGridViewDSSV.Rows[dong].Cells[0].Value.ToString();
            txtHoTenSV.Text = dataGridViewDSSV.Rows[dong].Cells[1].Value.ToString();
            string gioiTinh = dataGridViewDSSV.Rows[dong].Cells[2].Value.ToString();
            if (gioiTinh == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            dateNgaySinh.Text = dataGridViewDSSV.Rows[dong].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridViewDSSV.Rows[dong].Cells[4].Value.ToString();
            txtMaKhoa.Text = dataGridViewDSSV.Rows[dong].Cells[5].Value.ToString();
            txtSoDienThoai.Text = dataGridViewDSSV.Rows[dong].Cells[6].Value.ToString();
            txtMaSV.Enabled = false;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTenSV = txtHoTenSV.Text;
            string gioiTinh = "Nu";
            if (rdoNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            DateTime ngaySinh = DateTime.Parse(dateNgaySinh.Text);
            string diaChi = txtDiaChi.Text;
            string maKhoa = txtMaKhoa.Text;
            string soDT = txtSoDienThoai.Text;

            clsSinhVien sinhVien = new clsSinhVien(maSV, hoTenSV, gioiTinh, ngaySinh, diaChi, maKhoa, soDT);
            if (bll_SinhVien.suaSinhVien(sinhVien) >= 0)
            {
                MessageBox.Show("Sửa sinh viên thành công");
                dataGridViewDSSV.DataSource = bll_SinhVien.getDSSinhVien();
            }
        }
        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMaSV.Enabled = true;
            txtMaSV.Text = "";
            txtHoTenSV.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dateNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtMaKhoa.Text = "";
            txtSoDienThoai.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoDienThoai.Text) || txtSoDienThoai.Text.Length == 10)
            {
                errorProvider1.SetError(txtSoDienThoai, string.Empty);
            }
            else if (txtSoDienThoai.Text.Length > 10 || txtSoDienThoai.Text.Length < 10)
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại hợp lệ!!!");
            }
            else if (handles.checkNumber(txtSoDienThoai.Text) == false)
            {
                errorProvider1.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại hợp lệ!!!");
            }
            else
            {
                errorProvider1.SetError(txtSoDienThoai, string.Empty);
            }
        }
    }
}
