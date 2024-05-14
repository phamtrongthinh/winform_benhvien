using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using new_quanlykhambenh.XuLyDL;

namespace new_quanlykhambenh
{
    public partial class frm_dangNhap : Form
    {
        public frm_dangNhap()
        {
            InitializeComponent();
        }
        XuLyTK xltk = new XuLyTK();
        

        private void btnNhap_Click(object sender, EventArgs e)
        {
            bool kiemtra = true;
            bool dangnhap = true;
            errorProvider1.Clear();
            if(txt_DangNhap.Text == "")
            {
                errorProvider1.SetError(txt_DangNhap,"admin");
                kiemtra = false;
            }
            if(txtMatKhau.Text =="")
            {
                errorProvider1.SetError(txtMatKhau, "1234");
                kiemtra = false;
            }
            if(kiemtra )
            {
                dangnhap = xltk.dangnhap(txt_DangNhap.Text,txtMatKhau.Text);
                if(dangnhap)
                {
                    MessageBox.Show("dang nhap thanh cong ");
                    frm_trangChu tc = new frm_trangChu();
                    tc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("dang nhap that bai ");
                }
            }



        }

        private void frm_dangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {
            quenMk qmk = new quenMk();
            this.Hide();
            qmk.ShowDialog();
            this.Show();
           
        }
    }
}
