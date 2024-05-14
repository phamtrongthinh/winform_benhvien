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
using System.Text.RegularExpressions;


namespace new_quanlykhambenh
{
    public partial class quenMk : Form
    {
        public quenMk()
        {
            InitializeComponent();
        }
        XuLyTK xltk = new XuLyTK();
        public bool kiemtramk(string mk)
        {
            return Regex.IsMatch(mk, "^[a-zA-Z0-9]{6,24}$");
        }
        private void btnDoimk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool kiemtra = kiemtramk(txt_Nhapmkmoi.Text);
            bool kt = true;
            if(kiemtra ==false)
            {
                errorProvider1.SetError(txt_Nhapmkmoi, "mat khau ko hop quy tac ");
                kt = false;
            }
            if(txt_Nhapmkmoi.Text == "")
            {
                errorProvider1.SetError(txt_Nhapmkmoi, "mat kahu ko dc de trong ");
                kt = false;
            }
            if(txtnhapsdt.Text =="")
            {
                errorProvider1.SetError(txtnhapsdt, "sdt ko dc de chong  ");
                kt = false;
            }
            if (txt_Nhapmkmoi.Text != txtnhaplaimk.Text)
            {
                errorProvider1.SetError(txtnhaplaimk, "mat khau nhap lai phai giong mat khau cu  ");
                kt = false;
            }


            if (kt == true)
            {
                kt = xltk.quenmatkhau(txtnhapsdt.Text, txt_Nhapmkmoi.Text);
                if (kt == true)
                {
                    MessageBox.Show("ban da doi thanh cong");
                    this.Close();
                }
                else MessageBox.Show("doi that bai");
               
            }


        }

        private void lblQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
