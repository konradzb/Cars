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

        public IEnumerable<Car> GetAllCars()
        {
            return carsDao.GetAllCars();
        }

        public ActionResult<Car> GetCarById(Guid id)
        {
            return carsDao.GetCarById(id);
        }
        public Car AddCar(CarInput carInput)
        {
            throw new NotImplementedException();
        }

        public ActionResult<Car> EditCarById(Guid id, CarInput carInput)
        {
            throw new NotImplementedException();
        }

        public ActionResult<Car> DeleteCarById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
