using Cars.Dtos;
using Cars.Model;
using Cars.Repo;
using Cars.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service
{
    public class BrandService : IBrandService
    {
        private readonly IBrandDao brandsDao;
        public BrandService(IBrandDao brandsDao)
        {
            this.brandsDao = brandsDao;
        }
        public BrandDto AddBrand(BrandInputDto brandInput)
        {
            int id = 0;
            Brand brand = new Brand(
                id,
                brandInput.Name,
                brandInput.Founder,
                brandInput.Origin,
                brandInput.Headquarter,
                brandInput.EstablishmentDate
            );
            return brandsDao.AddBrand(brand).AsDto();
        }

        public ActionResult<bool> DeleteBrandById(int id)
        {
            var brandToDelete = brandsDao.GetBrandById(id);
            if(brandToDelete is null)
            {
                return null;
            }
            return brandsDao.DeleteBrandById(id);
        }

        public ActionResult<BrandDto> EditBrandById(int id, BrandEditDto brandEditDto)
        {
            var brandToEdit = brandsDao.GetBrandById(id);
            if (brandToEdit is null)
            {
                return null;
            }

            Brand editBrand = brandToEdit with
            {
                Name = brandEditDto.Name,
                Founder = brandEditDto.Founder,
                Origin = brandEditDto.Origin,
                Headquarter = brandEditDto.Headquarter,
                EstablishmentDate = brandEditDto.EstablishmentDate
            };
            return brandsDao.EditBrandById(editBrand).AsDto();
        }

        public IEnumerable<BrandDto> GetAllBrands()
        {
            var brands = brandsDao.GetAllBrands().ConvertAll(brand => brand.AsDto());
            return brands;
        }

        public ActionResult<BrandDto> GetBrandById(int id)
        {
            var brand = brandsDao.GetBrandById(id);
            if (brand is null)
            {
                return null;
            }
            return brand.AsDto();
        }
    }
}
