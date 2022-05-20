using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAssigmentService
    {
        IDataResult<List<Assigment>> GetAll();
        IDataResult<Assigment> GetById(int Id);
        IDataResult<List<Assigment>> GetByName(string name);
        IResult Add(Assigment assigment);
        IResult Update(Assigment assigment);
        IResult Delete(Assigment assigment);
    }
}
