using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBranch_DepartmentDal : IEntityRepository<Branch_Department>
    {
        List<BranchDetailDto> GetBranchDetailDtos();
        List<BranchDetailDto> GetByBranchId(int Id);
    }
}
