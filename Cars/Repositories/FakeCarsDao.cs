using Cars.Model;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Cars.Repo
{
	public class FakeCarsDao : ICarsDao
	{
		private List<Car> cars = new();
		public FakeCarsDao()
		{
			cars.Add(new Car(Guid.NewGuid(), 123, "Czerowny", "v3", new DateTime(2010, 6, 27), true, 2));
			cars.Add(new Car(Guid.NewGuid(), 321, "Czarny", "v2", new DateTime(2011, 1, 7), false, 1));
			cars.Add(new Car(Guid.NewGuid(), 9990, "Biały", "v1", new DateTime(2011, 1, 29), true, 3));
		}

        public IEnumerable<Car> GetAllCars()
        {
			return cars;
        }

        public Car GetCarById(Guid id)
        {
            return cars.Find(car => car.Id == id);
        }

        public Car AddCar(CarInput carInput)
        {
            throw new NotImplementedException();
        }

        public Car DeleteCarById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Car EditCarById(Guid id, CarInput carInput)
        {
            throw new NotImplementedException();
        }
    }
}
