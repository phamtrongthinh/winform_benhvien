
namespace new_quanlykhambenh.XuLyChucNang
{
    partial class form_hoadon
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
            this.txtMaBA = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaBA = new System.Windows.Forms.Label();
            this.lbl_trangThaiHoaDon = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaBA);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.lblTenNV);
            this.panel1.Controls.Add(this.lblMaBA);
            this.panel1.Controls.Add(this.lbl_trangThaiHoaDon);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.txtNgayLap);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(14, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 543);
            this.panel1.TabIndex = 10;
            // 
            // txtMaBA
            // 
            this.txtMaBA.Location = new System.Drawing.Point(197, 151);
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.Size = new System.Drawing.Size(281, 26);
            this.txtMaBA.TabIndex = 15;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(197, 202);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(281, 26);
            this.txtTrangThai.TabIndex = 14;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(54, 106);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(76, 20);
            this.lblTenNV.TabIndex = 12;
            this.lblTenNV.Text = "Ngày Lập";
            // 
            // lblMaBA
            // 
            this.lblMaBA.AutoSize = true;
            this.lblMaBA.Location = new System.Drawing.Point(54, 151);
            this.lblMaBA.Name = "lblMaBA";
            this.lblMaBA.Size = new System.Drawing.Size(97, 20);
            this.lblMaBA.TabIndex = 11;
            this.lblMaBA.Text = "Mã bệnh án ";
            // 
            // lbl_trangThaiHoaDon
            // 
            this.lbl_trangThaiHoaDon.AutoSize = true;
            this.lbl_trangThaiHoaDon.Location = new System.Drawing.Point(54, 205);
            this.lbl_trangThaiHoaDon.Name = "lbl_trangThaiHoaDon";
            this.lbl_trangThaiHoaDon.Size = new System.Drawing.Size(142, 20);
            this.lbl_trangThaiHoaDon.TabIndex = 10;
            this.lbl_trangThaiHoaDon.Text = "Trạng thái hóa đơn";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(54, 55);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(91, 20);
            this.lblMaNV.TabIndex = 8;
            this.lblMaNV.Text = "Số hóa đơn";
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
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(197, 49);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(281, 26);
            this.txtMaHD.TabIndex = 3;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(197, 100);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(281, 26);
            this.txtNgayLap.TabIndex = 5;
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
            // form_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "form_hoadon";
            this.Text = "form_hoadon";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaBA;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaBA;
        private System.Windows.Forms.Label lbl_trangThaiHoaDon;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}