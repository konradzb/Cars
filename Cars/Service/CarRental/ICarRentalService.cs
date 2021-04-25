using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

//Interface of a CarRentalService
namespace Cars.Service
{
    public interface ICarRentalService
    {
        CarRentalDto AddRentalCar(CarRentalInputDto carRentalInput);
        ActionResult<bool> DeleteCarRentalById(int id);
        ActionResult<CarRentalDto> EditCarRentalById(int id, CarRentalEditDto carRentalEdit);
        IEnumerable<CarRentalDto> GetAllCarRentals();
        ActionResult<CarRentalDto> GetCarRentalById(int id);
    }
}