﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Model.EntityBase
{
    public class EntityBase<T, V>
    {
        public T Id { get; set; }

        public V CreatedOn { get; set; }

    }
}
