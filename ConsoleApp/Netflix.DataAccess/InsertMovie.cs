﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.DataAccess
{
    public class InsertMovie
    {
        public void InsertMovieData()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into Movie values(206,'Eli',103,'2023-06-02',4.2)";


            SqlCommand cmd = new SqlCommand(query, sqlConnetion);

            sqlConnetion.Open();

            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();

        }
    }
}
