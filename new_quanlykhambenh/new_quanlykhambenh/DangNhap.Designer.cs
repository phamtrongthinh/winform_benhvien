
namespace new_quanlykhambenh
{
    partial class frm_dangNhap
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
            this.components = new System.ComponentModel.Container();
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_DangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Location = new System.Drawing.Point(59, 92);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(88, 20);
            this.lbl_DangNhap.TabIndex = 0;
            this.lbl_DangNhap.Text = "Đăng nhập";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Location = new System.Drawing.Point(59, 145);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(79, 20);
            this.lbl_MatKhau.TabIndex = 1;
            this.lbl_MatKhau.Text = "Mật khẩu ";
            // 
            // txt_DangNhap
            // 
            this.txt_DangNhap.Location = new System.Drawing.Point(211, 89);
            this.txt_DangNhap.Name = "txt_DangNhap";
            this.txt_DangNhap.Size = new System.Drawing.Size(286, 26);
            this.txt_DangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(211, 145);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(286, 26);
            this.txtMatKhau.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(245, 247);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(110, 41);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Đăng nhập ";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(241, 327);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(122, 20);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Quên mật khẩu ";
            this.lblMatKhau.Click += new System.EventHandler(this.lblMatKhau_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_dangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txt_DangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_DangNhap);
            this.Name = "frm_dangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_dangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_DangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

