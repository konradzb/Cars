using Cars.Configuration;
using Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repo
{
    public class CarDao : ICarDao
    {
        private readonly ApplicationDbContext _dbContext;
        public CarDao(ApplicationDbContext db)
        {
            _dbContext = db;
        }
        public Car AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
            return car;
        }

        public bool DeleteCarById(int id)
        {
            throw new NotImplementedException();
        }

        public Car EditCarById(Car car)
        {
            _dbContext.Cars.Update(car);
            _dbContext.SaveChanges();
            return car;
        }

        public List<Car> GetAllCars()
        {
            return _dbContext.Cars.OrderBy(c => c.Id).ToList();
        }

        public Car GetCarById(int id)
        {
            return _dbContext.Cars.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
