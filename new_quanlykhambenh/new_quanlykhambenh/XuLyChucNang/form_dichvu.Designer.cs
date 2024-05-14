
namespace new_quanlykhambenh.XuLyChucNang
{
    partial class form_dichvu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblloloai = new System.Windows.Forms.Label();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(520, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(685, 543);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTenLoai);
            this.panel1.Controls.Add(this.lblloloai);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaLoai);
            this.panel1.Controls.Add(this.txtTenLoai);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(14, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 543);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(57, 106);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(64, 20);
            this.lblTenLoai.TabIndex = 12;
            this.lblTenLoai.Text = "Tên loại";
            // 
            // lblloloai
            // 
            this.lblloloai.AutoSize = true;
            this.lblloloai.Location = new System.Drawing.Point(59, 55);
            this.lblloloai.Name = "lblloloai";
            this.lblloloai.Size = new System.Drawing.Size(59, 20);
            this.lblloloai.TabIndex = 8;
            this.lblloloai.Text = "Mã loại";
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(318, 445);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(88, 34);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê ";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(412, 445);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(88, 34);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm kiếm ";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 445);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(185, 49);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(281, 26);
            this.txtMaLoai.TabIndex = 3;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(185, 100);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(281, 26);
            this.txtTenLoai.TabIndex = 5;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(132, 445);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(224, 445);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // form_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "form_dichvu";
            this.Text = "form_dichvu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblloloai;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}