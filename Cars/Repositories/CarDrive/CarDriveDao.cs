using Cars.Configuration;
using Cars.Model;
using Cars.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repositories
{

    public class CarDriveDao : ICarDriveDao
    {
        private readonly ApplicationDbContext _dbContext;
        public CarDriveDao(ApplicationDbContext db)
        {
            _dbContext = db;
        }
        public List<CarDrive> GetAllCarDrives()
        {
            return _dbContext.CarDrives.OrderBy(u => u.Id).ToList();
        }

        public CarDrive GetCarDriveById(int id)
        {
            return _dbContext.CarDrives.Where(u => u.Id == id).FirstOrDefault();
        }
    }
}