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
        Car AddCar(Car car);
        Car EditCarById(Car car);
        Car DeleteCarById(int id);

    }
}