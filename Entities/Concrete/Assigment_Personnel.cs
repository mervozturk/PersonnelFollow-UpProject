using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Assigment_Personnel : IEntity
    {
        public int AssigmentId { get; set; }
        public int PersonnelId { get; set; }
    }
}
