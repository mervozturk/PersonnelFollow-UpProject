﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Branch_Department:IEntity
    {
        public int BranchId { get; set; }
        public int Department { get; set; }
    }
}
