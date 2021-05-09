using Cars.DTOs;
using Cars.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service.FuelType
{
    using Cars.Repositories.FuelType;

    public class FuelTypeService : IFuelTypeService
    {
        private readonly IFuelTypeDao FuelTypeDao;
        public FuelTypeService(IFuelTypeDao repository)
        {
            this.FuelTypeDao = repository;
        }
        public ActionResult<FuelTypeDto> GetFuel(int id)
        {
            return FuelTypeDao.getFuelType(id).AsDto();
        }

        public IEnumerable<FuelTypeDto> GetFuelTypes()
        {
            return FuelTypeDao.getAllFuelNames().ConvertAll(FuelType => FuelType.AsDto());
        }
    }
}
