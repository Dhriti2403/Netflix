using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
    public class SubscriptionModel : EntityBase<int, DateTime>
    {
        public string SubscripType { get; set; }
        public int UserId { get; set; }
        public int PaymentId { get; set; }
        public DateTime SubscripDate { get; set; }
        public DateTime ValidTill { get; set; }

    }
}
