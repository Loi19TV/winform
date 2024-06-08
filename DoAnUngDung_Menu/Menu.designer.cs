namespace DoAnUngDung_Menu
{
    partial class Menu
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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSapXepDiem = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.panel_Left.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.White;
            this.panel_Left.Controls.Add(this.btnThoat);
            this.panel_Left.Controls.Add(this.btnTaiKhoan);
            this.panel_Left.Controls.Add(this.btnThongKe);
            this.panel_Left.Controls.Add(this.btnSapXepDiem);
            this.panel_Left.Controls.Add(this.btnInfo);
            this.panel_Left.Controls.Add(this.btnDiem);
            this.panel_Left.Controls.Add(this.btnKhoa);
            this.panel_Left.Controls.Add(this.btnMonHoc);
            this.panel_Left.Controls.Add(this.panel2);
            this.panel_Left.Controls.Add(this.flowLayoutPanel1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(133, 556);
            this.panel_Left.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(137, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 65);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(133, 65);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.White;
            this.panel_Top.Controls.Add(this.pictureBox1);
            this.panel_Top.Controls.Add(this.dateTimePicker2);
            this.panel_Top.Controls.Add(this.dateTimePicker1);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(133, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(692, 108);
            this.panel_Top.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(-83, 48);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(68, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(-83, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(55, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(133, 108);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(692, 448);
            this.panel_body.TabIndex = 4;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom to Student Management!";
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSinhVien.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_student_48;
            this.btnSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 0);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(133, 65);
            this.btnSinhVien.TabIndex = 3;
            this.btnSinhVien.Text = "Sinh viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSinhVien.UseMnemonic = false;
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnUngDung_Menu.Properties.Resources.STUDent_system_management;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_exit_48;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(0, 491);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 65);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_account_48;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 430);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(133, 65);
            this.btnTaiKhoan.TabIndex = 10;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_analytics_48;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 369);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(133, 65);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnSapXepDiem
            // 
            this.btnSapXepDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXepDiem.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_numeric_48;
            this.btnSapXepDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSapXepDiem.Location = new System.Drawing.Point(0, 308);
            this.btnSapXepDiem.Name = "btnSapXepDiem";
            this.btnSapXepDiem.Size = new System.Drawing.Size(133, 65);
            this.btnSapXepDiem.TabIndex = 8;
            this.btnSapXepDiem.Text = "Sắp Xếp";
            this.btnSapXepDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSapXepDiem.UseVisualStyleBackColor = true;
            this.btnSapXepDiem.Click += new System.EventHandler(this.btnSapXepDiem_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfo.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_info_48;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 248);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(133, 65);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseMnemonic = false;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiem.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_score_48;
            this.btnDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiem.Location = new System.Drawing.Point(0, 188);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(133, 65);
            this.btnDiem.TabIndex = 6;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiem.UseMnemonic = false;
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKhoa.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_department_48;
            this.btnKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.Location = new System.Drawing.Point(0, 125);
            this.btnKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(133, 65);
            this.btnKhoa.TabIndex = 5;
            this.btnKhoa.Text = "Khoa";
            this.btnKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhoa.UseMnemonic = false;
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMonHoc.Image = global::DoAnUngDung_Menu.Properties.Resources.icons8_book_48;
            this.btnMonHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonHoc.Location = new System.Drawing.Point(0, 63);
            this.btnMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(133, 65);
            this.btnMonHoc.TabIndex = 4;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonHoc.UseMnemonic = false;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 556);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSapXepDiem;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
    }
}

