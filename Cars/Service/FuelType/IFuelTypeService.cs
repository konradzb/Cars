using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Service.FuelType
{
    using Cars.Model;
    using Cars.DTOs;

    public interface IFuelTypeService
    {
        IEnumerable<FuelTypeDto> GetFuelTypes();
        ActionResult<FuelTypeDto> GetFuel(int id);
    }
}
