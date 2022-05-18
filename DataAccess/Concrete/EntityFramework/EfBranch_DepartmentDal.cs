using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBranch_DepartmentDal : EfEntityRepositoryBase<Branch_Department, PersonnelFollow_UpContex>,IBranch_DepartmentDal
    {
    }
}
