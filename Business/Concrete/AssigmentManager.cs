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
    public class AssigmentManager : IAssigmentService
    {
        IAssigmentDal _assigmentDal;
        public AssigmentManager(IAssigmentDal assigmentDal)
        {
            _assigmentDal = assigmentDal;
        }
        public IResult Add(Assigment assigment)
        {
            _assigmentDal.Add(assigment);
            return new SuccessResult();
        }

        public IResult Delete(Assigment assigment)
        {
            _assigmentDal.Delete(assigment);
            return new SuccessResult();
        }

        public IDataResult<List<Assigment>> GetActiveAssigment()
        {
            return new SuccessDataResult<List<Assigment>>(_assigmentDal.GetAll(p=>p.IsActive==true));
        }

        public IDataResult<List<Assigment>> GetAll()
        {
            return new SuccessDataResult<List<Assigment>>(_assigmentDal.GetAll());
        }

        public IDataResult<List<Assigment>> GetAllActive(int branchId, int unitId)
        {
            return new SuccessDataResult<List<Assigment>>(_assigmentDal.GetAll(a=>a.BranchId==branchId && a.UnitId==unitId && a.IsActive==true));
        }

        public IDataResult<List<AssigmentDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigmentDal.GetAllDetail());
        }

        public IDataResult<List<AssigmentDetailDto>> GetAllDetailActive()
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigmentDal.GetAllActive());
        }

        public IDataResult<List<AssigmentDetailDto>> GetAllDetailByAssigmentId(int Id)
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigmentDal.GetByAssigmentId(Id));
        }

        public IDataResult<List<AssigmentDetailDto>> GetAllDetailPassive()
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigmentDal.GetAllAPassive());
        }

        public IDataResult<List<AssigmentDetailDto>> GetAssigmentByBranchAndUnit(int branchId, int unitId)
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigmentDal.GetAllDetail().Where(a=>a.BranchId==branchId && a.UnitId==unitId).ToList());
        }

        public IDataResult<Assigment> GetById(int Id)
        {
            return new SuccessDataResult<Assigment>(_assigmentDal.Get(a => a.AssigmentId == Id));
        }

        public IDataResult<List<Assigment>> GetByName(string name)
        {

            return new SuccessDataResult<List<Assigment>>(_assigmentDal.GetAll(a => a.AssigmentName.Contains(name)));
        }

        public IResult Update(Assigment assigment)
        {
            _assigmentDal.Update(assigment);
            return new SuccessResult();
        }
    }
}
