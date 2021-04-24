using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Service
{
    public interface IBrandService
    {
        BrandDto AddBrand(BrandInputDto brandInput);
        ActionResult<bool> DeleteBrandById(int id);
        ActionResult<BrandDto> EditBrandById(int id, BrandEditDto brandEditDto);
        IEnumerable<BrandDto> GetAllBrands();
        ActionResult<BrandDto> GetBrandById(int id);
    }
}
