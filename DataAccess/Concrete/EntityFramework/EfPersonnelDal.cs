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
    public class EfPersonnelDal : EfEntityRepositoryBase<Personnel, PersonnelFollow_UpContex>, IPersonnelDal
    {
        public List<Personnel> GetPersonnelByBranchAndUnit(int branchId, int unitId)
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from p in contex.Personnels
                             where p.BranchId == branchId && p.UnitId == unitId
                             select new Personnel
                             {
                                 PersonnelId = p.PersonnelId,
                                 UnitId = p.UnitId,
                                 BranchId = p.BranchId,
                                 Birthdate = p.Birthdate,
                                 BirthPlace = p.BirthPlace,
                                 EducationalStatus = p.EducationalStatus,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 IdentityNumber = p.IdentityNumber,
                                 IsActive = p.IsActive,
                                 Occupation = p.Occupation,
                                 StartDateOfEmployment = p.StartDateOfEmployment,
                                 TerminationDate = p.TerminationDate
                             };
                return result.ToList();
            }
        }
    }
}
