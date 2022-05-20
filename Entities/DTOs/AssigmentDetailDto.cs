using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AssigmentDetailDto
    {
        public int AssigmentId { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string AssigmentName { get; set; }
        public string AssigmentDescription { get; set; }
        public int PersonnelId { get; set; }
        public string  PersonnelFirstName { get; set; }
        public string PersonnelFLastName { get; set; }
    }
}
