namespace DoAnUngDung_Menu
{
    partial class Info
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuat1SV = new System.Windows.Forms.Button();
            this.btnXuatDSSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.btnRotMon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRotMon);
            this.groupBox1.Controls.Add(this.btnXuat1SV);
            this.groupBox1.Controls.Add(this.btnXuatDSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.dataGridViewInfo);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Tìm kiếm";
            this.groupBox1.Text = "Thông tin sinh viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXuat1SV
            // 
            this.btnXuat1SV.Location = new System.Drawing.Point(665, 359);
            this.btnXuat1SV.Name = "btnXuat1SV";
            this.btnXuat1SV.Size = new System.Drawing.Size(75, 23);
            this.btnXuat1SV.TabIndex = 5;
            this.btnXuat1SV.Text = "Xuất 1 SV";
            this.btnXuat1SV.UseVisualStyleBackColor = true;
            this.btnXuat1SV.Click += new System.EventHandler(this.btnXuat1SV_Click);
            // 
            // btnXuatDSSV
            // 
            this.btnXuatDSSV.Location = new System.Drawing.Point(432, 358);
            this.btnXuatDSSV.Name = "btnXuatDSSV";
            this.btnXuatDSSV.Size = new System.Drawing.Size(145, 24);
            this.btnXuatDSSV.TabIndex = 4;
            this.btnXuatDSSV.Text = "Xuất Danh Sách SV";
            this.btnXuatDSSV.UseVisualStyleBackColor = true;
            this.btnXuatDSSV.Click += new System.EventHandler(this.btnXuatDSSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(356, 301);
            this.btnTim.Name = "btnTim";
            this.btnTim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(271, 241);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 20);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Tag = "Tìm kiếm... ";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(734, 183);
            this.dataGridViewInfo.TabIndex = 0;
            this.dataGridViewInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInfo_CellContentClick);
            // 
            // btnRotMon
            // 
            this.btnRotMon.Location = new System.Drawing.Point(583, 359);
            this.btnRotMon.Name = "btnRotMon";
            this.btnRotMon.Size = new System.Drawing.Size(76, 23);
            this.btnRotMon.TabIndex = 6;
            this.btnRotMon.Text = "Rớt môn";
            this.btnRotMon.UseVisualStyleBackColor = true;
            this.btnRotMon.Click += new System.EventHandler(this.btnRotMon_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatDSSV;
        private System.Windows.Forms.Button btnXuat1SV;
        private System.Windows.Forms.Button btnRotMon;
    }
}