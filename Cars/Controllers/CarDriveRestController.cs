using Cars.Dtos;
using Cars.Model;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Controller for Car drive Object
/// Controller operates on DTO's, it never returns object carDrive itself
/// </summary>
namespace Cars.Controllers
{
    [ApiController]
    [Route("carDrives")]
    public class CarDriveRestController : ControllerBase
    {
        private readonly ICarDriveService carDriveService;
        public CarDriveRestController(ICarDriveService carDriveService)
        {
            this.carDriveService = carDriveService;
        }
        [HttpGet]
        public IEnumerable<CarDriveDto> GetAllCarDrives()
        {
            return carDriveService.GetAllCarDrives();
        }
        [HttpGet("{id}")]
        public ActionResult<CarDriveDto> GetCarDriveById(int id)
        {
            var carDrive = carDriveService.GetCarDriveById(id);
            if(carDrive is null)
            {
                return NotFound();
            }
            return carDrive;
        }
    }
}
