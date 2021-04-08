using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cars.Repo
{
    public interface ICarsDao
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(Guid id);
        Car AddCar(CarInput carInput);
        Car EditCarById(Guid id, CarInput carInput);
        Car DeleteCarById(Guid id);

    }
}