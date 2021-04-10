using Cars.Dtos;
using Cars.Model;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Cars.Repo
{
	public class FakeCarDao : ICarDao
	{
		private List<Car> cars = new();
        private int i;
		public FakeCarDao()
		{
			cars.Add(new Car(1, 123, "Czerowny", "v3", new DateTime(2010, 6, 27), true, 2));
			cars.Add(new Car(2, 321, "Czarny", "v2", new DateTime(2011, 1, 7), false, 1));
			cars.Add(new Car(3, 9990, "Biały", "v1", new DateTime(2011, 1, 29), true, 3));
            i = cars.Count;
		}

        public List<Car> GetAllCars()
        {
			return cars;
        }

        public Car GetCarById(int id)
        {
            return cars.Find(car => car.Id == id);
        }

        public Car AddCar(Car car)
        {
            cars.Add(car);
            return car;
        }

        public Car DeleteCarById(int id)
        {
            var carToDelete = GetCarById(id);
            cars.Remove(carToDelete);
            return carToDelete;
        }

        public Car EditCarById(Car car)
        {
            int index = cars.FindIndex(carToEdit => carToEdit.Id == car.Id);
            cars[index] = car;
            return car;
        }
    }
}
