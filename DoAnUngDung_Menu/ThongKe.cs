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
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnUngDung_Menu
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        BLL_SinhVien bLL_SinhVien = new BLL_SinhVien();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            List<float> dsDiemTB = bLL_SinhVien.getDSDiemTrungBinh();
            // Kiểm tra và xét loại học sinh
            int gioi = 0, kha = 0, trungBinh = 0, yeu = 0;

            foreach (float diemTB in dsDiemTB)
            {
                if (diemTB >= 8.0)
                {
                    gioi++;
                }
                else if (diemTB >= 6.5)
                {
                    kha++;
                }
                else if (diemTB >= 5.0)
                {
                    trungBinh++;
                }
                else
                {
                    yeu++;
                }
            }

            Series series = new Series("Loại học lực");
            series.Points.AddXY("Giỏi", gioi);
            series.Points.AddXY("Khá", kha);
            series.Points.AddXY("Trung bình", trungBinh);
            series.Points.AddXY("Yếu", yeu);

            // Thêm dữ liệu vào biểu đồ
            chartThongKe.Series.Add(series);

            DataTable dataTable = new DataTable();

            // Thêm cột vào DataTable
            dataTable.Columns.Add("Loại học sinh", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));

            // Thêm hàng với dữ liệu
            dataTable.Rows.Add("Giỏi", gioi);
            dataTable.Rows.Add("Khá", kha);
            dataTable.Rows.Add("Trung bình", trungBinh);
            dataTable.Rows.Add("Yếu", yeu);

            dataGridViewThongKe.DataSource = dataTable;

            // Hiển thị tổng số học sinh bên trái biểu đồ
            chartThongKe.ChartAreas[0].AxisY.Title = "Tổng số học sinh";
            chartThongKe.ChartAreas[0].AxisY.Maximum = dsDiemTB.Count; // Đặt giá trị tối đa cho trục Y
            chartThongKe.ChartAreas[0].AxisY.Minimum = 0; // Đặt giá trị tối thiểu cho trục Y

            // Hiển thị giá trị trên từng điểm trên biểu đồ với số nguyên
            foreach (var point in series.Points)
            {
                point.IsValueShownAsLabel = true;
                point.LabelFormat = "#";
            }
        }


    }
}
