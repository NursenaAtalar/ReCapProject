using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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
            ValidationTool.Validate(new CarValidator(), car);

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Update(Car car)
        {
            ValidationTool.Validate(new CarValidator(), car);
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetAllDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDto()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

        public IDataResult<List<CarDetailDto>> GetCarByColorId(int x)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos(c => c.ColorId == x));
        }

        public IDataResult<List<CarDetailDto>> GetCarByBrandId(int x)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos(b => b.BrandId == x));
        }
    }
}
