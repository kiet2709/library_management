
namespace LibraryManagement.GUI
{
    partial class FrmThemDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemDocGia));
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbKhac = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(507, 332);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(176, 42);
            this.dtpNgaySinh.TabIndex = 125;
            // 
            // rbKhac
            // 
            this.rbKhac.AutoSize = true;
            this.rbKhac.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhac.Location = new System.Drawing.Point(244, 10);
            this.rbKhac.Name = "rbKhac";
            this.rbKhac.Size = new System.Drawing.Size(92, 39);
            this.rbKhac.TabIndex = 100;
            this.rbKhac.TabStop = true;
            this.rbKhac.Text = "Khác";
            this.rbKhac.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.Location = new System.Drawing.Point(10, 10);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(88, 39);
            this.rbNam.TabIndex = 98;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.Location = new System.Drawing.Point(143, 10);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(70, 39);
            this.rbNu.TabIndex = 99;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbKhac);
            this.panel5.Controls.Add(this.rbNam);
            this.panel5.Controls.Add(this.rbNu);
            this.panel5.Location = new System.Drawing.Point(507, 266);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 52);
            this.panel5.TabIndex = 124;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnThem.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Location = new System.Drawing.Point(340, 543);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 59);
            this.btnThem.TabIndex = 121;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(333, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 38);
            this.label10.TabIndex = 120;
            this.label10.Text = "Thêm độc giả";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(507, 450);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 42);
            this.txtEmail.TabIndex = 119;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(507, 388);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(380, 42);
            this.txtSdt.TabIndex = 118;
            // 
            // txtMssv
            // 
            this.txtMssv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMssv.Location = new System.Drawing.Point(507, 138);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(380, 42);
            this.txtMssv.TabIndex = 117;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(507, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(380, 42);
            this.txtHoTen.TabIndex = 116;
            // 
            // cbKhoa
            // 
            this.cbKhoa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Cơ khí Chế tạo máy",
            "Cơ khí Động lực",
            "Công nghệ Hóa học và Thực phẩm",
            "Thời trang và Du lịch",
            "Công nghệ Thông tin",
            "Đào tạo Chất lượng cao",
            "Điện - Điện tử",
            "In - Truyền thông",
            "Khoa học Ứng dụng",
            "Kinh tế",
            "Xây dựng",
            "Đào tạo Quốc tế",
            "Ngoại ngữ"});
            this.cbKhoa.Location = new System.Drawing.Point(507, 200);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(380, 43);
            this.cbKhoa.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 35);
            this.label9.TabIndex = 114;
            this.label9.Text = "Khoa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 35);
            this.label6.TabIndex = 111;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 35);
            this.label5.TabIndex = 110;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 109;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 108;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 107;
            this.label2.Text = "MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 106;
            this.label1.Text = "Họ Tên:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(36, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 75);
            this.btnBack.TabIndex = 123;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbAnh
            // 
            this.pbAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAnh.Location = new System.Drawing.Point(67, 136);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(204, 305);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 122;
            this.pbAnh.TabStop = false;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnThemAnh.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemAnh.Location = new System.Drawing.Point(55, 457);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(225, 59);
            this.btnThemAnh.TabIndex = 126;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = false;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // FrmThemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 655);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbAnh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThemDocGia";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbKhac;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemAnh;
    }
}