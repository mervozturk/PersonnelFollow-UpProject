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
    public interface IAssigment_PersonnelDal :IEntityRepository<Assigment_Personnel>
    {
        List<AssigmentDetailDto> GetAssigmentDetail();
        List<Assigment> GetAssigmentByPersonnelId(int personnelId);
        List<AssigmentDetailDto> GetByAssigmentId(int assigmentId);
        List<Personnel> GetPersonnelByAssigmentId(int assigmentId);
    }
}
