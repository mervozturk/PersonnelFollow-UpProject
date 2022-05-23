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
    public interface IAssigmentService
    {
        IDataResult<List<Assigment>> GetAll();
        IDataResult<List<Assigment>> GetAllActive(int branchId, int unitId);
        IDataResult<List<AssigmentDetailDto>> GetAllDetail();
        IDataResult<List<AssigmentDetailDto>> GetAllDetailByAssigmentId(int Id);
        IDataResult<List<AssigmentDetailDto>> GetAllDetailActive();
        IDataResult<List<AssigmentDetailDto>> GetAllDetailPassive();
        IDataResult<List<Assigment>> GetActiveAssigment();
        IDataResult<Assigment> GetById(int Id);
        IDataResult<List<Assigment>> GetByName(string name);
        IResult Add(Assigment assigment);
        IResult Update(Assigment assigment);
        IResult Delete(Assigment assigment);
        IDataResult<List<AssigmentDetailDto>> GetAssigmentByBranchAndUnit(int branchId, int unitId);
      
    }
}
