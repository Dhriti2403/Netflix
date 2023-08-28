using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.DataAccess
{
    public class InsertGenresType
    {
        public void InsertGenresTypeData()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into GenresType values(104,'Tv Show')";


            SqlCommand cmd = new SqlCommand(query, sqlConnetion);

            sqlConnetion.Open();

            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();

        }
    }
}
