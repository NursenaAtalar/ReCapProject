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
            

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId=1,BrandId = 1, ColorId = 2, DailyPrice = 500, ModelYear = "2016", Description = "BMW" });
            

        }
    }
}
