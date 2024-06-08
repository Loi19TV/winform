namespace DoAnUngDung_Menu
{
    partial class SapXepDiem
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
            this.dtgvSapXepDiem = new System.Windows.Forms.DataGridView();
            this.comboBoxTenKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiemGiamDan = new System.Windows.Forms.Button();
            this.btnDiemTangDan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSapXepDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvSapXepDiem
            // 
            this.dtgvSapXepDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSapXepDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSapXepDiem.Location = new System.Drawing.Point(110, 30);
            this.dtgvSapXepDiem.Name = "dtgvSapXepDiem";
            this.dtgvSapXepDiem.Size = new System.Drawing.Size(549, 162);
            this.dtgvSapXepDiem.TabIndex = 0;
            this.dtgvSapXepDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxTenKhoa
            // 
            this.comboBoxTenKhoa.FormattingEnabled = true;
            this.comboBoxTenKhoa.Location = new System.Drawing.Point(297, 229);
            this.comboBoxTenKhoa.Name = "comboBoxTenKhoa";
            this.comboBoxTenKhoa.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTenKhoa.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvSapXepDiem);
            this.groupBox1.Controls.Add(this.DiemGiamDan);
            this.groupBox1.Controls.Add(this.comboBoxTenKhoa);
            this.groupBox1.Controls.Add(this.btnDiemTangDan);
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 372);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp Xếp Điểm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên khoa: ";
            // 
            // DiemGiamDan
            // 
            this.DiemGiamDan.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_reversed_numerical_sorting_32;
            this.DiemGiamDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiemGiamDan.Location = new System.Drawing.Point(192, 297);
            this.DiemGiamDan.Name = "DiemGiamDan";
            this.DiemGiamDan.Size = new System.Drawing.Size(151, 50);
            this.DiemGiamDan.TabIndex = 2;
            this.DiemGiamDan.Text = "Giảm Dần";
            this.DiemGiamDan.UseVisualStyleBackColor = true;
            this.DiemGiamDan.Click += new System.EventHandler(this.DiemGiamDan_Click);
            // 
            // btnDiemTangDan
            // 
            this.btnDiemTangDan.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_numeric_32;
            this.btnDiemTangDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemTangDan.Location = new System.Drawing.Point(448, 297);
            this.btnDiemTangDan.Name = "btnDiemTangDan";
            this.btnDiemTangDan.Size = new System.Drawing.Size(151, 50);
            this.btnDiemTangDan.TabIndex = 1;
            this.btnDiemTangDan.Text = "Tăng Dần";
            this.btnDiemTangDan.UseVisualStyleBackColor = true;
            this.btnDiemTangDan.Click += new System.EventHandler(this.btnDiemTangDan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xuất Giảm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xuất Tăng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SapXepDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SapXepDiem";
            this.Text = "SapXepDiem";
            this.Load += new System.EventHandler(this.SapXepDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSapXepDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSapXepDiem;
        private System.Windows.Forms.Button btnDiemTangDan;
        private System.Windows.Forms.Button DiemGiamDan;
        private System.Windows.Forms.ComboBox comboBoxTenKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}