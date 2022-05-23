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
        public int BranchId { get; set; }
        public int UnitId { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string AssigmentName { get; set; }
        public string AssigmentDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
