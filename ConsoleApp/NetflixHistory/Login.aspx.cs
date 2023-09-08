using Netflix.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetflixHistory
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click1(object sender, EventArgs e)
        {
            string UserEmail = TextBox1.Text;
            string Password = TextBox2.Text;

            InsertUserDetail insertuser = new InsertUserDetail();
            bool exist = insertuser.InsertLoginData(UserEmail, Password, out string validationmessage);
            if (exist)
            {
                Session["UserEmail"] = UserEmail;
                Response.Redirect("redirect.aspx");
            }
            else
            {
                Label2.Text = validationmessage;
            }
        }

    }
}