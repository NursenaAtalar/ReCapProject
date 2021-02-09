using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice>0 && car.Description.Length > 2) 
            {
                _carDal.Add(car);
                Console.WriteLine("New Car is added");
            }
            else 
            {
                Console.WriteLine("please give a car with daily price greater than 0 and description lenght longer than 2 ");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("car is deleted");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }



        public List<Car> GetAllDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice>=min && c.DailyPrice<=max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarByBrandId(int x)
        {
            return _carDal.GetCarDetailDtos(b => b.BrandId == x);
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            return _carDal.GetCarDetailDtos();
        }

        public List<CarDetailDto> GetCarByColorId(int x)
        {
            return _carDal.GetCarDetailDtos(c => c.ColorId == x);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
                Console.WriteLine(" Car is Updated");
            }
            else
            {
                Console.WriteLine("please give a car with daily price greater than 0 and description lenght longer than 2 ");
            }
        }
    }
}
