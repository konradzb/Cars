using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

//Interface of a CarService,
//every implementation should implements this one
namespace Cars.Service
{
    public interface ICarService
    {
        CarDto AddCar(CarInputDto carInput);
        ActionResult<bool> DeleteCarById(int id);
        ActionResult<CarDto> EditCarById(int id, CarEditDto carEdit);
        IEnumerable<CarDto> GetAllCars();
        ActionResult<CarDto> GetCarById(int id);
    }
}