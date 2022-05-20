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
    public interface IBranch_DepartmentService
    {
        IDataResult<List<BranchDetailDto>> GetAllDetails();
        IDataResult<List<BranchDetailDto>> GetByBranchId(int Id);
        IDataResult<List<Branch_Department>> GetAll();
        IResult Add(Branch_Department branch_Department);
        IResult Update(Branch_Department branch_Department);
        IResult Delete(Branch_Department branch_Department);
    }
}
