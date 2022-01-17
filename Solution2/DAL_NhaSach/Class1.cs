using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_NhaSach;

namespace DAL_NhaSach
{
    public class Class1
    {
    }

    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source =DESKTOP-U0R07KQ\SQLEXPRESS ; Initial Catalog =QLNHASACH1; Integrated Security=True");

    }

   
}
