﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ketnoi
    {
        public static SqlConnection Get()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-5OFAVU9\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True";
            cnn.Open();
            return cnn;
        }
   }
}
