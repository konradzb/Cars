using Cars.Dtos;
using Cars.Model;
using Cars.Repo;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// Controller for Car Object, all methods related to car objects are here
/// controller operates on DTO's, it never returns object car itself.
/// </summary>
namespace Cars.Controllers
{
	[ApiController]
	[Route("cars")]
	public class CarRestController : ControllerBase
	{
		private readonly ICarService CarService;

		public CarRestController(ICarService carService)
		{
			this.CarService = carService;
		}

		[HttpGet]
		public IEnumerable<CarDto> GetAllCars()
		{
			return CarService.GetAllCars();
		}

		[HttpGet("{id}")]
		public ActionResult<CarDto> GetCarById(int id)
		{
			var car =  CarService.GetCarById(id);
			if (car == null)
            {
				return NotFound();
            }
			return car;
		}

		[HttpPost]
		public ActionResult<CarDto> AddCar(CarInputDto carInput)
        {
			CarDto car = CarService.AddCar(carInput);

			// It adds a 'location' header in to HTTP resposne, with a link to the object
			return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
        }

		[HttpPut("{id}")]
		public ActionResult<CarDto> EditCarById(int id, CarEditDto carEditDto)
        {
			var car = CarService.EditCarById(id, carEditDto);
			if (car == null)
			{
				return NotFound();
			}

			return CreatedAtAction(nameof(GetCarById), new { id = id }, car);
		}

		[HttpDelete("{id}")]
		public ActionResult<bool> DeleteCarById(int id)
        {
			var car = CarService.DeleteCarById(id);
			if (car == null)
			{
				return NotFound();
			}

			return car;
		}

		[HttpGet("complex/{pageIndex}")]
		public IEnumerable<ComplexCar> GetComplexCarsObejct(int pageIndex)
		{
			return CarService.GetComplexCarsObejct(pageIndex);
		}

		[HttpGet("colors")]
		public IEnumerable<String> GetAllColors()
        {
			return CarService.GetAllColors();
        }

	}
}
