using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUnit_AssigmentService
    {
        IDataResult<List<UnitAssigmentDetailDto>> GetAllDetails();
        IDataResult<List<UnitAssigmentDetailDto>> GetByunitId(int unitId);
        IDataResult<List<UnitAssigmentDetailDto>> GetByName(string name);
        IResult Add(Unit_Assigment unit_assigment);
        IResult Update(Unit_Assigment unit_assigment);
        IResult Delete(Unit_Assigment unit_assigment);
    }
}
