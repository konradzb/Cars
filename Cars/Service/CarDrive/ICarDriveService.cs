using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Dtos;
using Cars.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Service
{
    public interface ICarDriveService
    {
        IEnumerable<CarDriveDto> GetAllCarDrives();
        ActionResult<CarDriveDto> GetCarDriveById(int id);
    }
}
