namespace DoAnUngDung_Menu
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThongKe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThongKe
            // 
            chartArea3.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend3);
            this.chartThongKe.Location = new System.Drawing.Point(96, 67);
            this.chartThongKe.Name = "chartThongKe";
            this.chartThongKe.Size = new System.Drawing.Size(796, 328);
            this.chartThongKe.TabIndex = 0;
            this.chartThongKe.Text = "chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê xếp loại học lực của sinh ";
            // 
            // dataGridViewThongKe
            // 
            this.dataGridViewThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKe.Location = new System.Drawing.Point(313, 468);
            this.dataGridViewThongKe.Name = "dataGridViewThongKe";
            this.dataGridViewThongKe.RowHeadersWidth = 51;
            this.dataGridViewThongKe.RowTemplate.Height = 24;
            this.dataGridViewThongKe.Size = new System.Drawing.Size(347, 178);
            this.dataGridViewThongKe.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(367, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số liệu thống kê chi tiết";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartThongKe);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewThongKe;
        private System.Windows.Forms.Label label2;
    }
}