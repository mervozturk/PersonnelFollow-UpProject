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
    interface IAssigment_PersonnelService
    {
        IDataResult<List<AssigmentDetailDto>> GetAllDetails();
        IDataResult<AssigmentDetailDto> GetByAssigmentId(int assigmentId);
        IDataResult<List<Assigment>> GetByPersonnelId(int personnelId);
        IResult Add(Assigment_Personnel assigment_Personnel);
        IResult Update(Assigment_Personnel assigment_Personnel);
        IResult Delete(Assigment_Personnel assigment_Personnel);


    }
}
