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
    public interface IAssigmentDal :IEntityRepository<Assigment>
    {
        List<AssigmentDetailDto> GetAllDetail();
        List<AssigmentDetailDto> GetAllAPassive();
        List<AssigmentDetailDto> GetByPersonnelId(int personnelId);
        List<AssigmentDetailDto> GetByUnitId(int unitId);
        List<AssigmentDetailDto> GetByAssigmentId(int assigmentId);
        List<AssigmentDetailDto> GetAllActive();


    }
}
