using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUnitService
    {
        IDataResult<List<Unit>> GetAll();
        IDataResult<Unit> GetById(int Id);
        IDataResult<List<Unit>> GetByDepartmentId(int Id);
        IResult Add(Unit unit);
        IResult Update(Unit unit);
        IResult Delete(Unit unit);
    }
}
