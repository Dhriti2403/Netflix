using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
    public class WatchListModel : EntityBase<int, DateTime>
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
    }
}
