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
    public class EfAssigment_PersonnelDal : EfEntityRepositoryBase<Assigment_Personnel, PersonnelFollow_UpContex>,IAssigment_PersonnelDal
    {
    }
}
