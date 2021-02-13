using Business.Abstract;
using Business.Constant;
using Core.Utilities;
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

        public IResult Add(Car car)
        {

            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
        }

        IResult ICarService.Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CarUpdatedFail);
            }
            
        }

        IResult ICarService.Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }

        IDataResult<Car> ICarService.GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        IDataResult<List<Car>> ICarService.GetAllDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        IDataResult<List<CarDetailDto>> ICarService.GetCarDetailDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

        IDataResult<List<CarDetailDto>> ICarService.GetCarByColorId(int x)
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetailDtos(c => c.ColorId == x));
        }

        IDataResult<List<CarDetailDto>> ICarService.GetCarByBrandId(int x)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos(b => b.BrandId == x));
        }
    }
}
