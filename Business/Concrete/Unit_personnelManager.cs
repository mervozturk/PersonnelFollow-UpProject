using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Unit_personnelManager : IUnit_PersonnelService
    {
        IUnit_PersonnelDal _unit_PersonnelDal;
        public Unit_personnelManager(IUnit_PersonnelDal unit_PersonnelDal)
        {
            _unit_PersonnelDal = unit_PersonnelDal;
        }
        public IResult Add(Unit_Personnel unit_Personnel)
        {
            _unit_PersonnelDal.Add(unit_Personnel);
            return new SuccessResult();
        }

        public IResult Delete(Unit_Personnel unit_Personnel)
        {
            _unit_PersonnelDal.Delete(unit_Personnel);
            return new SuccessResult();
        }

        public IDataResult<List<UnitPersonnelDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<UnitPersonnelDetailDto>>(_unit_PersonnelDal.GetDetails());
        }

        public IDataResult<List<UnitPersonnelDetailDto>> GetByName(string PersonnelName)
        {
            return new SuccessDataResult<List<UnitPersonnelDetailDto>>(_unit_PersonnelDal.GetDTO(p=>p.FirstName.Contains(PersonnelName)));
        }

        public IDataResult<List<UnitPersonnelDetailDto>> GetByunitId(int unitId)
        {
            return new SuccessDataResult<List<UnitPersonnelDetailDto>>(_unit_PersonnelDal.GetDTO(u=>u.UnitId==unitId));
        }

        public IResult Update(Unit_Personnel unit_Personnel)
        {
            _unit_PersonnelDal.Update(unit_Personnel);
            return new SuccessResult();
        }
    }
}
