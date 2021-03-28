using Cars.Model;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Cars.Repo
{
	public class FakeCarsDao
	{
		private List<Car> cars = new();
		public FakeCarsDao()
		{
			cars.Add(new Model.Car(Guid.NewGuid(), "Szybka v3", 8999, "Skoda", "02.12.1999"));
		}

		public IEnumerable<Car> getAllCars()
        {
			return cars;
        }

	}
}
