using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace new_quanlykhambenh.XuLyDL.Connect
{
    class ConnnectStr
    {
        string strcon = "Data Source=.;Initial Catalog=BTL_BenhVien;Integrated Security=True";

        public ConnnectStr()
        {

        }

        public ConnnectStr(string strcon)
        {
            this.strcon = strcon;
        }

        public SqlConnection cnn ( )
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            return sqlcon;
        }
    }

}
