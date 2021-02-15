using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        public static DateTime Now { get; private set; }

        static void Main(string[] args)
        {
            //CarManager carManager = Inmemory();

            //CarAdd();
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarByColorId(2))
            //{
            //    System.Console.WriteLine(car.ColorName);
            //}
            //RentalAdd();

            GetRental();

        }

        private static void GetRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var item in rentalManager.GetRentalDetailsDto(2).Data)
            {
                System.Console.WriteLine(item.CarName + " " + item.CustomerName + " " + item.RentDate);
            }
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
    }

    private static void RentalAdd()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        rentalManager.Add(new Rental { CarId = 4, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null });
    }

}
    



