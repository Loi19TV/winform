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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnUngDung_Menu
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        BLL_SinhVien bLL_SinhVien = new BLL_SinhVien();
        private void Info_Load(object sender, EventArgs e)
        {
            dataGridViewInfo.DataSource = bLL_SinhVien.getInfo();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tenSV = txtTimKiem.Text;
            dataGridViewInfo.DataSource  = bLL_SinhVien.getSearch(tenSV);
        }

        private void dataGridViewInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXuatDSSV_Click(object sender, EventArgs e)
        {
            HienThiDSSV sv = new HienThiDSSV();
            sv.Show();
        }

        private void btnXuat1SV_Click(object sender, EventArgs e)
        {
            HienThiDS1SV oneSV = new HienThiDS1SV();
            oneSV.Show();
        }

        private void btnRotMon_Click(object sender, EventArgs e)
        {
            XuatDSSVRotMon rotMon = new XuatDSSVRotMon();
            rotMon.Show();
        }
    }
}
