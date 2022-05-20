﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetByPersonnelId(int personnelId);
        IDataResult<Address> GetById(int Id);
        IResult Add(Address address);
        IResult Update(Address address);
        IResult Delete(Address address);
    }
}
