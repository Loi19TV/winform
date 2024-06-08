using DoAnLaptrinhUngDung;
using QUANLISINHVIEN;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenCurrentFormChild(Form childForm)
        {
            if(currentFormChild!= null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //chinh size 
            float scaleWidth = panel_body.Width / (float)childForm.Width;
            float scaleHeight = panel_body.Height / (float)childForm.Height;
            childForm.Scale(new SizeF(scaleWidth, scaleHeight));
            panel_body.Controls.Add(childForm); 
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new frmDSSV());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            FormKhoa formKhoa = new FormKhoa();
            OpenCurrentFormChild(formKhoa);
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new MonHoc());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new Info());
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new KetQua());

        }
        private void btnSapXepDiem_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new SapXepDiem());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new ThongKe());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenCurrentFormChild(new ChangePassWord());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.OKCancel);
            if (s == DialogResult.OK)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
