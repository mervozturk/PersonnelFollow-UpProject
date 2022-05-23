using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personnel : IEntity
    {
        public int PersonnelId { get; set; }
        public int BranchId { get; set; }
        public int UnitId { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string BirthPlace { get; set; }
        public string EducationalStatus { get; set; }
        public string Occupation { get; set; }
        public DateTime StartDateOfEmployment  { get; set; }
        public DateTime TerminationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
