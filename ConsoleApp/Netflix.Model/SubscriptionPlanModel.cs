using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
    public class SubscriptionPlanModel:EntityBase<int>
    {
        public string PlanName { get; set; }

        public decimal PlanCharge { get; set; }
    }
}
