using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAllDailyPrice(decimal min , decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetailDto();
        IDataResult<List<CarDetailDto>>GetCarByColorId(int x);
        IDataResult<List<CarDetailDto>>GetCarByBrandId(int x);

    }
}
