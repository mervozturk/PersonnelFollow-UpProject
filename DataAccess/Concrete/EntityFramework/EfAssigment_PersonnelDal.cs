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

        public AssigmentDetailDto GetByAssigmentId(int assigmentId)
        {
            return GetAssigmentDetail().SingleOrDefault(a => a.AssigmentId == assigmentId);
        }
    }
}
