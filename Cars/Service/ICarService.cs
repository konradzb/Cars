using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cars.Service
{
    public interface ICarService
    {
        Car AddCar(CarInput carInput);
        ActionResult<Car> DeleteCarById(Guid id);
        ActionResult<Car> EditCarById(Guid id, CarInput carInput);
        IEnumerable<Car> GetAllCars();
        ActionResult<Car> GetCarById(Guid id);
    }
}