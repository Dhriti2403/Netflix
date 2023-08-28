using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
    public class PaymentModel : EntityBase<int, DateTime>
    {
        public string PaymentType { get; set; }
    }
}
