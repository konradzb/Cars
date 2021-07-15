using Cars.Dtos;
using Cars.Model;
using System;
using System.Collections.Generic;

/// <summary>
/// In memmory data base for car object, based on a simple list
/// </summary>
namespace Cars.Repo
{
	public class FakeCarDao : ICarDao
	{
		private List<Car> cars = new();
        private int i;
		public FakeCarDao()
		{
			cars.Add(new Car(1, 1, 123, "Czerowny", new DateTime(2010, 6, 27), true, 200));
			cars.Add(new Car(2, 2, 321, "Czarny", new DateTime(2011, 1, 7), false, 370));
			cars.Add(new Car(3, 3, 9990, "Biały", new DateTime(2011, 1, 29), true, 120));
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

        public bool DeleteCarById(int id)
        {
            var carToDelete = GetCarById(id);
            return cars.Remove(carToDelete);
        }

        public Car EditCarById(Car car)
        {
            int index = cars.FindIndex(carToEdit => carToEdit.Id == car.Id);
            cars[index] = car;
            return car;
        }

        public List<ComplexCar> GetComplexCarsObject(int pageIndex)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllColors()
        {
            throw new NotImplementedException();
        }

        public List<ComplexCar> GetComplexCarsWithParms(string brand, string color, string carDrive, string fuelType, int pageIndex)
        {
            throw new NotImplementedException();
        }
    }
}
