using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using new_quanlykhambenh.XuLyDL.Connect;
using System.Data;
using System.Data.SqlClient;

namespace new_quanlykhambenh.XuLyDL
{
    class XuLyTK
    {
        private string mk, tentk, sdt;
        private int matk;

        public XuLyTK()
        {
        }

        public XuLyTK(string mk, string tentk, string sdt, int matk)
        {
            this.mk = mk;
            this.tentk = tentk;
            this.sdt = sdt;
            this.matk = matk;
        }

        ConnnectStr constr = new ConnnectStr();

        public bool dangnhap (string tentk , string mk)
        {
            string proc = "dangnhap";
            using (SqlConnection sqlcon  = constr.cnn())
            {
                using(SqlCommand cmd = sqlcon.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    sqlcon.Open();
                    cmd.Parameters.AddWithValue("@tk",tentk);
                    cmd.Parameters.AddWithValue("@mk", mk);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        return true;
                    }
                    else return false;
                    sqlcon.Close();
                }
                
            }
        }


        public bool quenmatkhau (string sdt , string mkmoi)
        {
            string proc = "quenmk";
            using (SqlConnection sqlcon = constr.cnn())
            {
                using (SqlCommand cmd = sqlcon.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    sqlcon.Open();
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@mkmoi", mkmoi);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        return true;
                    }
                    else return false;
                    sqlcon.Close();
                }

            }
        }


    }
}
