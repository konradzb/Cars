using Cars.Model;
using Cars.Repo;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Cars.Service
{
	public class CarService
	{
		private FakeCarsDao fakeCarsDao;
		public CarService()
		{
			fakeCarsDao = new();
		}

		public IEnumerable<Car> getAllCars()
        {
			return fakeCarsDao.getAllCars();
        }
	}
}
