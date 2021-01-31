using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            carManager.Add(new Car { CarId=4,ColorId=2,BrandId=1,DailyPrice=450,ModelYear=2009, Description="new"} );
            
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.CarId + " " + car.DailyPrice);
            }


        }
    }
}
