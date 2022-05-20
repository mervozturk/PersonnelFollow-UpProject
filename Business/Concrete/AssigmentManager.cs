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

        public IDataResult<List<Assigment>> GetAll()
        {
            return new SuccessDataResult<List<Assigment>>(_assigmentDal.GetAll());
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
