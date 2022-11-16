
using System;

namespace LibraryManagement.GUI
{
    partial class FrmThemPhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sinhVien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vcg_sachMuon = new System.Windows.Forms.DataGridView();
            this.CAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_daTra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtp_ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayTra = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_khoa = new System.Windows.Forms.TextBox();
            this.dtp_hanTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tienPhat = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.pd_anh = new System.Windows.Forms.PictureBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_themSach = new System.Windows.Forms.Button();
            this.txt_maSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_timSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vcg_sachMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pd_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(394, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(306, 38);
            this.label10.TabIndex = 58;
            this.label10.Text = "Thêm phiếu mượn";
            // 
            // txt_sinhVien
            // 
            this.txt_sinhVien.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sinhVien.Location = new System.Drawing.Point(401, 182);
            this.txt_sinhVien.Name = "txt_sinhVien";
            this.txt_sinhVien.ReadOnly = true;
            this.txt_sinhVien.Size = new System.Drawing.Size(355, 42);
            this.txt_sinhVien.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 35);
            this.label9.TabIndex = 47;
            this.label9.Text = "Khoa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(797, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 35);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ngày trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 35);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ngày mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sinh Viên:";
            // 
            // vcg_sachMuon
            // 
            this.vcg_sachMuon.AllowUserToAddRows = false;
            this.vcg_sachMuon.AllowUserToDeleteRows = false;
            this.vcg_sachMuon.AllowUserToResizeColumns = false;
            this.vcg_sachMuon.AllowUserToResizeRows = false;
            this.vcg_sachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vcg_sachMuon.BackgroundColor = System.Drawing.Color.White;
            this.vcg_sachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vcg_sachMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.vcg_sachMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vcg_sachMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vcg_sachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vcg_sachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAR_ID,
            this.fine,
            this.startDate,
            this.col_daTra,
            this.ghiChu,
            this.col_xoa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vcg_sachMuon.DefaultCellStyle = dataGridViewCellStyle4;
            this.vcg_sachMuon.EnableHeadersVisualStyles = false;
            this.vcg_sachMuon.GridColor = System.Drawing.Color.White;
            this.vcg_sachMuon.Location = new System.Drawing.Point(26, 363);
            this.vcg_sachMuon.Margin = new System.Windows.Forms.Padding(4);
            this.vcg_sachMuon.Name = "vcg_sachMuon";
            this.vcg_sachMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.vcg_sachMuon.RowHeadersVisible = false;
            this.vcg_sachMuon.RowHeadersWidth = 51;
            this.vcg_sachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vcg_sachMuon.Size = new System.Drawing.Size(1143, 270);
            this.vcg_sachMuon.TabIndex = 62;
            this.vcg_sachMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vcg_sachMuon_CellContentClick);
            // 
            // CAR_ID
            // 
            this.CAR_ID.FillWeight = 35.80297F;
            this.CAR_ID.HeaderText = "STT";
            this.CAR_ID.MinimumWidth = 6;
            this.CAR_ID.Name = "CAR_ID";
            this.CAR_ID.ReadOnly = true;
            // 
            // fine
            // 
            this.fine.FillWeight = 90.53038F;
            this.fine.HeaderText = "Mã sách";
            this.fine.MinimumWidth = 6;
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.FillWeight = 180F;
            this.startDate.HeaderText = "Tên sách";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // col_daTra
            // 
            this.col_daTra.HeaderText = "Đã trả";
            this.col_daTra.MinimumWidth = 6;
            this.col_daTra.Name = "col_daTra";
            this.col_daTra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_daTra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.FillWeight = 120F;
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.MinimumWidth = 6;
            this.ghiChu.Name = "ghiChu";
            // 
            // col_xoa
            // 
            this.col_xoa.HeaderText = "Xóa";
            this.col_xoa.MinimumWidth = 6;
            this.col_xoa.Name = "col_xoa";
            this.col_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtp_ngayMuon
            // 
            this.dtp_ngayMuon.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayMuon.Location = new System.Drawing.Point(993, 124);
            this.dtp_ngayMuon.Name = "dtp_ngayMuon";
            this.dtp_ngayMuon.Size = new System.Drawing.Size(176, 42);
            this.dtp_ngayMuon.TabIndex = 111;
            // 
            // dtp_ngayTra
            // 
            this.dtp_ngayTra.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayTra.Location = new System.Drawing.Point(993, 241);
            this.dtp_ngayTra.Name = "dtp_ngayTra";
            this.dtp_ngayTra.Size = new System.Drawing.Size(176, 42);
            this.dtp_ngayTra.TabIndex = 112;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(26, 13);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(108, 75);
            this.btn_back.TabIndex = 113;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_khoa
            // 
            this.txt_khoa.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoa.Location = new System.Drawing.Point(401, 245);
            this.txt_khoa.Name = "txt_khoa";
            this.txt_khoa.ReadOnly = true;
            this.txt_khoa.Size = new System.Drawing.Size(355, 42);
            this.txt_khoa.TabIndex = 114;
            // 
            // dtp_hanTra
            // 
            this.dtp_hanTra.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_hanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hanTra.Location = new System.Drawing.Point(993, 180);
            this.dtp_hanTra.Name = "dtp_hanTra";
            this.dtp_hanTra.Size = new System.Drawing.Size(174, 42);
            this.dtp_hanTra.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(797, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 35);
            this.label4.TabIndex = 117;
            this.label4.Text = "Hạn trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(797, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 35);
            this.label5.TabIndex = 119;
            this.label5.Text = "Tiền phạt:";
            // 
            // txt_tienPhat
            // 
            this.txt_tienPhat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tienPhat.Location = new System.Drawing.Point(993, 302);
            this.txt_tienPhat.Name = "txt_tienPhat";
            this.txt_tienPhat.Size = new System.Drawing.Size(176, 42);
            this.txt_tienPhat.TabIndex = 120;
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_huy.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_huy.Location = new System.Drawing.Point(341, 673);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(122, 52);
            this.btn_huy.TabIndex = 122;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_luu.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_luu.Location = new System.Drawing.Point(753, 673);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(122, 52);
            this.btn_luu.TabIndex = 121;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // pd_anh
            // 
            this.pd_anh.Location = new System.Drawing.Point(26, 124);
            this.pd_anh.Name = "pd_anh";
            this.pd_anh.Size = new System.Drawing.Size(200, 220);
            this.pd_anh.TabIndex = 123;
            this.pd_anh.TabStop = false;
            // 
            // txt_mssv
            // 
            this.txt_mssv.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mssv.Location = new System.Drawing.Point(401, 126);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(211, 42);
            this.txt_mssv.TabIndex = 125;
            this.txt_mssv.TextChanged += new System.EventHandler(this.txt_mssv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 124;
            this.label2.Text = "MSSV:";
            // 
            // btn_themSach
            // 
            this.btn_themSach.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_themSach.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themSach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_themSach.Location = new System.Drawing.Point(634, 298);
            this.btn_themSach.Name = "btn_themSach";
            this.btn_themSach.Size = new System.Drawing.Size(122, 52);
            this.btn_themSach.TabIndex = 126;
            this.btn_themSach.Text = "Thêm";
            this.btn_themSach.UseVisualStyleBackColor = false;
            this.btn_themSach.Click += new System.EventHandler(this.btn_themSach_Click);
            // 
            // txt_maSach
            // 
            this.txt_maSach.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSach.Location = new System.Drawing.Point(401, 305);
            this.txt_maSach.Name = "txt_maSach";
            this.txt_maSach.Size = new System.Drawing.Size(211, 42);
            this.txt_maSach.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 35);
            this.label3.TabIndex = 127;
            this.label3.Text = "Mã sách:";
            // 
            // btn_timSV
            // 
            this.btn_timSV.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_timSV.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timSV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_timSV.Location = new System.Drawing.Point(634, 119);
            this.btn_timSV.Name = "btn_timSV";
            this.btn_timSV.Size = new System.Drawing.Size(122, 52);
            this.btn_timSV.TabIndex = 129;
            this.btn_timSV.Text = "Tìm";
            this.btn_timSV.UseVisualStyleBackColor = false;
            this.btn_timSV.Click += new System.EventHandler(this.btn_timSV_Click);
            // 
            // FrmThemPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 750);
            this.Controls.Add(this.btn_timSV);
            this.Controls.Add(this.txt_maSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_themSach);
            this.Controls.Add(this.txt_mssv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pd_anh);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_tienPhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_hanTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_khoa);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dtp_ngayTra);
            this.Controls.Add(this.dtp_ngayMuon);
            this.Controls.Add(this.vcg_sachMuon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_sinhVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.vcg_sachMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pd_anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sinhVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vcg_sachMuon;
        private System.Windows.Forms.DateTimePicker dtp_ngayMuon;
        private System.Windows.Forms.DateTimePicker dtp_ngayTra;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_khoa;
        private System.Windows.Forms.DateTimePicker dtp_hanTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tienPhat;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.PictureBox pd_anh;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_themSach;
        private System.Windows.Forms.TextBox txt_maSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_timSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_daTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewButtonColumn col_xoa;
    }
}