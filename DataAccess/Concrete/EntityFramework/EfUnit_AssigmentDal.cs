using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUnit_AssigmentDal : EfEntityRepositoryBase<Unit_Assigment, PersonnelFollow_UpContex>, IUnit_AssigmentDal
    {
        public List<UnitAssigmentDetailDto> GetDetails()
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from u_a in contex.Units_Assigments
                             join u in contex.Units
                             on u_a.UnitId equals u.UnitId
                             join a in contex.Assigments
                             on u_a.AssigmentId equals a.AssigmentId
                             select new UnitAssigmentDetailDto
                             {
                                 AssigmentId = a.AssigmentId,
                                 UnitId = u.UnitId,
                                 UnitName = u.UnitName,
                                 AssigmentName = a.AssigmentName,
                                 AssigmentDescription = a.AssigmentDescription,
                                 Deadline = a.Deadline,
                                 SubmittedDate = a.SubmittedDate
                             };
                return result.ToList();
            }
        }

        public List<UnitAssigmentDetailDto> GetDTO(Func<UnitAssigmentDetailDto, bool> filter = null)
        {
            return filter == null ?
                  GetDetails() :
                  GetDetails().Where(filter).ToList();
        }
    }
}
