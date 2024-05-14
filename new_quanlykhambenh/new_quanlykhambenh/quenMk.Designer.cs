
namespace new_quanlykhambenh
{
    partial class quenMk
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
            this.lblnhaplaimk = new System.Windows.Forms.Label();
            this.txtnhapsdt = new System.Windows.Forms.TextBox();
            this.lblnhapmatkhaumoi = new System.Windows.Forms.Label();
            this.txtnhaplaimk = new System.Windows.Forms.TextBox();
            this.txt_Nhapmkmoi = new System.Windows.Forms.TextBox();
            this.btnDoimk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuaylai = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnhaplaimk
            // 
            this.lblnhaplaimk.AutoSize = true;
            this.lblnhaplaimk.Location = new System.Drawing.Point(41, 231);
            this.lblnhaplaimk.Name = "lblnhaplaimk";
            this.lblnhaplaimk.Size = new System.Drawing.Size(140, 20);
            this.lblnhaplaimk.TabIndex = 0;
            this.lblnhaplaimk.Text = "Nhập lại mật khẩu ";
            // 
            // txtnhapsdt
            // 
            this.txtnhapsdt.Location = new System.Drawing.Point(228, 87);
            this.txtnhapsdt.Name = "txtnhapsdt";
            this.txtnhapsdt.Size = new System.Drawing.Size(279, 26);
            this.txtnhapsdt.TabIndex = 1;
            // 
            // lblnhapmatkhaumoi
            // 
            this.lblnhapmatkhaumoi.AutoSize = true;
            this.lblnhapmatkhaumoi.Location = new System.Drawing.Point(41, 157);
            this.lblnhapmatkhaumoi.Name = "lblnhapmatkhaumoi";
            this.lblnhapmatkhaumoi.Size = new System.Drawing.Size(154, 20);
            this.lblnhapmatkhaumoi.TabIndex = 4;
            this.lblnhapmatkhaumoi.Text = "Nhập mật khẩu mới  ";
            // 
            // txtnhaplaimk
            // 
            this.txtnhaplaimk.Location = new System.Drawing.Point(228, 231);
            this.txtnhaplaimk.Name = "txtnhaplaimk";
            this.txtnhaplaimk.Size = new System.Drawing.Size(279, 26);
            this.txtnhaplaimk.TabIndex = 5;
            // 
            // txt_Nhapmkmoi
            // 
            this.txt_Nhapmkmoi.Location = new System.Drawing.Point(228, 151);
            this.txt_Nhapmkmoi.Name = "txt_Nhapmkmoi";
            this.txt_Nhapmkmoi.Size = new System.Drawing.Size(279, 26);
            this.txt_Nhapmkmoi.TabIndex = 6;
            // 
            // btnDoimk
            // 
            this.btnDoimk.Location = new System.Drawing.Point(250, 305);
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.Size = new System.Drawing.Size(138, 50);
            this.btnDoimk.TabIndex = 2;
            this.btnDoimk.Text = "Đổi mật khẩu ";
            this.btnDoimk.UseVisualStyleBackColor = true;
            this.btnDoimk.Click += new System.EventHandler(this.btnDoimk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số điện thoại ";
            // 
            // lblQuaylai
            // 
            this.lblQuaylai.AutoSize = true;
            this.lblQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuaylai.Location = new System.Drawing.Point(284, 372);
            this.lblQuaylai.Name = "lblQuaylai";
            this.lblQuaylai.Size = new System.Drawing.Size(65, 20);
            this.lblQuaylai.TabIndex = 7;
            this.lblQuaylai.Text = "Quay lại";
            this.lblQuaylai.Click += new System.EventHandler(this.lblQuaylai_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // quenMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.lblQuaylai);
            this.Controls.Add(this.txt_Nhapmkmoi);
            this.Controls.Add(this.txtnhaplaimk);
            this.Controls.Add(this.lblnhapmatkhaumoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoimk);
            this.Controls.Add(this.txtnhapsdt);
            this.Controls.Add(this.lblnhaplaimk);
            this.Name = "quenMk";
            this.Text = "quenMk";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhaplaimk;
        private System.Windows.Forms.TextBox txtnhapsdt;
        private System.Windows.Forms.Label lblnhapmatkhaumoi;
        private System.Windows.Forms.TextBox txtnhaplaimk;
        private System.Windows.Forms.TextBox txt_Nhapmkmoi;
        private System.Windows.Forms.Button btnDoimk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuaylai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}