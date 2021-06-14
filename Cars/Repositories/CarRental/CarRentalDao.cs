using Cars.Configuration;
using Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repo
{
    public class CarRentalDao : ICarRentalDao
    {
        private readonly ApplicationDbContext _dbContext;
        public CarRentalDao(ApplicationDbContext db)
        {
            _dbContext = db;
        }
        public CarRental AddCarRental(CarRental carRental)
        {
            _dbContext.CarRentals.Add(carRental);
            _dbContext.SaveChanges();
            return carRental;
        }

        public bool DeleteCarRentalById(int id)
        {
            var result = _dbContext.CarRentals.FirstOrDefault(c => c.Id == id);
            if (result != null)
            {
                _dbContext.CarRentals.Remove(result);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public CarRental EditCarRentalById(CarRental carRental)
        {
            var result = _dbContext.CarRentals.FirstOrDefault(c => c.Id == carRental.Id);
            if (result != null)
            {
                result.RentalTimeStart = carRental.RentalTimeStart;
                result.RentalTimeEnd = carRental.RentalTimeEnd;
                result.Price = carRental.Price;
                result.UserId = carRental.UserId;
                result.CarId = carRental.CarId;
                _dbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public List<CarRental> GetAllCarRentals()
        {
            return _dbContext.CarRentals.OrderBy(c => c.Id).ToList();
        }

        public CarRental GetCarRentalById(int id)
        {
            return _dbContext.CarRentals.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
