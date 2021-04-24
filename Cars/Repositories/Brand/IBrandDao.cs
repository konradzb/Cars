using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Dtos;
using Cars.Model;
/// <summary>
/// Dao - Data access object
/// </summary>
namespace Cars.Repo
{
    public interface IBrandDao
    {
        List<Brand> GetAllBrands();
        Brand GetBrandById(int id);
        Brand AddBrand(Brand brand);
        Brand EditBrandById(Brand brand);
        bool DeleteBrandById(int id);
    }
}
