using Cars.Dtos;
using Cars.Extensions;
using Cars.Model;
using Cars.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Cars.Service
{
    public class CarService : ICarService
    {
        private readonly ICarDao carsDao;
        public CarService(ICarDao carsDao)
        {
            this.carsDao = carsDao;
        }

        public IEnumerable<CarDto> GetAllCars()
        {
            var cars = carsDao.GetAllCars().ConvertAll(car => car.AsDto());
            return cars;
        }

        public ActionResult<CarDto> GetCarById(int id)
        {
            var car = carsDao.GetCarById(id);
            if (car == null)
            {
                return null;
            }
            return car.AsDto();
        }

        public CarDto AddCar(CarInputDto carInput)
        {
            return carsDao.AddCar(carInput).AsDto();
        }

        public ActionResult<CarDto> DeleteCarById(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult<CarDto> EditCarById(int id, CarInputDto carInput)
        {
            throw new NotImplementedException();
        }
    }
}
