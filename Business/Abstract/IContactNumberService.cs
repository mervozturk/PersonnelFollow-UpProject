using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactNumberService
    {
        IDataResult<List<ContactNumber>> GetAll();
        IDataResult<ContactNumber> GetById(int Id);
        IDataResult<List<ContactNumber>> GetByPersonnelId(int PersonnelId);
        IResult Add(ContactNumber contactNumber);
        IResult Update(ContactNumber contactNumber);
        IResult Delete(ContactNumber contactNumber);
    }
}
