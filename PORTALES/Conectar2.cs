using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PORTALES
{
    class Conectar2
    {
        public static SqlConnection Conexion()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-SL3B3B3\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            return cn;

        }

    }
}
