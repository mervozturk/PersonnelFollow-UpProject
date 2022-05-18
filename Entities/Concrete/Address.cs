using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address
    {
        public int AddressId { get; set; }
        public int PersonnelId { get; set; }
        public string AddressDescription { get; set; }
    }
}
