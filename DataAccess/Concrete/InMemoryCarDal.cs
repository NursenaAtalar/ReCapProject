using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars = new List<Car>
        {
            new Car{CarId=1,BrandId=2, ColorId=1,DailyPrice=200, ModelYear=2007,Description="second hand"},
            new Car{CarId=2,BrandId=2, ColorId=2,DailyPrice=600, ModelYear=2015,Description="new"},
            new Car{CarId=3,BrandId=1, ColorId=2,DailyPrice=400, ModelYear=2013,Description="second hand"},
        };

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int carId)
        {
           return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
