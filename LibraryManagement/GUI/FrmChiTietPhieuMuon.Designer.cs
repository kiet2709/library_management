namespace LibraryManagement.GUI
{
    partial class FrmChiTietPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietPhieuMuon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.viewCarGrid = new System.Windows.Forms.DataGridView();
            this.CAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(836, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 52);
            this.button2.TabIndex = 59;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(394, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 38);
            this.label10.TabIndex = 58;
            this.label10.Text = "Phiếu mượn sách";

            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(813, 178);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(167, 42);
            this.maskedTextBox2.TabIndex = 55;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(813, 125);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(167, 42);
            this.maskedTextBox1.TabIndex = 54;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(162, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 42);
            this.textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 42);
            this.textBox1.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(162, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 43);
            this.comboBox1.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 35);
            this.label9.TabIndex = 47;
            this.label9.Text = "Khoa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(612, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 35);
            this.label8.TabIndex = 46;
            this.label8.Text = "Ngày trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 35);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ngày mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.TabIndex = 40;
            this.label2.Text = "MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 39;
            this.label1.Text = "Họ Tên:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(14, 15);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(108, 75);
            this.backBtn.TabIndex = 61;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // viewCarGrid
            // 
            this.viewCarGrid.AllowUserToAddRows = false;
            this.viewCarGrid.AllowUserToDeleteRows = false;
            this.viewCarGrid.AllowUserToResizeColumns = false;
            this.viewCarGrid.AllowUserToResizeRows = false;
            this.viewCarGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewCarGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewCarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewCarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewCarGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAR_ID,
            this.fine,
            this.startDate,
            this.endDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCarGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewCarGrid.EnableHeadersVisualStyles = false;
            this.viewCarGrid.GridColor = System.Drawing.Color.White;
            this.viewCarGrid.Location = new System.Drawing.Point(11, 311);
            this.viewCarGrid.Margin = new System.Windows.Forms.Padding(4);
            this.viewCarGrid.Name = "viewCarGrid";
            this.viewCarGrid.ReadOnly = true;
            this.viewCarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewCarGrid.RowHeadersVisible = false;
            this.viewCarGrid.RowHeadersWidth = 51;
            this.viewCarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCarGrid.Size = new System.Drawing.Size(987, 345);
            this.viewCarGrid.TabIndex = 62;
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
            // endDate
            // 
            this.endDate.FillWeight = 120F;
            this.endDate.HeaderText = "Ghi chú";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(674, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 63;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 690);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewCarGrid);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChiTietPhieuMuon";
            this.Text = "FrmChiTietPhieuMuon";
            ((System.ComponentModel.ISupportInitialize)(this.viewCarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewCarGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.Button button1;
    }
}