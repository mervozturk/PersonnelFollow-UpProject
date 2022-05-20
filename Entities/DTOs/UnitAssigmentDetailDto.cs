using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UnitAssigmentDetailDto
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int AssigmentId { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string AssigmentName { get; set; }
        public string AssigmentDescription { get; set; }
    }
}
