using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Assigment :IEntity
    {
        public int AssigmentId { get; set; }
        public string AssigmentName { get; set; }
        public string AssigmentDescription { get; set; }
    }
}
