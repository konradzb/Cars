using Cars.Model;
using Cars.Repo;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Cars.Controllers
{
	[ApiController]
	[Route("cars")]
	public class RestController : ControllerBase
	{
		private readonly ICarService carService;

		public RestController(ICarService carService)
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
			return carService.GetCarById(id);
		}
	}
}
