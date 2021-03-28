using Cars.Model;
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
		private readonly CarService carService;

		public RestController()
		{
			carService = new();
		}
		
		[HttpGet]
		public IEnumerable<Car> getAllCars()
        {
			var cars = carService.getAllCars();
			return cars;
		}
	}
}
