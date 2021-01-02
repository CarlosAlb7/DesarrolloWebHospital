﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PruebaGit.Web.Models
{
    public class DBCommon
    {
        //Conexion a la base de datos
        private static string Conn = @"Data Source=.;Initial Catalog=xHospitalDB;Integrated Security=True";
       
        public static IDbConnection Conexion()
        {
        return new SqlConnection(Conn);
        }
    }
}