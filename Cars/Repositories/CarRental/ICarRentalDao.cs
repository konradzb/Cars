using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// Interface resposible for communication with Data Base 
namespace Cars.Repo
{
    public interface ICarRentalDao
    {
        List<CarRental> GetAllCarRentals();
        CarRental GetCarRentalById(int id);
        CarRental AddCarRental(CarRental carRental);
        CarRental EditCarRentalById(CarRental carRental);
        bool DeleteCarRentalById(int id);

    }
}