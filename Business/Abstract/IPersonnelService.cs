using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonnelService
    {
        IDataResult<List<Personnel>> GetAll();
        IDataResult<List<Personnel>> GetActivePersonnel();
        IDataResult<List<Personnel>> GetByPassive();
        IDataResult<List<Personnel>> GetByUnitId(int unitId);
        IDataResult<List<Personnel>> GetByBranchId(int branchId);
        IDataResult<List<Personnel>> GetPersonnelByBranchAndUnit(int branchId, int unitId);
        IDataResult<List<Personnel>> GetByName(string name);
        IDataResult<List<Personnel>> GetByIdentityNumber(string IdentityNumber);
        IDataResult<List<Personnel>> GetByStartDateOfEmployment(DateTime date);
        IDataResult<Personnel> GetById(int Id);
        IResult Add(Personnel personnel);
        IResult Update(Personnel personnel);
        IResult Delete(Personnel personnel);
    }
}
