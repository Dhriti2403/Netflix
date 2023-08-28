using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.DataAccess
{
    public class InsertUserDetail
    {
        public void InsertUserDetails()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into UserDetails(userid,username,useremail,createdon,updatedon) values(1,'Dhriti','dhriti12@gmail.com',GETDATE(),GETDATE())";

          
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            
            sqlConnetion.Open();

            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();

            if (rowaffected == 1)
            {
                //success
            }

        }

        public void InsertUserDetail_store()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            

            string query = "InsertUserDetails";

            SqlCommand cmd = new SqlCommand(query, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

           // cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = 3;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = "yatri";
            cmd.Parameters.Add("@UserEmail", SqlDbType.VarChar).Value = "yatri123@gmail.com";
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";
            
            sqlconnection.Open();

            int rowaffected = cmd.ExecuteNonQuery();
            sqlconnection.Close();

            if (rowaffected == 1)
            {
                //success
            }

        }


    }
}
