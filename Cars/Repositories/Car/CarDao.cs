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
            var result = _dbContext.Cars.FirstOrDefault(c => c.Id == id);
            if(result!=null)
            {
                _dbContext.Cars.Remove(result);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Car EditCarById(Car car)
        {
            var result = _dbContext.Cars.FirstOrDefault(c => c.Id == car.Id);
            if(result != null)
            {
                _dbContext.Cars.Update(result);
                _dbContext.SaveChanges();
            }
            return result;
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
