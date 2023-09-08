using Netflix.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetflixHistory
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            InsertMovie im = new InsertMovie();
            Repeater1.DataSource = im.MovieRepeater();
            Repeater1.DataBind();
        }   

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}