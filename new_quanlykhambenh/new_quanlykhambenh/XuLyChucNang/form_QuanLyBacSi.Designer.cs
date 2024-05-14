
namespace new_quanlykhambenh.XuLyChucNang
{
    partial class form_QuanLyBacSi
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtBasi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.lblMaBS = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenBS = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(46, 445);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            // txtMaBS
            // 
            this.txtMaBS.Location = new System.Drawing.Point(185, 49);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(281, 26);
            this.txtMaBS.TabIndex = 3;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(185, 253);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(281, 26);
            this.txtNS.TabIndex = 4;
            // 
            // txtBasi
            // 
            this.txtBasi.Location = new System.Drawing.Point(185, 100);
            this.txtBasi.Name = "txtBasi";
            this.txtBasi.Size = new System.Drawing.Size(281, 26);
            this.txtBasi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtGT);
            this.panel1.Controls.Add(this.lblTenBS);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.lbl_GioiTinh);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblMaBS);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaBS);
            this.panel1.Controls.Add(this.txtBasi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtNS);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 543);
            this.panel1.TabIndex = 6;
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
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(318, 445);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(88, 34);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê ";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // lblMaBS
            // 
            this.lblMaBS.AutoSize = true;
            this.lblMaBS.Location = new System.Drawing.Point(59, 55);
            this.lblMaBS.Name = "lblMaBS";
            this.lblMaBS.Size = new System.Drawing.Size(80, 20);
            this.lblMaBS.TabIndex = 8;
            this.lblMaBS.Text = "Mã bác sĩ ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(60, 253);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày sinh ";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(59, 205);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(67, 20);
            this.lbl_GioiTinh.TabIndex = 10;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(54, 151);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(106, 20);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "Số điện thoại ";
            // 
            // lblTenBS
            // 
            this.lblTenBS.AutoSize = true;
            this.lblTenBS.Location = new System.Drawing.Point(57, 106);
            this.lblTenBS.Name = "lblTenBS";
            this.lblTenBS.Size = new System.Drawing.Size(85, 20);
            this.lblTenBS.TabIndex = 12;
            this.lblTenBS.Text = "Tên bác sĩ ";
            this.lblTenBS.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(185, 202);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(281, 26);
            this.txtGT.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(185, 151);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(281, 26);
            this.txtSDT.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(528, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(685, 543);
            this.dataGridView1.TabIndex = 7;
            // 
            // form_QuanLyBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "form_QuanLyBacSi";
            this.Text = "form_QuanLyBacSi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtBasi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenBS;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaBS;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtGT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}