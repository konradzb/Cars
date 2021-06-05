using Cars.Configuration;
using Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repo
{
    public class BrandDao : IBrandDao
    {
        private readonly ApplicationDbContext _dbContext;
        public BrandDao(ApplicationDbContext db)
        {
            _dbContext = db;
        }

        public Brand AddBrand(Brand brand)
        {
            _dbContext.Brands.Add(brand);
            _dbContext.SaveChanges();
            return brand;
        }

        public bool DeleteBrandById(int id)
        {
            throw new NotImplementedException();
        }

        public Brand EditBrandById(Brand brand)
        {
            _dbContext.Brands.Update(brand);
            _dbContext.SaveChanges();
            return brand;
        }

        public List<Brand> GetAllBrands()
        {
            return _dbContext.Brands.OrderBy(b => b.Id).ToList();
        }

        public Brand GetBrandById(int id)
        {
            return _dbContext.Brands.Where(b => b.Id == id).FirstOrDefault();
        }
    }
}
