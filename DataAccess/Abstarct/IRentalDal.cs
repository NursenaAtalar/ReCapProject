﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstarct
{
    public interface IRentalDal: IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetailsDto(Expression<Func<Rental, bool>> filter = null);
       
    }
}
