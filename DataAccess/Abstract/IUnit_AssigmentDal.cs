using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUnit_AssigmentDal : IEntityRepository<Unit_Assigment>
    {
        List<UnitAssigmentDetailDto> GetDetails();
        public List<UnitAssigmentDetailDto> GetDTO(Func<UnitAssigmentDetailDto, bool> filter = null);
    }
}
