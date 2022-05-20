using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBranch_DepartmentDal : EfEntityRepositoryBase<Branch_Department, PersonnelFollow_UpContex>, IBranch_DepartmentDal
    {
        public List<BranchDetailDto> GetBranchDetailDtos()
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from b in contex.Branches
                             join b_d in contex.Branches_Departments
                             on b.BranchId equals b_d.BranchId
                             join d in contex.Departments
                             on b_d.DepartmentId equals d.DepartmentId
                             select new BranchDetailDto
                             {
                                 BranchId = b.BranchId,
                                 DepartmentId = d.DepartmentId,
                                 BranchName = b.BranchName,
                                 DepartmentName = d.DepartmentName
                             };
                return result.ToList();
            }
        }

        public List<BranchDetailDto> GetByBranchId(int Id)
        {
            return GetBranchDetailDtos().Where(b => b.BranchId == Id).ToList();
        }
    }
}
