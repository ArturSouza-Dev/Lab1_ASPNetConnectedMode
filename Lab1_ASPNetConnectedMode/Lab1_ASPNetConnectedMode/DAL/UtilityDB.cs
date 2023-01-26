using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["WSA_lab1_ConnString"].ConnectionString;
            conn.Open();
            return conn;
        }
    }
}