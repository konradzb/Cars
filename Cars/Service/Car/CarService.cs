using Cars.Dtos;
using Cars.Extensions;
using Cars.Model;
using Cars.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// This service is responsible for funcionality of a car object
/// It is connected to the CarsDao and parses output to the car controller
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

        public IEnumerable<CarDto> GetAllCars()
        {
            var cars = carsDao.GetAllCars().ConvertAll(car => car.AsDto());
            return cars;
        }

        public ActionResult<CarDto> GetCarById(int id)
        {
            var car = carsDao.GetCarById(id);
            if (car == null)
            {
                return null;
            }
            return car.AsDto();
        }

        public CarDto AddCar(CarInputDto carInput)
        {
            //this is just a temporary ID, because it cannot be null,
            //after implementing mySQL server, the ID will be auto generated
            //We can also consider creating second constructor with no ID property
            int id = 0;
            Car car = new Car(
                   id,
                   carInput.ModelId,
                   carInput.Mileage,
                   carInput.Color,
                   carInput.ProductionDate,
                   carInput.IsAvailable,
                   carInput.PricePerDay
               );
            return carsDao.AddCar(car).AsDto();
        }

        public ActionResult<bool> DeleteCarById(int id)
        {
            var carToDelete = carsDao.GetCarById(id);

            if (carToDelete is null)
            {
                return null;
            }
            return carsDao.DeleteCarById(id);

        }

        public ActionResult<CarDto> EditCarById(int id, CarEditDto carEditDto)
        {
            var carToEdit = carsDao.GetCarById(id);

            if (carToEdit is null)
            {
                return null;
            }

            Car editedCar = carToEdit with
            {
                ModelId = carEditDto.ModelId,
                Mileage = carEditDto.Mileage,
                Color = carEditDto.Color,
                ProductionDate = carEditDto.ProductionDate,
                IsAvailable = carEditDto.IsAvailable,
                PricePerDay = carEditDto.PricePerDay
            };

            return carsDao.EditCarById(editedCar).AsDto();
        }

        public IEnumerable<ComplexCar> GetComplexCarsObejct(int pageIndex)
        {
            return carsDao.GetComplexCarsObject(pageIndex);
        }


        public IEnumerable<string> GetAllColors()
        {
            return carsDao.GetAllColors();
        }
    }
}
