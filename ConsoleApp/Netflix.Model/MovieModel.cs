using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
    public class MovieModel : EntityBase<int, DateTime>
    {
        public string MovieTitle { get; set; }
        public int GenresId { get; set; }
        public DateTime ReleasDate { get; set; }
    }
}
