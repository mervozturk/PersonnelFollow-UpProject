using Business.Abstract;
using Business.Constants;
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
    public class Assigment_PersonnelManager : IAssigment_PersonnelService
    {
        IAssigment_PersonnelDal _assigment_PersonnelDal;
        public Assigment_PersonnelManager(IAssigment_PersonnelDal assigment_PersonnelDal)
        {
            _assigment_PersonnelDal = assigment_PersonnelDal;
        }
        public IResult Add(Assigment_Personnel assigment_Personnel)
        {
            _assigment_PersonnelDal.Add(assigment_Personnel);
            return new SuccessResult();
        }

        public IResult Delete(Assigment_Personnel assigment_Personnel)
        {
            _assigment_PersonnelDal.Delete(assigment_Personnel);
            return new SuccessResult();
        }

        public IDataResult<List<AssigmentDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigment_PersonnelDal.GetAssigmentDetail(),Messages.Listed);
        }

        public IDataResult<Assigment_Personnel> GetAssigment_Personnel(int assigmentId, int personnel)
        {
            return new SuccessDataResult<Assigment_Personnel>(_assigment_PersonnelDal.Get(a => a.AssigmentId == assigmentId && a.PersonnelId == personnel));
        }

        public IDataResult<List<AssigmentDetailDto>> GetByAssigmentId(int assigmentId)
        {
            return new SuccessDataResult<List<AssigmentDetailDto>>(_assigment_PersonnelDal.GetByAssigmentId(assigmentId), Messages.Listed);
        }

        public IDataResult<List<Assigment>> GetByPersonnelId(int personnelId)
        {
            return new SuccessDataResult<List<Assigment>>(_assigment_PersonnelDal.GetAssigmentByPersonnelId(personnelId), Messages.Listed);
        }

        public IDataResult<List<Personnel>> GetPersonByAssigmentId(int assigmentId)
        {
            return new SuccessDataResult<List<Personnel>>(_assigment_PersonnelDal.GetPersonnelByAssigmentId(assigmentId));
        }

        public IResult Update(Assigment_Personnel assigment_Personnel)
        {
            _assigment_PersonnelDal.Update(assigment_Personnel);
            return new SuccessResult();
        }
    }
}
