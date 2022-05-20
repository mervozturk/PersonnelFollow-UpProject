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
    public class EfUnit_PersonnelDal : EfEntityRepositoryBase<Unit_Personnel, PersonnelFollow_UpContex>, IUnit_PersonnelDal
    {
        public List<UnitPersonnelDetailDto> GetDetails()
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from u_p in contex.Units_Personnels
                             join u in contex.Units
                             on u_p.UnitId equals u.UnitId
                             join p in contex.Personnels
                             on u_p.PersonnelId equals p.PersonnelId
                             join d in contex.Departments
                             on u.DepartmentId equals d.DepartmentId
                             select new UnitPersonnelDetailDto
                             {
                                 DepartmentId = d.DepartmentId,
                                 DepartmentName = d.DepartmentName,
                                 UnitId = u.UnitId,
                                 UnitName = u.UnitName,
                                 PersonnelId = p.PersonnelId,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName
                             };
                return result.ToList();
            }
        }


        public List<UnitPersonnelDetailDto> GetDTO(Func<UnitPersonnelDetailDto, bool> filter = null)
        {
            return filter == null ?
                  GetDetails() :
                  GetDetails().Where(filter).ToList();
        }
    }
}
