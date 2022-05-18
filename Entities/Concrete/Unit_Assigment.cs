using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Unit_Assigment :IEntity
    {
        public int UnitId { get; set; }
        public int AssigmentId { get; set; }
    }
}
