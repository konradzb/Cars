using Cars.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repo
{
    public class FakeBrandDao : IBrandDao
    {
        private List<Brand> brands = new();
        private int i;
        public FakeBrandDao()
        {
            brands.Add(new Brand(1, "Mercedes", "Karl Benz", "Germany", "Stuttgart", new DateTime(1926, 6, 28)));
            brands.Add(new Brand(2, "Porshe", "Ferdinand Porsche", "Germany", "Stuttgart", new DateTime(1931, 4, 25)));
            brands.Add(new Brand(3, "Ferrari", "Enzo Ferrari", "Italy", "Maranello", new DateTime(1939, 8, 13)));
            brands.Add(new Brand(4, "Aston Martin", "Lionel Martin", "United Kingdom", "Gaydon", new DateTime(1913, 1, 15)));
            brands.Add(new Brand(5, "Maserati", "Alfieri Maserati", "Italy", "Bologna", new DateTime(1914, 12, 1)));
            brands.Add(new Brand(6, "Tesla", "Elon Musk", "United States", "Palo Alto", new DateTime(2003, 7, 1)));
            i = brands.Count;
        }
        public Brand AddBrand(Brand brand)
        {
            brands.Add(brand);
            return brand;
        }

        public bool DeleteBrandById(int id)
        {
            var brandToDelete = this.GetBrandById(id);
            return brands.Remove(brandToDelete);

        }

        public Brand EditBrandById(Brand brand)
        {
            int index = brands.FindIndex(brandToEdit => brandToEdit.Id == brand.Id);
            brands[index] = brand;
            return brand;
        }

        public List<Brand> GetAllBrands()
        {
            return brands;
        }

        public Brand GetBrandById(int id)
        {
            return brands.Find(brand => brand.Id == id);
        }
    }
}
