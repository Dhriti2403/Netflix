using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
   public class UserDetailModel : EntityBase<int, DateTime>
    {
            public string UserName { get; set; }
            public string UserEmail { get; set; }
            public DateTime UpdatedOn { get; set; }
        }
    }
