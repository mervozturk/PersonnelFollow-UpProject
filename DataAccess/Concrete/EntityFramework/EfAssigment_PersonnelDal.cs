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
    public class EfAssigment_PersonnelDal : EfEntityRepositoryBase<Assigment_Personnel, PersonnelFollow_UpContex>, IAssigment_PersonnelDal
    {
        public List<Assigment> GetAssigmentByPersonnelId(int personnelId)
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from a in contex.Assigments
                             join a_p in contex.Assigments_Personnels
                             on a.AssigmentId equals a_p.AssigmentId
                             join p in contex.Personnels
                             on personnelId equals p.PersonnelId
                             select new Assigment
                             {
                                 AssigmentId = a.AssigmentId,
                                 AssigmentName = a.AssigmentName,
                                 AssigmentDescription = a.AssigmentDescription,
                                 Deadline = a.Deadline,
                                 SubmittedDate = a.SubmittedDate

                             };
                return result.ToList();
            }
        }

        public List<AssigmentDetailDto> GetAssigmentDetail()
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from a in contex.Assigments
                             join a_p in contex.Assigments_Personnels
                             on a.AssigmentId equals a_p.AssigmentId
                             join p in contex.Personnels
                             on a_p.PersonnelId equals p.PersonnelId
                             select new AssigmentDetailDto
                             {
                                 AssigmentId = a.AssigmentId,
                                 PersonnelId = p.PersonnelId,
                                 PersonnelFirstName = p.FirstName,
                                 PersonnelFLastName = p.LastName,
                                 AssigmentName = a.AssigmentName,
                                 AssigmentDescription = a.AssigmentDescription,
                                 Deadline = a.Deadline,
                                 SubmittedDate = a.SubmittedDate
                             };
                return result.ToList();
            }
        }


        public List<AssigmentDetailDto> GetByAssigmentId(int assigmentId)
        {
            return GetAssigmentDetail().Where(a => a.AssigmentId == assigmentId).ToList();
        }

        public List<Personnel> GetPersonnelByAssigmentId(int assigmentId)
        {
            using(PersonnelFollow_UpContex contex = new PersonnelFollow_UpContex())
            {
                var result = from u_a in contex.Assigments_Personnels
                             where u_a.AssigmentId==assigmentId
                             join a in contex.Assigments
                             on u_a.AssigmentId equals a.AssigmentId
                             join p in contex.Personnels
                             on u_a.PersonnelId equals p.PersonnelId
                             select new Personnel
                             {
                                 PersonnelId = p.PersonnelId,
                                 Birthdate = p.Birthdate,
                                 BirthPlace = p.BirthPlace,
                                 BranchId = p.BranchId,
                                 EducationalStatus = p.EducationalStatus,
                                 FirstName = p.FirstName,
                                 IdentityNumber = p.IdentityNumber,
                                 IsActive = p.IsActive,
                                 LastName = p.LastName,
                                 Occupation = p.Occupation,
                                 StartDateOfEmployment = p.StartDateOfEmployment,
                                 TerminationDate = p.TerminationDate,
                                 UnitId = p.UnitId
                             };
                return result.ToList();
            }
            
        }
    }
}
