
namespace LibraryManagement.GUI
{
    partial class FrmXemChiTietDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXemChiTietDocGia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbKhac = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbKhongHoatDong = new System.Windows.Forms.RadioButton();
            this.rbHoatDong = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 35);
            this.label9.TabIndex = 8;
            this.label9.Text = "Khoa:";
            // 
            // cbcKhoa
            // 
            this.cbcKhoa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcKhoa.FormattingEnabled = true;
            this.cbcKhoa.Items.AddRange(new object[] {
            "Khoa Cơ khí Chế tạo máy",
            "Khoa Cơ khí Động lực",
            "Khoa Công nghệ Hóa học và Thực phẩm",
            "Khoa Thời trang và Du lịch",
            "Khoa Công nghệ Thông tin",
            "Khoa Đào tạo Chất lượng cao",
            "Khoa Điện - Điện tử",
            "Khoa In - Truyền thông",
            "Khoa Khoa học Ứng dụng",
            "Khoa Kinh tế",
            "Khoa Xây dựng",
            "Khoa Đào tạo Quốc tế",
            "Khoa Ngoại ngữ"});
            this.cbcKhoa.Location = new System.Drawing.Point(493, 199);
            this.cbcKhoa.Name = "cbcKhoa";
            this.cbcKhoa.Size = new System.Drawing.Size(380, 43);
            this.cbcKhoa.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(493, 81);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(380, 42);
            this.txtHoTen.TabIndex = 14;
            // 
            // txtMssv
            // 
            this.txtMssv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMssv.Location = new System.Drawing.Point(493, 137);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(380, 42);
            this.txtMssv.TabIndex = 15;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(493, 442);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(380, 42);
            this.txtSdt.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(493, 496);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 42);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(243, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 38);
            this.label10.TabIndex = 21;
            this.label10.Text = "Thông tin chi tiết";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Location = new System.Drawing.Point(326, 580);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 52);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 305);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(22, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 75);
            this.btnBack.TabIndex = 38;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbKhac);
            this.panel5.Controls.Add(this.rbNam);
            this.panel5.Controls.Add(this.rbNu);
            this.panel5.Location = new System.Drawing.Point(493, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 52);
            this.panel5.TabIndex = 102;
            // 
            // rbKhac
            // 
            this.rbKhac.AutoSize = true;
            this.rbKhac.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhac.Location = new System.Drawing.Point(244, 10);
            this.rbKhac.Name = "rbKhac";
            this.rbKhac.Size = new System.Drawing.Size(105, 39);
            this.rbKhac.TabIndex = 100;
            this.rbKhac.TabStop = true;
            this.rbKhac.Text = "Khác";
            this.rbKhac.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.Location = new System.Drawing.Point(10, 10);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(99, 39);
            this.rbNam.TabIndex = 98;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.Location = new System.Drawing.Point(143, 10);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(78, 39);
            this.rbNu.TabIndex = 99;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(493, 331);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(176, 42);
            this.dtpNgaySinh.TabIndex = 103;
            // 
            // rbKhongHoatDong
            // 
            this.rbKhongHoatDong.AutoSize = true;
            this.rbKhongHoatDong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhongHoatDong.Location = new System.Drawing.Point(694, 383);
            this.rbKhongHoatDong.Name = "rbKhongHoatDong";
            this.rbKhongHoatDong.Size = new System.Drawing.Size(264, 39);
            this.rbKhongHoatDong.TabIndex = 106;
            this.rbKhongHoatDong.TabStop = true;
            this.rbKhongHoatDong.Text = "Không hoạt động";
            this.rbKhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbHoatDong
            // 
            this.rbHoatDong.AutoSize = true;
            this.rbHoatDong.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHoatDong.Location = new System.Drawing.Point(493, 383);
            this.rbHoatDong.Name = "rbHoatDong";
            this.rbHoatDong.Size = new System.Drawing.Size(173, 39);
            this.rbHoatDong.TabIndex = 105;
            this.rbHoatDong.TabStop = true;
            this.rbHoatDong.Text = "Hoạt động";
            this.rbHoatDong.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 35);
            this.label7.TabIndex = 104;
            this.label7.Text = "Trạng thái:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(485, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 54);
            this.panel1.TabIndex = 107;
            // 
            // FrmXemChiTietDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 656);
            this.Controls.Add(this.rbKhongHoatDong);
            this.Controls.Add(this.rbHoatDong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cbcKhoa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmXemChiTietDocGia";
            this.Text = "FrmQuanLyDocGia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbcKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbKhac;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbKhongHoatDong;
        private System.Windows.Forms.RadioButton rbHoatDong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}