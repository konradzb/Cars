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
                result.Mileage = car.Mileage;
                result.Color = car.Color;
                result.ProductionDate = car.ProductionDate;
                result.IsAvailable = car.IsAvailable;
                result.PricePerDay = car.PricePerDay;
                result.ModelId = car.ModelId;
                _dbContext.SaveChanges();
                return result;
            }
            return null;
        }

        public List<Car> GetAllCars()
        {
            return _dbContext.Cars.OrderBy(c => c.Id).ToList();
        }

        public Car GetCarById(int id)
        {
            return _dbContext.Cars.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<string> GetAllColors()
        {
            var items = (from c in _dbContext.Cars
                         select new
                         {
                             Color = c.Color
                         }).Distinct().ToList();
            List<string> list = new List<string>();
            for(int i = 0; i < items.Count(); i++)
            {
                list.Add(items[i].Color);
            }

            return list;
        }

        public List<ComplexCar> GetComplexCarsObject(int pageIndex)
        {
            int carsPerPage = 5;
            int carIndex = carsPerPage * pageIndex;
            var items = (from c in _dbContext.Cars
                              join m in _dbContext.Models on c.ModelId equals m.Id
                              join b in _dbContext.Brands on m.BrandId equals b.Id
                              join cd in _dbContext.CarDrives on m.CarDriveId equals cd.Id
                              join ft in _dbContext.FuelTypes on m.FuelTypeId equals ft.id
                              where c.ModelId == m.Id
                                where c.IsAvailable == true
                              select new
                              {
                                  Id = c.Id,
                                  ModelType = m.Type,
                                  ModelName = m.Name,
                                  Brand = b.Name,
                                  Mileage = c.Mileage,
                                  Color = c.Color,
                                  ProductionDate = c.ProductionDate,
                                  IsAvailable = c.IsAvailable,
                                  PricePerDay = c.PricePerDay,
                                  FuelType = ft.name,
                                  CarDrive = cd.Name,
                                  Power = m.Power
                              }).Skip(carIndex).Take(carsPerPage).ToList();

            int length = items.Count();
            List<ComplexCar> list = new List<ComplexCar>();

            for (int i = 0; i < length; i++)
            {
                ComplexCar complexCar = new ComplexCar(
                        items[i].Id,
                        items[i].ModelType,
                        items[i].ModelName,
                        items[i].Brand,
                        items[i].Mileage,
                        items[i].Color,
                        items[i].ProductionDate,
                        items[i].IsAvailable,
                        items[i].PricePerDay,
                        items[i].FuelType,
                        items[i].CarDrive,
                        items[i].Power
                    );

                list.Add(complexCar);
            }

            return list;
        }

        public List<ComplexCar> GetComplexCarsWithParms(string brand, string color, string carDrive, string fuelType, int pageIndex)
        {
            int carsPerPage = 5;
            int carIndex = carsPerPage * pageIndex;
            var items = (from c in _dbContext.Cars
                         join m in _dbContext.Models on c.ModelId equals m.Id
                         join b in _dbContext.Brands on m.BrandId equals b.Id
                         join cd in _dbContext.CarDrives on m.CarDriveId equals cd.Id
                         join ft in _dbContext.FuelTypes on m.FuelTypeId equals ft.id
                         where c.ModelId == m.Id
                         where c.IsAvailable == true
                         where b.Name.Contains(brand)
                         where c.Color.Contains(color)
                         where cd.Name.Contains(carDrive)
                         where ft.name.Contains(fuelType)
                         select new
                         {
                             Id = c.Id,
                             ModelType = m.Type,
                             ModelName = m.Name,
                             Brand = b.Name,
                             Mileage = c.Mileage,
                             Color = c.Color,
                             ProductionDate = c.ProductionDate,
                             IsAvailable = c.IsAvailable,
                             PricePerDay = c.PricePerDay,
                             FuelType = ft.name,
                             CarDrive = cd.Name,
                             Power = m.Power
                         }).Skip(carIndex).Take(carsPerPage).ToList();

            int length = items.Count();
            List<ComplexCar> list = new List<ComplexCar>();

            for (int i = 0; i < length; i++)
            {
                ComplexCar complexCar = new ComplexCar(
                        items[i].Id,
                        items[i].ModelType,
                        items[i].ModelName,
                        items[i].Brand,
                        items[i].Mileage,
                        items[i].Color,
                        items[i].ProductionDate,
                        items[i].IsAvailable,
                        items[i].PricePerDay,
                        items[i].FuelType,
                        items[i].CarDrive,
                        items[i].Power
                    );

                list.Add(complexCar);
            }

            return list;
        }
    }
}
