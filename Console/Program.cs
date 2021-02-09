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

            //CarAdd();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarByColorId(2))
            {
                System.Console.WriteLine(car.ColorName);
            }


            //private static void CarAdd()
            //{
            //    CarManager carManager = new CarManager(new EfCarDal());

            //    carManager.Add(new Car { Name = "D", BrandId = 3, ColorId = 2, DailyPrice = 100, ModelYear = "2002", Description = "Second Hand" });
            //}

            //private static CarManager Inmemory()
            //{
            //    CarManager carManager = new CarManager(new InMemoryCarDal());
            //    carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = "2016", Description = "BMW" });
            //    foreach (var car in carManager.GetAll())
            //    {
            //        System.Console.WriteLine(car.Id + car.Description);
            //    }

            //    return carManager;
            //}
        }
    }

}

