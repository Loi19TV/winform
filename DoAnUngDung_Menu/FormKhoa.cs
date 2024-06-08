using BLL;
using DoAnUngDung_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnLaptrinhUngDung
{
    public partial class FormKhoa : Form
    {
        public FormKhoa()
        {
            InitializeComponent();
        }
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            dataGridViewKhoa.DataSource = bll_SinhVien.getDSKhoa();

        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MAKHOA = txtMaKhoa.Text;
            string TENKHOA = txtTenKhoa.Text;
            if(txtMaKhoa.Text=="" || txtTenKhoa.Text=="")
            {
                MessageBox.Show("vui long nhap du lieu");
            }    

           else
            {
                clsKhoa khoa = new clsKhoa(MAKHOA, TENKHOA);
                if (bll_SinhVien.insertKhoa(khoa) >= 0)
                {
                    MessageBox.Show("Thêm khoa thành công");
                    dataGridViewKhoa.DataSource = bll_SinhVien.getDSKhoa();
                }
            }    
        }

        private void dataGridViewKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaKhoa.Text = dataGridViewKhoa.Rows[dong].Cells[0].Value.ToString();
            txtTenKhoa.Text = dataGridViewKhoa.Rows[dong].Cells[1].Value.ToString();
            txtMaKhoa.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MAKHOA = txtMaKhoa.Text;
            string TENKHOA = txtTenKhoa.Text;
            clsKhoa khoa = new clsKhoa(MAKHOA, TENKHOA);
            if (bll_SinhVien.updateKhoa(khoa) >= 0)
            {
                MessageBox.Show("Sửa khoa thành công");
                dataGridViewKhoa.DataSource = bll_SinhVien.getDSKhoa();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhoa.SelectedRows.Count > 0)
            {
                string maKhoa = dataGridViewKhoa.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có muốn xóa khoa {txtTenKhoa.Text} không?", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bll_SinhVien.deleteKhoa(maKhoa);
                    dataGridViewKhoa.DataSource = bll_SinhVien.getDSKhoa();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                dataGridViewKhoa.DataSource = bll_SinhVien.getDSKhoa();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Enabled = true;
            txtMaKhoa.Text = " ";
            txtTenKhoa.Text = " ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
