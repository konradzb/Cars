using Cars.Dtos;
using Cars.Model;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Controller for Brand Object
/// Controller operates on DTO's, it never returns obejct car itself
/// </summary>
namespace Cars.Controllers
{     
    [ApiController]
    [Route("brands")]
    public class BrandRestController: ControllerBase
    {
        private readonly IBrandService brandService;
        public BrandRestController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        [HttpGet]
        public IEnumerable<BrandDto> GetAllBrands()
        {
            return brandService.GetAllBrands();
        }

        [HttpGet("{id}")]
        public ActionResult<BrandDto> GetBrandById(int id)
        {
            var brand = brandService.GetBrandById(id);
            if(brand is null)
            {
                return NotFound();
            }
            return brand;
        }
        [HttpPost]
        public ActionResult<BrandDto> AddBrand(BrandInputDto brandInput)
        {
            BrandDto brand = brandService.AddBrand(brandInput);
            return CreatedAtAction(nameof(GetBrandById), new { id = brand.Id }, brand);
        }
        [HttpPut("{id}")]
        public ActionResult<BrandDto> EditBrandById(int id, BrandEditDto brandEditDto)
        {
            var brand = brandService.EditBrandById(id, brandEditDto);
            if(brand is null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(GetBrandById), new { id = id }, brand);
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteBrandById(int id)
        {
            var brand = brandService.DeleteBrandById(id);
            if(brand is null)
            {
                return NotFound();
            }
            return brand;

        }
    }
}
