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
    public class EfAssigmentDal : EfEntityRepositoryBase<Assigment, PersonnelFollow_UpContex>, IAssigmentDal
    {
        public List<AssigmentDetailDto> GetAllActive()
        {
            return GetAllDetail().Where(a=>a.IsActive==true).ToList();
        }
        public List<AssigmentDetailDto> GetAllAPassive()
        {
            return GetAllDetail().Where(a => a.IsActive == false).ToList();
        }

        public List<AssigmentDetailDto> GetAllDetail()
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from u in contex.Units
                             join a in contex.Assigments
                             on u.UnitId equals a.UnitId
                             join a_p in contex.Assigments_Personnels
                             on a.AssigmentId equals a_p.AssigmentId
                             join p in contex.Personnels
                             on a_p.PersonnelId equals p.PersonnelId
                             select new AssigmentDetailDto
                             {
                                 AssigmentId = a.AssigmentId,
                                 AssigmentName = a.AssigmentName,
                                 AssigmentDescription = a.AssigmentDescription,
                                 Deadline = a.Deadline,
                                 SubmittedDate = a.SubmittedDate,
                                 IsActive=a.IsActive,
                                 UnitId = u.UnitId,
                                 UnitName = u.UnitName,
                                 PersonnelId = p.PersonnelId,
                                 PersonnelFirstName = p.FirstName,
                                 PersonnelFLastName = p.LastName,
                                 BranchId=p.BranchId
                                 
                             };
                return result.ToList();
            }
        }

        

        public List<AssigmentDetailDto> GetByAssigmentId(int assigmentId)
        {
            return GetAllDetail().Where(a => a.AssigmentId == assigmentId).ToList();
        }

        public List<AssigmentDetailDto> GetByPersonnelId(int personnelId)
        {
            return GetAllDetail().Where(p=>p.PersonnelId==personnelId).ToList();
        }

        public List<AssigmentDetailDto> GetByUnitId(int unitId)
        {
            return GetAllDetail().Where(u=>u.UnitId==unitId).ToList();
        }
    }
}
