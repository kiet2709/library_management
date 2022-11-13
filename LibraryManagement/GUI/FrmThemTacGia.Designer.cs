namespace LibraryManagement.GUI
{
    partial class FrmThemTacGia
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
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.pnlThemTheLoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThemTheLoai
            // 
            this.pnlThemTheLoai.Controls.Add(this.btnThemTheLoai);
            this.pnlThemTheLoai.Controls.Add(this.txtTacGia);
            this.pnlThemTheLoai.Controls.Add(this.lblTheLoai);
            this.pnlThemTheLoai.Location = new System.Drawing.Point(12, 13);
            this.pnlThemTheLoai.Name = "pnlThemTheLoai";
            this.pnlThemTheLoai.Size = new System.Drawing.Size(636, 239);
            this.pnlThemTheLoai.TabIndex = 3;
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheLoai.Location = new System.Drawing.Point(387, 153);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(127, 58);
            this.btnThemTheLoai.TabIndex = 2;
            this.btnThemTheLoai.Text = "Thêm";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(265, 52);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(249, 45);
            this.txtTacGia.TabIndex = 0;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(54, 51);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(151, 42);
            this.lblTheLoai.TabIndex = 1;
            this.lblTheLoai.Text = "Tác giả:";
            // 
            // FrmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 264);
            this.Controls.Add(this.pnlThemTheLoai);
            this.Name = "FrmThemTacGia";
            this.Text = "FrmThemTacGia";
            this.pnlThemTheLoai.ResumeLayout(false);
            this.pnlThemTheLoai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThemTheLoai;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTheLoai;
    }
}