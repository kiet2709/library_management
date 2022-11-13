namespace LibraryManagement.GUI
{
    partial class FrmThemNhaXuatBan
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
            this.pnlThemTheLoai = new System.Windows.Forms.Panel();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.pnlThemTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThemTheLoai
            // 
            this.pnlThemTheLoai.Controls.Add(this.btnThemTheLoai);
            this.pnlThemTheLoai.Controls.Add(this.txtNhaXuatBan);
            this.pnlThemTheLoai.Controls.Add(this.lblNhaXuatBan);
            this.pnlThemTheLoai.Location = new System.Drawing.Point(12, 13);
            this.pnlThemTheLoai.Name = "pnlThemTheLoai";
            this.pnlThemTheLoai.Size = new System.Drawing.Size(636, 239);
            this.pnlThemTheLoai.TabIndex = 4;
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheLoai.Location = new System.Drawing.Point(451, 149);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(127, 58);
            this.btnThemTheLoai.TabIndex = 2;
            this.btnThemTheLoai.Text = "Thêm";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaXuatBan.Location = new System.Drawing.Point(309, 52);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(269, 45);
            this.txtNhaXuatBan.TabIndex = 0;
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaXuatBan.Location = new System.Drawing.Point(23, 51);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(251, 42);
            this.lblNhaXuatBan.TabIndex = 1;
            this.lblNhaXuatBan.Text = "Nhà xuất bản:";
            // 
            // FrmThemNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 264);
            this.Controls.Add(this.pnlThemTheLoai);
            this.Name = "FrmThemNhaXuatBan";
            this.Text = "FrmThemNhaXuatBan";
            this.pnlThemTheLoai.ResumeLayout(false);
            this.pnlThemTheLoai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThemTheLoai;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.Label lblNhaXuatBan;
    }
}