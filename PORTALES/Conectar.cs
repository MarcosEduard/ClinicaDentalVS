﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PORTALES
{
    class Conectar
    {
        public static SqlConnection Conexion()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-SL3B3B3\\SQLEXPRESS;Initial Catalog=OD3;Integrated Security=True";
            return cn;

        }

    }
}