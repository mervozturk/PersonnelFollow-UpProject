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
    public interface IUnit_PersonnelService
    {
        IDataResult<List<UnitPersonnelDetailDto>> GetAllDetails();
        IDataResult<List<UnitPersonnelDetailDto>> GetByunitId(int unitId);
        IDataResult<List<UnitPersonnelDetailDto>> GetByName(string PersonnelName);
        IResult Add(Unit_Personnel unit_Personnel);
        IResult Update(Unit_Personnel unit_Personnel);
        IResult Delete(Unit_Personnel unit_Personnel);
    }
}
