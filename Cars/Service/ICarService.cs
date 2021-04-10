using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cars.Service
{
    public interface ICarService
    {
        CarDto AddCar(CarInputDto carInput);
        ActionResult<CarDto> DeleteCarById(int id);
        ActionResult<CarDto> EditCarById(int id, CarEditDto carInput);
        IEnumerable<CarDto> GetAllCars();
        ActionResult<CarDto> GetCarById(int id);
    }
}