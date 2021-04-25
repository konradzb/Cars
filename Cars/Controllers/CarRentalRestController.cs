using Cars.Dtos;
using Cars.Model;
using Cars.Repo;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// Controller for CarRental Object, all methods related to car objects are here
/// controller operates on DTO's, it never returns object carRental itself.
/// </summary>
namespace Cars.Controllers
{
	[ApiController]
	[Route("carRentals")]
	public class CarRentalRestController : ControllerBase
	{
		private readonly ICarRentalService CarRentalService;

		public CarRentalRestController(ICarRentalService carRentalService)
        {
			this.CarRentalService = carRentalService;
        }

		[HttpGet]
		public IEnumerable<CarRentalDto> GetAllCarRentals()
        {
			return CarRentalService.GetAllCarRentals();
        }

		[HttpGet("{id}")]
		public ActionResult<CarRentalDto> GetCarRentalById(int id)
        {
			var carRental = CarRentalService.GetCarRentalById(id);
			if(carRental is null)
            {
				return NotFound();
            }
			return carRental;
        }

		[HttpPost]
		public ActionResult<CarRentalDto> AddCarRental(CarRentalInputDto carRentalInput)
        {
			CarRentalDto carRental = CarRentalService.AddRentalCar(carRentalInput);

			return CreatedAtAction(nameof(GetCarRentalById), new { id = carRental.Id }, carRental);
        }

		[HttpPut("{id}")]
		public ActionResult<CarRentalDto> EditCarRentalById(int id, CarRentalEditDto carRentalEditDto)
		{
			var carRental = CarRentalService.EditCarRentalById(id, carRentalEditDto);
			if (carRental is null)
			{
				return NotFound();
			}

			return CreatedAtAction(nameof(GetCarRentalById), new { id = id }, carRental);
        }

		[HttpDelete("{id}")]
		public ActionResult<bool> DeleteCarRentalById(int id)
        {
			var carRental = CarRentalService.DeleteCarRentalById(id);
			if (carRental is null)
            {
				return NotFound();
            }

			return carRental;
        }
	}
}
