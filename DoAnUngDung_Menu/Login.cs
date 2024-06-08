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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           if(txtUserName.Text != String.Empty && txtPassWord.Text!= String.Empty)
            {
                string userName = txtUserName.Text;
                string passWord = txtPassWord.Text;
                if (KiemTraDangNhap(userName, passWord)) { 
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!!!");
                }    
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            bool ketQua = false;

            // Chuỗi kết nối đến cơ sở dữ liệu
            string chuoiKetNoi = @"Data Source=B202A-PC04\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";

            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
                {
                    ketNoi.Open();

                    // Sử dụng truy vấn có tham số để ngăn chặn SQL injection
                    string truyVan = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TENNGUOIDUNG = @sTenNguoiDung AND MATKHAU = @sMatKhau";
                    using (SqlCommand lenh = new SqlCommand(truyVan, ketNoi))
                    {
                        lenh.Parameters.AddWithValue("@sTenNguoiDung", tenDangNhap);
                        lenh.Parameters.AddWithValue("@sMatKhau", matKhau);

                        int soLuong = (int)lenh.ExecuteScalar();
                        ketQua = soLuong > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý hoặc ghi log cho ngoại lệ
                MessageBox.Show("Lỗi trong quá trình thao tác cơ sở dữ liệu: " + ex.Message);
            }

            return ketQua;
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            ChangePassWord changePassWord = new ChangePassWord();
            changePassWord.Show();

        }
    }
}
