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
    public interface IAssigment_PersonnelService
    {
        IDataResult<List<AssigmentDetailDto>> GetAllDetails();
        IDataResult<List<AssigmentDetailDto>> GetByAssigmentId(int assigmentId);
        IDataResult<List<Assigment>> GetByPersonnelId(int personnelId);
        IDataResult<List<Personnel>> GetPersonByAssigmentId(int assigmentId);
        IDataResult<Assigment_Personnel> GetAssigment_Personnel(int assigmentId, int personnel);
        IResult Add(Assigment_Personnel assigment_Personnel);
        IResult Update(Assigment_Personnel assigment_Personnel);
        IResult Delete(Assigment_Personnel assigment_Personnel);


    }
}
