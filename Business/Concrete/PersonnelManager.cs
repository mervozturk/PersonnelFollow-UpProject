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
    public class PersonnelManager : IPersonnelService
    {
        IPersonnelDal _personnelDal;
        public PersonnelManager(IPersonnelDal personnelDal)
        {
            _personnelDal = personnelDal;
        }
        public IResult Add(Personnel personnel)
        {
            _personnelDal.Add(personnel);
            return new SuccessResult();
        }

        public IResult Delete(Personnel personnel)
        {
            _personnelDal.Delete(personnel);
            return new SuccessResult();
        }

        public IDataResult<List<Personnel>> GetActivePersonnel()
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p=>p.IsActive==true));
        }

        public IDataResult<List<Personnel>> GetAll()
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll());
        }
        public IDataResult<List<Personnel>> GetByPassive()
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p => p.IsActive == false));
        }

        public IDataResult<Personnel> GetById(int Id)
        {
            return new SuccessDataResult<Personnel>(_personnelDal.Get(p => p.PersonnelId == Id));
        }

        public IDataResult<List<Personnel>> GetByIdentityNumber(string IdentityNumber)
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p => p.IdentityNumber.Contains(IdentityNumber)));
        }

        public IDataResult<List<Personnel>> GetByName(string name)
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p => p.FirstName.Contains(name)));
        }

        public IDataResult<List<Personnel>> GetByStartDateOfEmployment(DateTime date)
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p => p.StartDateOfEmployment.ToString().Contains(date.ToString())));
        }

        public IResult Update(Personnel personnel)
        {
            _personnelDal.Update(personnel);
            return new SuccessResult();
        }

        public IDataResult<List<Personnel>> GetByUnitId(int unitId)
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p => p.UnitId==unitId));
        }

        public IDataResult<List<Personnel>> GetByBranchId(int branchId)
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetAll(p => p.BranchId==branchId));
        }

        public IDataResult<List<Personnel>> GetPersonnelByBranchAndUnit(int branchId, int unitId)
        {
            return new SuccessDataResult<List<Personnel>>(_personnelDal.GetPersonnelByBranchAndUnit(branchId, unitId));
        }
    }
}
