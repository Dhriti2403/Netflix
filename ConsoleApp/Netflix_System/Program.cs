
using Netflix.DataAccess;
using Netflix.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix_System
{
   public class Program
    {
        static void Main(string[] args)
        {
            //UserDetailModel userDetailModel = new UserDetailModel();
            //userDetailModel.UserName = "Dhriti";

            //Console.WriteLine(userDetailModel.UserName);


            //new InsertUserDetail().InsertUserDetail_store();
            //    InsertGenresType obj = new InsertGenresType();
            //    obj.InsertGenresTypeData();

           new InsertMovie().InsertMovieData();
            //new InsertPayment().InsertPaymentData();
            // new InsertSubscription().InsertSubscriptionData();

            //new InsertWatchList().InsertWatchListData();
            //new InsertRating().InsertRatingData();
            //  new InsertUserHistory().InsertUserHistoryData();
            new InsertSubsciptionPlan().InsertPlanData();
        }
    }
}
