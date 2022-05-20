using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Branch_DepartmentManager : IBranch_DepartmentService
    {
        IBranch_DepartmentDal _branch_DepartmentDal;
        public IResult Add(Branch_Department branch_Department)
        {
            _branch_DepartmentDal.Add(branch_Department);
            return new SuccessResult();
        }

        public IResult Delete(Branch_Department branch_Department)
        {
            _branch_DepartmentDal.Delete(branch_Department);
            return new SuccessResult();
        }

        public IDataResult<List<Branch_Department>> GetAll()
        {
            return new SuccessDataResult<List<Branch_Department>>(_branch_DepartmentDal.GetAll());
        }

        public IDataResult<List<BranchDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<BranchDetailDto>>(_branch_DepartmentDal.GetBranchDetailDtos());
        }

        public IDataResult<List<BranchDetailDto>> GetByBranchId(int Id)
        {
            return new SuccessDataResult<List<BranchDetailDto>>(_branch_DepartmentDal.GetByBranchId(Id));
        }

        public IResult Update(Branch_Department branch_Department)
        {
            _branch_DepartmentDal.Update(branch_Department);
            return new SuccessResult();
        }
    }
}
