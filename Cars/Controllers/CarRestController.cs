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

			// It adds a 'location' header in to HTTP resposne, with a link to the object
			return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
        }

		[HttpPut("{id}")]
		public ActionResult<CarDto> EditCarById(int id, CarEditDto carEditDto)
        {
			var car = carService.EditCarById(id, carEditDto);
			if (car == null)
			{
				return NotFound();
			}

			return CreatedAtAction(nameof(GetCarById), new { id = id }, car);
		}

		[HttpDelete("{id}")]
		public ActionResult<bool> DeleteCarById(int id)
        {
			var car = carService.DeleteCarById(id);
			if (car == null)
			{
				return NotFound();
			}

			return car;
		}
	}
}
