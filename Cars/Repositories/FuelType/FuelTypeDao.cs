using Cars.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories.FuelType
{
    public class FuelTypeDao : IFuelTypeDao
    {
        private readonly ApplicationDbContext _dbContext;
        public FuelTypeDao(ApplicationDbContext db)
        {
            _dbContext = db;
        }
        public List<Model.FuelType> getAllFuelNames()
        {
            return _dbContext.FuelTypes.OrderBy(f => f.id).ToList();
        }

        public Model.FuelType getFuelType(int id)
        {
            return _dbContext.FuelTypes.OrderBy(f => f.id == id).FirstOrDefault();
        }
    }
}
