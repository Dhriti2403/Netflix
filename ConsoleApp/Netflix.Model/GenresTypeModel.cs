using Netflix.Model.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model
{
    public class GenresTypeModel : EntityBase<int>
    {
        public string GeneresName { get; set; }
    }
}
