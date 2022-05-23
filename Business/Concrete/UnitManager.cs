using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UnitManager : IUnitService
    {
        IUnitDal _unitDal;
        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }
        public IResult Add(Unit unit)
        {
            _unitDal.Add(unit);
            return new SuccessResult();
        }

        public IResult Delete(Unit unit)
        {
            _unitDal.Delete(unit);
            return new SuccessResult();
        }

        public IDataResult<List<Unit>> GetAll()
        {
            return new SuccessDataResult<List<Unit>>(_unitDal.GetAll());
        }

        public IDataResult<List<Unit>> GetByDepartmentId(int Id)
        {
            return new SuccessDataResult<List<Unit>>(_unitDal.GetAll(u=>u.DepartmentId==Id));
        }

        public IDataResult<Unit> GetById(int Id)
        {
            return new SuccessDataResult<Unit>(_unitDal.Get(u=>u.UnitId==Id));
        }

        public IResult Update(Unit unit)
        {
            _unitDal.Update(unit);
            return new SuccessResult();
        }
    }
}
