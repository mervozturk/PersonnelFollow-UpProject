using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UnitPersonnelDetailDto
    {
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int PersonnelId { get; set; }
        public string UnitName { get; set; }
        public string DepartmentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
