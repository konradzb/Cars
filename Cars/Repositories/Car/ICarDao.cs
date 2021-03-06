using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// Interface resposible for communication with Data Base
namespace Cars.Repo
{
    public interface ICarDao
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car AddCar(Car car);
        Car EditCarById(Car car);
        bool DeleteCarById(int id);
    }
}