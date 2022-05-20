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
    public class ContactNumberManager : IContactNumberService
    {
        IContactNumberDal _contactNumberDal;
        public ContactNumberManager(IContactNumberDal contactNumberDal)
        {
            _contactNumberDal = contactNumberDal;
        }
        public IResult Add(ContactNumber contactNumber)
        {
            _contactNumberDal.Add(contactNumber);
            return new SuccessResult();
        }

        public IResult Delete(ContactNumber contactNumber)
        {
            _contactNumberDal.Delete(contactNumber);
            return new SuccessResult();
        }

        public IDataResult<List<ContactNumber>> GetAll()
        {
            return new SuccessDataResult<List<ContactNumber>>(_contactNumberDal.GetAll());
        }

        public IDataResult<ContactNumber> GetById(int Id)
        {
            return new SuccessDataResult<ContactNumber>(_contactNumberDal.Get(c => c.ContactNumberId == Id));
        }

        public IDataResult<List<ContactNumber>> GetByPersonnelId(int PersonnelId)
        {
            return new SuccessDataResult<List<ContactNumber>>(_contactNumberDal.GetAll(c=>c.PersonnelId==PersonnelId));
        }

        public IResult Update(ContactNumber contactNumber)
        {
            _contactNumberDal.Update(contactNumber);
            return new SuccessResult();
        }
    }
}
