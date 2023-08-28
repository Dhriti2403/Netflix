using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.DataAccess
{
    public class InsertWatchList
    {
        public void InsertWatchListData()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into WatchList values(605,1,203,GETDATE(),GETDATE())";


            SqlCommand cmd = new SqlCommand(query, sqlConnetion);

            sqlConnetion.Open();

            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();

        }
    }
}
