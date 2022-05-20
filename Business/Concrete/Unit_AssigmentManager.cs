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
    public class Unit_AssigmentManager : IUnit_AssigmentService
    {
        IUnit_AssigmentDal _unit_AssigmentDal;
        public Unit_AssigmentManager(IUnit_AssigmentDal unit_AssigmentDal)
        {
            _unit_AssigmentDal = unit_AssigmentDal;
        }
        public IResult Add(Unit_Assigment unit_assigment)
        {
            _unit_AssigmentDal.Add(unit_assigment);
            return new SuccessResult();
        }

        public IResult Delete(Unit_Assigment unit_assigment)
        {
            _unit_AssigmentDal.Delete(unit_assigment);
            return new SuccessResult();
        }

        public IDataResult<List<UnitAssigmentDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<UnitAssigmentDetailDto>>(_unit_AssigmentDal.GetDetails());
        }

        public IDataResult<List<UnitAssigmentDetailDto>> GetByName(string name)
        {
            return new SuccessDataResult<List<UnitAssigmentDetailDto>>(_unit_AssigmentDal.GetDTO(a => a.AssigmentName.Contains(name)));
        }

        public IDataResult<List<UnitAssigmentDetailDto>> GetByunitId(int unitId)
        {
            return new SuccessDataResult<List<UnitAssigmentDetailDto>>(_unit_AssigmentDal.GetDTO(a => a.UnitId==unitId));
        }

        public IResult Update(Unit_Assigment unit_assigment)
        {
            _unit_AssigmentDal.Update(unit_assigment);
            return new SuccessResult();
        }
    }
}
