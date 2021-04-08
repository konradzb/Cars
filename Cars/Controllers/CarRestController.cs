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
		public IEnumerable<Car> getAllCars()
		{
			return carService.GetAllCars();
		}

		[HttpGet("{id}")]
		public ActionResult<Car> GetCarById(Guid id)
		{
			var car =  carService.GetCarById(id);

			if (car == null)
            {
				return NotFound();
            }
			return car;
		}

	}
}
