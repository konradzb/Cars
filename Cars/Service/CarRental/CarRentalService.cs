using Cars.Dtos;
using Cars.Extensions;
using Cars.Model;
using Cars.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// This service is responsible for funcionality of a carRental object
/// It is connected to the CarRentalDao and parses output to the carRental controller
/// </summary>
namespace Cars.Service
{
    public class CarRentalService : ICarRentalService
    {
        private readonly ICarRentalDao carRentalDao;
        public CarRentalService(ICarRentalDao carRentalDao)
        {
            this.carRentalDao = carRentalDao;
        }

        public IEnumerable<CarRentalDto> GetAllCarRentals()
        {
            var carRentals = carRentalDao.GetAllCarRentals()
                .ConvertAll(carRental => carRental.AsDto());
            return carRentals;
        }

        public ActionResult<CarRentalDto> GetCarRentalById(int id)
        {
            var carRental = carRentalDao.GetCarRentalById(id);
            if (carRental == null)
            {
                return null;
            }
            return carRental.AsDto();
        }
        public CarRentalDto AddRentalCar(CarRentalInputDto carRentalInput)
        {
            // Id is 0, because after real DB implementation,
            // this argument will be generated automatically
            CarRental carRental = new CarRental (
                0,  //id
                carRentalInput.RentalTimeStart,
                carRentalInput.RentalTimeEnd,
                carRentalInput.Price,
                carRentalInput.UserId,
                carRentalInput.CarId
            );
            return carRentalDao.AddCarRental(carRental).AsDto();
        }

        public ActionResult<bool> DeleteCarRentalById(int id)
        {
            var carRentalToDelete = carRentalDao.GetCarRentalById(id);
            if(carRentalToDelete is null)
            {
                return null;
            }
            return carRentalDao.DeleteCarRentalById(id);
        }

        public ActionResult<CarRentalDto> EditCarRentalById(int id, CarRentalEditDto carRentalEdit)
        {
            var carRentalToEdit = carRentalDao.GetCarRentalById(id);

            if(carRentalToEdit is null)
            {
                return null;
            }

            CarRental editedCarRental = carRentalToEdit with
            {
                RentalTimeStart = carRentalEdit.RentalTimeStart,
                RentalTimeEnd = carRentalEdit.RentalTimeEnd,
                Price = carRentalEdit.Price,
                UserId = carRentalEdit.UserId,
                CarId = carRentalEdit.CarId
              
            };

            return carRentalDao.EditCarRentalById(editedCarRental).AsDto();
        }

    }
}
