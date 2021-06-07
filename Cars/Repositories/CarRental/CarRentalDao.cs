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
            throw new NotImplementedException();
        }

        public CarRental EditCarRentalById(CarRental carRental)
        {
            _dbContext.CarRentals.Update(carRental);
            _dbContext.SaveChanges();
            return carRental;
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
