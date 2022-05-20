using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BranchDetailDto
    {
        public int BranchId { get; set; }
        public int DepartmentId { get; set; }
        public string BranchName { get; set; }
        public string DepartmentName { get; set; }
    }
}
