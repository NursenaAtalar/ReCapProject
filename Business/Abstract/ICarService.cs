using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        Car GetById(int id); 
        List<Car> GetAllDailyPrice(decimal min , decimal max);
        List<CarDetailDto> GetCarDetailDto();
        List<CarDetailDto> GetCarsByColorId(int x);
        List<CarDetailDto> GetCarByBrandId(int x);

    }
}
