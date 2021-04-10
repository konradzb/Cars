using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cars.Repo
{
    public interface ICarDao
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car AddCar(CarInputDto carInput);
        Car EditCarById(int id, CarInputDto carInput);
        Car DeleteCarById(int id);

    }
}