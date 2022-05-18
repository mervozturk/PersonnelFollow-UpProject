using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ContactNumber:IEntity
    {
        public int ContactNumberId { get; set; }
        public int PersonnelId { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
