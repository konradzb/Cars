using Cars.Dtos;
using Cars.Model;
using Cars.Repo;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
namespace Cars.Controllers
{
	[ApiController]
	[Route("cars")]
	public class CarRestController : ControllerBase
	{
		private readonly ICarService carService;

		public CarRestController(ICarService carService)
		{
			this.carService = carService;
		}

		[HttpGet]
		public IEnumerable<CarDto> getAllCars()
		{
			return carService.GetAllCars();
		}

		[HttpGet("{id}")]
		public ActionResult<CarDto> GetCarById(int id)
		{
			var car =  carService.GetCarById(id);
			if (car == null)
            {
				return NotFound();
            }
			return car;
		}

		[HttpPost]
		public ActionResult<CarDto> AddCar(CarInputDto carInput)
        {
			CarDto car = carService.AddCar(carInput);

			// It works fine, without this, but in b
			return car;
			//return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
        }
	}
}
