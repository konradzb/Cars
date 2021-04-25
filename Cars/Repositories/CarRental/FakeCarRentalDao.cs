using Cars.Dtos;
using Cars.Model;
using System;
using System.Collections.Generic;

/// <summary>
/// In memmory data base for car object, based on a simple list
/// </summary>
namespace Cars.Repo
{
    public class FakeCarRentalDao : ICarRentalDao
    {
        private List<CarRental> carRentals = new();
        public FakeCarRentalDao()
        {
            carRentals.Add(new CarRental(1, 1, 1, 1, new DateTime(2020, 6, 27), new DateTime(2020, 6, 30), 379.99));
            carRentals.Add(new CarRental(2, 2, 2, 2, new DateTime(2021, 1, 1), new DateTime(2021, 2, 1), 4579.99));
            carRentals.Add(new CarRental(3, 3, 3, 3, new DateTime(2021, 3, 17), new DateTime(2020, 4, 2), 1699.99));
        }

        public List<CarRental> GetAllCarRentals()
        {
            return carRentals;
        }

        public CarRental GetCarRentalById(int id)
        {
            return carRentals.Find(car => car.Id == id);
        }

        public CarRental AddCarRental(CarRental carRental)
        {
            carRentals.Add(carRental);
            return carRental;
        }

        public bool DeleteCarRentalById(int id)
        {
            var carRentalToDelete = GetCarRentalById(id);
            return carRentals.Remove(carRentalToDelete);
        }

        public CarRental EditCarRentalById(CarRental carRental)
        {
            int index = carRentals.FindIndex(carRentalToEdit => carRentalToEdit.Id == carRental.Id);
            carRentals[index] = carRental;
            return carRental;
        }
    }
}
