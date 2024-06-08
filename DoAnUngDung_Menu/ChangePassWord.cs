using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnUngDung_Menu
{
    public partial class ChangePassWord : Form
    {
        public ChangePassWord()
        {
            InitializeComponent();
        }
        BLL_SinhVien bLL_SinhVien = new BLL_SinhVien();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string id_NguoiDung = txtMaNguoiDung.Text;
            string newPass = txtMatKhauMoi.Text;
            string xacNhanMatKhau = txtXacNhanMatKhau.Text;
            string matKhauCu = txtMatKhauCu.Text;
           if(bLL_SinhVien.kiemTraNguoiDung(id_NguoiDung) && bLL_SinhVien.kiemTraMatKhau(matKhauCu))
            {
                if (bLL_SinhVien.changeNewPassWord(id_NguoiDung, newPass, xacNhanMatKhau) >= 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!!!");
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin người dùng!!!");
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNguoiDung.Text = " ";
            txtMatKhauMoi.Text = " ";
            txtXacNhanMatKhau.Text = " ";
        }
        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == txtMatKhauMoi.Text || string.IsNullOrEmpty(txtXacNhanMatKhau.Text))
            {
                errorProvider1.SetError(txtXacNhanMatKhau, string.Empty);
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Mật khẩu không trùng khớp");
            }
        }
    }
}
