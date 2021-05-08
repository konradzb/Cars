using Cars.DTOs;
using Cars.Repositories.FuelType;
using Cars.Service.FuelType;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    [ApiController]
    [Route("fuel")]
    public class FuelTypeRestController : Controller
    {
        private readonly IFuelTypeService fuelTypeService;
        public FuelTypeRestController(IFuelTypeService fuelTypeService)
        {
            this.fuelTypeService = fuelTypeService;
        }

        [HttpGet("{id}")]
        public ActionResult<FuelTypeDto> GetFuel(int id)
        {
            var fuel = fuelTypeService.GetFuel(id);
            return fuel;
        }
        [HttpGet]
        public IEnumerable<FuelTypeDto> GetFuelTypes()
        {
            return fuelTypeService.GetFuelTypes();
        }
    }
}
