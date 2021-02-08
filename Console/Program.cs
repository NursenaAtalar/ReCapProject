using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = Inmemory();

            CarManager carManager = new CarManager(new EfCarDal());
           
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                System.Console.WriteLine(car.Name);
            }
        }

        private static CarManager Inmemory()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = "2016", Description = "BMW" });
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Id + car.Description);
            }

            return carManager;
        }
    }
}
